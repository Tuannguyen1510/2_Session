using Lab03._2_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        Contact contact = new Contact();
        contact.Id = 1;
        contact.Firstname = "Nguyễn";
        contact.Lastname = "hải";
        contact.Adress = "Hà Nội";
        contact.Phone = "012334";
        contact.Email = "a@gmail.com";
        contact.Display();
        contact.Id = 2;
        contact.Firstname = "Nguyễn";
        contact.Lastname = "hải";
        contact.Adress = "Hà Nội";
        contact.Phone = "01233456789";
        contact.Email = "b@gmail.com";
        contact.Display();

    }
}