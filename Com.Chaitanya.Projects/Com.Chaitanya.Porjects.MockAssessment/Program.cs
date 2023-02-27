﻿
using Com.Chaitanya.Data.Repository;
using Com.Chaitanya.Models;
using Com.Chaitanya.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;

namespace Com.Chaitanya.Porjects.MockAssessment
{
    internal class Program
    {
        public static object quesid { get; private set; }
        static List<Item> itemList;

        static void Main(string[] args)
        {
            
            string assesmblyPath = Directory.GetParent(AppContext.BaseDirectory).FullName;
            AppSettingsBuilder settings = new AppSettingsBuilder(assesmblyPath);
            string noOfQuestions = settings.GetValueBykey("noOfQuestions");


            Console.WriteLine("Thank you taking a Mock test with us today. \nPlease Proceed with the instructions on the screen.\n");
            Console.WriteLine("Do you want to start the test? (YES/QUIT):");
            string choice = Console.ReadLine();
            do
            {
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
                // int[] save = new int[5];
                List<int> randomList = new List<int>();
                int noofquest = itemList.Count;


                for (int i = 0; i < 10; i++)
                {
                    RandomNumberManager number = new RandomNumberManager();
                    int randnum = number.GetNumber(1, noofquest);

                    if (randomList.Contains(randnum) == false)
                    {
                        randomList.Add(randnum);
                    }
                    else
                    {
                        //Console.WriteLine("found duplicate. So re-trying this {0} iteration.", i);
                        i--;
                    }

                    //for (int q = 0; q < save.Length; q++)
                    //{
                    //   if( save[q] != randnum)

                    //    {
                    //        save[i] = randnum;

                    //    }
                    //}



                }



                // iterating the save array and called the question id which matches the array with questionid.
                for (int p = 0; p < randomList.Count; p++)
                {
                    int seqnum = p + 1;
                    int quesid = randomList[p];
                    string s = getQuestionById(quesid.ToString());
                    Console.WriteLine(seqnum + "." + s);



                }


                Console.WriteLine("Do you want to re-take the test: (Yes/Quit)");
                choice = Console.ReadLine();


            }
            while (choice.ToLower() == "y" || choice.ToLower() == "yes");

        }

        private static string getQuestionById(string quesid)
        {

            string questionText = "";
            for (int z = 0; z < itemList.Count; z++)
            {


                Item obj = itemList[z];

                if (obj.Id == quesid)
                {
                    questionText = obj.Name;
                    //Console.WriteLine(x +"." + "{0}", obj.Name);
                    break;
                }
            }

            return questionText;

        }

    }
}

