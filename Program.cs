﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        //program.Task_1_17(10);
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
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 1; i <= 10; i = i + 1)
            s += 1.0 / i;
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int chislitel = 2; chislitel <= 112; chislitel += 2)
        {
            int znamenatel = chislitel + 1;
            s += (double)chislitel / znamenatel;
            answer = Math.Round(s, 0);
        }
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
for (int i = 1; i <= 9; i++)
{

    answer += (Math.Cos(i * x)) / s;
    s = s * x;
}
if (x == 0)
{
    return 0;
}
answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 0; i <= 9; i++)
        {
            s = s + (p + i * h) * (p + i * h);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round((0.5 * x * x - 7 * x), 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            if (i == 1) answer = 1;
            else;
            {
                answer *= i;
            }
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1;
        for (int i = 1; i <= 6; i++)
        {
            if (i == 1) answer = 1;
            else
            {
                s *= i;
                answer += s;
            }
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int p = -1;
        int x = 1;
        double a = 1;
        for (int i = 1; i <= 6; i++)
        {
            a *= i;
            x *= 5;
            answer += p * x / a;
            p = -p;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int number = 3;
        int stepen = 7;
        int result = 1;
        for (int i = 0; i < stepen; i++)
        {
            result *= number;
        }
        answer = result;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (int j = 1; j <= 6; j++)
        {
            Console.Write(5 + " ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return 0;
        else
        {
            double n = 1;
            for (int i = 1; i <= 10 + 1; i++)
            {
                answer += 1 / n;
                n *= x;
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
        if (x <= -1) answer = 1;
        else if (x > -1 && x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine(b);
        for (double i = 1; i < 8; i++)
        {
            c = a;
            a = b;
            b = c + b;

            Console.WriteLine(b);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1, ch2, zn2;
        for (int i = 1; i <= 4; i++)
        {
            zn2 = ch1;
            ch2 = ch1 + zn1;
            answer = ch2 / zn2;
            ch1 = ch2;
            zn1 = zn2;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 1.0;
        double p = 1;
        for (int i = 1; i <= 64; i++)
        {
            x *= 2;
        }
        answer = x / 15;
        power = (int)Math.Log10(answer);
        for (int i = 1; i <= power; i++)
        {
            p *= 10;
        }
        answer = Math.Round(answer / p, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        x = x / 3;
        int n = 1;
        for (int i = 0; i < x; i++)
        {
            n *= 2;
            answer = 10 * n;
        }
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
        long L = 30000;
        long p = 1;
        int n = 1;
        int k = 1;
        while (true)
        {
            p *= n;
            if (p > L)
            {
                break;
            }
            k++;
            n = 1 + 3 * (k - 1);
        }
        answer = n - 3;
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
        double s = 0, p = 1;
        if (Math.Abs(x) >= 1)
            return 0;
        else
        {
            for (int i = 1; ; i++)
            {
                if (p < 0.0001)
                    break;
                else
                {
                    s += p;
                    p *= x * x;
                }
            }
            answer = Math.Round(s, 2);
        }
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
        int time = 0;

        for (int cnt = 10; cnt < 100_000; cnt *= 2)
        {
            time += 3;
        }
        answer = time;
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
        double r = 0.08;
        int t = 0;
        while (true)
        {
            if (s >= 20000) break;
            else
            {
                t += 1;
                s += s * r;
            }
        }
        answer = t;
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
        double a = 0;
        double b = 1;
        double c = 0;
        double s = 0;
        for (answer = 0; ; answer++)
        {
            c = a;
            a = b;
            b = c + b;
            if (Math.Abs(b / a - s) <= 0.001)
            {
                break;
            }
            s = b / a;
        }
        answer++;
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
        double a = 1, p = -1, x1 = x;
const double eps = 0.0001;
int i = 1;
while (Math.Abs(a) > eps)
{
    p = -p;
    if (i > 1)
    {
        x1 *= x * x; 
    }
    a = p * (x1 / (4 * i * i - 1));
    S += a;
    i += 1;
}
y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
Console.WriteLine($"s = {S}, y = {y}");
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
