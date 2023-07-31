using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._1_P1
{
    internal class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;



        public void Start()
        {
            Console.WriteLine("Khởi động");
        }
        public void Stop()
        {
            Console.WriteLine("Dừng");
        }
        public void Input()
        {
            Console.WriteLine("Information car: make-{0}, model-{1}, color-{2}, year-{3}", make, model, color, year);
        }
    }
}
