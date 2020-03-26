using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    public class Student
    {
        public string Fname { get; }
        public string Lname { get; }
        public string Birthdate { get; }
        public string Email { get; }
        public string MotherName { get; }
        public string FatherName { get; }

        //public IEnumerable<Study> Studies; { get; }

        private Student(string Fname, string Lname, string Birthdate, string Email, string MotherName, string FatherName)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Birthdate = Birthdate;
            this.Email = Email;
            this.MotherName = MotherName;
            this.FatherName = FatherName;
        }


        public static Student GetInstanceOf(string student)
        {

            return null;
        }
    }

}
