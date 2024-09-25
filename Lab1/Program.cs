using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        program.Task_2_9();
        program.Task_2_10();
        program.Task_3_1(0.1);
        program.Task_3_2(0.1);
        program.Task_3_3(0.1);
        program.Task_3_4(0.1);
        program.Task_3_5(double.Pi / 5);
        program.Task_3_6(0.1);
        program.Task_3_7(0.1);
        program.Task_3_8(0.1);
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        
        int elementOfAP = 2;
        for (int i = 2; i <= 35; i += 3)
        {
            answer += elementOfAP;
            elementOfAP += 3;
        }
       
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        double elementOfAP = 1;
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / elementOfAP;
            elementOfAP++;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        double dividend = 2, divisor = 3;
        for (double i = 0; i <= 55; i++)
        {
            answer += dividend / divisor;
            dividend += 2;
            divisor += 2;
        }
        answer = Math.Round(answer);

        // end

        return answer;
        
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        double degree = x;
        answer = Math.Cos(x);
        for (int i = 2; i < 10; i++)
        {
            if (x == 0)
            {
                answer = 0;
                break;
            }
            else
            {
                answer += Math.Cos(x * i) / degree;
                degree *= x;
            }
        }
        answer = Math.Round(answer,2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        for (int i = 0; i < 10; i++)
        {
            answer += p * p + 2 * p * (i * h) + i * h * i * h;
        }

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here

        answer = 1;
        for (int i = 6; i > 0; i--)
            answer *= i;

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        int fact = 1;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                fact = fact * j;
            }
            answer += fact;
            fact = 1;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        int k = 1;
        double degree1 = -1, degree5 = 5;
        for (int i = 1; i < 7; i++)
        {
            for (int j = 1; j <= i; j++)
            { 
                k *= j;
            }
            answer += degree1 * degree5 / k;
            k = 1;
            degree1 *= -1;
            degree5 *= 5;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        int k = 3;
        for (int i = 1; i < 7; i++)
        {
            k *= 3;
        }
        answer = k;

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        Console.WriteLine("Номер 1.11");
        for (int i = 1; i < 7; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i < 7; i++)
        {
            Console.Write(5 + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double degree = x;
        answer = 1;
        for (int i = 0; i < 10; i++)
        {
            if (x != 0)
            {
                answer += 1 / degree;
                degree *= x;
            }
            else
            {
                answer = 0;
                break;
            }
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        Console.WriteLine("Номер 1.14");
        int term1 = 1, term2 = 2;
        Console.Write("1" + " " + "1" + " ");
        for (int i = 1; i < 6; i++)
        {
            int element = term1 + term2;
            term1 = term2;
            term2 = element;
            Console.Write(element + " ");
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        double dividend1 = 1, deveder1 = 1, dividend2 = 2, deveder2 = 1;


        for (int i = 1; i < 4; i++)
        {
            double dividend3 = dividend1 + dividend2;
            dividend1 = dividend2;
            dividend2 = dividend3;
            double deveder3 = deveder1 + deveder2;
            deveder1 = deveder2;
            deveder2 = deveder3;
            answer = dividend3 / deveder3;
        }

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        double seedOnCell = 1;
        int koef = 2;

        for (int i = 1; i <= 64; i++)
        {
            answer += seedOnCell;
            double j = seedOnCell * koef;
            seedOnCell = j;
        }

        answer /= 15;

        while (answer > 10)
        {
            answer /= 10;
            power++;

        }

        answer = Math.Round(answer, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        double R = 6350;
        answer = Math.Sqrt((R + x)*(R + x) - R * R);
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        int quantity = 10;
        for (int i = 3; i <= x; i += 3)
        {
            quantity += quantity;
        }
        answer = quantity;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        int L = 30000, p = 1, n = 1;
        while (p < L)
        {
            p *= n;
            if (p * n < L)
            {
                n += 3;
            }
            else
            {
                break;
            }
        }
        answer = n;

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        double degree = 1;
        while (degree > 0.0001)
        {
            answer += degree;
            if (((degree * x * x) > 0.0001) && (x != 1))
            {
                degree *= x * x;
            }
            else if (x == 1)
            {
                answer = 0;
                break;
            }
            else
            {
                break;
            }
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        int quantity = 10;
        while (quantity <= 10 * 10 * 10 * 10 * 10)
        {
            answer += 3;
            quantity *= 2;
        }

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        double s = 10000;
        while (s <= 20000)
        {
            s += 0.08 * s;
            answer++;
        }

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        double dividend1 = 1, deveder1 = 1, dividend2 = 2, deveder2 = 1, diff = 1, fraction2 = 0;
        answer = 2;
        while (diff > 0.001)
        {
            double dividend3 = dividend1 + dividend2;
            dividend1 = dividend2;
            dividend2 = dividend3;
            double deveder3 = deveder1 + deveder2;
            deveder1 = deveder2;
            deveder2 = deveder3;
            double fraction1 = fraction2;
            fraction2 = dividend3 / deveder3;
            diff = Math.Abs(fraction2 - fraction1);
            answer++;
        }

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        double dividend = 1, deveder = 1, count = 1;
        double f = 1;

        while (f > 0.0001)
        {
            {
                S += dividend / deveder;
                dividend *= 2 * x;
                deveder *= count;
                count++;
                f = dividend / deveder;


            }
        }

        y = Math.Exp(2 * x);

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}