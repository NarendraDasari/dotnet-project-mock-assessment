
using Com.Chaitanya.Data.Repository;
using Com.Chaitanya.Models;
using Com.Chaitanya.Utils;

namespace Com.Chaitanya.Porjects.MockAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you taking a Mock test with us today. \nPlease Proceed with the instructions on the screen.\n");
            Console.WriteLine("Do you want to start the test? (YES/QUIT):");
            string choice = Console.ReadLine();
            if(choice.ToLower() == "y" || choice.ToLower() == "yes")
            {
                Console.WriteLine("Please wait while we retrive the question........");



              QuestionRepository repo = new QuestionRepository();
              List<Item> items=  repo.GetQuestions();

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
                    int noofquest = items.Count;
                    RandomNumberManager number = new RandomNumberManager();
                    int randnum = number.GetNumber(1, items.Count);
                    
                    save[i]= randnum;
                    //for (int z = 0; z < save.Length; z++)
                    //{
                    //    save[z]= randnum;

                    //}
                             
                
                }

                //  at this point of a time save[] have the question id's we need to filter from items list.

                int num = 20;

                for(int z = 0; z < save.Length;z++)
                {
                    if (save[z]==num)
                    {
                        Console.WriteLine("found item");
                        break;
                    }
                }









                }
        }
    }
}