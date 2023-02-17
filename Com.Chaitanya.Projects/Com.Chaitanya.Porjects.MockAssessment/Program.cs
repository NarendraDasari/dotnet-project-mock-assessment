
using Com.Chaitanya.Data.Repository;
using Com.Chaitanya.Models;
using Com.Chaitanya.Utils;
using System.Security.Cryptography.X509Certificates;

namespace Com.Chaitanya.Porjects.MockAssessment
{
    internal class Program
    {
        public static object quesid { get; private set; }
        static List<Item> itemList;

        static void Main(string[] args)
        {
            Console.WriteLine("Thank you taking a Mock test with us today. \nPlease Proceed with the instructions on the screen.\n");
            Console.WriteLine("Do you want to start the test? (YES/QUIT):");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "y" || choice.ToLower() == "yes")
            {
                //Console.WriteLine("Please wait while we retrive the question........");



                QuestionRepository repo = new QuestionRepository();
                itemList = repo.GetQuestions();

                // get a random number with in range of 0 - 32
                // retrive the question Item matching with the random number and store it in your question results object.
                // get a random number again for iteration 2.
                // check if the random number generated is existing with your copy  of results objects.

                // If generated random number doesn't exist with your copy then , retrieve the question Id matching with the random number from items object.
                // Copy the Item that was retreved into you results object.

                // If the random number generated already exist with a question Id from your results object - then, generate a random number again. Repeate this process
                // until a unique number that doesn't match with the question Id from the result object.


                // modules - featues.
                // Write a forloop to iterate 5 items to get 5 unique random numbers.
                // write a method to match a number and retriev the Item Object.
                // Save the unique questions items into an array or List Object.

                // print the unique question result Object.
                int[] save = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    int noofquest = itemList.Count;
                    RandomNumberManager number = new RandomNumberManager();
                    int randnum = number.GetNumber(1,itemList.Count);
                    
                    save[i] = randnum;
                    // int randnum = 10;


                }



                //int num = 10;



                //for (int z = 0; z < save.Length; z++)
                //{
                //    if (save[z] == num)
                //    {
                //        Console.WriteLine("Found.item");
                //    }
                //}

                //  at this point of a time save[] have the question id's we need to filter from items list.
                string first = "10";
                string second = "33";
                string third =" 26";
                string fourth = "15";
                 string fifth = "17";

                 getQuestionById("33" );
                getQuestionById("10");
                getQuestionById("26");
                getQuestionById("15");
                getQuestionById("17");

            }
        }

        private static void getQuestionById(string quesid)
        {
            for (int z = 0; z < itemList.Count; z++)
            {


                Item obj = itemList[z];

                if (obj.Id == quesid)
                {

                    Console.WriteLine("Item found: {0}", obj.Name);
                    break;
                }
            }

        }
      

          

        }
    }
