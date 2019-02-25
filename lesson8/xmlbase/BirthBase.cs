using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace xmlbase
{
    class BirthBase : IList //С этим элементом так и несмог заставить
    {
        string fileName;
        public List<birthday> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public BirthBase(string fileName)
        {
            this.fileName = fileName;
            list = new List<birthday>();
        }
        public void Add(string text, DateTime date)
        {
            list.Add(new birthday(text, date));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public birthday this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<birthday>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<birthday>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<birthday>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        
        public int Add(object value)
        {
            if (value != null)
            {
                list.Add((birthday)value);
                return list.Count;
            }
            else return -1;
        }

        public bool Contains(object value)
        {
            bool res = false;
            foreach (var item in list)
            {
                res = item.Equals(value as birthday);
                if (res) break;
            }
            return res;
        }

        public void Clear()
        {
            list.Clear();
        }

        public int IndexOf(object value)
        {
            int ret = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(value as birthday))
                    return i;
            }
            return ret;
        }

        public void Insert(int index, object value)
        {
            list.Insert(index, (value as birthday));
        }

        public void Remove(object value)
        {
            list.Remove(value as birthday);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            list.CopyTo((array as birthday[]), index);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly => false;

        public bool IsFixedSize => false;

        public object SyncRoot => this;

        public bool IsSynchronized => true;

        object IList.this[int index] { get => list[index]; set => list[index]=(value as birthday); }
    }

}

