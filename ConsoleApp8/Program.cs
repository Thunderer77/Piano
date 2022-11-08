using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Пианино!\nВыберите октаву:\nF1(2 окт)\nF2(3 окт)\nF3(4 окт)\nF4(5 окт)\n " +
               "F5(6 окт)\nESC - для выхода из программы.");
            Console.WriteLine("До - A\nДо# - W\nРе - S\nРе# - E\nМи - D\nФа - F\nФа# - T\nСоль - G\nСоль# - Y\nЛя - H\nЛя# - U\nСи - J");
            ConsoleKey key = Console.ReadKey().Key;
            while (key != ConsoleKey.Escape)
            {
                switch(key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("2 окт");
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("3 окт");
                         break;
                    case ConsoleKey.F3:
                        Console.WriteLine("4 окт");
                         break;
                    case ConsoleKey.F4:
                        Console.WriteLine("5 окт");
                         break;
                    case ConsoleKey.F5:
                        Console.WriteLine("6 окт");
                         break;
                    default: Console.WriteLine("Выберете октаву заново"); key = Console.ReadKey().Key; break;



                }
                static ConsoleKey o(int okt)
                {
                    ConsoleKey a1 = Console.ReadKey().Key;
                    while (a1 != ConsoleKey.F1 && a1 != ConsoleKey.F2 && a1 != ConsoleKey.F3 && a1 != ConsoleKey.F4 && a1 != ConsoleKey.F5 && a1 != ConsoleKey.Escape)
                    {
                        int result;
                        switch (a1)
                        {
                            case ConsoleKey.A:
                                result = Notes(okt, 0); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.S:
                                result = Notes(okt, 2); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.D:
                                result = Notes(okt, 4); Console.Clear();
                                Console.Beep(result, 200); 
                                break;
                            case ConsoleKey.F:
                                result = Notes(okt, 5); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.G:
                                result = Notes(okt, 7); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.H:
                                result = Notes(okt, 9); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.J:
                                result = Notes(okt, 11); Console.Clear();
                                Console.Beep(result, 200);
                                break;

                            case ConsoleKey.W:
                                result = Notes(okt, 1); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.E:
                                result = Notes(okt, 3); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.T:
                                result = Notes(okt, 6); Console.Clear();
                                Console.Beep(result, 200); 
                                break;
                            case ConsoleKey.Y:
                                result = Notes(okt, 8); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            case ConsoleKey.U:
                                result = Notes(okt, 10); Console.Clear();
                                Console.Beep(result, 200);
                                break;
                            default:
                                break;
                        }
                        a1 = Console.ReadKey().Key;
                    }
                    return a1;
                }

                static int Notes(int a, int b)
                {
                    int[,] game = new int[,] { { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123}, { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246},
        { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 }, {523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987,}
        , { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976} };
                    return game[a, b];
                }
            }
    




            }
        
        }
    }
