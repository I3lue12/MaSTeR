using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseIncorp
{
    public class StudentInfo
    {
        protected int studentID;
        protected string nameFirst;
        protected string nameLast;
        public StudentInfo(int id, string frst, string lst) //TODO: can mix up first and last name to be swapped
        {     
            studentID = id;
            nameFirst = frst;
            nameLast = lst;
        }
        public int ID // delete this too see error.
        {
            get
            {
                return studentID;
            }
        }
        public string FirstName
        {
            get
            {
                return nameFirst;
            }
        }
        public string LastName
        {
            get
            {
                return nameLast;
            }
        }


    }
}
