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
    public partial class Form1 : Form
    {
        public List<Package>  Packages = new List<Package>();
        List<Courier> Couriers = new List<Courier>();

        DateTime CurrentTime;

        public Form1()
        {
            InitializeComponent();
            CurrentTime = DateTime.Now;
        }

        private void NewPackageButton_Click(object sender, EventArgs e)
        {
            AddPackageForm addPackageForm = new AddPackageForm(this);
            addPackageForm.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime.AddMinutes(1);
            foreach(Courier c in Couriers)
            {
                if (CurrentTime >= c.DateAndTimeOfReturns)
                    c.IsBusy = false;
            }
        }
    }
}
