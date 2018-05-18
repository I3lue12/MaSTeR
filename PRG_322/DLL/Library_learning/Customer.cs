using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Library_learning
{
    public sealed class Customer  //sealed prevents sealed
    {
        //protected string FirstName;
        //protected string LastName;
        //public string Address;
        //protected string SSN;

        protected FirstName CFirstName;
        protected LastName CLastName;
        protected SSN CSSN;

        //public FirstName firstName        //see if I did this right
        //{
        //    get
        //    {
        //        return CFirstName;
        //    }
        //    set
        //    {
        //        CFirstName = firstName;
        //    }
        //}

        //public LastName lastName
        //{
        //    get
        //    {
        //        return CLastName;
        //    }
        //    set
        //    {
        //        CLastName = lastName;
        //    }
        //}
        //public SSN ssn
        //{
        //    get
        //    {
        //        return ssn;
        //    }
        //    set
        //    {
        //        CSSN = ssn;
        //    }
        //}



        protected Customer():base()
        {                  
        }
        public Customer(FirstName frstname,LastName lstname, SSN social) //used class types
        {
            //firstName = frstname; not needed because we used classes instead of 
            //lastName = lstname;
            //ssn = social;

            CFirstName = frstname;
            CLastName = lstname;
            CSSN = social;
        }
        
        //public void Serialize(string filename)
        //{
        //    IFormatter formatter = new BinaryFormatter();
        //    Stream stream = new FileStream(filename, FileMode.Create);               
        //    formatter.Serialize(stream,this);
        //    stream.Close();
        //}


       
        

    }
    public class FirstName
    {
        public string Value;
        public FirstName(String s)
        {
            Value = s;
        }

    }
    public class LastName
    {
        public string Value;
        public LastName(string s)
        {
            Value = s;
        }
    }
    public class SSN
    {
        SSNMalFormException e;
        public string Value;
        public SSN(String s)
        {
            e = new SSNMalFormException("failed 11 digit check");

            Value = s;
            int sz = s.Length;
            int countHyphins = 0;
            int countNumbs = 0;

            if (sz != 11)
            {
                throw e;
            }

            //Convert.ToInt32(s.Replace("-", string.Empty));
                               
            for (int i = 0; i < s.Length; i++)
            {
               // char.GetNumericValue(s[i]); //will this work               
                // make sure there are numbers and hyphens
                //question, by casting int to s[i] do I now have the ascii character?
                if (((int)s[i] > 47) && ((int)s[i] < 58)) 
                {                    
                  
                   if(countNumbs > 10)
                    {
                        countNumbs++;
                        //if the amount of numbers found are greater then ten
                        throw e;
                    }
                }
                if ((int)s[i] == 45)
                {
                                                          
                  if(countHyphins > 2)
                  {    countHyphins++;
                        //failed there are more then 2 hyphins
                        throw e;
                  }                 
                }              
            }
            //45, 49-57
            //make sure there are 2 hyphins
            //each digit is group 3,2,4
        }
    }
}
