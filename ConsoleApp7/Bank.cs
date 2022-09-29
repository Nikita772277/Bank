using System;
using System.Collections.Generic;
using System.Linq;
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
        int[] score=new int[20];
        public Bank()
        {
            _contribution = 10000;
            _about = 5;
        }
        public void OpenScore() //открыть счёт
        {
            Random ran = new Random();
            for (int i=0; i< score.Length; i++)
            {
                score[i] = ran.Next(0,9);
            }
            foreach (int i in score)
            {
                Console.Write($"{i}"); //номер открытого счёта
            }
        }
        public void ReplenishScore() //пополнить счёт
        {

        }
        public void InformationScore() //посмотреть инф о счёте
        {
            Console.WriteLine($"номер счёта:");
            OpenScore();

        }
        public void CloseScore() //закрыть счёт
        {

        }
        public void WithdrawMoney() //снять деньги
        {

        }
        public void SummScore() //сумма через год
        {

        } 
    }
}
