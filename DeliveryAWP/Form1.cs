using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace DeliveryAWP
{
    public partial class Form1 : Form
    {
        public List<Package>  Packages = new List<Package>();
        public List<Courier> Couriers = new List<Courier>();
        string CourierFilePath = "Couriers.json";
        string PackagesFilePath = "Packages.json";

        public DateTime CurrentTime;

        public Form1()
        {
            InitializeComponent();
            CurrentTime = DateTime.Now;
            //Запускаем таймер
            timer1.Start();
            //прячем груп боксы
            PCKGSGB.Visible = false;
            CouriersGB.Visible = false;
        }

        //функция обновления информации в таблицах
        void ReDraw()
        {
            int CourierSelectedRow = 0;
            int PackagesSelectedRow = 0;
            if (COURIERSDGW.CurrentCell != null)
                CourierSelectedRow = COURIERSDGW.CurrentCell.RowIndex;
            
            if(PackagesDGW.CurrentCell != null)
            PackagesSelectedRow = PackagesDGW.CurrentCell.RowIndex;

            //перерисовка заявок
            PackagesDGW.Rows.Clear();
            if (Packages == null)
            {
                return;
            }
            for(int i = 0; i < Packages.Count(); i++)
            {
                PackagesDGW.Rows.Add();
                PackagesDGW.Rows[i].Cells[0].Value = Packages[i].Sender;
                PackagesDGW.Rows[i].Cells[1].Value = Packages[i].Reciver;
                PackagesDGW.Rows[i].Cells[2].Value = Packages[i].DateAndTimeCreated;
                if (Packages[i].Deliver != null)
                {
                    PackagesDGW.Rows[i].Cells[3].Value = Packages[i].Deliver.Name;
                }
                else
                {
                    PackagesDGW.Rows[i].Cells[3].Value = "";
                }
                PackagesDGW.Rows[i].Cells[4].Value = Packages[i].Status;
            }


            //Перерисовка курьеров
            COURIERSDGW.Rows.Clear();
            FreeCouriers.Items.Clear();
            if (Couriers == null)
            {
                return;
            }

            for (int i = 0; i < Couriers.Count; i++)
            {
                if(!Couriers[i].IsBusy)
                {
                    FreeCouriers.Items.Add(Couriers[i].GetInfo());
                }

                COURIERSDGW.Rows.Add();
                COURIERSDGW.Rows[i].Cells[0].Value = Couriers[i].Name;
                COURIERSDGW.Rows[i].Cells[1].Value = Couriers[i].Volume;
                COURIERSDGW.Rows[i].Cells[2].Value = Couriers[i].Volume - Couriers[i].Packages.Count();
                COURIERSDGW.Rows[i].Cells[3].Value = Couriers[i].AverageDeliverTime;
                COURIERSDGW.Rows[i].Cells[4].Value = Couriers[i].PckgCount;
                COURIERSDGW.Rows[i].Cells[5].Value = Couriers[i].GetSalary();   
                if(Couriers[i].IsBusy)
                {
                    COURIERSDGW.Rows[i].Cells[6].Value = "Работает";
                }
                else
                {
                    COURIERSDGW.Rows[i].Cells[6].Value = "Ожидает";
                }
            }

            COURIERSDGW.CurrentCell = COURIERSDGW[0, CourierSelectedRow];
            PackagesDGW.CurrentCell = PackagesDGW[0, PackagesSelectedRow];
            
        }

        private void NewPackageButton_Click(object sender, EventArgs e)
        {
            AddNewPckg addPackageForm = new AddNewPckg(this);
            addPackageForm.ShowDialog();
            ReDraw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime = CurrentTime.AddMinutes(1.0);
            foreach(Courier c in Couriers)
            {
                if (CurrentTime >= c.DateAndTimeOfReturns && c.IsBusy)
                {
                    c.IsBusy = false;
                    foreach (Package p in c.Packages) 
                    {
                        p.SetStatus(EPackageStatus.Done);
                    }
                    c.Packages.Clear();
                }
            }

            ReDraw();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (PackagesDGW.CurrentCell == null || PackagesDGW.CurrentCell.RowIndex == -1 || PackagesDGW.CurrentCell.RowIndex >= Packages.Count())
            {
                MessageBox.Show("Не выбрана заявка для удаления.\nНажмите на ячейку строки таблицы которая соответствует нужной заявке.", 
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Packages.ElementAt(PackagesDGW.CurrentCell.RowIndex).Status == EPackageStatus.InWork) 
            {
                MessageBox.Show("Удаление невозвможно - посылка уже доставляется.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Packages.RemoveAt(PackagesDGW.CurrentCell.RowIndex);
            ReDraw();
        }
        //переключение с меню курьеров на меню заявок
        private void PackagesBTTN_Click(object sender, EventArgs e)
        {
            PCKGSGB.Visible = true;
            CouriersGB.Visible = false;
            ReDraw();
        }
        //переключение с заявок на курьеров
        private void CouriersBttn_Click(object sender, EventArgs e)
        {
            PCKGSGB.Visible = false;
            CouriersGB.Visible = true;
            ReDraw();

        }

        //добавление нового курьера
        private void AddCourier_Click(object sender, EventArgs e)
        {
            AddCourier addcourier = new AddCourier(this);
            addcourier.ShowDialog();
            ReDraw();
        }

        //удаление курьера
        private void DeleteCourier_Click(object sender, EventArgs e)
        {
            if (COURIERSDGW.CurrentCell == null || COURIERSDGW.CurrentCell.RowIndex == -1 || COURIERSDGW.CurrentCell.RowIndex >= Couriers.Count())
            {
                MessageBox.Show("Не выбран курьер для удаления.\nНажмите на ячейку строки таблицы которая соответствует нужному курьеру.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Couriers[COURIERSDGW.CurrentCell.RowIndex].IsBusy)
            {
                MessageBox.Show("Выбранный курьер еще доставляет заказы. Дождитесь его возвращения.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Couriers.RemoveAt(COURIERSDGW.CurrentCell.RowIndex);
            ReDraw();
        }
        //отправка курьера, который заполнен не полностью
        private void SendCourier_Click(object sender, EventArgs e)
        {
            if (COURIERSDGW.CurrentCell == null || COURIERSDGW.CurrentCell.RowIndex == -1 || COURIERSDGW.CurrentCell.RowIndex >= Couriers.Count())
            {
                MessageBox.Show("Не выбран курьер для отправки.\nНажмите на ячейку строки таблицы которая соответствует нужному курьеру.", 
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Couriers[COURIERSDGW.CurrentCell.RowIndex].IsBusy)
            {
                MessageBox.Show("Выбранный курьер уже доставляет заказы. Дождитесь его возвращения.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Couriers[COURIERSDGW.CurrentCell.RowIndex].Packages.Count == 0)
            {
                MessageBox.Show("Выбранному курьеру нечего доставлять. Для того, чтобы отправить его, ему необходимо выдать заказ.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Couriers[COURIERSDGW.CurrentCell.RowIndex].Start(CurrentTime);
            ReDraw();
        }
        //сохраняем данные в файлы
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Packages.Count != 0)
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    JsonSerializer json = JsonSerializer.Create(settings);
                    using (StreamWriter sw = new StreamWriter(PackagesFilePath))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        json.Serialize(writer, Packages);
                    }
                }

                if (Couriers.Count != 0)
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    JsonSerializer json = JsonSerializer.Create(settings);
                    using (StreamWriter sw = new StreamWriter(CourierFilePath))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        json.Serialize(writer, Couriers);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Пожалуйста попробуйте снова или обратитесь к специалисту", 
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //передача заявки курьеру
        private void AddToCourier_Click(object sender, EventArgs e)
        {
            if(FreeCouriers.Text == "")
            {
                MessageBox.Show("Не выбран курьер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PackagesDGW.CurrentCell == null || PackagesDGW.CurrentCell.RowIndex == -1 || PackagesDGW.CurrentCell.RowIndex >= Packages.Count())
            {
                MessageBox.Show("Не выбрана заявка для отправки.\nНажмите на ячейку строки таблицы которая соответствует нужной заявке.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Packages[PackagesDGW.CurrentCell.RowIndex].Deliver != null)
            {
                MessageBox.Show("Курьер уже назначен.",
                 "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < Couriers.Count; i++)
            {
                if(Couriers[i].GetInfo() == FreeCouriers.Text)
                {
                    if (PackagesDGW.CurrentCell.RowIndex >= Packages.Count()) 
                    {
                        MessageBox.Show("Не выбрана заявка для назначения курьера.\nНажмите на ячейку строки таблицы которая соответствует нужной заявке.",
                        "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Couriers[i].AddToPackgList(Packages[PackagesDGW.CurrentCell.RowIndex], CurrentTime))
                    {
                        FreeCouriers.Text = "";
                        Packages[PackagesDGW.CurrentCell.RowIndex].AssignToDeliver(Couriers[i]);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить заявку курьеру :(!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
            ReDraw();
        }

        //автоматическое чтение данных при загрузке окна
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(CourierFilePath))
                {
                    Couriers.Clear();
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    Couriers = JsonConvert.DeserializeObject<List<Courier>>(File.ReadAllText(CourierFilePath), settings);
                    if (Couriers == null) 
                    {
                        Couriers = new List<Courier>();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл с информацией о курьерах не был открыт, так как поврежден или имет некорректный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (File.Exists(PackagesFilePath))
                {
                    Packages.Clear();
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    Packages = JsonConvert.DeserializeObject<List<Package>>(File.ReadAllText(PackagesFilePath), settings);
                    if (Packages == null)
                    {
                        Packages = new List<Package>();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл поврежден или имет некорректный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            ReDraw();
        }
        //Здесь как будто бы происходит зачисление денег курьерам
        private void PaySalaryBttn_Click(object sender, EventArgs e)
        {

            //как бы заплатили деньги и сбрасываем счетчики доставленных посылок
            for(int i = 0; i < Couriers.Count(); i++)
            {
                Couriers[i].ResetCounter();
            }


        }

        private void EditPackage_Click(object sender, EventArgs e)
        {
            if (PackagesDGW.CurrentCell == null || PackagesDGW.CurrentCell.RowIndex == -1 || PackagesDGW.CurrentCell.RowIndex >= Packages.Count())
            {
                MessageBox.Show("Не выбрана заявка для редактирования.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddNewPckg editingPckgForm = new AddNewPckg(this, PackagesDGW.CurrentCell.RowIndex);
            editingPckgForm.ShowDialog();
        }

        private void EditCourier_Click(object sender, EventArgs e)
        {
            if (COURIERSDGW.CurrentCell == null || COURIERSDGW.CurrentCell.RowIndex == -1 || COURIERSDGW.CurrentCell.RowIndex >= Couriers.Count())
            {
                MessageBox.Show("Не выбран курьер для редактирования.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddCourier editingCourierForm = new AddCourier(this, COURIERSDGW.CurrentCell.RowIndex);
            editingCourierForm.ShowDialog();
        }
    }
}
