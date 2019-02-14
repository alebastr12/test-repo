using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace examinebase
{
    struct learner
    {
        public string name;
        public float averScore;
        public override string ToString()
        {
            return string.Format($"{name, -20} ср. балл {averScore:f2}");
        }
    }
    /// <summary>
    /// Конструктор класса. Создается массив структур Фамилия Имя и средняя оценка. Данные парсятся из переданной строки.
    /// </summary>
    class exam
    {
        learner[] learnerList;

        public exam(string str)
        {
            Regex learnRegEx = new Regex(@"\w{1,20}\s\w{1,15}\s[1-5]\s[1-5]\s[1-5]");
            MatchCollection matches = learnRegEx.Matches(str); //Ищем строки по нужному шаблону
            if (matches.Count > 0)
                learnerList = new learner[matches.Count];
            else
            {
                throw new FormatException("Параметр str не содержит строк соответствующих шаблону - <Фамилия> <Имя> <оценки>.");
            }
            int i = 0;
            foreach (Match match in matches) //Перебираем результаты по строкам
            {
                learnerList[i].name = Regex.Match(match.Value, @"\w{1,20}\s\w{1,15}").Value; //Вычленяем из результатов Имя Фамилию
                MatchCollection matchesScore = Regex.Matches(match.Value, @"\d"); //Вычленяем цифры
                float sum = 0;
                foreach (Match matchScore in matchesScore) //проходимся по цифрам и суммируем их
                {
                    sum += uint.Parse(matchScore.Value);
                }
                learnerList[i].averScore = (float)sum / 3;
                i++;
            }
        }
        public int lenght
        {
            get
            {
                return learnerList.Length;
            }
        }
        //Этот метод, наверное, не нужен.
        //
        //void Add(string str, uint pos)
        //{
        //    Regex learnRegEx = new Regex(@"\w{1,20}\s\w{1,15}\s\d\s\d\s\d}");
        //    if (!learnRegEx.IsMatch(str))
        //    {
        //        throw new FormatException("Параметр str не соответствует шаблону - <Фамилия> <Имя> <оценки>.");
        //    }
        //    if (pos > (learnerList.Length - 1)){
        //        throw new IndexOutOfRangeException("Параметр pos не может быть применен к этому обекту.");
        //    }
        //    learnerList[pos].name = Regex.Match(str,@"\w{1,20}\s\w{1,15}").ToString();
        //    MatchCollection matches = Regex.Matches(str, @"\d");
        //    float sum = 0;
        //    foreach (Match match in matches)
        //    {
        //        sum += uint.Parse(match.Value);
        //    }
        //    sum = (float) sum / 3;
        //}
        public learner this[uint i] => learnerList[i];
        /// <summary>
        /// Метод сортировки массива по среднему баллу
        /// </summary>
        public void sort()
        {
            learner temp;
            for (int j = 0; j < learnerList.Length; j++)//метод пузырька
            {
                for (int i = 0; i < learnerList.Length - 1; i++)
                {
                    if (learnerList[i].averScore > learnerList[i + 1].averScore)
                    {
                        temp = learnerList[i + 1];
                        learnerList[i + 1] = learnerList[i];
                        learnerList[i] = temp;
                    }
                }
            }
        }
    }
}
