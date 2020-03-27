using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tutorial_2
{
   
    [XmlRoot("university")]
    [XmlInclude(typeof(Student))]
    [Serializable]
    public class University
    {
        [XmlAttribute("createdAt")]
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
        [XmlAttribute("author")]
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [XmlArrayAttribute("student")]
        [JsonPropertyName("student")]
        public List<Student> Students { get; set; }

    }
}
