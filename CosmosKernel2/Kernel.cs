//using Cosmos.System.Graphics;
using System;
//using System.Drawing;
using Sys = Cosmos.System;

namespace CosmosKernel2
{
    public class Kernel : Sys.Kernel
    {
        //Canvas canvas;

        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bohemia Baslatiliyor...");
            //canvas = FullScreenCanvas.GetFullScreenCanvas();
            //canvas.Clear(Color.Blue);
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            var input2 = "";
            Console.Beep();
            //Console.Write("Text typed: ");
            //Console.WriteLine(input);
            if (input == "kutla")
            {
                Fonk.Kutla();
            }
            if (input == "echo")
            {
                Console.WriteLine("What would you like to write? \n");
                input2 = Console.ReadLine();
                Fonk.echo(input2);
            }
            if (input == "calc")
            {
                hesap();
            }

            //try
            //{
            //    /* A red Point */
            //    Pen pen = new Pen(Color.Red);
            //    canvas.DrawPoint(pen, 69, 69);

            //    /* A GreenYellow horizontal line */
            //    pen.Color = Color.GreenYellow;
            //    canvas.DrawLine(pen, 250, 100, 400, 100);

            //    /* An IndianRed vertical line */
            //    pen.Color = Color.IndianRed;
            //    canvas.DrawLine(pen, 350, 150, 350, 250);

            //    /* A MintCream diagonal line */
            //    pen.Color = Color.MintCream;
            //    canvas.DrawLine(pen, 250, 150, 400, 250);

            //    /* A PaleVioletRed rectangle */
            //    pen.Color = Color.PaleVioletRed;
            //    canvas.DrawRectangle(pen, 350, 350, 80, 60);

            //    Console.ReadKey();

            //    /* Let's try to change mode...*/
            //    canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);

            //    /* A LimeGreen rectangle */
            //    pen.Color = Color.LimeGreen;
            //    canvas.DrawRectangle(pen, 450, 450, 80, 60);

            //    Console.ReadKey();

            //    Stop();
            //}
            //catch (Exception e)
            //{
            //    mDebugger.Send("Exception occurred: " + e.Message);
            //    mDebugger.Send(e.Message);
            //    Stop();
            //}
         }
        int hesap()
        {
            Calc clc = new Calc();
            Console.WriteLine("Lutfen isleminizi seciniz:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cikarma");
            Console.WriteLine("3 - Carpma");
            Console.WriteLine("4 - Bolme");
            Console.WriteLine("0 - cikis");
            string secim = Console.ReadLine().Trim();
            int sec1;
            if (int.TryParse(secim, out sec1))
            {
                if (sec1 == 0)
                {
                    return 0;
                }
                float sayi1 = 0.0F;
                float sayi2 = 0.0F;
                Console.WriteLine("Lutfen birinci sayiyi giriniz:");
                string s1 = Console.ReadLine().Trim();
                if (float.TryParse(s1, out sayi1))
                {
                    Console.WriteLine("Lutfen ikinci sayiyi giriniz:");
                    string s2 = Console.ReadLine().Trim();
                    if (float.TryParse(s2, out sayi2))
                    {
                        switch (sec1)
                        {
                            case 0:
                                return 0;
                            case 1:
                                Console.WriteLine(clc.Topla(sayi1, sayi2));
                                break;
                            case 2:
                                Console.WriteLine(clc.Cikar(sayi1, sayi2));
                                break;
                            case 3:
                                Console.WriteLine(clc.Carp(sayi1, sayi2));
                                break;
                            case 4:
                                if (sayi2 != 0)
                                {
                                    Console.WriteLine(clc.Bol(sayi1, sayi2));
                                }
                                else
                                {
                                    Console.WriteLine("Sifira bolme hatasi!!");
                                }
                                break;

                            default:
                                Console.Beep(500, 400);
                                Console.WriteLine("Gecerli bir secim yapmadiniz!");
                                break;
                        }
                        return 0;
                    }
                    else
                    {
                        Console.Beep(500, 600);
                        Console.WriteLine("Gecerli bir sayi girisi yapmadiniz!");
                        return 0;
                    }
                }
                else
                {
                    Console.Beep(500, 600);
                    Console.WriteLine("Gecerli bir sayi girisi yapmadiniz!");
                    return 0;
                }
            }
            else
            {
                Console.Beep(500, 400);
                Console.WriteLine("Gecerli bir secim yapmadiniz!");
                return 0;
            }
            return 0;
        }
    }
}
