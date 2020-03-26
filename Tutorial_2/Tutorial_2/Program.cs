using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            var list = new List<Student>();
            FillList(args[0], list);
            Console.WriteLine(args[1]);

            WriteToXml(args[1], list);


            
        }

        private static void FillList(string fileLocation, List<Student> list)
        {
            using (var stream = new StreamReader(fileLocation))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    try
                    {
                        var student = Student.GetInstanceOf(line);
                        if (Contains(list, student)) continue;
                        list.Add(Student.GetInstanceOf(line));

                    }catch(StudentParseException ex)
                    {
                        WriteInLog("Couldnt parse: " + line);
                    }
                }
            }
        }
            
        private static void WriteToXml(string path, List<Student> list)
        {
            FileStream writer = new FileStream(path, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("university"));
            //var list = new List<Student>();
            


            serializer.Serialize(writer, list);

        }

        private static bool Contains(List<Student> list, Student student)
        {
            foreach(Student item in list){
                if (item.Equals(student)) return true;
            }
            return false;
        }

        private static void WriteInLog(string message)
        {
            using (var writer = new StreamWriter(@"C:\Users\user\dotNetProjects\4_sem\tutorial_2\Tutorial_2\Tutorial_2\log.txt"))
            {
                writer.Write(message);
                writer.Write("\n");
                writer.Flush();
            }
        }
    }
}
