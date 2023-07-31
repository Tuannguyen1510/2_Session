using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._3_P1
{
    internal class StudentModel
    {
        List<student> lstStudent;

        public StudentModel()
        {
            this.lstStudent = new List<student> {
            new student() { Id = 1, Name="A" , Age=10},
            new student() { Id = 2, Name = "B", Age = 11 },
            new student() { Id = 3, Name = "C", Age = 12 },
            new student() { Id = 4, Name = "D", Age = 13 },
            new student() { Id = 5, Name = "E", Age = 14 }
            };
        }

        public List<student> GetStudent()
        {
            return lstStudent;
        }
        // Trả siv theo id 

        public student GetStudent(int id)
        {
            student st = null;
            foreach(var item in lstStudent)
            {
                if ((item.Id == id))
                {

                    st = item;
                }
            }
            return st;
        }

        // student x -> y
        public List<student> GetStudent(int x , int y)
        {
            List<student> result = new List<student>();
            foreach(var item in lstStudent)
            {
                if(item.Age >= x && item.Age <= y)
                {
                    result.Add(item);
                }
            }
            return result;
        }



    }
}
