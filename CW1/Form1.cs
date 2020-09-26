using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CW1
{
    public partial class Form1 : Form
    {

        public   ArrayList Students = new System.Collections.ArrayList();
        //public static ArrayList Students2 = new System.Collections.ArrayList();
        List<Group> GroupList = new List<Group>();
        List<Students_Group_Marks> Students_Group_Marks = new List<Students_Group_Marks>();
        private CurrencyManager currencyManager = null;
        private CurrencyManager currencyManager2 = null;
        //private DataGridViewSelectedRowCollection row;
        public Form2 form2;
        public Form3 form3;

        //private BindingSource bindSrc = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1400, 730);
           
         
        }

        public void RefreshStuGroupMarkDG()

        {
            dataGridView3.DataSource = null;
            Students_Group_Marks = null;
            Students_Group_Marks = new List<Students_Group_Marks>();
            // create student group marks object equal to the number of students to store student and group marks information
            for (int i = 0; i < Students.Count; i++)
            {
                Students_Group_Marks.Add((new Students_Group_Marks((new Student("", "", "", "", "", false, "", "")), new Group(""))));

            }

            //set the student and group marks array and datagrid
            Students_Group_Marks[0].StudentMarK = ((Student)Students[0]).Student_Mark;
            Students_Group_Marks[0].GroupMarK = ((Student)Students[0]).groupMark;
            Students_Group_Marks[0].StUdentID = ((Student)Students[0]).student_ID;
            Students_Group_Marks[0].groupNum = ((Student)Students[0]).group;
            for (int i = 1; i < Students.Count + 1; i++)
            {
                Students_Group_Marks[i - 1].GroupMarK = ((Student)Students[i - 1]).groupMark;
                Students_Group_Marks[i - 1].StudentMarK = ((Student)Students[i - 1]).Student_Mark;
                Students_Group_Marks[i - 1].StUdentID = ((Student)Students[i - 1]).student_ID;
                Students_Group_Marks[i - 1].groupNum = ((Student)Students[i -1 ]).group;

            }

            //set the student and group marks 
            foreach (Students_Group_Marks stdMarks in Students_Group_Marks)
            {
                if (stdMarks.StudentMarK != null & stdMarks.StudentMarK != "" & stdMarks.GroupMarK != null & stdMarks.GroupMarK != "")

                {
                    int stdMarks2 = Int32.Parse(stdMarks.StudentMarK);
                    int groupMarks = Int32.Parse(stdMarks.GroupMarK);
                    int totalGrade = (stdMarks2 + groupMarks) / 2;
                    //if (stdMarks2 % groupMarks==1)
                    // {
                    //   totalGrade=+1;

                    //}
                    stdMarks.TotalMarK = totalGrade.ToString();

                }

            }

            
          //  Console.WriteLine(Students_Group_Marks.Count);


            //set the combobox datasource to the group arraylist
            GroupNumberComboBox1.DataSource = (object)this.GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
            //set students marks groups datagrid
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Students_Group_Marks;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Students.Add(new Student("1111", "", "", "", "1", false,"4","11"));
            Students.Add(new Student("2222", "", "", "", "", false, "5", "4"));
            Students.Add(new Student("3333", "", "", "", "", false, "", ""));
            Students.Add(new Student("5555", "", "", "", "", false, "4", ""));
            Students.Add(new Student("4444", "", "", "", "", false, "", ""));
            Students.Add(new Student("6666", "", "", "", "", false, "4", ""));
            Students.Add(new Student("7777", "", "", "", "", false, "", ""));
            Students.Add(new Student("8888", "", "", "", "", false, "", "5"));


            // Students.Add(new Student(6666, "", "", "", "3", false));
            dataGridView1.DataSource = Students;
            dataGridView3.DataSource = Students_Group_Marks;
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[Students];
            currencyManager2 = (CurrencyManager)dataGridView3.BindingContext[Students_Group_Marks];

            for (int i = 0; i < 2; i++)
            {
                //initialise the array with numberOfDepartments Depertment object
                GroupList.Add(new Group("" + (i + 1))); //this is because DeptId is declared as string
                ((Group)GroupList[i]).Group_Name = "Group no." + (i + 1);
            }

            // create student group marks object equal to the number of students to store student and group marks information
            for (int i = 0; i < Students.Count; i++)
            {
                Students_Group_Marks.Add((new Students_Group_Marks((new Student("", "", "", "", "", false, "", "")), new Group(""))));

            }


            //set the student and group marks array and datagrid
            Students_Group_Marks[0].StudentMarK= ((Student)Students[0]).Student_Mark;
            Students_Group_Marks[0].StUdentID = ((Student)Students[0]).student_ID;
            Students_Group_Marks[0].groupNum = ((Student)Students[0]).group;          
            
            for (int i = 1; i < Students.Count+1 ; i++)
            {
                Students_Group_Marks[i - 1].GroupMarK = ((Student)Students[i - 1]).groupMark;
                Students_Group_Marks[i-1].StudentMarK = ((Student)Students[i-1]).Student_Mark;
                Students_Group_Marks[i - 1].StUdentID = ((Student)Students[i - 1]).student_ID;
                Students_Group_Marks[0].groupNum = ((Student)Students[0]).group;

            }


            //set the student and group marks 
            foreach (Students_Group_Marks stdMarks in Students_Group_Marks)
            {
                if (stdMarks.StudentMarK != null & stdMarks.StudentMarK != "" & stdMarks.GroupMarK != null & stdMarks.GroupMarK !="" )

                {
                    int stdMarks2 = Int32.Parse( stdMarks.StudentMarK);
                    int groupMarks = Int32.Parse(stdMarks.GroupMarK);
                    int totalGrade = (stdMarks2 + groupMarks) / 2;
                    //if (stdMarks2 % groupMarks==1)
                   // {
                     //   totalGrade=+1;

                    //}
                    stdMarks.TotalMarK = totalGrade.ToString();

                }

            }          
           
      

            //set students marks groups datagrid
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Students_Group_Marks;

            //set the combobox datasource to the group arraylist
            GroupNumberComboBox1.DataSource = (object) this.GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
           
        }
        
        //Refresh datagridview of the students table information
        public void RefreshGrid()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[Students];
            this.dataGridView2.Refresh();

        }

        //serialization button
        private void Button1_Click(object sender, EventArgs e)
        {
            
            // Save student details

            BinaryFormatter bformatter = new BinaryFormatter();
            Stream stream = File.Open("Student.dat", FileMode.Create);
            Console.WriteLine("Writing Student Information");
            bformatter.Serialize(stream, Students);
            stream.Close();

            //save department details
            stream = File.Open("GroupDetails.dat", FileMode.Create);
            Console.WriteLine("Writing Groups Information");
            bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, GroupList);
            stream.Close();

            MessageBox.Show("Students and Groups Data saved to file");

           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }


        //Add Student button event 
        private void Button4_Click(object sender, EventArgs e)
        {
            
            if (GroupNumberComboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a group ");

            }
            if (this.GroupNumberComboBox1.SelectedValue == null)
                return;
            foreach (object student in this.Students)
            {
                

                

                string upper = ((Student)student).student_ID.ToUpper();
                if (upper.CompareTo(this.textStuID.Text.ToUpper()) == 0)
                {
               
                    string Gnum1 = this.GroupNumberComboBox1.SelectedValue.ToString();
                    if (MessageBox.Show("A stdudent with ID = " + upper + " already exists!\n Do you really want to update this student's record with new details", "Student already exists!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;                 
                    ((Student)student).student_FirstName= this.textStuFirstName.Text;
                    ((Student)student).student_LastName = this.textStuLastName.Text;
                    ((Student)student).GroupStatus = this.checkBox1.Checked;
                    ((Student)student).Group_Num = Gnum1;
                    int num = (int)MessageBox.Show(((Student)student).student_FirstName +""+ ((Student)student).student_LastName+ " record has been updated with new details, except the ID.");
                    this.dataGridView1.DataSource = (object)null;
                    this.dataGridView1.DataSource = (object)this.Students;
                    
                    //Refresh datagrids and combobox
                    RefreshStuGroupMarkDG();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Students;
                    GroupNumberComboBox1.DataSource = (object)this.GroupList;
                    GroupNumberComboBox1.DisplayMember = "Group_Name";
                    GroupNumberComboBox1.ValueMember = "Group_Num";
                    return;
                }
            }
            string Gnum = this.GroupNumberComboBox1.SelectedValue.ToString();
            Students.Add(new Student((this.textStuID.Text), this.textStuFirstName.Text, this.textStuLastName.Text, this.textStuEmail.Text, Gnum, this.checkBox1.Checked,"",""));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;
            currencyManager = (CurrencyManager)dataGridView1.BindingContext[Students];
            this.dataGridView2.Refresh();



            

            



        }

        private void Button8_Click(object sender, EventArgs e)
        {
            currencyManager.Position++;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            currencyManager.Position--;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            currencyManager.Position = 0;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            currencyManager.Position = Students.Count - 1;
        }



        //De-serialization button
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                Stream stream = File.Open("Student.dat", FileMode.Open);
                //bformatter = new BinaryFormatter();
                BinaryFormatter bformatter = new BinaryFormatter();

                //Console.WriteLine("Reading Student Information");
                Students = (ArrayList)bformatter.Deserialize(stream);
                stream.Close();
                this.dataGridView1.DataSource = (object)null;
                this.dataGridView1.DataSource = (object)this.Students;
                dataGridView1.DataSource = Students;
                currencyManager = (CurrencyManager)dataGridView1.BindingContext[Students];


                //Open the file written above and read values from it.
                stream = File.Open("GroupDetails.dat", FileMode.Open);
                bformatter = new BinaryFormatter();

                //Reading Department Information
                GroupList = (List<Group>)bformatter.Deserialize(stream);                
               
               

                stream.Close();

                //refresh the combobox of departments
                GroupNumberComboBox1.DataSource = (object) null;
                GroupNumberComboBox1.DataSource = (object) GroupList;
                GroupNumberComboBox1.DisplayMember = "Group_Name";
                GroupNumberComboBox1.ValueMember = "Group_Num";

               
                MessageBox.Show("Students & Group Data retrieved from file");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR reading file!"); }

            //Refresh Students and Group marks datagrid
            RefreshStuGroupMarkDG();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.textStuID.Text = "";
            this.textStuFirstName.Text = "";
            this.textStuLastName.Text = "";
            this.textStuEmail.Text = "";

        }

        private void Button13_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Student selectedStd = row.DataBoundItem as Student;
                if (selectedStd != null)
                {
                    Students.Remove(selectedStd);
                }
            }

            //Refresh Students and Group marks datagrid
            RefreshStuGroupMarkDG();

            //RefreshDatgridView1 of the students class information
            dataGridView1.DataSource = null;         
            dataGridView1.DataSource = Students;
        }


        //Sorting the students by ID method method 
        private void button6_Click(object sender, EventArgs e)
        {
            IComparer Comp1 = new Student.sortByStudentIDHelper();

            Students.Sort(Comp1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;

        }

        //Sorting the students by name method method
        private void button7_Click(object sender, EventArgs e)
        {
            Students.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;

        }

        //DataGrid of the students information selection method
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
                    this.GroupNumberComboBox1.SelectedValue = selectedStd.Group_Num;
                    // this.checkBoxFulltime.Checked = selectedStd.EmpStatus;
                }
            }
        }

        //de-serialization method 
        private void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Do you want to replace the current data?";
                string caption = "Import from CSV file";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result != System.Windows.Forms.DialogResult.Yes) //the user click no                  
                {
                    return;
                }

                //the user click Yes
                // delete the current data in the EmployeeList arraylist
                Students.Clear();
                //import from Students.csv file located in the bin\debug folder within
                //the project folder
                string CSVfileName = "Students.csv";
                string csvData = "";
                //read from file into a string
                using (StreamReader oStreamReader = new StreamReader(File.OpenRead
                (CSVfileName)))
                {
                    csvData = oStreamReader.ReadToEnd();
                }
                //parse the string csvData to object collection
                string[] rows = csvData.Replace("\r", "").Split('\n');
                foreach (string row in rows)
                {
                    if (string.IsNullOrEmpty(row)) continue;
                    string[] cols = row.Split(',');
                    //instantiate a new Employee object to store the row to import
                    Student StdObj = new Student("0", "", "", "", "", false,"","");
                    //the employee csv file has 3 columns, which contain empId, empName
                    //and employment status
                    StdObj.student_ID = (cols[0]);
                    StdObj.student_FirstName = cols[1];
                    StdObj.student_LastName = cols[2];
                    StdObj.student_Email = cols[3];
                    this.GroupNumberComboBox1.SelectedValue = (object)1;
                    this.checkBox1.Checked = false;


                    //empObj.student_LastName = Boolean.Parse(cols[2]); //convert from string
                    //TRUE or FALSE to boolean value
                    this.Students.Add(StdObj);

                }
                //refesh view
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Students;
                //reset the textboxes
                this.textStuID.Text = "";
                this.textStuFirstName.Text = "";
                this.textStuLastName.Text = "";
                this.textStuEmail.Text = "";                     
                this.GroupNumberComboBox1.SelectedValue = 1;
                this.checkBox1.Checked = false;
                
               

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ERROR reading file!"); }

            //Refresh datagrids and combobox
            RefreshStuGroupMarkDG();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;
            GroupNumberComboBox1.DataSource = (object)this.GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Button to add a new group 
        private void Button14_Click(object sender, EventArgs e)
        {   if (textBoxGroupNum.Text == null || textBoxGroupNum.Text.Trim() == "") 
            {
                MessageBox.Show( "Please enter a number to represent the new group number.");
            }

            if (textBoxGroupNum.Text != null & textBoxGroupNum.Text.Trim() != "")
            {
                
           
            //validate the new deptID - must be unique
            foreach (object o in this.GroupList)
            {
                string str = ((Group)o).Group_Num.ToUpper();

                //if found an existing group with the same ID
                if (str.CompareTo((this.textBoxGroupNum.Text).ToUpper()) == 0)
                {

                    // Initializes the variables to pass to the MessageBox.Show method. 

                    string message = "A Group with ID = " + str + " already exists! Please enter a different number";
                    string caption = "Group already exists!";
                   
                    

                    MessageBox.Show(message, caption);
               

                    
                }

                    if (str.CompareTo((this.textBoxGroupNum.Text).ToUpper()) == 0)
                    {

                        return;

                    }
                }

            // the value of the entered in Group number  in the textbox is new

            //create a new group object
            Group newGroup = new Group(this.textBoxGroupNum.Text);
            newGroup.Group_Name = "Group no." + this.textBoxGroupNum.Text;
            GroupList.Add(newGroup);

            MessageBox.Show(newGroup.Group_Name + " has been created");

            //refresh the combobox
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = GroupList;
            GroupNumberComboBox1.DataSource = null;
            GroupNumberComboBox1.DataSource = GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
            GroupNumberComboBox1.Refresh();

            //foreach (Group g in GroupList)
           // {
             //   Console.WriteLine(g.Group_Name);
           // }


            string message2 = "Would you like to add students to the new group from the student's list? ";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            string caption2 = "Proceed to assign students?";
            DialogResult result2;

            // Displays the MessageBox.

            result2 = MessageBox.Show(message2, caption2, button);


            //Form to add students from the list which have no group, after creating a new group 
            if (result2 == System.Windows.Forms.DialogResult.Yes)
            {
                ArrayList students3 = new ArrayList();
                foreach (object student in Students)
                {
                    if (((Student)student).Group_Num == "")
                    {
                        students3.Add((object)(Student)student);
                    }
                }
                string Gnumber = this.textBoxGroupNum.Text;
                form2 = new Form2(students3, GroupList, Gnumber, this);
                form2.Show();

                //Get students from other form and refresh datagrid


            }
            }

        }

        public void GetNumberStds(int nrStdsIndGroup, Group group) 
        {
            int nrStds = nrStdsIndGroup;
            Group Group1=group;
            foreach (Group group5 in GroupList)
            {
                if (group5.Group_Num == Group1.Group_Num) 
                {
                    group5.Nstudents = nrStds;
                }
            }

         
        }

        private void GroupNumberComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.GroupNumberComboBox1.SelectedValue == null)
                return;
            string Combo = this.GroupNumberComboBox1.SelectedValue.ToString();
            ArrayList arrayList = new ArrayList();
            foreach (object student in this.Students)
            {
                if (((Student)student).Group_Num.CompareTo(Combo) == 0 )
                    arrayList.Add((object)(Student)student);
            }
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = arrayList;

        }


        //Clear button  for group table 
        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            Students.Clear();
            dataGridView2.Rows.Clear();
        }


        //Bulk assign students button 
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList noGroup = new ArrayList();
            List<Student> noStudentgroup = new List<Student>();
            List<Group> group_with_1_Std = new List<Group>();
            ArrayList group_with_0_Std = new ArrayList();
            int noGroupcount;
            foreach (object student in Students)
            {
                string GroupNum = ((Student)student).Group_Num;

                if (GroupNum == null || GroupNum.Trim() == "")
                        
                {
                    noStudentgroup.Add((Student)student);
                }
            }
           

            noGroupcount = noStudentgroup.Count;

            if (noGroupcount == 0) 
            {
                MessageBox.Show(" All students have been assign to  a group. Cant proceed to bulk assign the students");
            }

            if (noGroupcount == 0)
            {
                return;
            }

            
            //get the number of groups with 0 students
            //foreach (Group group in this.GroupList)
            //{
            //    foreach (object student in this.Students)
             //   {
                //    if (((Student)student).Group_Num.CompareTo(group.Group_Num) == 0)
               //         //group_with_0_Std.Add((object)(Student)student);
               //     group.Nstudents++;


            //    }
            //}

            //If there are no empty groups to assing, cancel the assignment 
            if (noGroup.Count < 0 || group_with_0_Std.Count < 0)
            {
                MessageBox.Show("No empty groups available to proceed assignment.");
            }
            if (noGroup.Count <0  ||   group_with_0_Std.Count < 0)
            {
                return;
            }


            if (noGroupcount != 0) 
            { 
                if (MessageBox.Show(noGroupcount.ToString() + " Students with no group\nDo you want to execute bulk-assignment?", "Bulk-Assign", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            int studentsWithGroup = 0;//number of students in group
            string group_numbers;//group number 
                                 //  groupNumbstr = this.bulkAssignTextBox.Text;




             
                    foreach (Group groupnumbers in GroupList)
            {
                group_numbers = groupnumbers.Group_Num;



                foreach (Student student in Students)
                {
                    if (group_numbers == student.Group_Num)
                    {
                        studentsWithGroup++;


                    }

                }
                    int NrstudentsWithNoGroup = Students.Count - studentsWithGroup;

            
             

                //If there are no groups with 1 students in the first place 

                   
                    int index3 = 0;
                    int CountRemainderStd4 = 0;          
                    int avaiulable_pLAces_in_Groups = group_with_0_Std.Count * 4;
                    // for (int i=0; i< noGroup.Count; i++)
                    // {


                    //    Console.WriteLine(CountRemainderStd4);
                    //   ((Student)noGroup[i-1]).Group_Num = ((Group)group_with_0_Std[index3]).Group_Num;
                    //    //noGroup.Remove(noGroup[i]);
                    //    CountRemainderStd4++;
                    //    if (CountRemainderStd4 == 4)
                    //    {
                    //      index3++;
                    //      CountRemainderStd4 = 0;

                    //  }

                    //}

                    //if the numbers of students with no group is bigger than the available places 
                    if (NrstudentsWithNoGroup > avaiulable_pLAces_in_Groups) {
                        foreach(Group group in GroupList)
                        {
                            foreach (Student std in noStudentgroup)
                                {  
                                    foreach (object student in Students)                                       
                                    { 

                                    if (((Student)student).student_ID == std.student_ID & group.Nstudents <4) 
                                    { 
                                    ((Student)student).Group_Num = group.Group_Num;
                                        group.Nstudents++;
                                  //  noStudentgroup.Remove(std);
                                    
                                }
                                    }
                                }
                            //CountRemainderStd4++;
                        }
                    }
            }



            //foreach (Group g in group_with_0_Std)
            //{
            //  Console.WriteLine( g.Group_Num );

            //  }



            //Console.WriteLine(count69);
            //Console.WriteLine("There are " + group_with_1_Std.Count + "groups with 1 stds");
            // foreach (Group g2 in group_with_0_Std)
            // {


            // }



            // int group_with_2Std_Size = group_with_2_Std.Count; //how many groups with 2 students
            // int reachLimitCount = 2;//variable to indicate if 2 students have been added 
            // do
            //{
            //    foreach (Student student in Students)
            //   {
            //     string GroupNum = ((Student)student).Group_Num;
            //    if (GroupNum == null || GroupNum.Trim() == "")
            //  {

            //foreach (Group group in group_with_<2_Std)
            //    for (int i = 0; i < group_with_2_Std.Count - 1; i++)
            //  {
            //  do
            // {
            //     string GroupNum2 = group_with_2_Std[i].Group_Num;
            //((Group)group).Group_Num;
            //assign the group number to the student
            //  student.Group_Num = GroupNum2;
            //  //recount the students with the group in the students list
            //  foreach (Student student7 in Students)
            // {

            //   if (student7.Group_Num == GroupNum2)
            //   {
            //      reachLimitCount++;//how many students in the group now

            //  }
            // }


            //  } while (reachLimitCount < 2);
            //  foreach (Student g in Students)
            //  {
            //      Console.WriteLine(g.Group_Num);
            //  }
            // group_with_2_Std.Remove(group_with_2_Std[i]);//remove group from the list
            // group_with_2Std_Size = group_with_2_Std.Count;

            //((Student)student).Group_Num;
            // noGroupcount--;

            //   }
            //  }
            // }

            //} while (group_with_2Std_Size > 0 | noGroupcount > 0);






            //int num1 = (count + 4 - 1) / 4;
            //int val1 = count % 4;
            // int num2 = 0;
            //int num3 = 0;
            // string GroupNumstr = "";
            //foreach (object obj in noGroup)
            // {
            //  if (num3 == 0)
            // {
            //   ++num2;
            //  GroupNumstr = this.bulkAssignTextBox.Text + (object)num2;
            // this.GroupList.Add((object)new Group(GroupNumstr)
            //  {
            //      Group_Name = (this.bulkAssignTextBox.Text + (object)num2)
            //  });
            // }
            //  ((Student)obj).Group_Num = GroupNumstr;
            // ++num3;
            // if (num1 > 1 && val1 > 0 && (num2 == 1 && num3 == Math.Max(val1, 2)) || num3 == 4)
            //     num3 = 0;
            //}
            this.dataGridView1.DataSource = (object)null;
            this.dataGridView1.DataSource = (object)Students;
            this.GroupNumberComboBox1.DataSource = (object)null;
            this.GroupNumberComboBox1.DataSource = (object)this.GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
                }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }


        //Add student marks button 
        private void button17_Click(object sender, EventArgs e)
        {
           

            if (textBoxGroupNum.Text != null & textBoxGroupNum.Text.Trim() != "")
            {
                // create student group marks equal to the number of students
                for (int i = 0; i < Students.Count; i++)
                {
                    Students_Group_Marks.Add((new Students_Group_Marks((new Student("", "", "", "", "", false, "", "")), new Group(""))));

                }

                Students_Group_Marks[0].StudentMarK = ((Student)Students[0]).Student_Mark;
                Students_Group_Marks[0].StUdentID = ((Student)Students[0]).student_ID;

                //set the student and group marks 

                for (int i = 1; i < Students.Count + 1; i++)
                {

                    Students_Group_Marks[i - 1].GroupMarK = ((Student)Students[i - 1]).groupMark;
                    Students_Group_Marks[i - 1].StudentMarK = ((Student)Students[i - 1]).Student_Mark;
                    Students_Group_Marks[i - 1].StUdentID = ((Student)Students[i - 1]).student_ID;

                }


                //set the student and group marks 
                foreach (Students_Group_Marks stdMarks in Students_Group_Marks)
                {
                    if (stdMarks.StudentMarK != null & stdMarks.StudentMarK != "" & stdMarks.GroupMarK != null & stdMarks.GroupMarK != "")

                    {
                        int stdMarks2 = Int32.Parse(stdMarks.StudentMarK);
                        int groupMarks = Int32.Parse(stdMarks.GroupMarK);
                        int totalGrade = (stdMarks2 + groupMarks) / 2;                       
                        stdMarks.TotalMarK = totalGrade.ToString();
                    }
                }
  
                //set students marks groups datagrid
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = Students_Group_Marks;
                //set the combobox datasource to the group arraylist
                GroupNumberComboBox1.DataSource = (object)this.GroupList;
                GroupNumberComboBox1.DisplayMember = "Group_Name";
                GroupNumberComboBox1.ValueMember = "Group_Num";
            }


            //Validate studentID  text box 
            if (StudentiD.Text == null || StudentiD.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a student ID.");
            }
            if (StudentiD.Text == null || StudentiD.Text.Trim() == "")
            {
                return;
            }
            //Validate student mark text box 
            if (StudentmarkTextBox.Text == null || StudentmarkTextBox.Text.Trim() == "")
                
            {
                MessageBox.Show("Please enter a student mark.");
            }
            if (StudentmarkTextBox.Text == null || StudentmarkTextBox.Text.Trim() == "")

            {
               return;
            }
        
            //Search the group for the student id 
            bool IDFound = false;
            Students_Group_Marks searchStudent;


            foreach (Students_Group_Marks studentGM in this.Students_Group_Marks)
            {
                if (studentGM.StUdentID.CompareTo(StudentiD.Text)==0)
                {                  
                    IDFound = true;
                    searchStudent = studentGM;
                    searchStudent.StudentMarK = StudentmarkTextBox.Text;
                }
            }

            if(IDFound == true) 
            {
                MessageBox.Show("The student mark was updated succesfully");
            }


            if  (IDFound == false)
            {
                MessageBox.Show("The student ID entered could not be found ");
            }
            if (IDFound == false)
            {
                return;
            }


            //assigning the student marks to the students array 
            for (int i = 1; i < Students.Count + 1; i++)
            {
                ((Student)Students[i - 1]).Student_Mark = Students_Group_Marks[i - 1].StudentMarK;
                Console.WriteLine(((Student)Students[i - 1]).Student_Mark);             
            }

            //set the student and group marks 
            foreach (Students_Group_Marks stdMarks in Students_Group_Marks)
            {
                if (stdMarks.StudentMarK != null & stdMarks.StudentMarK != "" & stdMarks.GroupMarK != null & stdMarks.GroupMarK != "")

                {
                    int stdMarks2 = Int32.Parse(stdMarks.StudentMarK);
                    int groupMarks = Int32.Parse(stdMarks.GroupMarK);
                    int totalGrade = (stdMarks2 + groupMarks) / 2;
                    //if (stdMarks2 % groupMarks==1)
                    // {
                    //   totalGrade=+1;

                    //}
                    stdMarks.TotalMarK = totalGrade.ToString();

                }

            }
            //set students marks groups datagrid and refresh
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Students_Group_Marks;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;



        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            ArrayList students3 = new ArrayList();
            foreach (object student in Students)
            {
                if (((Student)student).Group_Num == "")
                {
                    students3.Add((object)(Student)student);
                }
            }
            string Gnumber = this.textBoxGroupNum.Text;
            form3 = new Form3(students3, GroupList, Gnumber, this);
            form3.Show();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Validate GroupID  text box 
            if (GroupNumTTBox.Text == null || GroupNumTTBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a group number.");
            }
            if (GroupNumTTBox.Text == null || GroupNumTTBox.Text.Trim() == "")
            {
                return;
            }

            //Validate group mark text box 
            if (GroupMarkTTextBox.Text == null || GroupMarkTTextBox.Text.Trim() == "")

            {
                MessageBox.Show("Please enter a group mark.");
            }
            if (GroupMarkTTextBox.Text == null || GroupMarkTTextBox.Text.Trim() == "")

            {
                return;
            }

            //Search the group  
            bool IDFound2 = false;
            Students_Group_Marks searchGroup;


            foreach (Students_Group_Marks studentGM in this.Students_Group_Marks)
            {
                if (studentGM.groupNum != null)
                {
                    if (studentGM.groupNum.CompareTo(GroupNumTTBox.Text) == 0)
                    {
                        IDFound2 = true;
                        searchGroup = studentGM;
                        searchGroup.GroupMarK = GroupMarkTTextBox.Text;
                    }
                }
            }

            if (IDFound2 == true)
            {
                MessageBox.Show("The group mark was updated succesfully");
            }


            if (IDFound2 == false)
            {
                MessageBox.Show("The group ID entered could not be found ");
            }


            if (IDFound2 == false)
            {
                return;
            }


            //assigning the group marks to the Group array 
            for (int i = 1; i < Students.Count + 1; i++)
            {
                ((Student)Students[i - 1]).groupMark = Students_Group_Marks[i - 1].GroupMarK;
                Console.WriteLine(((Student)Students[i - 1]).Student_Mark);
            }


            //set the student and group marks 
            foreach (Students_Group_Marks stdMarks in Students_Group_Marks)
            {
                if (stdMarks.StudentMarK != null & stdMarks.StudentMarK != "" & stdMarks.GroupMarK != null & stdMarks.GroupMarK != "")

                {
                    int stdMarks2 = Int32.Parse(stdMarks.StudentMarK);
                    int groupMarks = Int32.Parse(stdMarks.GroupMarK);
                    int totalGrade = (stdMarks2 + groupMarks) / 2;
                    //if (stdMarks2 % groupMarks==1)
                    // {
                    //   totalGrade=+1;

                    //}
                    stdMarks.TotalMarK = totalGrade.ToString();

                }

            }

            //set students marks groups datagrid and refresh
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Students_Group_Marks;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Students;
            GroupNumberComboBox1.DataSource =null;
            GroupNumberComboBox1.DataSource = (object)this.GroupList;
            GroupNumberComboBox1.DisplayMember = "Group_Name";
            GroupNumberComboBox1.ValueMember = "Group_Num";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


}



