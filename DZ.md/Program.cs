﻿string[] array1 = new string[3] { "2", "5", "hello" };
string[] array2 = new string[array1.Length];

void SecondArrayF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}