using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgrid
{
    [Serializable]
    public class Element
    {
        public string Name { set; get; }
        public DateTime Date { set; get; }

        public Element()
        {

        }
        public Element(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }
        public override string ToString()
        {
            return string.Format($"{Name} {Date.ToShortDateString()}");
        }
        public override bool Equals(object obj)
        {
            return (Name==(obj as Element).Name) && Date.Equals((obj as Element).Date);
        }

    }
}
