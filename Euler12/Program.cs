using System;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int k = 10;
            int triangularNumber;

            while(flag)
            {
                triangularNumber = TriangularNumber(k); // знаходимо трикутне число
                if(NumbersOfDivisors(triangularNumber)>=200) // шукаємо число кількість дільників якого перевищує 200
                {
                    Console.WriteLine($"TriangleNumber = {triangularNumber}, numberOfDivisors = {NumbersOfDivisors(triangularNumber)}");
                    
                    flag = false;

                }


                ++k;
            }
        }
        
        static int NumbersOfDivisors(int number)
        {
            int quantity = 0;
            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    quantity++;
            return quantity;
        }
        static int  TriangularNumber(int number)
        {
            int sum=0;
            for(int i = 1; i <= number; i++)
            {
                sum += i;
            }
            
            return sum;
        }
    }
}
