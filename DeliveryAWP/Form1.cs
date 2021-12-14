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

        public DateTime CurrentTime;

        public Form1()
        {
            InitializeComponent();
            CurrentTime = DateTime.Now;
            timer1.Start();

            PCKGSGB.Visible = false;
            CouriersGB.Visible = false;
        }

        void ReDraw()
        {
            //перерисовка заявок
            PackagesDGW.Rows.Clear();
            for(int i = 0; i < Packages.Count; i++)
            {
                PackagesDGW.Rows.Add();
                PackagesDGW.Rows[i].Cells[0].Value = Packages[i].Sender;
                PackagesDGW.Rows[i].Cells[1].Value = Packages[i].Reciver;
                PackagesDGW.Rows[i].Cells[2].Value = Packages[i].DateAndTimeCreated;
                PackagesDGW.Rows[i].Cells[3].Value = Packages[i].Status;
            }


            //Перерисовка курьеров
            COURIERSDGW.Rows.Clear();
            FreeCouriers.Items.Clear();
            for(int i = 0; i < Couriers.Count; i++)
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
                if (CurrentTime >= c.DateAndTimeOfReturns)
                    c.IsBusy = false;
            }

            ReDraw();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (PackagesDGW.CurrentCell == null || PackagesDGW.CurrentCell.RowIndex == -1 )
            {
                MessageBox.Show("Не выбрана заявка для удаления.\nНажмите на ячейку строки таблицы которая соответствует нужной заявке.", 
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Packages.RemoveAt(PackagesDGW.CurrentCell.RowIndex);
            ReDraw();
        }

        private void PackagesBTTN_Click(object sender, EventArgs e)
        {
            PCKGSGB.Visible = true;
            CouriersGB.Visible = false;
        }

        private void CouriersBttn_Click(object sender, EventArgs e)
        {
            PCKGSGB.Visible = false;
            CouriersGB.Visible = true;

        }

        private void AddCourier_Click(object sender, EventArgs e)
        {
            AddCourier addcourier = new AddCourier(this);
            addcourier.ShowDialog();
            ReDraw();
        }

        private void DeleteCourier_Click(object sender, EventArgs e)
        {
            if (COURIERSDGW.CurrentCell == null || COURIERSDGW.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Не выбран курьер для удаления.\nНажмите на ячейку строки таблицы которая соответствует нужному курьеру.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Couriers.RemoveAt(COURIERSDGW.CurrentCell.RowIndex);
            ReDraw();
        }

        private void SendCourier_Click(object sender, EventArgs e)
        {
            if (COURIERSDGW.CurrentCell == null || COURIERSDGW.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Не выбран курьер для отправки.\nНажмите на ячейку строки таблицы которая соответствует нужному курьеру.", 
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Couriers[COURIERSDGW.CurrentCell.RowIndex].Start(CurrentTime);
            ReDraw();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            string filePath = "";
            openFileDialog1.Title = "Выберите файл с заявками";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != openFileDialog1.InitialDirectory)
                filePath = openFileDialog1.FileName;

            try
            {
                if (File.Exists(filePath))
                {
                    Packages.Clear();
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    Packages = JsonConvert.DeserializeObject<List<Package>>(File.ReadAllText(filePath), settings);
                }
            }
            catch
            {
                MessageBox.Show("Файл поврежден или имет некорректный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            openFileDialog1.Title = "Выберите файл с курьерами";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != openFileDialog1.InitialDirectory)
                filePath = openFileDialog1.FileName;

            try
            {
                if (File.Exists(filePath))
                {
                    Couriers.Clear();
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    Couriers = JsonConvert.DeserializeObject<List<Courier>>(File.ReadAllText(filePath), settings);
                }
            }
            catch
            {
                MessageBox.Show("Файл поврежден или имет некорректный формат.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                saveFileDialog1.Title = "Введите имя файла с заявками для сохранения";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != saveFileDialog1.InitialDirectory)
                    filePath = saveFileDialog1.FileName;

                filePath += ".json";

                if (Packages.Count != 0)
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    JsonSerializer json = JsonSerializer.Create(settings);
                    using (StreamWriter sw = new StreamWriter(filePath))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        json.Serialize(writer, Packages);
                    }
                }

                filePath = "";
                saveFileDialog1.Title = "Введите имя файла с курьерами для сохранения";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != saveFileDialog1.InitialDirectory)
                    filePath = saveFileDialog1.FileName;

                filePath += ".json";

                if (Couriers.Count != 0)
                {
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
                    JsonSerializer json = JsonSerializer.Create(settings);
                    using (StreamWriter sw = new StreamWriter(filePath))
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

        private void AddToCourier_Click(object sender, EventArgs e)
        {
            if(FreeCouriers.Text == "")
            {
                MessageBox.Show("Не выбран курьер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PackagesDGW.CurrentCell == null || PackagesDGW.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Не выбрана заявка для отправки.\nНажмите на ячейку строки таблицы которая соответствует нужной заявке.",
                    "Ошибка:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < Couriers.Count; i++)
            {
                if(Couriers[i].GetInfo() == FreeCouriers.Text)
                {
                    Couriers[i].AddToPackgList(Packages[PackagesDGW.CurrentCell.RowIndex], CurrentTime);
                    break;
                }
            }
        }
    }
}
