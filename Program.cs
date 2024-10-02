using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double a = 1;
        // code here
        for (double b = 1; b <= 10; b++)
        {
            answer += a / b;      
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double a = 2, b=3; a <= 113; a += 2, b+=2)
        {
            answer += a / b;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / (Math.Pow(x, (i - 1)));
            }
        }
        else {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int k = 0; k <= 9; k++)
        {
            double n = (p + k * h) * (p + k * h);
            answer += n;
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
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int n = 1;
            for (int j = 1; j <= i; j++)
            {
                n *= j;
            }
            answer += n;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int znak = -1, schet = 1; double chisl = 5, znam = 1;
        for (double digit = 0; schet <= 6; schet++)
        {
            znam *= schet;
            digit = (znak * chisl) / znam;
            chisl *= 5;
            answer += digit;
            znak = -znak;
            Console.WriteLine(digit);

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int n = 1;
        for (int i = 0; i <= 6; i++)
        {
            n *= 3;
        }
        answer = n;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double s = 1.0;
            for (int i = 1; i <= 10; i++)
            {
                double sum = 1; 
                for (int j = 1; j <= i; j++)
                {
                    sum *= x;
                }
                s += 1.0 / sum;
                answer = Math.Round(s, 2);
            }
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double k = -1.5; k <= 1.5; k += 0.1)
        {
            if (k <= -1) {Console.WriteLine(1);}
            if (k > 1) {Console.WriteLine(-1);}
            if (k > -1 && k <= 1) {Console.WriteLine(Math.Round((-1 * k), 2));}
        }
        if (x <= -1)
        {
            answer = 1;
        }
        if (x > 1)
        {
            answer = -1;
        }
        if (x > -1 && x <= 1)
        {
            answer = -1.0 * x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1; int b = 1;
        Console.WriteLine(a + " " + b + " ");
        for (int i = 2; i < 8; i++)
        {
            int next = a + b;
            Console.WriteLine(next + " ");
            a = b;
            b = next;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double n1 = 1, d1 = 1;
        double n2 = 2, d2 = 1;
        double n3 = 3, d3 = 2;

        for (int i = 4; i <= 5; ++i)
        {
            n1 = n2; d1 = d2;
            n2 = n3; d2 = d3;
            n3 = n1 + n2; d3 = d1 + d2;
        }
        answer = Math.Round(n3 / d3, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double amount = 0;
        double mass;
        // code here
        for (int i = 0; i < 64; i++)
        {
            amount += Math.Pow(2, i);
        }
        mass = amount / 15;
        power = (int) Math.Log10(mass);
        answer = Math.Round(mass / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = Math.Sqrt(2 * r * x + x * x);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        while(x > 0)
       {
            answer *= 2;
            x -= 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double eps = 0.0001, i = 1, nextSum = Math.Cos(x);
        while (Math.Abs(nextSum) >= eps)
        {
            answer += nextSum;
            i += 1;
            nextSum = Math.Cos(i * x) / Math.Pow(i, 2);
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0, currSum;
        int n = 0;
        do
        {
            currSum = a + n * h;
            if (currSum <= 0 && h <= 0) return 0;
            s += currSum;
            n++;
        } while (s <= p);

        answer = n - 1;
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M != 0)
        {
            N = Math.Abs(N);
            M = Math.Abs(M);
            while ((N - M) >= 0)
            {
                N -= M;
                quotient++;
            }
            remainder = N;
        }
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        double step = 10.0;
        for (int i = 1; i <= 7; i++)
        {
            answer += step;
            step *= 1.1;
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, step = 10.0;
        while (s < 100.0)
        {
            s += step;
            step *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double step = 10.0;
        while (step <= 20.0)
        {
            step *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double L = 0.1, D = Math.Pow(10, -10);
        while (L > D)
        {
            L /= 2;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

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
        S = 1;
        double elem = Math.Cos(x), i = 1.0, fact = 1.0;
        while (Math.Abs(elem) > 0.0001)
        {
            elem = Math.Cos(i * x) / fact;
            i++;
            fact *= i;
            S += elem;
            y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
            //Console.WriteLine($"Sum: {S}, elem: {elem} fact: {fact}");
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine(S + " " + y);
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