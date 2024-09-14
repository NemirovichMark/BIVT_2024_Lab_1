using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        //program.Task_2_1(1.6);
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
        //program.Task_3_6(0.2);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int k = 2; k <= 35; k += 3) { answer += k; }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double k = 1; k <= 10; k++) { answer += 1 / k; }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double k = 2; k <= 112; k += 2) { answer += k / (k + 1); }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return answer; // division by zero is not possible
        for (double k = 1, y=1; k <= 9; k++)
        {
            answer += Math.Cos(k * x) / y;
            y *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double n = 0; n <= 9; n++) { answer += (p + n * h) * (p + n * h); }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int k = 1; k <= 6; k++) { answer *= k; }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1, f=1; i <= 6; i++)
        {
            f *= i;
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double i = 1, k = 1, f=1; i <= 6; i++)
        {
            f *= 5 / i;
            k = -k;
            answer += k*f;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int step = 1; step < 7; step++) { answer *= 3; }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        string a="", b="";
        for (int i = 1; i <= 6; i++) { a += " "+i.ToString(); b += " 5"; }
        Console.WriteLine($"{a}\n{b}");
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return answer; // can't divide by 0
        for (double p = 1, i=0; i <= 10; i++)
        {
            answer += 1 / p;
            p *= x;
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
        else if (-1 < x && x <= 1) answer = -x;
        else if (x > 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        for (int a = 0, b = 1, i=1; i <= 8; i++)
        {
            Console.Write($" {b}");
            int k = a + b;
            a = b; b = k;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double a = 1, b = 1, c, i = 1; i <= 5; i++)
        {
            answer = a / b;
            c = a;
            a += b;
            b = c;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code 
        double n = 1;
        for (int i = 0; i < 64; i++, n *= 2) ;
        n /= 15;
        power = (int) Math.Log10(n);
        answer = Math.Round(n / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int step = 1; step <= x / 3; step++) { answer *= 2; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        for (double n = 1, y= Math.Cos(x); Math.Abs(y) >= 0.0001; )
        {
            answer += y;
            n++;
            y = Math.Cos(n * x) / (n * n);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        for (int n = 1, p = 1; p * n < 30000; n += 3)
        {
            p *= n;
            answer = n;
        }
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0;
        for (int n = 0; s <= p; n++)
        {
            s += a + n * h;
            if (a < Math.Abs(h) && h < 0) { break; } // if the amount is negatively infinite, return 0
            answer = n;
        }
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        for (double y=1; Math.Abs(x) < 1 && y > 0.0001;)
        {
            answer += y;
            y *= x * x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M == 0) return (quotient, remainder);
        for (remainder = N; Math.Abs(remainder) >= Math.Abs(M);)
        {
            quotient++;
            remainder -= M;
        }
        remainder = Math.Abs(remainder);
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here
        for (int n = 10; n <= 100000; n *= 2, answer += 3) ;
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        for (double n=1, p=10; n<=7; n++)
        {
            answer += p;
            p += p / 10;
        }
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        for (double p = 10, s=0; s < 100; answer++, s+=p, p+=p/10) ;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double p = 10;
        while (p<=20)
        {
            p += p / 10;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        for (double a = 10000; a < 20000; answer++, a += 8 * a / 100) ;
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double l = 0.1;
        while (l>1E-10)
        {
            l /= 2;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        answer = 1;
        for (double a = 1, b = 1, c, prev=0; Math.Abs(a / b - prev) > 0.001;)
        {
            prev = a / b;
            c = a;
            a += b;
            b = c;
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
        S = 1;
        double n=1, i = 1, fact=1, num=1, k=1;

        for (; Math.Abs(n) >= 0.0001; i+=1)
        {
            k = -k;
            num *= x * x;
            fact *= 4 * i * i - 2 * i;
            n = k * num / fact;
            S += n;
        }

        y = Math.Round(Math.Cos(x), 2, MidpointRounding.ToEven);
        S = Math.Round(S, 2, MidpointRounding.ToEven);
        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 1, k = x, n = 1; Math.Abs(k) >= 0.0001; i++)
        {
            n = k * Math.Sin(i * Math.PI / 4);
            S += n;
            k *= x;
        }
        y = x * Math.Sqrt(2) / (2 - 2 * Math.Sqrt(2) * x + 2 * x * x);

        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here
        S = 1;
        for (double i = 1, f = 1, n = 1; Math.Abs(n) >= 0.0001; i++)
        {
            f *= i;
            n = Math.Cos(i * x) / f;
            S += n;
        }
        y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here
        S = 1;
        for (double i=1, f=1, p=x*x, n=1; Math.Abs(n)>=0.0001; i++)
        {
            f *= i;
            n = (2 * i + 1) * p / f;
            S += n;
            p *= x * x;
        }
        y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i=1, k=-1, n=1; Math.Abs(n)>=0.0001; i++)
        {
            n = k * Math.Cos(i * x) / (i * i);
            S += n;
            k = -k;
        }
        y = (x * x - Math.PI * Math.PI / 3) / 4;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i=1, k=1, p=x*x*x, n=1; Math.Abs(n)>=0.0001; i++)
        {
            n = k * p / (4 * i * i - 1);
            S += n;
            k = -k;
            p *= x * x;
        }
        y = (1 + x * x) * Math.Atan(x) / 2 - x/2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here
        S = 1;
        for (double i = 1, p = x*x, f = 1, n = 1; Math.Abs(n) >= 0.0001; i++)
        {
            f *= 2 * i * (2 * i - 1);
            n = p / f;
            S += n;
            p *= x * x;
        }
        y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here
        S = 1;
        for (double i=1, f=1, p=2*x, n=1; Math.Abs(n)>=0.0001; i++)
        {
            f *= i;
            n = p / f;
            S += n;
            p *= 2 * x;
        }
        y = Math.Pow(Math.E, 2 * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i=0, k=1, p=x, n=1; Math.Abs(n)>=0.0001; i++)
        {
            n = k * p / (2 * i + 1);
            S += n;
            k = -k;
            p *= x * x;
        }
        y = Math.Atan(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    #endregion
}
