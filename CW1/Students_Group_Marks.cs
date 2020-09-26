using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1
{
    class Students_Group_Marks
    {
        
        
        public string StUdentID;
        public string studentFirstName;
        public string studentLastName;
        public Student Student;
        public Group Group;
        public string GroupMarK;
        public string StudentMarK ;
        public string TotalMarK;
        public string groupNum;







        public Students_Group_Marks(Student student, Group group) 
        {
            Student = student;
            Group = group;
            StUdentID = student.student_ID;
            studentFirstName = student.student_FirstName;
            studentLastName = student.student_LastName;
            GroupMarK = group.Group_Mark;
            StudentMarK= student.Student_Mark;
            TotalMarK = student.FinalMMark;




        }


       
        public string Get_student_ID
        {
            get
            {
                return StUdentID;
            }
            set
            {
                StUdentID = value;
            }
        }

        public string GroupNum
        {
            get
            {
                return groupNum;
            }
            set
            {
                groupNum = value;
            }
        }



        public string student_Mark
        {
            get
            {
                return StudentMarK;
            }
            set
            {
                StudentMarK = value;
            }

        }


        public string Group_Mark
        {
            get
            {
                return GroupMarK;
            }
            set
            {
                GroupMarK = value;
            }

        }



        public string totalmark
        {
            get
            {
                return TotalMarK;
            }
            set
            {
                TotalMarK = value;
            }

        }

    }
}
