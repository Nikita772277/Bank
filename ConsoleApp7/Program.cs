using ConsoleApp7;
using System.Security.Cryptography;
using System.Security.Principal;

void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1. Открыть счёт");
    Console.WriteLine($"2. Закрыть счёт");
    Console.WriteLine($"3. Посмотреть информацию о счёте");
    Console.WriteLine($"4. Сумма на счёте через год");
    Console.WriteLine($"5. Денег с собой");
    Console.WriteLine($"6. Снять деньги");
    Console.WriteLine($"7. Пополнить банковский счёт");
    Console.WriteLine();
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
        bool a = int.TryParse(n, out var s);
        if (s == 1)
        {
            bank.OpenScore(human);
        }
        else if (s == 2)
        {
            human.DeleteNumberContribution(human);
        }
        else if (s == 3)
        {
            bank.InformationScore(human);
        }
        else if (s == 4)
        {
            bank.SummScore(human);
        }
        else if (s == 5)
        {
            human.GetMoney(human);
        }
        else if (s == 6)
        {
            bank.WithdrawMoney(human);
        }
        else if (s == 7)
        {
            bank.TopUpAccount(human);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"введите команду из списка");
            Console.WriteLine();
        }

    }
}

ControlMenu();