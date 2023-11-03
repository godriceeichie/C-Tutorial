using System.Globalization;
using System.Linq;

class StringProgram
{
    TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
    static string PrintMsg(string firstName, string lastName)
    {
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        return string.Format("Thanks {0} {1}, for celebraing with us", currentTextInfo.ToTitleCase(firstName), currentTextInfo.ToTitleCase(lastName));
    }
    static string swapCase(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsUpper(c))
            {
                result[i] = char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                result[i] = char.ToUpper(c);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }

    static string StringGame(string input)
    {
        int upperScore = 0;
        int lowerScore = 0;


        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsUpper(c))
            {
                upperScore++;
            }
            else if (char.IsLower(c))
            {
                lowerScore++;
            }
        }
        if(upperScore > lowerScore)
        {
            return "Uppercase has won";
        }
        else if(lowerScore > upperScore)
        {
            return "Lowercase has won";
        }
        else
        {
            return "Draw";
        }

    }
    static string convertText(string word)
    {
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = "";
        if (word.Contains("_"))
        {
            //result =  currentTextInfo.ToTitleCase(string.Join("", word.Split("_")));
            int i = 0;
            Array.ForEach(word.Split("_"), x =>
            {
                if(i == 0)
                {
                    result += x;
                }
                if(i > 0)
                {
                    result += currentTextInfo.ToTitleCase(x);
                }
                i++;
            });
        }
        else if(word.Contains("-"))
        {
            //result = currentTextInfo.ToTitleCase(string.Join("", word.Split("-")));
            int i = 0;
            Array.ForEach(word.Split("-"), x =>
            {
                if (i == 0)
                {
                    result += x;
                }
                if (i > 0)
                {
                    result.Concat(currentTextInfo.ToTitleCase(x));
                }
                i++;
            });
        }
        return result;
        
    }

    
    private static void Main()
    {
        //Console.WriteLine("Enter your first name: ");
        //string firstName = Console.ReadLine();
        //Console.WriteLine("Enter your last name: ");
        //string lastName = Console.ReadLine();
        //Console.WriteLine(MyProgram.PrintMsg(firstName, lastName));

        //Swap case problem
        Console.WriteLine("Enter any word: ");
        string word = Console.ReadLine();
        Console.WriteLine(StringProgram.swapCase(word));

        //Uppercase and lowercase game
        Console.WriteLine(StringProgram.StringGame(word));

        //Split and Join String problem
        Console.WriteLine(StringProgram.convertText("The_Stealth_Warrior"));
    }
}