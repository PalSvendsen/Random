using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace variabeltilordning_demovideo
{
    internal class DataTyper
    {
        int tall = 1;

        float desimalTall = 1.01F; //nøyaktig
        double desimalTall2 = 1.01;
        decimal desimalTall3 = 1.01M; //Veldig nøyaktig

        char bokstav = 'a';
        string tekst = "Hei";

        bool santUsant = true; // eller False

        int[] tallArray = { 1, 2, 3 };
        string[] tekstArray = { "hei", "på", "deg" };

        List<int> listeMedTall = new List<int>(); //lager en ny liste med Tall. 

        public string ReturnString()
        {
            return tekst;
        }
        public int ReturnWholeNumber()
        {
            return tall;
        }
        public double ReturnDouble()
        {
            return 2.554154;
        }
        public bool TrueFalse()
        {
            return santUsant;
        }

        public void Run()
        {
            Console.WriteLine($"Dette er en string: {ReturnString()}");
            Console.WriteLine($"Dette er en int:{ReturnWholeNumber()}");
            Console.WriteLine($"Dette er en double:{ReturnDouble()}");
            Console.WriteLine($"Dette er en Boolean:{TrueFalse()}");
        }

    }

}
