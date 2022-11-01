using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class BankAccount<T> // Счет
    {
        private T Number { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }
        public string GetInfo() // Вывод информации о счете
        {
            return $"\nНомер счета: {Number} \nБаланс: {Balance} \nФИО: {Name}\n";
        }

        public void Input() // Ввод информации о счете
        {
            Console.WriteLine("Введите номер счета");
            string stringNumber = Console.ReadLine();
            Number = (T)Convert.ChangeType(stringNumber, typeof(T));

            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();

        }
    }
}
