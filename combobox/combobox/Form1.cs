using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;

        private void Form1_Load(object sender, EventArgs e)
        {
            coursecmb.Items.Add("C#");
            coursecmb.Items.Add("C++");
            coursecmb.Items.Add("C");
            coursecmb.Items.Add("PHP");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            name = coursecmb.SelectedItem.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
