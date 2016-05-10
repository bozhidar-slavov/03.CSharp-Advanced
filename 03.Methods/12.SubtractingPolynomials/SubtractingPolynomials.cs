using System;

class SubtractingPolynomials
{
    static void FillPolinomial(ref int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("Enter coefficient of x^{0}: ", i);
            polynomial[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
    }

    static int[] Addition(int[] firstPoly, int[] secondPoly, bool addition = true)
    {
        if (firstPoly.Length < secondPoly.Length || (firstPoly.Length == secondPoly.Length && firstPoly[firstPoly.Length - 1] < secondPoly[secondPoly.Length - 1]))
        {
            return Addition(secondPoly, firstPoly, addition);
        }

        int[] sumOfPoly = new int[firstPoly.Length];

        for (int i = 0; i < secondPoly.Length; i++)
        {
            if (addition)
            {
                sumOfPoly[i] = firstPoly[i] + secondPoly[i];
            }
            else
            {
                sumOfPoly[i] = secondPoly[i] - firstPoly[i];
            }
        }

        for (int i = secondPoly.Length; i < firstPoly.Length; i++)
        {
            sumOfPoly[i] = firstPoly[i];
        }

        return sumOfPoly;
    }

    static int[] MultiplyPoly(int[] firstPolynomial, int[] secondPolynomial)
    {
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            return MultiplyPoly(secondPolynomial, firstPolynomial);
        }

        int[] result = new int[secondPolynomial.Length];
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            result[i] = firstPolynomial[i] * secondPolynomial[i];
        }

        for (int j = firstPolynomial.Length; j < secondPolynomial.Length; j++)
        {
            result[j] = secondPolynomial[j];
        }

        return result;
    }

    static void PrintPolynomial(int[] finalResult)
    {
        string sign = String.Empty;
        for (int i = finalResult.Length - 1; i >= 0; i--)
        {
            if (finalResult[i] >= 0 && i != finalResult.Length - 1)
            {
                sign = "+";
            }
            else
            {
                sign = "";
            }

            Console.Write("{2}{0}*x^{1}", finalResult[i], i, sign);
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a power of the first polynomial: ");
        int firstPolynomialLenght = int.Parse(Console.ReadLine()) + 1;
        int[] firstPolynomial = new int[firstPolynomialLenght];
        FillPolinomial(ref firstPolynomial);

        Console.Write("Enter a power of the second polynomial: ");
        int secondPolynomialLenght = int.Parse(Console.ReadLine()) + 1;
        int[] secondPolynomial = new int[secondPolynomialLenght];
        FillPolinomial(ref secondPolynomial);

        int[] sum = Addition(firstPolynomial, secondPolynomial);
        int[] difference = Addition(firstPolynomial, secondPolynomial, false);
        int[] product = MultiplyPoly(firstPolynomial, secondPolynomial);
        Console.WriteLine("The sum of the polynomials is: ");
        PrintPolynomial(sum);

        Console.WriteLine("The difference between the polynomials is:");
        PrintPolynomial(difference);

        Console.WriteLine("The product of the polynomials is:");
        PrintPolynomial(product);
    }
}