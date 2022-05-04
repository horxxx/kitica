using ConsoleApp1;
using System;

namespace Simple
{

    class Program
    {


        static void Main(string[] args)
        {
            List<User> _userList = new List<User>();
            Console.Write("\nUnesite broj korisnika: ");
            int b = int.Parse(Console.ReadLine());
            float c = 0;
            float avg = 0;
            for (int i = 0; i < b; i++)
            {
                Console.Write("Ime: ");
                string ime = Console.ReadLine();

                Console.Write("Prezime: ");
                string prezime = Console.ReadLine();

                Console.Write("Visina: ");
                float visina = float.Parse(Console.ReadLine());

                Console.Write("Tezina: ");
                float tezina = float.Parse(Console.ReadLine());

                User user = new User(ime, prezime, visina, tezina);
                _userList.Add(user);
            }
            foreach (User u in _userList)
            {
                c += u.Visina;
                avg = c / b;
            }
            Console.WriteLine(avg);
        }
    }
}