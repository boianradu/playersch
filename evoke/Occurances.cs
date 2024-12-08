using System;
using System.Drawing;

public class Occurances
{
    private readonly char _smallC = 'a';

    private int sizeN;
    private string stringS;

    public Occurances(int N, string S)
    {
        sizeN = N;
        stringS = S;
    }
    public int CountC()
    {
        string finalString = "";
        int occurances = 0;
        for (int i = 0; i < sizeN - stringS.Length * i; i++)
        {
            finalString += stringS;
        }
        for (int i = 0; i < sizeN - finalString.Length + 1; i++)
        {
            finalString += stringS[i];
        }
        foreach (char c in finalString)
        {
            if (c == _smallC)
            {
                occurances++;
            }
        }
        return occurances;
    }
}