
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tutorial_2
{
    [XmlRoot("studies")]
    [Serializable]
    public class Study
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        public string Mode { get; set; }

        public Study(string Name, string Mode)
        {
            this.Name = Name;
            this.Mode = Mode;
        }

        public Study()
        {

        }
    }
}
