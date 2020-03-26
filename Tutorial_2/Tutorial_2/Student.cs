using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    public class Student
    {

        public string IndexNumber { get; }
        public string Fname { get; }
        public string Lname { get; }
        public string Birthdate { get; }
        public string Email { get; }
        public string MotherName { get; }
        public string FatherName { get; }

        private Study studies { get; }

        private Student(string Fname, string Lname, string IndexNumber, string Birthdate, string Email, string MotherName, string FatherName, Study Studies)
        {
            this.IndexNumber = IndexNumber;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Birthdate = Birthdate;
            this.Email = Email;
            this.MotherName = MotherName;
            this.FatherName = FatherName;
            studies = Studies;
        }


        public static Student GetInstanceOf(string student)
        {
            string[] arr = student.Split(',');
            if (arr.Length != 9) throw new StudentParseException();
            Study study = new Study(arr[3], arr[4]);

            return new Student(arr[0], arr[1], arr[2], arr[5], arr[6], arr[7], arr[8], study);
        }
    }

}
