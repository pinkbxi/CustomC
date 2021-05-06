using System;

namespace CustomC
{
    abstract class CustomC
    {
            /// <summary>
            /// Prints Text With Your Selected Color
            /// </summary>
            /// <param name="Input"></param>
            /// <param name="Color"></param>
            public static void Print(string Input, ConsoleColor Color)
            {
                Console.ForegroundColor = Color;
                Console.WriteLine(Input);
                Console.ForegroundColor = ConsoleColor.White;
            }
            /// <summary>
            /// Prints Text
            /// </summary>
            /// <param name="Input"></param>
            public static void Print(string Input)
            {
                Console.WriteLine(Input);
            }
            /// <summary>
            /// Masks The Given Text And Prints It With Selected Color
            /// </summary>
            /// <param name="Input"></param>
            /// <param name="Color"></param>
            public static void Mask(string Input, ConsoleColor Color)
            {
                Console.ForegroundColor = Color;
                Console.WriteLine(Input.GetHashCode());
                Console.ForegroundColor = ConsoleColor.White;
            }
            /// <summary>
            /// Masks The Given Text
            /// </summary>
            /// <param name="Input"></param>
            public static void Mask(string Input)
            {
                Console.WriteLine(Input.GetHashCode());
            }
            /// <summary>
            /// Prints Reversed String With Color
            /// </summary>
            /// <param name="Input"></param>
            /// <param name="Color"></param>
            public static void Reversed(string Input, ConsoleColor Color)
            {
                Char[] inp = Input.ToCharArray();
                for (int a = inp.Length - 1; a >= 0; a--)
                {
                    Console.ForegroundColor = Color;
                    Console.Write(inp[a]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            /// <summary>
            /// Prints Reversed String
            /// </summary>
            /// <param name="Input"></param>
            public static void Reversed(string Input)
            {
                Char[] inp = Input.ToCharArray();
                for (int a = inp.Length - 1; a >= 0; a--)
                {
                    Console.Write(inp[a]);
                }
            }
            /// <summary>
            /// Does Not Close Console Until Any Button Is Pressed
            /// </summary>
            public static void Wait()
            {
                Console.Read();
            }
    }
}
