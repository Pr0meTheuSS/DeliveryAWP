using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryAWP
{
    public partial class AddCourier : Form
    {
        Form1 Caller;
        int indexOfEditingCourier = -1;
        Courier courier = null;
        public AddCourier(Form1 form)
        {
            InitializeComponent();
            Caller = form;
            CourierType.SelectedIndex = 0;
            FuelTB.Visible = false;
            Fuel.Visible = false;
            TransportTB.Visible = false;
            Transport.Visible = false;
        }

        public AddCourier(Form1 form, int courierIndex)
        {
            InitializeComponent();
            Caller = form;
            indexOfEditingCourier = courierIndex;
            courier = Caller.Couriers[indexOfEditingCourier];
            CourierNameTB.Text = courier.Name;
            SalaryMTB.Text = courier.SalaryForPckg.ToString();
            TimeMTB.Text = courier.AverageDeliverTime.ToString();
            VolumeTB.Text = courier.Volume.ToString();
            
            if (courier._GetType() == "Courier")
            {
                CourierType.SelectedIndex = 0;
                FuelTB.Visible = false;
                Fuel.Visible = false;
                TransportTB.Visible = false;
                Transport.Visible = false;
            }
            if (courier._GetType() == "BicycleCourier")
            {
                var words = courier.GetInfo().Split(' ');
                CourierType.SelectedIndex = 1;
                Transport.Text = "Модель велосипеда: ";
                Transport.Visible = true;
                TransportTB.Visible = true;
                Fuel.Visible = false;
                FuelTB.Visible = false;
                TransportTB.Text = words.Last();
            }

            if (courier._GetType() == "AutoCourier")
            {
                var words = courier.GetInfo().Split(' ');
                for (int i = 0; i < words.Length; i++) 
                {
                    if (words[i] == "машины:") 
                    {
                        TransportTB.Text = words[i + 1];
                    }
                    if (words[i] == "100км:")
                    {
                        if (words[i + 1].Split(',')[0].Length == 1)
                        {
                            words[i + 1] = "0" + words[i + 1];
                        }
                        FuelTB.Text = words[i + 1];
                    }

                }
                CourierType.SelectedIndex = 2;
                Transport.Text = "Номер машины: ";
                Transport.Visible = true;
                TransportTB.Visible = true;

                Fuel.Visible = true;
                FuelTB.Visible = true;
                
            }
        }

        private void AddCourier_Load(object sender, EventArgs e)
        {
        }

        private void CourierType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //открывыаем поля для ввода в зависимости от выбранного типа
            if (CourierType.SelectedIndex == 0)
            {
                FuelTB.Visible = false;
                Fuel.Visible = false;
                TransportTB.Visible = false;
                Transport.Visible = false;
            }
            if (CourierType.SelectedIndex == 1)
            {
                Transport.Text = "Модель велосипеда: ";
                Transport.Visible = true;
                TransportTB.Visible = true;
                Fuel.Visible = false;
                FuelTB.Visible = false;
            }

            if (CourierType.SelectedIndex == 2)
            {
                Transport.Text = "Номер машины: ";
                Transport.Visible = true;
                TransportTB.Visible = true;

                Fuel.Visible = true;
                FuelTB.Visible = true;

            }

        } 

        private void SaveCourier_Click(object sender, EventArgs e)
        {
            //создаем объект базового класса
            Courier c = null;
            if (indexOfEditingCourier >= 0)
            {
                c = courier;
            }
            try
            {
                //в зависимости от выбранного типа создаем объект производного класса
                if (CourierType.SelectedIndex == 0)
                {
                    c = new Courier(CourierNameTB.Text, Convert.ToInt32(VolumeTB.Text), Convert.ToInt32(TimeMTB.Text),
                        Convert.ToInt32(SalaryMTB.Text));
                }

                if (CourierType.SelectedIndex == 1)
                {
                    c = new BicycleCourier(CourierNameTB.Text, Convert.ToInt32(VolumeTB.Text), Convert.ToInt32(TimeMTB.Text),
                        Convert.ToInt32(SalaryMTB.Text), TransportTB.Text);

                }
                if (CourierType.SelectedIndex == 2)
                {
                    c = new AutoCourier(CourierNameTB.Text, Convert.ToInt32(VolumeTB.Text), Convert.ToInt32(TimeMTB.Text),
                        Convert.ToInt32(SalaryMTB.Text), TransportTB.Text, Convert.ToDouble(FuelTB.Text));
                }

                if (indexOfEditingCourier < 0)
                {
                    //записываем созданного курьера в список курьеров
                    Caller.Couriers.Add(c);
                }
                else
                {
                    Caller.Couriers[indexOfEditingCourier] = c;
                }

                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Данные некорректны", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
