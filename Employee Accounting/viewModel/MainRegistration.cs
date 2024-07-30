using Employee_Accounting.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Employee_Accounting.viewModel
{
    public class MainRegistration
    {

        public  async void InputLogIn()
        {
            Console.WriteLine("Введите ваше имя: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Придумайте логин для входа: ");
            string login = Console.ReadLine();
            Console.WriteLine("Придумайте пароль для входа: ");
            string password = Console.ReadLine();

            string role = Console.ReadLine();

            PersonLogIn personLogIn = new PersonLogIn(Guid.NewGuid(), firstName, lastName, login, password, role);

            using (FileStream fs = new FileStream("PersonLogIn.json", FileMode.OpenOrCreate))
            {

                await JsonSerializer.SerializeAsync<PersonLogIn>(fs, personLogIn);
                Console.WriteLine("Data has been saved to file");
            }

        }
    }
}
