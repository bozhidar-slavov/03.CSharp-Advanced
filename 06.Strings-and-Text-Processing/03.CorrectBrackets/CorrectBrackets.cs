using System;

class CorrectBrackets
{
    static bool CheckExpression(string input)
    {
        int leftBracketCounter = 0;
        int rightBracketCounter = 0;
        bool isCorrect = false;
        foreach (var symbol in input)
        {
            switch (symbol)
            {
                case '(': leftBracketCounter++; break;
                case ')': rightBracketCounter++; break;
            }
        }

        if (leftBracketCounter == rightBracketCounter)
        {
            isCorrect = true;
        }

        return isCorrect;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        if (CheckExpression(input))
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}