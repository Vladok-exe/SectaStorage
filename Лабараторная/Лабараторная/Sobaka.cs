using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабараторная
{
    class Sobaka
    {
        private string klichka { get; set; }
        private string poroda { get; set; }
        private float vozrast { get; set; }
        public void vivod()
        {
            Console.WriteLine("Кличка:" + klichka + " " + "Порода:" + poroda + " " + "Возраст:" + vozrast + " ");
        }
        public void write()
        {
            Console.WriteLine("Требуется ввести кличку собаки: ");
            klichka = Console.ReadLine();
            Console.WriteLine("Требуется ввести породу собаки: ");
            poroda = Console.ReadLine();
            Console.WriteLine("Требуется ввести возраст собаки: ");
            vozrast = int.Parse(Console.ReadLine());
        }
    }
}
