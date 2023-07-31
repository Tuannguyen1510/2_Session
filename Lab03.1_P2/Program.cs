using Lab03._1_P2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> lstEmployees = new List<Employee>();

        Console.WriteLine("Nhap so nhan vien: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thông tin nhan vien");
        for(int i =1; i<= n; i++)
        {
            Console.WriteLine("Nhap thông tin nhan vien {0}", i);
            Employee employee = new Employee();
            employee.Input();
            lstEmployees.Add(employee);
        }
        // dislpay
        foreach(Employee employee in lstEmployees)
        {
            employee.Display();
        }
    }
}