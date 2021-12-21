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
    public partial class AddNewPckg : Form
    {
        Form1 Caller;
        int indexOfEditingPackage = -1;
        public AddNewPckg(Form1 form)
        {
            InitializeComponent();
            Caller = form;
            DateAndTimeMTB.Text = Caller.CurrentTime.ToString();
        }

        public AddNewPckg(Form1 form, int indexOfPackage)
        {
            InitializeComponent();
            Caller = form;
            DateAndTimeMTB.Text = Caller.Packages[indexOfPackage].DateAndTimeCreated.ToString();
            Sender.Text = Caller.Packages[indexOfPackage].Sender;
            Reciver.Text = Caller.Packages[indexOfPackage].Reciver;
            indexOfEditingPackage = indexOfPackage;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexOfEditingPackage >= 0 && Sender.Text != "" && Reciver.Text != "" && DateAndTimeMTB.Text != "")
                {
                    Caller.Packages[indexOfEditingPackage].DateAndTimeCreated = Convert.ToDateTime(DateAndTimeMTB.Text);
                    Caller.Packages[indexOfEditingPackage].Sender = Sender.Text;
                    Caller.Packages[indexOfEditingPackage].Reciver = Reciver.Text;
                    Close();
                    return;
                }
                if (indexOfEditingPackage < 0)
                { 
                    //создаем новую заявку
                    Package p = new Package(Sender.Text, Reciver.Text, Convert.ToDateTime(DateAndTimeMTB.Text));
                    //добавляем в список
                    Caller.Packages.Add(p);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Пустые поля недопустимы.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
