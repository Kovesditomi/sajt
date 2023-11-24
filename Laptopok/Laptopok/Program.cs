using System.Text;

namespace Laptopok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> laptops= new ();

            using (var sr = new StreamReader(@"..\..\..\src\laptopok.txt", Encoding.UTF8))
            { 

               _= sr.ReadLine();
                while(!sr.EndOfStream) laptops.Add(new Laptop(sr.ReadLine()));
                foreach(Laptop laptop in laptops) Console.WriteLine(laptop);
        
            }


            Console.WriteLine("11.feladat:");


            var fl10 = Bluetooth(laptops);
            Console.WriteLine("10.feladat");
            if()





            Console.WriteLine($"9. Feladat: Átlagos processzor sebessége:{AtlagProcSeb(laptops)}");




            var fl8 = Uzemido(laptops);


            Console.WriteLine("8.feladat");


            Console.WriteLine($"Ennek a laptopnak bírja a legkevesebb ideig az akksija:{fl8[0].AkksiElettartam},ez az a modell:{fl8.Count}");





            List <Laptop> fl7 =Win2kg(laptops);


            Console.WriteLine($"7. feladat");


            Console.WriteLine(fl7.Count > 0 ? $"Ennyi{fl7.Count} ilyen laptop van összesen:":"Nem található ilyen fajta laptop!") ;


        }
        static List<Laptop> Win2kg(List<Laptop> k) => k.Where(k => k.Oprendszer == "Windows" &&k.Suly>2).ToList();




        static List<Laptop> Uzemido(List<Laptop> k) => k.Where(k => k.AkksiElettartam <= 6).ToList();


        static double AtlagProcSeb(List<Laptop> k) => k.Average(k => k.ProcTipSeb);



        static List<Laptop> Bluetooth(List<Laptop> k) => k.Where(k => k.VezetekNelkuli == " Bluetooth 5.2"&&k.VezetekNelkuli==k.GYartoModell).ToList();

        static List<int> AMD(List<Laptop> k) => k.Where(k => k.ProcTipSeb.Countains("AMD" && k.Suly > 1, 3)ToList();

    }
}