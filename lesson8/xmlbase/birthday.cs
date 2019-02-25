using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlbase
{
    [Serializable]
    class birthday
    {
        public string Name { get; set; }
        public DateTime birth { get; set; }
                             
        public birthday()
        {
        }
        public birthday(string text, DateTime date)
        {
            this.Name = text;
            this.birth = date;
        }
        public override bool Equals(object obj)
        {
            return (this.Name.Equals((obj as birthday).Name) && this.birth.Equals((obj as birthday).birth));
        }
        public override string ToString()
        {
            return $"{Name} {birth.ToShortDateString()}";
        }

    }
}
