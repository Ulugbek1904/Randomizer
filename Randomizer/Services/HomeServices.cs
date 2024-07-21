using System;
using Tynamix.ObjectFiller;

namespace Randomizer.Services
{
    internal class HomeServices : IHomeServices
    {
        public void LoadExistedMenus()
        {
            bool ContinueProg = true;
            while (ContinueProg)
            {
                string menu = "" +
                    "1. Random some EmailAdressess\n" +
                    "2. Random some names \n" +
                    "3. Random some integer numbers \n" +
                    "4. Generate a paragraph \n" +
                    "5. Exit ";
                Console.WriteLine("\n======== Menu ========\n");
                Console.WriteLine(menu);

                Console.Write("\nChoose an option : ");
                try
                {
                    string UserInput = Console.ReadLine();
                    int intUserInput = int.Parse(UserInput);

                    switch (intUserInput)
                    {
                        case 1:
                            Console.Clear();
                            GenerateEmailAddresses();
                            break;
                        case 2:
                            Console.Clear();
                            GenerateNames();
                            break;
                        case 3:
                            Console.Clear();
                            GenerateRandomNumbers();
                            break;
                        case 4:
                            Console.Clear();
                            GenerateParagraph();
                            break;
                        case 5:
                            Exit();
                            break;
                        default:
                            Console.WriteLine("Enter " +
                                "only number from 5 to 1");
                            break;
                    }

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        public static void GenerateEmailAddresses()
        {
            EmailAddresses emailGenerator =
                new EmailAddresses();
            Console.WriteLine("How many email account " +
                "do you want to generate? Enter count : ");
            try
            {
                string UserInput = Console.ReadLine();
                int IntUserInput = int.Parse(UserInput);

                for (int i = 0; i < IntUserInput; i++)
                {
                    string emailRandom =
                        emailGenerator.GetValue();
                    Console.WriteLine(emailRandom);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public static void GenerateNames()
        {
            RealNames realNames = new RealNames();

            Console.WriteLine("How many random names " +
                "do you want to generate? Enter count : ");
            try
            {
                string UserInput = Console.ReadLine();
                int IntUserInput = int.Parse(UserInput);

                for (int i = 0; i < IntUserInput; i++)
                {
                    string nameRandom =
                        realNames.GetValue();
                    Console.WriteLine(nameRandom);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public static void GenerateRandomNumbers()
        {
            Console.WriteLine("Enter the range in" +
                " which the number will be ");

            Console.Write("min : ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("max : ");
            int maxNumber = int.Parse(Console.ReadLine());

            IntRange randomNumber = new 
                IntRange(minNumber,maxNumber);

            Console.WriteLine("How many random names " +
                "do you want to generate? Enter count : ");
            try
            {
                string UserInput = Console.ReadLine();
                int IntUserInput = int.Parse(UserInput);

                for (int i = 0; i < IntUserInput; i++)
                {
                    int intNumber = randomNumber.GetValue();
                    Console.WriteLine(intNumber);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public static void GenerateParagraph()
        {
            Console.WriteLine("How many random paragraphs " +
                "do you want to generate? Enter count : ");
            
            try
            {
                string UserInput = Console.ReadLine();
                int intUserInput = int.Parse(UserInput);
                LipsumFlavor flavor = 
                    LipsumFlavor.LoremIpsum;
                Console.WriteLine("How many " +
                    "words do you need in each sentence: ");

                int countOfWords = int.Parse(Console.ReadLine());
                int minWords = countOfWords; 
                int maxWords = countOfWords;
                Console.WriteLine("How many " +
                    "sentence do you need in each paragraph: ");

                int countOfSentences = int.Parse(Console.ReadLine());
                int minSentences = countOfSentences; 
                int maxSentences = countOfSentences;
                int paragraphs = intUserInput;

                Lipsum lipsum = new Lipsum(flavor, minWords, maxWords, minSentences, maxSentences, paragraphs);

                var generatedParagraphs = lipsum.GetValue();

                Console.WriteLine(generatedParagraphs);
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
