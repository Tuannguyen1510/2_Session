using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._2_P1
{
    internal class Contact
    {
        private int id;
        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string adress;

        public Contact() { }

        public Contact(int id, string firstname, string lastname, string email, string phone, string adress)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.adress = adress;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }


        public void Display()
        {
            Console.WriteLine("information contact: id-{0}, firstname-{1}, lastname-{2}, adress-{3}, phone-{4}, email-{5}", Id,Firstname,Lastname,Adress,Phone,Email);
        }
    }
}
