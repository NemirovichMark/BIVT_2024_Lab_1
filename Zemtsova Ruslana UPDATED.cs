using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //for (double x = -4; x <= 4; x += 0.5)
        //{
        //    program.Task_1_6(x);
        //}
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11_a();
        //program.Task_1_11_b();
        //program.Task_1_12(0.9);
        //for (double x = - 1.5; x <= 1.5; x += 0.1)
        //{
        //    program.Task_1_13(x);
        //}
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
        //for (double x = 0.1; x <= 1; x += 0.05)
        //{
        //    program.Task_3_7(0.1);
        //}
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
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += (double)1 / i;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double S = 0, y = 1;
        for (int i = 1; i <= 9; i++)
        {
            S += Math.Cos(i * x) / y;
            y *= x;

        }
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double S = 0;
        for (int i = 0; i < 10; i++)
        {
            S += ((p + i * h) * (p + i * h));

        }
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y;
        y = 0.5 * x * x - 7 * x;
        Console.WriteLine($"{x,10:F2}   {y,10:F2}");
        answer = Math.Round(y, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int p = 1;
        for (int i = 1; i <= 6; i++)
        {
            p *= i;
        }
        Console.WriteLine("{0:d}", p);
        answer = p;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int S = 0, fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact *= i;
            S += fact;
        }
        Console.WriteLine(S);
        answer = S;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double S = 0;
        double fact = 1, n = -1, x = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact *= i;
            S = S + (n * 5 * x / fact);
            n *= -1;
            x *= 5;
        }
        Console.WriteLine("{0:f2}", S);
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i = 2; i <= 7; i++)
        {
            answer *= 3;
        }

        // end

        return answer;
    }
    public void Task_1_11_a()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i);
        }
        // end

    }
    public void Task_1_11_b()
    {

        // code here
        int x = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(x);
        }

        // end

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double S = 0, y = 1;
        if (x == 0) return 0;
        for (int i = 0; i <= 10; i++)
        {
            S += 1 / y;
            y *= x;
        }
        Console.WriteLine(S);
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1.0) y = 1.0;
        else if (x <= 1.0) y = -x;
        else y = -1.0;
        Console.WriteLine($"{x,10:F1}   {y,10:F1}");
        answer = Math.Round(y, 1);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int p1 = 1, p2 = 1, p3 = 0;
        for (int i = 1; i <= 8; i++)
        {
            p3 = p1 + p2;
            p1 = p2;
            p2 = p3;
            Console.WriteLine(p3);
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double n = 0, x = 1, y = 0;
        for (int i = 1; i <= 5; i++)
        {
            y = x;
            x = y + n;
            answer = (x / y);
            n = y;
        }
        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double S = 0, x = 1;
        for (int i = 1; i <= 64; i++)
        {
            S += x;
            x *= 2;
        }
        S /= 15;
        double y = 1;
        power = (int)Math.Round(Math.Log10(S));
        for (int i = 1; i <= power; i++)
        {
            y *= 10;
        }
        answer = Math.Round(S / y, 2);
        //Console.WriteLine($"{answer} {power}");

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350, d = 0;
        d = (R + x) * (R + x) - (R * R);
        d = Math.Sqrt(d);
        answer = Math.Round(d, 2);
        //Console.WriteLine($"{x} {answer}");

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 1;
        for (int i = 0; i <= (x / 3); i++)
        {
            answer = 10 * k;
            k *= 2;
        }
        //Console.WriteLine(answer);

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        double S = 0, y = Math.Cos(x);
        for (int n = 2; Math.Abs(y) >= 0.0001; n++)
        {
            S += y;
            y = (Math.Cos(n * x)) / (n * n);
            //Console.WriteLine(S);
        }
        answer = S;
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
        double S = a;
        if (h > 0)
            for (double n = 1; S <= p; n++)
            {
                answer += 1;
                S += a + (n * h);
            }
        //Console.WriteLine(answer);
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
            while (Math.Abs(N) >= Math.Abs(M))
            {
                N -= M;
                quotient += 1;
                remainder = Math.Abs(N);
            }
        Console.WriteLine($"{quotient} {remainder}");
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
        double path = 10, S = 10;
        for (int day = 2; day <= 7; day++)
        {
            path *= 1.1;
            S += path;
        }
        //Console.WriteLine(S);
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        int day = 1;
        double path = 10, S = 10;
        while (S <= 100)
        {
            path *= 1.1;
            S += path;
            day++;
        }
        //Console.WriteLine(day);
        answer = day;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        int day = 0;
        double path = 10, S = 10;
        while (path < 20)
        {
            path *= 1.1;
            S += path;
            day++;
        }
        //Console.WriteLine(day);
        answer = day;
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
        for (double L = 0.1; L > 0.0000000001; L /= 2)
        {
            answer += 1;
        }
        //Console.WriteLine(answer);

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
        double S = 1, y = 0;

        // code here
        double ch = 1, zn = 1, answer = 0, n = 1;
        if (zn != 0)
            y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        for (int i = 1; Math.Abs(n) >= 0.0001; i++)
        {
            ch *= x * x;
            zn *= (2 * i) * (2 * i - 1);
            n = ch / zn;
            S += n;
        }
        //Console.WriteLine($"{x,10}\t{y,10}\t{S,10}");
        answer = S;

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here


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
