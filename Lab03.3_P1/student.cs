using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._3_P1
{
    internal class student
    {
        // thuộc tính tự động 

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Phương thức 
        public void Display()
        {
            Console.WriteLine("Information student: id-{0}, name-{1}, age-{2}", Id, Name, Age);
        }

    }
}
