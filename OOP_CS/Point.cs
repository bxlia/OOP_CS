using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point
    {
        double x;
        double y;
        /*
		private:
		public:
		protected:
		internal:
		protected internal:
		 */
        //Get/Set-методы
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        //Proprties (Свойства) - это синтаксическая конструкция, 
        //которая объединяет Get и Set метод для какой-то переменной в классе:
        //Свойства обычно называют так же как и переменную, но с бльшой буквы
        //(переменную называют с маленькой).
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        //				Methods:
        public void Print()
        {
            Console.WriteLine($"X = {x}\tY = {y}");
        }
    }
}
