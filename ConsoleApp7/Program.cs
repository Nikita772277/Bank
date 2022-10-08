using ConsoleApp7;
using System.Security.Cryptography;
void GetMenu()
{
    Console.WriteLine($"1. Открыть счёт");
    Console.WriteLine($"2. открыть");
    Console.WriteLine($"3. Посмотреть информацию о счёте");

}
void ControlMenu()
{
Bank bank = new Bank();
Human Human = new Human();
    while (true)
    {
    GetMenu();
    
        string n = Console.ReadLine();
        int a = int.Parse(n);
        if (a == 1)
        {
            bank.OpenScore();
        }
        else if (a == 2)
        {

        }
        else if (a == 3)
        {
            bank.InformationScore();
        }
        else if (a == 4)
        {

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