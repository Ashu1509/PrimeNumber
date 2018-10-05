using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrimeNum.Enum;

namespace PrimeNum
{
    class PrimeProduct
    {

        static void Main(string[] args)
        {
            bool IsPrime = true;
            List<int> Primearr = new List<int>();

            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Primearr.Add(i);
                }
                IsPrime = true;
            }
            Product(Primearr.ToArray());
        }


        //Method to calculate product of 4 different prime numbers
        public static void Product(int[] Primearr)
        {
            try
            {

                for (int first = 0; first <= Primearr.Length - 3; first++)
                {

                    for (int second = first + 1; second < Primearr.Length - 2; second++)
                    {
                        for (int third = second + 1; third < Primearr.Length - 1; third++)
                        {
                            for (int fourth = third + 1; fourth < Primearr.Length; fourth++)
                            {

                                int firstNum = Primearr[first];
                                int secondNum = Primearr[second];
                                int thirdNum = Primearr[third];
                                int fourthNum = Primearr[fourth];


                                long product = (long)firstNum * (long)secondNum * (long)thirdNum * (long)fourthNum;

                                long result = product;
                                long prodSize = (long)(Math.Floor(Math.Log10(product) + 1));
                                int noOfDigits = (int)NumOfDigits.noOfDigits; // Size given in requirement ,using it to reduce iteration
                                if (prodSize == noOfDigits)
                                {
                                    long[] array = new long[noOfDigits]; // hold digits of product == size
                                    prodSize = array.Length - 1;

                                    while (product != 0)
                                    {
                                        long digit = product % 10;
                                        array[prodSize] = digit;
                                        product = product / 10;
                                        prodSize--;
                                    }
                                    bool correct = true; //hold true if 4 numbers product meet the requirement

                                    for (int index = 0; index < array.Count() - 1; index++)
                                    {

                                        if ((array[index] == array[index + 1] || array[index + 1] == array[index] + 1) && correct)
                                        {
                                            correct = true;

                                        }
                                        else
                                        {
                                            correct = false;
                                            continue;

                                        }
                                    }
                                    if (correct)
                                    {

                                        Console.WriteLine("First Number::   " + firstNum);
                                        Console.WriteLine("Second Number::  " + secondNum);
                                        Console.WriteLine("Third Number::   " + thirdNum);
                                        Console.WriteLine("Fourth Number::  " + fourthNum);
                                        Console.WriteLine("Product of these prime Numbers is:   " + result);

                                    }

                                }

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("exception" + ex.Message);
            }

        }
    }


}
