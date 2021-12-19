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
        public AddCourier(Form1 form)
        {
            InitializeComponent();
            Caller = form;
        }
        private void AddCourier_Load(object sender, EventArgs e)
        {
            FuelTB.Visible = false;
            Fuel.Visible = false;
            TransportTB.Visible = false;
            Transport.Visible = false;
            CourierType.SelectedIndex = 0;
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

                //записываем созданного курьера в список курьеров
                Caller.Couriers.Add(c);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Констркутор класса Courier не может обработать входные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
