using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleAppCSharp.MLStuff
{
    internal class MLTestOne
    {
        public MLTestOne() {
            int chi;
            Console.WriteLine("This menu go");

            do
            {
                Console.WriteLine("1. Predict IMDB Dataset.");
                Console.WriteLine("2. Predict AMAZON Dataset");
                Console.WriteLine("3. Predict Yelp Dataset");
                chi = Convert.ToInt32(Console.ReadLine());
                switch(chi)
                {
                    case 1:
                        Console.WriteLine("IMDB Datasets");
                        //string dataIMBD = MLSentimentData();
                        break;
                    case 2:
                        Console.WriteLine("Amazon Dataset");

                        break;
                    case 3:
                        Console.WriteLine("Yelp Dataset");
                        break;
                    default:
                        Console.WriteLine("Back to the main menu");
                        break;
                }

            }
            while (chi != 5);
        }

        public void MLSentimentData()
        {
            string charData;
            Console.Clear();
            Console.WriteLine("Prediction set of Supervised Learning");
            Console.WriteLine("\n");
            Console.WriteLine("Input some text: ");
            charData = Console.ReadLine();

            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = @"Great for the jawbone",
            };

            var result = SentimentModel.Predict(sampleData);

            var sentimentRest = result.PredictedLabel == 1 ? result.PredictedLabel : 0;

            Console.WriteLine($"Text: {sampleData.Col0}\n");

        }

        public void MLDataIMDB()
        {
            string charD;
            Console.Clear();
            Console.WriteLine("Prediction set of Supervised learning of IMBD data");
            Console.WriteLine("\n");

        }
    }
}
