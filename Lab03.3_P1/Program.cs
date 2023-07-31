using Lab03._3_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentModel student = new StudentModel();

        List<student> lstAll = student.GetStudent();

        // display

        foreach(var item in lstAll)
        {
            item.Display();
        }
        // theo id 
        Console.WriteLine("-------Lay hs theo id-----");
        student st = student.GetStudent(2);
        st.Display();
        // tuổi 
        Console.WriteLine("-------Lay hs theo tuổi-----");
        List<student> lstAge = student.GetStudent(10, 12);

        foreach(student item in lstAge)
        {
            item.Display();
        }

    }
}