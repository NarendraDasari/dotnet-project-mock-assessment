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

            }
        }
    }
}