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
        public Sobaka()
        {
            this.klichka = "Now name";
            this.poroda = "";
            this.vozrast = 0;

        }
        public Sobaka(string Klichka, string Poroda, float Vozrast)
        {
            this.klichka = Klichka;
            this.poroda = Poroda;
            this.vozrast = Vozrast;
        }
    }
    
}

