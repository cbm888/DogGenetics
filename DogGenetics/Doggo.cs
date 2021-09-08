using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Doggo
    {
        string[] doggos = new string[] { "German Shepherd", "Yorkshire Terrier", "Golden Retriever", "Chihuahua", "Dalmation" };

        public void GetDoggoInfo()
        {
            Random random = new Random();
            const int max = 101;
            string userInput;
            int type1 = random.Next(max);
            int type2 = random.Next(max - type1);
            int type3 = random.Next(max - (type2 + type1));
            int type4 = random.Next(max - (type1 + type2 + type3));
            int type5 = random.Next(max - (type1 + type2 + type3 + type4));

            int[] dogPercents = new int[] { type1, type2, type3, type4, type5 };

            


            Console.WriteLine("Hello fellow dog lover! What is the name of your doggo? ");
            userInput = Console.ReadLine();
            Console.WriteLine("Sounds great! Well, if you don't mind, I have run some numbers of your pooch " + userInput + "in order to find out more about their genetic makeup.");
            Console.WriteLine("Your pooch " + userInput + " has the following genetic breakdown: ");
            Console.WriteLine(type1 + " % " + doggos[0]);
            Console.WriteLine(type2 + " % " + doggos[1]);
            Console.WriteLine(type3 + " % " + doggos[2]);
            Console.WriteLine(type4 + " % " + doggos[3]);
            Console.WriteLine(type5 + " % " + doggos[4]);

        }
    }
}
            






        


    

