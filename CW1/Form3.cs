using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW1
{
    public partial class Form3 : Form
    {
        ArrayList students2 = new System.Collections.ArrayList();
        List<Group> group2 = new List<Group>();
        List<Student> Student2 = new List<Student>();
        string Gnumber;
        private readonly Form1 frm1;
        public static int groupLimit = 1;
        //public ArrayList Students = new System.Collections.ArrayList();
        private CurrencyManager currencyManager = null;
        public Form3(ArrayList students, List<Group> group, string gnumber, Form1 frm)
        {
            InitializeComponent();
            students2 = students;
            group2 = group;
            Gnumber = gnumber;
            frm1 = frm;
            dataGridView1.DataSource = students2;
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[students2];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    }

