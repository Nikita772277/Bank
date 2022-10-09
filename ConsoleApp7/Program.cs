using ConsoleApp7;
using System.Security.Cryptography;
void GetMenu()
{
    Console.WriteLine($"1. Открыть счёт");
    Console.WriteLine($"2. Удалить номер счёта");
    Console.WriteLine($"3. Посмотреть информацию о счёте");
    Console.WriteLine($"4. Сумма на счёте через год");
    Console.WriteLine($"5. Денег с собой");
    Console.WriteLine($"6. Снять деньги");
}
void ControlMenu()
{
Bank bank = new Bank();
Human human = new Human();
    while (true)
    {
    GetMenu();
        Console.WriteLine();
        string n = Console.ReadLine();
        Console.WriteLine();
        int a = int.Parse(n);
        if (a == 1)
        {
            bank.OpenScore();
        }
        else if (a == 2)
        {
            human.DeleteNumberContribution();//не понемаю как удалить номер счёта
        }
        else if (a == 3)
        {
            bank.InformationScore();//не выводит имя
        }
        else if (a == 4)
        {
            bank.SummScore();
        }
        else if (a == 5)
        {
            human.GetMoney();//ошибка выводится 0
        }
        else if (a == 6)
        {
            bank.WithdrawMoney();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"введите команду из списка");
            Console.WriteLine();
        }
        //switch (a)
        //{
        //    case 1:
        //       // return bank.OpenScore;
        //        break;
        //    case 2:

        //        break;
        //    case 3:

        //        break;
        //    case 4:
        //        break;

        //}
    }
}
//bank.InformationScore();
//Console.WriteLine("\t");
//Human.GetMoney();
ControlMenu();