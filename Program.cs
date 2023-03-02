string Remove_Space(string text)
{
    string new_text = "";
    foreach (char c in text)
    {
        if (c != ' ')
        {
            new_text += c;
        }

    }
    return new_text;
}

string Reverse_Test(string text)
{
    string reversed_text = "";
    foreach (char c in text)
    {
        reversed_text = c + reversed_text;
    }
    return reversed_text;
}

bool Is_Palindrome(string text)
{
    text = Remove_Space(text);
    string reversed_text =  Reverse_Test(text);
    return text.ToLower() == reversed_text.ToLower();
}

Console.WriteLine(Is_Palindrome("amo la paloma"));
Console.WriteLine(Is_Palindrome("hola mundo"));
Console.WriteLine(Is_Palindrome("ana lava lana"));
Console.WriteLine(Is_Palindrome("racecar"));
Console.WriteLine(Is_Palindrome("A man a plan a canal Panama"));
Console.WriteLine(Is_Palindrome("Was it a car or a cat I saw?"));
Console.WriteLine(Is_Palindrome("Eva, can I see bees in a cave?"));
Console.WriteLine(Is_Palindrome("No 'x' in Nixon"));
