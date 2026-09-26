using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using System.Diagnostics;
using ConsoleAppCSharp.Games;
using ConsoleAppCSharp.Algorithm;
using ConsoleAppCSharp.ISApps;
using ConsoleAppCSharp.LeetCode;
using System.ComponentModel.Design;
//using 

namespace ConsoleAppCSharp
{

    class Program
    {


        static void Main(string[] args)
        {
            
            int choose;

            do
            {

                Console.WriteLine("----------------------------------------");
                Console.WriteLine(".: welcome to dka Simple Console Apps :.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("choose your games");
                Console.WriteLine("1. MiniGames");
                Console.WriteLine("2. Simple Project Information System");
                Console.WriteLine("3. Try to sfml GUI");
                Console.WriteLine("4. Codingbat C# practice");
                Console.WriteLine("5. ML Dotnet");
                Console.WriteLine("6. LeetCode cases");
                Console.WriteLine("next menu got to be awesome... ");
                Console.WriteLine("7. Exit Programs \n");

                Console.WriteLine("Input yours choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        MiniGames code = new MiniGames();
                        //code.MenuGames();
                        Console.WriteLine("Welcome to a mini games with simple console");
                        Console.WriteLine("1. Stars Project (Star) or (star2)");
                        Console.WriteLine("2. Hangmans (Hangman)");
                        Console.WriteLine("3. Pathfinder a* algo (astar)");
                        Console.WriteLine("4. Djikstra algo (djikstra)");
                        Console.WriteLine("5. Play Banjo (banjo)");
                        Console.WriteLine("7. Check Cigar (cigar");
                        Console.WriteLine("8. back to the future");

                        Console.WriteLine("Type your choose: ");
                        string inputCase = Console.ReadLine();

                        if (inputCase == "Hangman")
                        {
                            Console.Clear();

                            code.Hangman();
                        }
                        else if (inputCase == "Star")
                        {
                            Console.Clear();

                            Console.WriteLine("Input how many star that you want to show: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            code.ParalellogramStar(count);
                        }
                        else if (inputCase == "Star2")
                        {
                            Console.Clear();

                            Console.WriteLine("Input how many Star for triangle pattern");
                            int ctn = Convert.ToInt32(Console.ReadLine());

                        }
                        else if (inputCase == "astar")
                        {
                            Console.Clear();
                            APathFinding apath = new APathFinding();
                            Console.WriteLine("algorithma a*");
                            apath.APathFinder();
                        }
                        else if (inputCase == "djikstra")
                        {
                            Console.Clear();
                            Djikstra djikstra = new Djikstra();
                            Console.WriteLine("algo djikstra");
                            djikstra.djikstraAlgo();
                        }
                        else if (inputCase == "banjo")
                        {
                            Console.Clear();
                            Console.Write("Please input your name: ");
                            string inputName = Console.ReadLine();
                            code.CheckIfSay(inputName);
                        }
                        else if (inputCase == "cigar")
                        {
                            Console.Clear();
                            Console.WriteLine("input your cigar");
                            int cigar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("input weekend");
                            bool isWeekend = Convert.ToBoolean(Console.ReadLine());
                            code.CheckCigar(cigar, isWeekend);
                        }
                        else if (inputCase == "leetcodeCase")
                        {
                            Console.Clear();
                            Console.WriteLine("input your leetcode case");

                        }
                        else if (inputCase == "back")
                        {
                            Console.Clear();
                            Console.WriteLine("back to the main menu");
                        }
                        else
                        {
                            Console.WriteLine("please choose the right case");
                        }

                        break;

                    case 2:

                        Cenums cenums = new Cenums();
                        Console.Clear();
                        Console.WriteLine("Simple Banking apps");
                        Console.WriteLine("===================");
                        Console.WriteLine("list of weeks!!");
                        Console.WriteLine("try input weeks");
                        Console.WriteLine("try input bank");
                        Console.WriteLine("try input testdb");

                        switch (Console.ReadLine())
                        {
                            case "weeks":
                                Console.Clear();
                                cenums.ListOfDaysWeek();
                                break;
                            case "bank":
                                Console.WriteLine("test data");
                                cenums.menuAccount();
                                break;
                            case "testdb":
                                Console.Clear();
                                Console.WriteLine("wait for connection");
                                ConnDB cdb = new ConnDB();
                                cdb.connDb();

                                break;
                            default:
                                break; 
                        }

                        break;
                    case 3:
                        const int WIDTH = 640;
                        const int HEIGHT = 480;
                        const string TITLE = "Try windwos of SFML";
                       
                        //VideoMode mode = new VideoMode(WIDTH, HEIGHT);
                        //RenderWindow window = new RenderWindow(mode, TITLE);

                        //window.SetVertic alSyncEnabled(true);

                        MyWindow wdw = new MyWindow();

                        //window.Show();
                        wdw.Show();
                        Console.WriteLine("All done");

                        Console.WriteLine("Try to SFML GUI");

                        //window.Closed += (sender, args) => window.Close();

                        //while (window.IsOpen)
                        //{
                        //    window.DispatchEvents();
                        //    window.Clear(Color.Blue);
                        //    window.Display();
                        //}

                        break;
                    case 4:

                        Codingbat cds = new Codingbat();

                        Console.Clear();
                        Console.WriteLine("Here a choose of Codingbats Puzzle from codingbat.com");
                        Console.WriteLine("1. Logic (type: Logic)");
                        Console.WriteLine("2. Array (type: Array)");
                        Console.WriteLine("3. AP-1 (type: AP)");
                        Console.WriteLine("4. WarmpUP (type: WarmpUp-2)");
                        Console.WriteLine("5. Warmpup (type: WarmpUp-1)");
                        Console.WriteLine("input your case with string: ");
                        string cbchoose = Console.ReadLine();

                        if (cbchoose == "Logic")
                        {
                            Console.Clear();
                            cds.modEven();
                        }
                        else if (cbchoose == "Array")
                        {
                            Console.Clear();
                            Console.WriteLine("checking an array");

                        } else if (cbchoose == "AP")
                        {
                            int[] cton = new[] { 5, 3, 6, 7, 2 }; 
                            
                            Console.WriteLine("AP-1 cases");

                            Console.WriteLine(cds.bigHeights(cton, 2, 4));
                        } else if (cbchoose == "String-2")
                        {
                            Console.Clear();
                            Console.WriteLine("WarmpUp 2 cases");
                            Console.WriteLine(cds.StringBits("Hello"));
                        }
                        else if (cbchoose == "WarmUp-1")
                        {
                            Console.Clear();
                            Console.WriteLine("WarmpUp 1 cases");
                            Console.WriteLine(cds.StringBits("Hello"));
                        }
                        else
                        {
                            Console.WriteLine("please choose the right case");
                        }

                        break;
                    case 5:
                        Console.Clear();
                        int options;
                        Console.WriteLine("Here some ML from dotnet examples");

                        do
                        {
                            
                            Console.WriteLine("1. prediciton data");
                            Console.WriteLine("2. classification data");
                            options =Convert.ToInt32(Console.ReadLine());
                            
                            switch(options)
                            {
                                case 1:
                                    Console.WriteLine("data predictio");
                                    var sampleData = new SentimentModel.ModelInput()
                                    {
                                        Col0 = @"Good case, Excellent value",
                                    };

                                    //Load model and predict output
                                    var result = SentimentModel.Predict(sampleData);

                                    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
                                    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

                                    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment} \n");
                                    break;
                                default:
                                    Console.WriteLine("please choose next time ...");
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (options != 3);
                        //Load sample data
                        Environment.Exit(0);
                        break;
                    case 6:
                        Console.Clear();
                        DSA leet = new DSA();
                        int leetChoose;

                        Console.WriteLine("Choose an option for DSA operations:");
                        Console.WriteLine("1. Binary Search");
                        Console.WriteLine("2. Binary Search Recursive");
                        leetChoose = Convert.ToInt32(Console.ReadLine());

                        switch(leetChoose)
                        {
                            case 1:
                                Console.Clear();
                                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                                int sample = 5;
                                leet.BinarySearch(nums, sample);
                                break;
                            case 2:
                                Console.Clear();
                                int[] numsRec = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                                int sampleRec = 7;
                                leet.BinarySearchRecursive(numsRec, sampleRec, 0, numsRec.Length - 1);
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please choose again.");
                                break;
                        }

                        break;
                    case 7:
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("guten tag!! Aufwierdershen ");
                        Environment.Exit(0);
                        break;
                }

            } while (choose != 7);

            Environment.Exit(0);
        }

        

    }


}
