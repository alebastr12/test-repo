using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    /// <summary>
    /// Класс для работы с дробями
    /// </summary>
    class fraction
    {

        int num;
        int denom;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Denom
        {
            get { return denom; }
            set { if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
            }
        }
        public fraction(int num, int denom)
        {
            this.Num = num;
            this.Denom = denom;
        }
        /// <summary>
        /// Статический метод для умножения дробей, возвращиет новый объект
        /// </summary>
        /// <param name="a">первая дробь</param>
        /// <param name="b">вторая дробь</param>
        /// <returns>возвращает результат, экземпляр класса fracion</returns>
        static fraction mult(fraction a, fraction b)
        {
            return new fraction(a.num*b.num,a.denom*b.denom);
        }
        /// <summary>
        /// Статический метод для приведение двух дробей к общему знаменатею
        /// </summary>
        /// <param name="a">первая дробь</param>
        /// <param name="b">вторая дробь</param>
        static void comDenom(fraction a, fraction b)
        {
            a.num *= b.denom;
            b.num *= a.denom;
            a.denom = b.denom = a.denom * b.denom;
        }
        /// <summary>
        /// Сатический метод сложения двух дробей
        /// </summary>
        /// <param name="a">первая дробь</param>
        /// <param name="b">вторая дробь</param>
        /// <returns>Возвращает сумму в виде нового объекта</returns>
        static fraction sum(fraction a, fraction b)
        {
            if (a.denom != b.denom)
            {
                fraction aCom = new fraction(a.num, a.denom);
                fraction bCom = new fraction(b.num, b.denom);
                comDenom(aCom, bCom);
                aCom.Num += bCom.Num;
                return aCom;
            } else
            {
                return new fraction(a.num + b.num, a.denom);
            }

        }
        /// <summary>
        /// Статический метод вычитания из дроби a дроби b
        /// </summary>
        /// <param name="a">дробь a</param>
        /// <param name="b">дробь b</param>
        /// <returns>возвращает разницу в объекте fraction</returns>
        static fraction sub(fraction a, fraction b)
        {
            if (a.denom != b.denom)
            {
                fraction aCom = new fraction(a.num, a.denom);
                fraction bCom = new fraction(b.num, b.denom);
                comDenom(aCom, bCom);
                aCom.Num -= bCom.Num;
                return aCom;
            } else
            {
                return new fraction(a.num-b.num,a.denom);
            }
        }
        /// <summary>
        /// Статический метод деления двух дробей
        /// </summary>
        /// <param name="divisor">Делимое</param>
        /// <param name="divisible">Делитель</param>
        /// <returns>Возвращает результат в объекте fraction</returns>
        static fraction div(fraction divisor, fraction divisible)
        {
            return new fraction(divisor.num * divisible.denom, divisor.denom * divisible.num);
        }
        /// <summary>
        /// Метод сложения с дробью. Не изменяет объект.
        /// </summary>
        /// <param name="a">слагаемое</param>
        /// <returns>Возвращает сумму в новом объекте</returns>
        public fraction sum(fraction a)
        {
            if (a.denom != this.denom)
            {
                fraction aCom = new fraction(a.num, a.denom);
                fraction bCom = Copy();
                comDenom(aCom, bCom);
                aCom.Num += bCom.Num;
                return aCom;
            } else
            {
                return new fraction(a.num + this.num, a.denom);
            }
        }
        /// <summary>
        /// Метод вычитания из объекта
        /// </summary>
        /// <param name="b">вычитанмое</param>
        /// <returns>возвращает разницу в объекте fraction</returns>
        public fraction sub(fraction b)
        {
            if (this.denom != b.denom)
            {
                fraction aCom = Copy();
                fraction bCom = new fraction(b.num, b.denom);
                comDenom(aCom, bCom);
                aCom.Num -= bCom.Num;
                return aCom;
            }
            else
            {
                return new fraction(this.num - b.num, this.denom);
            }
        }
        /// <summary>
        /// Метод для приведения к общему знаменателю
        /// </summary>
        /// <param name="a">дробь</param>
        public void comDenom(fraction a)
        {
            a.num *= this.denom;
            this.num *= a.denom;
            a.denom = this.denom = a.denom * this.denom;
        }
        /// <summary>
        /// Умножение на дробь
        /// </summary>
        /// <param name="a">множитель</param>
        public fraction mult(fraction a)
        {
            fraction rez = new fraction(a.Num, a.Denom);
            rez.num = this.num * a.num;
            rez.denom = this.denom * a.denom;
            return rez;
        }

        public override string ToString()
        {
            return string.Format($"{num}/{denom}");
        }

        public fraction Copy()
        {
            return new fraction(this.num, this.denom);
        }

        public override bool Equals(object obj)
        {
            fraction objFr = (fraction)obj;
            return (objFr.num==this.num&&objFr.denom==this.denom);
        }

    }
}
