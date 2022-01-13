using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа перевода значений угла из градусов в радианы");
            Console.Write("Введите значение в градусах ");
            int grad1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение в минутах ");
            int min1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение в секундах ");
            int sec1 = Convert.ToInt32(Console.ReadLine());
            Angle angl = new Angle(grad1, min1, sec1);
            angl.ToRadians();
            Console.WriteLine("Градусы={0}grad {1}min {2}sec",angl.Gradus,angl.Min,angl.Sec);
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value>=0 && value<=360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение в градусах");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение в минутах");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Неверное значение в секундах");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus=0, int min=0, int sec=0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadians()
        {
            double Radian = 0;
            Radian = Convert.ToDouble(gradus)+((Convert.ToDouble(min) + Convert.ToDouble(sec) / 60)/60);
            Console.WriteLine("Значение в радианах={0,8:f10}",Radian);
        }
    }
}
