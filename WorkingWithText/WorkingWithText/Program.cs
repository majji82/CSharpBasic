using System.Text;

static void StringExamples()
{
    var fullName = " Majji Janardhan  ";
    Console.WriteLine("Trim: '{0}'", fullName.Trim());
    Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

    // first name and last name using split
    var names = fullName.Trim().Split(' ');
    Console.WriteLine("FirstName: {0} LastName: {1}", names[0], names[1]);

    // first name and last name using index
    int index = fullName.Trim().IndexOf(' ');
    Console.WriteLine("FirstName: {0} LastName: {1}", fullName.Trim().Substring(0, index), fullName.Trim().Substring(index+1));

    Console.WriteLine(fullName.Trim().Replace("Janardhan", "Jaan"));

    // Original string is not affected in any of the above methods

    Console.WriteLine(String.IsNullOrEmpty(fullName));
    Console.WriteLine(String.IsNullOrWhiteSpace(fullName));

    int num = 1234;
    string numToString = num.ToString();
    Console.WriteLine(numToString + " Hello");

    int stringToNum = Convert.ToInt32(numToString);
    Console.WriteLine(stringToNum + 32);
    
}

static void SummarizingText()
{
    string sentence = "This is going to be a really really really really really really really really long text";
    const int maxLength = 25;
    if (sentence.Length < maxLength) Console.WriteLine(sentence);

    else
    {
        //Console.WriteLine(sentence.Substring(0, maxLength));
        var words = sentence.Split(' ');
        var totalCharacters = 0;
        var summary = new List<string>();

        foreach(var word in words)
        {
            summary.Add(word);
            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength){ break; }
        }

        string finalAns = String.Join(" ", summary) + ".......";
        Console.WriteLine(finalAns);
    }

}
static void StringBuilderExamples()
{
    var sb = new StringBuilder("Hello world").AppendLine().Append("Header").AppendLine().Append('-', 10).Replace('-', '+')
        .Remove(0, 10)
        .Insert(0, new string("-"), 10);
    Console.WriteLine(sb);

    Console.WriteLine("The first character is: " + sb[0]);
}

//StringExamples();
//SummarizingText();
StringBuilderExamples();