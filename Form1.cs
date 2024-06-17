using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhTienLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double laisuat = Double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            double sotien = Double.Parse(txtsotien.Text);
            int sonam = int.Parse(txttiengui.Text);
            sotien = Convert.ToDouble(txtsotien.Text);
            for (int i = 1; i <= sonam; i++)
            {
                tienlai = sotien * laisuat;
                lbx.Items.Add("Năm" + i + "   " + sotien + "   " + tienlai);
                sotien += laisuat;
            }
        }
    }
}
