using System;
using System.Collections.Generic;
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
        for (double x = 0.9; x <= 1.0; x += 0.1)
        { program.Task_3_6(x); }
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int x = 2; x <= 35; x += 3)
        {
            answer += x;
            //Console.WriteLine($"answer = {answer}, x = {x}");
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int x = 1; x <= 10; x++)
        {
            answer += (1.0 / x);
            //Console.WriteLine($"answer = {answer}, x = {x}");
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double x = 2.0; x <= 112; x += 2)
        {
            answer += x / (x + 1);
            //Console.WriteLine($"{answer}, {x}");
        }
        answer = Math.Round(answer, 0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        else
        {
            for (double y = 1; y <= 9; y++)
            {
                answer += Math.Cos(x * y) / Math.Pow(x, (y - 1));
            }
        }
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int x = 0; x <= 9; x++)
        {
            answer += (p + (x * h)) * (p + (x * h));
        }
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
                //Console.WriteLine($"answer = {answer}, s = {s}, i = {i}");
            }
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int s = 1;
        for (int i = 1; i <= 6; i++)
        {
            s *= i;
            answer += ((double)(Math.Pow(-1, i) * Math.Pow(5, i))) / s;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5);
            Console.Write(' ');
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1.0 / Math.Pow(x, i);
                Console.WriteLine(answer);
            }
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else if (x > 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int num1 = 1;
        int num2 = 1;
        for (int i = 0; i <= 7; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine(num1);
                num1 += num2;
            }
            else
            {
                System.Console.WriteLine(num2);
                num2 += num1;
            }
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double num1, num2, num3, num4;
        num1 = 1;
        num2 = 2;
        num3 = num4 = 1;
        for (int i = 0; i <= 4; i++)
        {
            if (i % 2 == 0)
            {
                answer = num1 / num3;
                num1 += num2;
                num3 += num4;
            }
            else
            {
                answer = num2 / num4;
                num2 += num1;
                num4 += num3;
            }
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
        for (int i = 1; i <= 64; i++)
        {
            x *= 2;
        }
        answer = x / 15;
        power = (int)Math.Log10(answer);
        answer = Math.Round(answer / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Round(Math.Sqrt(((R + x) * (R + x)) - (R * R)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int cell = 10;
        for (int i = 1; i <= (x / 3); i++)
        {
            cell *= 2;
        }
        answer = cell;
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
        int n = 1;
        int l = 1;
        while (l <= 30000)
        {
            n += 3;
            l *= n;
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
        double s = 1;
        double x1 = 1;
        double ep = 0.0001;
        if (Math.Abs(x) < 1)
        {
            while (x1 >= ep)
            {
                x1 *= x * x;
                s += x1;
                //System.Console.WriteLine($"s = {s}, x = {x1}, n = {n}");
            }
            answer = Math.Round(s, 2);
        }
        else answer = 0;
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
        int n = 0;
        int cell = 10;
        while (true)
        {
            if (cell >= 100000) break;
            else
            {
                n += 3;
                cell *= 2;
            }
        }
        answer = n;
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
        double d1 = 1;
        double d2 = 0;
        double num1, num2, num3, num4;
        num1 = 1;
        num2 = 2;
        num3 = num4 = 1;
        int n = 0;
        for (int i = 0; Math.Abs(d1 - d2) > 0.001; i++)
        {
            if (i % 2 == 0)
            {
                d1 = num1 / num3;
                //Console.WriteLine($"d1 = {d1}, num1 = {num1}, num3 = {num3}");
                num1 += num2;
                num3 += num4;
                n += 1;
            }
            else
            {
                d2 = num2 / num4;
                //Console.WriteLine($"d2 = {d2}, num2 = {num2}, num4 = {num4}");
                num2 += num1;
                num4 += num3;
                n += 1;
            }
        }
        answer = n;
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
        double a = 1, p = -1, x1;
        const double eps = 0.0001;
        int i = 1;
        while (Math.Abs(a) > eps)
        {
            x1 = 1;
            p = -p;
            for (int j = 1; j <= 2 * i + 1; j++)
            {
                x1 *= x;
            }

            a = p * (x1 / (4 * i * i - 1));
            S += a;
            i += 1;
        }
        y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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