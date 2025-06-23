namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
               string country = "United States of America";
    string state = "California";
    string city = "San Fransicso";
    string landmark = "Alcatraz Island";
    // output the length of state
    Console.WriteLine(state.Length);
    // Concatenate the contents of city and landmark * don't forget to add a space
    Console.WriteLine(state + " " + city + " " + landmark);
    // output the first character of county
    Console.WriteLine(country.Substring(0,1));
    // output a concatenation of the first and last characters of city
    Console.WriteLine(city.Substring(0,1) + city.Substring(city.Length -1,1));
    // output the substring of landmark starting at c and outputting to the end
    Console.WriteLine(landmark.Substring(2,13));
    // output the substring of country starting at the first S and ending at the first A
    Console.WriteLine(country.Substring(7,11));
    // output the position of f in California
    for (int i = 0; i < state.Length; i++)
    {
        string letter = Convert.ToString(state[i]);
        if (letter == "f")
        {
            Console.WriteLine("Found at index " + i);
        }             
    }
    //************CHALLENGE****************//
    // Output how many vowels are in each of the strings in the format
    // California has n vowels
    string vowels = "aeiouAEIOU";
    int vowelcount = 0;
    for (int i = 0; i < state.Length; i++)
    {
        string stateletter = Convert.ToString(state[i]);
        if (vowels.Contains(stateletter))
        {
            vowelcount++;
        }
    }
    Console.WriteLine("California has " + vowelcount + " vowels" );

        }
    }
}
