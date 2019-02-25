using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace xmlbase
{
    class XmlSaveLoad
    {
        /// <summary>
        /// Статический метод сериализации и сохранения в xml файл списка структур 
        /// </summary>
        /// <param name="fileName">Имя файла для сохранения</param>
        /// <param name="list">Список структур для сериализации</param>
        /// <returns>Возвращает true в случае успеха всех операций, false в случае ошибок</returns>
        public static bool Save(string fileName, List<Element> list)
        {
            bool res = false;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Element>));
            try
            {
                Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list);
                fStream.Close();
            }
            catch (System.Security.SecurityException e)
            {
                MessageBox.Show($"Нет прав на запись.",
                    "Недостаточно прав", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return res;
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show($"Возникла ошибка при сериализации структуры. {e.InnerException.Message}.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
                return res;
            }
            return true;
        }
        /// <summary>
        /// Статический метод загрузки и десериализации структуры из файла
        /// </summary>
        /// <param name="fileName">ссылка на имя файла</param>
        /// <returns>Экземпляр списка структур</returns>
        public static List<Element> Load(ref string fileName)
        {
            List<Element> list = new List<Element>();
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Element>));
            try
            {
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Element>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show($"Файл по умолчанию {fileName} не найден. Загрузите файл с данными или создайте новую базу.",
                    "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                list = new List<Element>();
                fileName = "";
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show($"Возникла ошибка при десериализации файла. {e.InnerException.Message}.",
                    "Ошибка файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                list = new List<Element>();
                fileName = "";
            }
            catch (Exception e) //Остальное
            {
                MessageBox.Show($"{e.Message}");
                list = new List<Element>();
                fileName = "";
            }
            return list;
        }
    }
}
