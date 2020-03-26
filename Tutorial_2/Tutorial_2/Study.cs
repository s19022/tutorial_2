
using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2
{
    [Serializable]
    class Study
    {
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
