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
    public class Group : ISerializable, IComparable
    {

            private string GroupName = "";
            private string GroupNum = "";
            public string GroupMark = "";
            public int Nstudents=0;

            //Default constructor
            public Group(string groupNum)
            {
                GroupNum = groupNum;
           
                
            }

            public string Group_Name
            {
                get { return GroupName; }
                set { GroupName = value; }
            }

            public string Group_Num
            {
                get { return GroupNum; }
                set { GroupNum = value; }
            }

            public string Group_Mark 
            {
                get { return GroupMark; }
                set { GroupMark = value; }
            }


        //Deserialization constructor.
        public Group(SerializationInfo info, StreamingContext ctxt)
            {
            //Get the values from info and assign them to the appropriate properties

                Group_Num = (String)info.GetValue("GroupNum", typeof(string)); ;
                Group_Name = (String)info.GetValue("GroupName", typeof(string));
                Group_Mark = (String)info.GetValue("GroupMark", typeof(string));


        }

            //Serialization function.
            public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
            {
                //You can use any custom name for your name-value pair. But make sure you
                // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
                // then you should read the same with "EmployeeId"

                info.AddValue("GroupNum", Group_Num);
                info.AddValue("GroupName", Group_Name);
                info.AddValue("GroupMark", Group_Mark);
        }

            //provide default sort order for the Department objects
            public int CompareTo(object obj)
            {
                if (obj is Group)
                {
                Group temp = (Group)obj;

                    return this.Group_Num.CompareTo(temp.Group_Num);
                }

                throw new ArgumentException("object is not a Group");
            }

            // Nested class to do the sorting by GroupName
            private class sortByDeptNameHelper : IComparer
            {
                int IComparer.Compare(object a, object b)
                {
                    Group group1 = (Group)a;
                    Group group2 = (Group)b;
                    return group1.CompareTo(group2.Group_Name);

                }
            }

            // Method to return IComparer object for sort helper.
            public static IComparer sortByDeptName()
            {
                return (IComparer)new sortByDeptNameHelper();
            }

        }


    }

