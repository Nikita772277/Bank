using ConsoleApp7;

Bank bank = new  Bank();
Human Human=new Human();
void GetMenu()
{
    Console.WriteLine($"1. Открыть счёт");
    Console.WriteLine($"2. открыть");
    Console.WriteLine($"3. открыть счёт");

}
void ControlMenu()
{
    while (true)
    {
        string n = Console.ReadLine();
        int a=int.Parse(n);
        switch (a)
        {
            case 1:
               // return bank.OpenScore;
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
                break;

        }
    }
}
bank.InformationScore();
Console.WriteLine("\t");
Human.GetMoney();