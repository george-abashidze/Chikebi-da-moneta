using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chikebi_da_moneta
{
    public class Game
    {
        //ჭიქების რაოდენობა
        public int glasses;

        //ცდების რაოდენობა
        public int steps;

        //რომელ ჭიქაშია მონეტა (ინდექსი)
        public int indexOfCoin;

        //ყოველ ცდაზე შეცვალსო თუარა არჩეული ჭიქა ბოლოში
        public bool alwaysChangeSelectedGlassAtEnd;

        //ყოველ ცდაზე random -ად აირჩიოს ჭიქა თუ არა
        public bool randomSelection;

        //თუ randomSelection false ა მაშინ ყოველ ცდაზე ამ კონკრეტულ ჭიქას აირჩევს
        public int selectedGlass;

        //ბოლო ჭიქა რომელიც დარჩება არჩეულთან ერთად
        public int lastGlassIndex;


        public int succesCount;
        public int failCount;

        public Random rnd = new Random();

 
        public void Play() {

            succesCount = 0;
            failCount = 0;

            for (int i = 0; i < steps; i++)
            {

                //random ინდექსი თუ რომელ ჭიქაში იყოს მონეტა 
                indexOfCoin = rnd.Next(1, glasses + 1);

                //თუ random-ად კომპიუტერმა უნდა აირჩიოს რომელი ჭიქა უნდა
                if (randomSelection)
                {
                    selectedGlass = rnd.Next(1,glasses + 1);
                }

                //თუ თავიდან არჩეული ჭიქაშია მონეტა დავტოვოთ არჩეული ჭიქა და +- 1 ით ახლო ჭიქა
                if (indexOfCoin == selectedGlass)
                {
                    lastGlassIndex = selectedGlass == glasses ? glasses - 1 : selectedGlass + 1;
                }
                //თუარადა არჩეულ ჭიქასთან ერთად უნდა დავტოვოთ ჭიქა რომელშიც მონეტაა
                else
                {
                    lastGlassIndex = indexOfCoin;
                }

                Console.WriteLine("");
                Console.WriteLine($" ---------- Cda:{i + 1} ------------------");
                Console.WriteLine($"Moneta aris me {indexOfCoin}-e chikashi.");
                Console.WriteLine($"Tavidan Archeuli chikis nomeria: {selectedGlass}");
                Console.WriteLine($"Darcha 2 cali chika: {selectedGlass}  da {lastGlassIndex}");

                //თუ ბოლოში ვცვლით არჩეულ ჭიქას მეორე დარჩენილზე
                if (alwaysChangeSelectedGlassAtEnd)
                {
                    selectedGlass = lastGlassIndex;
                    Console.WriteLine($"Shecvala Archeuli chika me {selectedGlass}-e chikit");
                }



                if (indexOfCoin == selectedGlass)
                    succesCount++;
                else
                    failCount++;

            }
            Console.WriteLine("");
            Console.WriteLine($"Success Count: {succesCount}");
            Console.WriteLine($"Fail Count: {failCount}");
        }
    }
}
