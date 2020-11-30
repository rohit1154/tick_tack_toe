using System;
using System.Linq;
namespace tick_tack_toe
{
    class Program
    {
        public static bool player1 = true;
        public static bool player2 = false;
        public static bool playerturn = true;
        public static int a;




         static string[,] twod =  { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        static string[,] reset = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };


        static void Main(string[] args)
        {


            while (playerturn)
            {
                Console.Clear();
                diagram();
                if (player1 == true)
                {

                    Console.WriteLine("Please enter the value player1 ");
                    tick();

                    win();
                    
                    player1 = false;
                    player2 = true;
                    // one[count] = ;
                }
                else if (player2 == true)
                {

                    Console.WriteLine("Please enter the value player2");
                    tick();
                    win();
                    
                    player1 = true;
                    player2 = false;
                    //  two[count2] = a;
                }


            }

        }
        public static int tick()
        {

            int[] one = new int[100];
            int[] two = new int[100];


            string firstinput = Console.ReadLine();


            bool b = Int32.TryParse(firstinput, out a);

            if (b != true)
            {
                Console.WriteLine("The value is not an intiger Please re try");

            }
            else
            {
                switch (a)
                {
                    case 1:
                        if (player1)
                        {
                            twod[0, 0] = "o";
                            one[0] = 1;
                        } else if (player2)
                        {
                            twod[0, 0] = "x";
                            two[0] = 1;
                        }
                        Console.Clear();
                        //diagram();
                        //tick();
                        break;
                    case 2:
                        if (player1)
                        {
                            twod[0, 1] = "o";
                            one[1] = 2;
                        }
                        else if (player2)
                        {
                            twod[0, 1] = "x";
                            two[1] = 2;
                        }
                        Console.Clear();
                        // diagram();
                        // tick();
                        break;
                    case 3:
                        if (player1)
                        {
                            twod[0, 2] = "o";

                            one[2] = 3;

                        }
                        else if (player2)
                        {
                            twod[0, 2] = "x";

                            two[2] = 3;
                        }
                        Console.Clear();
                        // diagram();
                        //tick();
                        break;

                    case 4:
                        if (player1)
                        {
                            twod[1, 0] = "o";

                            one[3] = 4;

                        }
                        else if (player2)
                        {
                            twod[1, 0] = "x";


                            two[3] = 4;
                        }
                        Console.Clear();
                        //   diagram();
                        //  tick();
                        break;
                    case 5:
                        if (player1)
                        {
                            twod[1, 1] = "o";

                            one[4] = 5;

                        }
                        else if (player2)
                        {
                            twod[1, 1] = "x";


                            two[4] = 5;
                        }
                        Console.Clear();
                        // diagram();
                        //tick();
                        break;
                    case 6:
                        if (player1)
                        {
                            twod[1, 2] = "o";

                            one[5] = 6;

                        }
                        else if (player2)
                        {
                            twod[1, 2] = "x";


                            two[5] = 6;
                        }
                        Console.Clear();
                        //   diagram();
                        //  tick();
                        break;
                    case 7:
                        if (player1)
                        {
                            twod[2, 0] = "o";

                            one[6] = 7;

                        }
                        else if (player2)
                        {
                            twod[2, 0] = "x";


                            two[6] = 7;
                        }
                        Console.Clear();
                        //  diagram();
                        // tick();
                        break;
                    case 8:
                        if (player1)
                        {
                            twod[2, 1] = "o";

                            one[7] = 8;

                        }
                        else if (player2)
                        {
                            twod[2, 1] = "x";


                            two[7] = 8;
                        }
                        Console.Clear();
                        //  diagram();
                        // tick();
                        break;
                    case 9:
                        if (player1)
                        {
                            twod[2, 2] = "o";

                            one[8] = 9;

                        }
                        else if (player2)
                        {
                            twod[2, 2] = "x";


                            two[8] = 9;
                        }
                        Console.Clear();
                        // diagram();
                        //tick();
                        break;

                }




            }








            return a;

        }
        public static void win()
        {

            if (player1)
            {
                
                    if (twod[0, 0] == "o" && twod[0, 1] == "o" && twod[0, 2] == "o" || twod[1, 0] == "o" && twod[1, 1] == "o" && twod[1, 2] == "o"
                       || twod[2, 0] == "o" && twod[2, 1] == "o" && twod[2, 2] == "o" || twod[0, 0] == "o" && twod[1, 0] == "o" && twod[2, 0] == "o"
                       || twod[0, 1] == "o" && twod[1, 1] == "o" && twod[2, 1] == "o" || twod[0, 2] == "o" && twod[1, 2] == "o" && twod[2, 2] == "o"
                       || twod[0, 2] == "o" && twod[1, 1] == "o" && twod[2, 0] == "o" || twod[0, 0] == "o" && twod[1, 1] == "o" && twod[2, 2] == "o")
                    {
                        Console.WriteLine("player 1 winn");
                        Console.Read();
                       

                    }

                

            }

            else if (player2)
            {

                if (twod[0, 0] == "x" && twod[0, 1] == "x" && twod[0, 2] == "x" || twod[1, 0] == "x" && twod[1, 1] == "x" && twod[1, 2] == "x"
                       || twod[2, 0] == "x" && twod[2, 1] == "x" && twod[2, 2] == "x" || twod[0, 0] == "x" && twod[1, 0] == "x" && twod[2, 0] == "x"
                       || twod[0, 1] == "x" && twod[1, 1] == "x" && twod[2, 1] == "x" || twod[0, 2] == "x" && twod[1, 2] == "x" && twod[2, 2] == "x"
                       || twod[0, 2] == "x" && twod[1, 1] == "x" && twod[2, 0] == "x" || twod[0, 0] == "x" && twod[1, 1] == "x" && twod[2, 2] == "x")
                {
                    Console.WriteLine("player 2 winn");
                    Console.Read();
                    
                }



            }
            resetfield();
        }


       


        public static void diagram()
        {
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + twod[i, j] + " | ");
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine();

        }

        public static void resetfield()
        {
            twod = reset;

            diagram();
            Console.WriteLine();
        }






    }
        
    
}
