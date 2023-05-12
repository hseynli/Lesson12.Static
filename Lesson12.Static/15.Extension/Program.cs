﻿int summand1 = 1, summand2 = 2, sum = 0;

summand1.Add(ref summand2, out sum);

// ref və out parametrlərdən istifadə. (Extension metodların arqumenti ref və out ola bilməz)
static class ExtensionClass
{
    public static void Add(this int summand1, ref int summand2, out int sum)
    {
        sum = summand1 + summand2;
        Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);
    }
}