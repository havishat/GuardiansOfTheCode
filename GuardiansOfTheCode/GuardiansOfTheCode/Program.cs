using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            PrimaryPlayer player = PrimaryPlayer.Instance;
            PrimaryPlayer player2 = PrimaryPlayer.Instance2;
            Console.WriteLine($"{player.Name} -lvl {player.Level}");
            Console.WriteLine($"{player2.Name} -lv2 {player2.Level}");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
            

        }
    }
}
