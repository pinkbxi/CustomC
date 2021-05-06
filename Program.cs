using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomC
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomC Preview
            CustomC.Mask("This Funcion Masks The Text In Hash", ConsoleColor.Green);         //Also You Can Select Any Color You Want To Be Your Texts Color
            CustomC.Print("This Funcion Prints Text", ConsoleColor.Red);                     //Also You Can Select Any Color You Want To Be Your Texts Color
            CustomC.Reversed("This Funcion Reverses Text Thats Given", ConsoleColor.Yellow); //Also You Can Select Any Color You Want To Be Your Texts Color
            CustomC.Wait();                                                                  //Does Not Let Console To Close Until Button Is Pressed
        }
    }
}
