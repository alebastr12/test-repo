/*
Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в 
него передается массив слов и текст, в качестве результата метод возвращает сколько раз 
каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace message
{
    static class message
    {
        static public string[] noMoreLetter(string str, uint n)
        {
            string[] ret;
            MatchCollection matches = Regex.Matches(str, @"\w{1," + n + @"}");
            if (matches.Count == 0)
            {
                return null;
            } else
            {
                ret = new string[matches.Count];
            }
            int i = 0;
            foreach (Match item in matches)
            {
                ret[i] = item.Value;
                i++;
            }
            return ret;
        }
        static public string deletWord(string str, char c)
        {
            StringBuilder newStr = new StringBuilder(str);
            string pars = @"\b\w{0,}" + c + @"\b";
            MatchCollection matches = Regex.Matches(str, pars);
            for (int i = matches.Count; i !=0; i--)
            {
                newStr.Remove(matches[i-1].Index,matches[i-1].Length);
            }
            return newStr.ToString();
        }
        static public string longWord(string str)
        {
            MatchCollection matches = ToMatchesColl(str);
            Match max = matches[0];
            for (int i = 1; i < matches.Count; i++)
            {
                if (max.Length < matches[i].Length)
                {
                    max = matches[i];
                }
            }
            return max.Value;
        }
        static public string longWordString(string str, int minlength)
        {
            StringBuilder newStr = new StringBuilder(str);
            MatchCollection matches = ToMatchesColl(str);
            foreach (Match item in matches)
            {
                if (item.Length >= minlength) newStr.Append($"{item.Value} ");
            }
            return newStr.ToString();
        }
        static public Dictionary<string, int> freqWord(string str, params string[] words)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            MatchCollection matches = ToMatchesColl(str);
            foreach (var item in words)
            {
                dic.Add(item, 0);
            }
            foreach (Match item in matches)
            {
                if (dic.ContainsKey(item.Value)) dic[item.Value]++;
            }
            return dic;
        }
        static public string[] ToStringArray(string str)
        {
            string[] ret;
            MatchCollection matches = ToMatchesColl(str);
            if (matches.Count > 0)
            {
                ret = new string[matches.Count];
            }
            else return null;
            for (int i = 0; i < matches.Count; i++)
            {
                ret[i] = matches[i].Value;
            }
            return ret;
        }
        static public MatchCollection ToMatchesColl(string str)
        {
            string pars = @"\b\w+\b";
            MatchCollection matches = Regex.Matches(str, pars);
            return matches;
        }
    }
    
}
