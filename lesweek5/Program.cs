using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = " dit is een test";
            int lenght = tekst.Length;

            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine(tekst.Substring(i,1)); 
            }

            //reads word by word
            string[] woorden = tekst.Split(' ');
            foreach(var woord in woorden)
            {
                Console.WriteLine(woord);
            }

            //HOOFDLETTERS, kleine letters, spaties verwijderen
            Console.WriteLine(tekst.ToUpper());
            Console.WriteLine(tekst.ToLower());
            Console.WriteLine(tekst.Replace(" ",""));

            //Spaties na en voor worden verwijderd
            char[] spatie = { ' ' };
            Console.WriteLine(tekst.Trim(spatie));

            //oef wachtwoord
            string wachtwoord = "test";
            bool test1 = wachtwoord.Contains('b');
            Console.WriteLine(test1);
            bool test2 = wachtwoord.Contains('b');
            Console.WriteLine(test2);
            bool test3 = wachtwoord.Contains('t');

            if(wachtwoord == "text")
            {
                Console.WriteLine("het wachtwoord is gelijk aan test");
            }

            //string.Equals(wachtwoord, "test") ?  Console.WriteLine("het wachtwoord is gelijk aan test"):  Console.WriteLine("het wachtwoord is niet gelijk aan test");

            Random randomGetal = new Random();
            int getal1 = randomGetal.Next(0, 20);
            Console.WriteLine(getal1);
            int getal2 = randomGetal.Next(0, 20);
            Console.WriteLine(getal2);
            int getal3 = randomGetal.Next(0, 20);
            Console.WriteLine(getal3);

            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(randomGetal.Next(0, 20));
            }

            char[] chars = new char[0];
            chars[0] = ' ';
            chars[1] = 'G';
            //char aanroepen met behulp van integer waarde
            chars[2] = (char)78;
            //char aanroepen met behulp van unicode vh karakter
            chars[3] = '\u002E';
            chars[4] = 'f';
            chars[5] = 'a';
            chars[6] = 'i';
            chars[7] = (char)85;

            foreach(char c in chars)
            {
                Console.Write(c);
            }

            //oef broodjes
            char[] campis = { 'M' , 'A' , 'B'};
            //3 is aantal items/elementen die we willen in deze array
            string[] menu1 = new string[3];
            menu1[0] = "broodjes martini";
            menu1[1] = "broodjes boulet";
            menu1[2] = "broodjes kaas";

            foreach(var item in menu1)
            {
                Console.Write(item);
            }

            string[] menu2 = new string[] { "broodje scampi" , "broodje brie" , "broodje boulet"};
            foreach(var item in menu2)
            {
                Console.Write(item);
            }

            Console.WriteLine("for loop");

            for(int i = 0; i < menu2.Length; i++)
            {
                Console.WriteLine(menu2[i]);
            }

            string[,] menu3 = new string[,] { {"broodje scampi", "4"} , {"broodje brie" , "3"} , {"broodje boulet" , "2"}};
            foreach(var item in menu3)
            {
                Console.WriteLine(item);   
            }



        }
    }
}
