using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();

        bool areEqual = true;
        string result = "";

        if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("<");
        }
        else if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(">");
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        result = "<";
                    }
                    else
                    {
                        result = ">";
                    }

                    break;
                }
                else
                {
                    result = "=";
                }
            }

            Console.WriteLine(result);
        }
    }
}