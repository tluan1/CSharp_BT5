using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_BT5
{
    public partial class lbllaptrinh : Form
    {
        public lbllaptrinh()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtnhapten.Text = txtnhapten.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radred":
                    txtnhapten.ForeColor = Color.Red;
                    txtlaptrinh.ForeColor = Color.Red;
                    break;
                case "radgreen":
                    txtnhapten.ForeColor = Color.Green;
                    txtlaptrinh.ForeColor = Color.Green;
                    break;
                case "radblue":
                    txtnhapten.ForeColor = Color.Blue;
                    txtlaptrinh.ForeColor = Color.Blue;
                    break;
                case "radblack":
                    txtnhapten.ForeColor = Color.Black;
                    txtlaptrinh.ForeColor = Color.Black;
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            CheckBox r = (CheckBox)sender;
            switch (r.Name)
            {
                case "chkbold":
                    label4.Font = new Font(label4.Font.Name, label4.Font.Size, label4.Font.Style ^ FontStyle.Bold);
                    break;
                case "chkitalic":
                    label4.Font = new Font(label4.Font.Name, label4.Font.Size, label4.Font.Style ^ FontStyle.Italic);
                    break;
                case "chkunderline":
                    label4.Font = new Font(label4.Font.Name, label4.Font.Size, label4.Font.Style ^ FontStyle.Underline);
                    break;
            }
        }
    }
}
