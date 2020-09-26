using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CW1
{
    [Serializable()]    //Set this attribute to all the classes that want to serialize
    public class Student : ISerializable, IComparable
    {
        private string StudentID;
        private string firstName;
        private string lastName;
        private string email;
        private bool status=false;
        public string group;
        public string studentMark;
        public string FinalMMark;
        public string groupMark;


        public Student(string studentID, string FirstName, string LastName, string Email, string Group, bool Status, string StudentMark, string GroupMark)
        {
            StudentID = studentID;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            group = Group;
            status = Status;
            studentMark = StudentMark;
            groupMark = GroupMark; 




        }


        public string student_ID
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }

        public string student_FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string student_LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }

        }

        public string student_Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }


        public bool GroupStatus
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }



        public string Group_Num
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }

        }

        public string Student_Mark
        {
            get
            {
                return studentMark;
            }
            set
            {
                studentMark = value;
            }

        }


        public string Group_Mark
        {
            get
            {
                return groupMark;
            }
            set
            {
                groupMark = value;
            }

        }










        //de-Serialization constructor
        public Student(SerializationInfo info, StreamingContext ctxt)
        {

            //get values from info and assign them to the appropiete properties 
            student_ID = (string)info.GetValue("StudeentID", typeof(string));
            student_FirstName = (string)info.GetValue("StudeentFirstName", typeof(string));
            student_LastName = (string)info.GetValue("StudeentLastName", typeof(string));
            student_Email = (string)info.GetValue("StudeentEmail", typeof(string));
            Group_Num = (string)info.GetValue("StudentGroup", typeof(string));
            Student_Mark = (string)info.GetValue("StudentMark", typeof(string));
            Group_Mark = (string)info.GetValue("GupppMark", typeof(string));
            
        }


        //Serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("StudeentID", student_ID);
            info.AddValue("StudeentFirstName", student_FirstName);
            info.AddValue("StudeentLastName", student_LastName);
            info.AddValue("StudeentEmail", student_Email);
            info.AddValue("StudentGroup", Group_Num);
            info.AddValue("StudentMark", Student_Mark);
            info.AddValue("GupppMark", Group_Mark);
            
        }

        //provide default sort order for the Employee objects
        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                Student temp = (Student)obj;

                return this.firstName.CompareTo(temp.firstName);
            }

            throw new ArgumentException("object is not a Employee");
        }


        // Nested class to do the sorting by EmpId
        public class sortByStudentIDHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                return ((Student)a).student_ID.CompareTo(((Student)b).student_ID);
               // Student std1 = (Student)a;
                // Student std2 = (Student)b;
                //  if (std1.StudentID > std2.StudentID)
                // return 1;
                // if (std1.StudentID < std2.StudentID)
                //    return -1;
                // else
                //  return 0;
            }


        }

        public static IComparer sortYearAscending()
        {
            return (IComparer)new sortByStudentIDHelper();
        }




    }
}


