using System.Globalization;
using System.Linq;

class MyProgram
{
    TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
    static string PrintMsg(string firstName, string lastName)
    {
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        return string.Format("Thanks {0} {1}, for celebraing with us", currentTextInfo.ToTitleCase(firstName), currentTextInfo.ToTitleCase(lastName));
    }
    static string swapCase(string text)
    {
        char[] chars = new char[text.Length];
        string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
        for(int i = 0; i < chars.Length; i++)
        {
            if (text[i].ToString() == text[i].ToString().ToUpper())
            {
                
            }
            else if (lowerLetters.Contains(text[i]))
            {
                text[i].ToString().ToUpper();
            }
        }
        return text;
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
        //Console.WriteLine("Enter any word: ");
        //string name = "Mike, Jedi, Hosea, Jericho";
        //string[] names = name.Split(",");
        //string word = Console.ReadLine();
        //int[] ages = new int[] { 4, 5, 6, 7, 8, 9, 10 };
        //string result = string.Join(",", ages);
        //Array.ForEach(names, x => Console.WriteLine(x));
        Console.WriteLine(MyProgram.convertText("The_Stealth_Warrior"));
    }
}