using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Bank
    {
        private string _name; // название банка
        private decimal _moneyintheaccount;//денег на счёте
        private int _contribution;//мин взнос
        private int _about;//процент по вкладу
        private int[] _score = new int[20];//номер счёта
        private bool _checscore = false;
        public Bank()
        {
            _contribution = 10000;
            _about = 5;
        }
        public void OpenScore(Human human) //открыть счёт
        {
            if (_checscore == false)
            {
                Console.Write($"Денег с собой: ");
                string a = Console.ReadLine();
                decimal amountmoney = decimal.Parse(a);
                human.SetMoney(amountmoney);
                if (human.GetAmounMoney(human) > _contribution)
                {
                    human.SetName();
                    Random ran = new Random();
                    for (int i = 0; i < _score.Length; i++)
                    {
                        _score[i] = ran.Next(0, 9);
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Счёт открыт");
                    _moneyintheaccount = _moneyintheaccount + _contribution;
                    human.CalculationOfFunds(human);
                    GetScore(human);
                    _checscore = true;

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Недостаточно средств для открытия счёта");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Счёт уже открыт");
            }
        }
        public void GetScore(Human human)//выовд номера счёта
        {

            if (_checscore = true)
            {
                Console.Write($"Номер счёта: ");
                foreach (int i in _score)
                {
                    Console.Write($"{i}"); //номер открытого счёта
                }
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void ReplenishScore(Human human) //пополнить счёт
        {
            if (_checscore == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Введите сумму пополнения");
                string moneyccount = Console.ReadLine();
                decimal moneyintheaccount = Convert.ToDecimal(moneyccount);
                _moneyintheaccount = _moneyintheaccount + moneyintheaccount;
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void InformationScore(Human human) //посмотреть инф о счёте
        {
            if (_checscore == true)
            {
                human.GetName(human);//имя владельца счёта
                GetScore(human);//номер счёта
                Console.WriteLine($"Денег на счёте: {_moneyintheaccount}");
                Console.WriteLine($"Процент по вкладу: {_about}");
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void WithdrawMoney(Human human) //снять деньги
        {
            if (_checscore == true)
            {
                Console.Write($"Сколько снять: ");
                string mone = Console.ReadLine();
                decimal money = decimal.Parse(mone);

                if (_moneyintheaccount >= money)
                {
                    _moneyintheaccount = _moneyintheaccount - money;
                    human.WithdrawalOfMoney(money, human);
                    Console.WriteLine($"Деньги сняты");
                    Console.WriteLine($"На счёте осталось: {_moneyintheaccount}");
                }
                else if (_moneyintheaccount < money)
                {
                    Console.WriteLine($"На счёте недостаточно средств");
                }
                else
                {
                    Console.WriteLine($"Непредвиденная ошибка");
                }
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void TopUpAccount(Human human)//Внести деньги
        {
            if (_checscore == true)
            {
                Console.Write($"Сколько внести: ");
                string mone = Console.ReadLine();
                decimal money = decimal.Parse(mone);

                if (money <= human.GetAmounMoney(human))
                {
                    _moneyintheaccount = _moneyintheaccount + money;
                    human.EnteringMoney(money, human);
                    Console.WriteLine($"Деньги внесены");
                    Console.WriteLine();
                    Console.WriteLine($"Денег на счёте: {_moneyintheaccount}");
                    Console.WriteLine();
                }
                else if (_moneyintheaccount > money)
                {
                    Console.WriteLine($"На счёте недостаточно средств");
                }
                else
                {
                    Console.WriteLine($"Непредвиденная ошибка");
                }
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void SummScore(Human human) //сумма через год
        {
            if (_checscore == true)
            {
                decimal moneymonth = _moneyintheaccount * _about / 100;
                decimal ayearlater = _moneyintheaccount + moneymonth * 12;
                Console.WriteLine();
                Console.WriteLine($"Через год {ayearlater}");
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public void DeleteScore(Human human)//закрыть счёт
        {
            if (_checscore == true)
            {
                Console.WriteLine($"Вы уверены 1.да 2.нет");
                string a = Console.ReadLine();
                bool s = int.TryParse(a, out var b);
                if (b == 1)
                {
                    _checscore = false;
                }
                else if (b == 2)
                {
                    Console.WriteLine();
                }
            }
            else
            {

                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
        }
        public int MinContribution(Human human)
        {
            return _contribution;
        }
    }
}
