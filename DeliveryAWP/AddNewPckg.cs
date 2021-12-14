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
        public AddNewPckg(Form1 form)
        {
            InitializeComponent();
            Caller = form;
        }
       
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Package p = new Package(Sender.Text, Reciver.Text, Caller.CurrentTime);
                Caller.Packages.Add(p);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода. Констркутор класса Package не может обработать входные данные", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
