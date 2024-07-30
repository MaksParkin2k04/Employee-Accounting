using Employee_Accounting.model;
using Employee_Accounting.viewModel;
using System.Data;
using System.Text.Json;

namespace Employee_Accounting
{
    public class Program
    {

        static void Main(string[] args)
        {
            MainHello();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                switch (keyinfo.Key)
                {
                    case ConsoleKey.D1:
                       Console.Clear();
                        LogIn();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Registration();
                        break;
                }
            } while (true);
        }

        static void MainHello()
        {

            Console.WriteLine("Приветствуем в информационной системе по учету сотрудников\n");
            Console.WriteLine("Выберите действие: \n");
            Console.WriteLine("1. Войти в систему \n" +
                              "2. Регистрация(для новых пользователей) \n" +
                              "3. Узнать больше \n");

        }

        static void LogIn()
        {
            Console.WriteLine("Вход в систему");

            CheckLogIn checkLogIn = new CheckLogIn();
            checkLogIn.LogIn();

        }
        static void Registration()
        {   
            Console.WriteLine("Регистрация в системе");
            Console.WriteLine("Введите свои данные \n");

            MainRegistration mainRegistration = new MainRegistration();
            mainRegistration.InputLogIn();


        }
    }
}
























        


