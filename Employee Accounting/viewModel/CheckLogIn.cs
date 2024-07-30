using Employee_Accounting.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Employee_Accounting.viewModel
{
    public class CheckLogIn
    {
       

        public async void LogIn()
        {

            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            using (FileStream fs = new FileStream("PersonLogIn.json", FileMode.OpenOrCreate))
            {
                PersonLogIn? personLogIn = await JsonSerializer.DeserializeAsync<PersonLogIn>(fs);
                Console.WriteLine($"Name: {personLogIn?.FirstName}  Age: {personLogIn?.LastName}");
                string login1 = personLogIn?.Login;

                if (login == login1)
                {
                    Console.WriteLine("ddd");

                }
                else
                {
                    Console.WriteLine("fff");
                }
            }

            


        }

    }
}
