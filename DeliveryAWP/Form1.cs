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

        public Form1()
        {
            InitializeComponent();
        }

        private void NewPackageButton_Click(object sender, EventArgs e)
        {
            AddPackageForm addPackageForm = new AddPackageForm(this);
            addPackageForm.ShowDialog();
            
        }
    }
}
