using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formreview2
{


    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        string name;
        string positon;
        int salary;
        string gender;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
             
            name = txtname.Text;
             positon = txtposition.Text;
             salary = int.Parse(txtsalary.Text);
           
            if(rbtndemale.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            display();
            empty();
           
            
        }
        public void display()
        {
            dt.Columns.Add("name ");
            dt.Columns.Add("position ");
            dt.Columns.Add("salary ");
            dt.Columns.Add("gender ");

            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = positon;
            dr[2] = salary;
            dr[3] = gender;

            dt.Rows.Add(dr);
            dtdataGridView.DataSource = dt;
        }
        public void empty()
        {
            txtname.Text = "";
            txtposition.Text = "";
            txtsalary.Text = "";


        }
    }
}
