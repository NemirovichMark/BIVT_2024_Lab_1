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
        program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        //program.Task_1_14();
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
        program.Task_3_5(double.Pi/5);
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
        for (int i = 2; i<= 35; i += 3)
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
        for(double i =1; i<= 10; i++)
        {
            answer += (1 / i);
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i = 2;
        while (i <= 112)
        {
            answer += (i / (i+1));
            i += 2;
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double p = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += (Math.Cos(x * i)) / (p);
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        else
        {
            answer = 0;
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += Math.Pow(p + h * i, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 6; i >=1; i--)
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
        int y = 0;
        for (int a = 1; a <= 6; a++)
        {
            y = 1;
            for (int b = a; b >= 1; b--)
            {
                y *= b;
            }
            answer += y;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int f;
        for (int i = 1; i<=6; i++)
        {
            double s = 1;
            f = 1;
            for (int a = i; a >= 1; a--)
            {
                f *= a;
                s *= 5;
            }
            answer += (1 -(i%2)*2) * s / f;
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
        for(int i = 1; i<=7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1;i<=6 ; i++)
        {
            Console.Write($"{i}");
            if (i < 6)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine(",");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5");
            if (i < 6)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine('.');
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double p = 1;
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        else
        {
            answer = 0;
        }
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
        if (-1 <= x & x<= 1)
        {
            answer = -x;
        }
        if (x >1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c = 0;
        Console.WriteLine(1);
        for (int i = 0; i<=6; i++)
        {
            Console.WriteLine(b);
            c = a;
            a = b;
            b = a + c;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 0, b = 1, c = 0;
        for (double i = 1; i <= 5; i++)
        {
            answer = (a+b) / b;
            c = a;
            a = b;
            b = a + c;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double p = 2;
        for (int i = 1; i < 64; i++)
        {
            answer += p;
            p *= 2;
        }
        power = (int)Math.Log10(answer / 15);
        answer = Math.Round(answer / 15_000_000_000_000_000_000,2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt((Math.Pow(R + x, 2) - Math.Pow(R, 2)));
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int n = 10,i =0;
        while (i < x)
        {
            i += 3;
            n *= 2;
        }
        answer = n;
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
        double n = 1;
        while (Math.Abs(Math.Cos(n * x) / Math.Pow(n, 2)) >= 0.0001)
        {
            answer += Math.Cos(n * x) / Math.Pow(n, 2);
            n++;
        }
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int l = 1;
        int p = -2;
        while (l <= 30_000)
        {
            p += 3;
            l *= p;
        }
        answer = p-3; // -3 т.к лишний раз заходим в цикл
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
        answer = 1;
        double p = x * x;
        x = p;
        if (x < 1)
        {
            while (x*p >= 0.0001)
            {
                answer += x;
                x *= p;
            }
            answer = Math.Round(answer, 2);
        }
        else
        {
            answer = 0;
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
        int n = 10;
        while (n < 100_000)
        {
            answer += 3;
            n *= 2;
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
        double w = 10000;
        while (w < 20000)
        {
            answer += 1;
            w = w * 1.08;
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
        double a = 0, b = 1, c = 0,e=0,p=0;
        int k = 0;
        do
        {
            k += 1;
            p = e;
            e = (a + b) / b;
            c = a;
            a = b;
            b = a + c;
        }
        while (Math.Abs(e - p) >= 0.001);
        answer = k;
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
        double S = 0, y = 0, f =1, xs=1;

        // code here
        for(double i=0; ;i++)
        {
            if (i > 0)
            {
                f = f * i;
            }
            if (xs / f<0.0001)
            {
                break;
            }
            S += xs / f;
            y = Math.Pow(double.E,2*x);
            xs *= 2 * x;
        }
        S = Math.Round(S, 2);
        y= Math.Round(y, 2);
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