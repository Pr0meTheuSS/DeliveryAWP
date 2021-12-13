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
    public partial class AddPackageForm : Form
    {
        Form1 Caller;
        public AddPackageForm(Form1 form)
        {
            Caller = form;
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Package p = new Package(SenderTextBox.Text, ReciverTextBox.Text, CreatedDateTimePicker.Value);
                Caller
            }
            catch {
                MessageBox.Show("Ошибка ввода. Констркутор класса Package не может обработать входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SenderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreatedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReciverTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
