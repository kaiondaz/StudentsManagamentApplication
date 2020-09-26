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
    public partial class Form2 : Form
    {
        ArrayList students2 = new System.Collections.ArrayList();
        List<Group> group2 = new List<Group>();
        string Gnumber;
        private readonly Form1 frm1;
        public static int groupLimit=1; 
        //public ArrayList Students = new System.Collections.ArrayList();
        private CurrencyManager currencyManager = null;
        public Form2(ArrayList students, List<Group> group, string gnumber,Form1 frm)
        {
            InitializeComponent();
            students2 = students;
            group2= group;
            Gnumber = gnumber;
            frm1 = frm;
            dataGridView1.DataSource = students2;
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[students2];

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Student selectedStd = row.DataBoundItem as Student;
                if (selectedStd != null)
                {
                    this.textStuID.Text = selectedStd.student_ID.ToString();
                    this.textStuFirstName.Text = selectedStd.student_FirstName;
                    this.textStuLastName.Text = selectedStd.student_LastName;
                    this.textStuEmail.Text = selectedStd.student_Email;
                    //this.textStuGroup.Text = selectedStd.Group_Num;
                    // this.checkBoxFulltime.Checked = selectedStd.EmpStatus;
                }
            }
        }

        //Add to students to group
        private void button1_Click(object sender, EventArgs e)
        {   for (int i=0; i<3; i++) { 
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Student selectedStd = row.DataBoundItem as Student;
                if (selectedStd != null)
                {
                    selectedStd.Group_Num =  Gnumber;
                    foreach (Group group3 in group2)
                    {
                        if (((Student)selectedStd).Group_Num == group3.Group_Num & group3.Nstudents < 4)
                        {
                            //((Student)selectedStd).Group_Num = group.Group_Num;
                            group3.Nstudents++;
                            frm1.GetNumberStds(group3.Nstudents, group3);
                        }
                    }
                   
                   
                    


                  
                }
            }
            }
            frm1.RefreshGrid();
            frm1.RefreshStuGroupMarkDG();
            this.Close();
        }

        public ArrayList getStudents
        {
            get
            {
                return students2;
            }
            
        }

        //Button to clear text boxes
        private void button2_Click(object sender, EventArgs e)
        {
            this.textStuID.Text = "";
            this.textStuFirstName.Text = "";
            this.textStuLastName.Text = "";
            this.textStuEmail.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
