string evens = "3 ve 5 qalıqsız bölünen ededler: ";
for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0)

        if (i % 3 == 0)
        {
            evens += i;
            evens += ", ";
        }
}
Console.WriteLine(evens);
