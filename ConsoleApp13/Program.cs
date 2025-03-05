Console.WriteLine("Введите строку:"); 
string input = Console.ReadLine(); 
string result = WriteLine(input); 
Console.WriteLine("Итoг: " + result);
string WriteLine(string input)
{
    char[] chars = input.ToCharArray();

    for (int b = 0; b < chars.Length; b++)
    {
        if (b % 2 == 0)
        {

            chars[b] = char.ToUpper(chars[b]);
        }
    }
    return new string(chars);
}