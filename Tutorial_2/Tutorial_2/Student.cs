using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tutorial_2
{
    [Serializable]
    public class Student
    {
        [XmlAttribute(AttributeName = "indexNumber")]
        public string IndexNumber { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Birthdate { get; set; }
        public string Email { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }

        private Study studies { get; set; }

        public Student()
        {

        }
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
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   IndexNumber == student.IndexNumber &&
                   Fname == student.Fname &&
                   Lname == student.Lname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IndexNumber, Fname, Lname);
        }


        public static Student GetInstanceOf(string student)
        {
            string[] arr = student.Split(',');
            if (arr.Length != 9) throw new StudentParseException();
            Study study = new Study(arr[2], arr[3]);

            return new Student(arr[0], arr[1], arr[4], arr[5], arr[6], arr[7], arr[8], study);
        }

    }

}
