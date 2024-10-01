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
        int s = 0, x = 2, n = 3;
        while (x <= 35)
        {
            s += x;
            x += n;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0, x = 1, n = 1, a = 0;
        while (n <= 10)
        {
            a = x / n;
            s += a;
            n += 1;
        }
        answer = s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0, x = 2, n = 3, a = 0;
        while ((x <= 112) && (n <= 113))
        {
            a = x / n;
            s += a;
            n += 2;
            x += 2;
        }
        answer = s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, y = 1;
        int i = 1;
        if (x == 0)
        {
            answer = 0;
            Console.WriteLine(answer);
        }
        else
        {
            while (i <= 9)
            {
                s += Math.Cos(i * x) / y;
                i += 1;
                y *= x;
            }
            answer = s;
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        int i = 0;
        while (i <= 9)
        {
            s += ((p + i * h) * (p + i * h));
            i++;
        }
        answer = s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        s = 0.5 * x * x - 7 * x;
        answer = s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int n = 6, p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * i;
        }
        answer = p;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int n = 6, p = 1, s = 1;
        for (int i = 2; i <= n; i++)
        {
            p = p * i;
            s += p;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        for (double i = 1, a = 1, b = 1; i <= 6; i++)
        {
            b *= 5 / i;
            a = -a;
            s += a * b;
            answer = s;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 3;
        answer = x * x * x * x * x * x * x;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string a = " ", b = " ";
        for (int i = 1; i <= 6; i++) 
        { 
            a += " " + i.ToString();
            b += " 5";
        }
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine(b);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, n = 0, p = 1;
        if (x == 0) return answer;
        while (n <= 10)
        {
            s += 1 / p;
            p *= x;
            n++;
        }
        answer = s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        if (x <= -1)
        {
            s = 1;
        }
        else if ((-1 < x) && (x <= 1))
        {
            s = -x;
        }
        else if (x > 1)
        {
            s = -1;
        }
        answer = s;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0, b = 1, i = 1, k = 0;
        while (i <= 8)
        {
            Console.WriteLine(b);
            k = a + b;
            a = b;
            b = k;
            i++;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double s = 0, c=0;
        for (double a = 1, b = 1, i = 1; i <= 5; i++)
        {
            s = a / b;
            c = a;
            a += b;
            b = c;
        }
        answer = s;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        int i = 0;
        while (i < 64)
        {
            i += 1;
            n *= 2;
        }
        n /= 15;
        power = (int)Math.Log10(n);
        answer = Math.Round(n / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350, s=0, a=0;
        a = Math.Sqrt((R + x)*(R + x) - R*R);
        s = Math.Round(a, 2);
        answer = s;
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int s=10;
        for (int step = 1; step <= x/3; step+=1)
        {
            s*= 2; 
        }
        answer = s;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double n = 1, y = Math.Cos(x);
        while (Math.Abs(y) >= 0.0001)
        {
            answer += y;
            n++;
            y = Math.Cos(n*x) / (n*n);
        }
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
        double s = 0;
        for (int n = 0; s <= p; n+=1)
        {
            s += a + n*h;
            if ((a < Math.Abs(h)) && (h < 0))
            {
                break;
            }
            answer = n;
        }
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
        if (M == 0) return (quotient, remainder);
        for (remainder = N; remainder >= M;)
        {
            quotient+=1;
            remainder -= M;
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
        double n = 1, p = 10;
        while (n <= 7)
        {
            answer += p;
            p += p / 10;
            n += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double p = 10, n = 0;
        while (n < 100)
        {
            answer += 1;
            n += p;
            p += p / 10;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double p = 10;
        while (p <= 20)
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

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double l = 0.1;
        while (l > 1E-10)
        {
            l = l / 2;
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
        for (double i = 1, l = 1, p = x, n = x; Math.Abs(n) >= 0.0001; i+=1)
        {
            S += n;
            l = -l;
            p *= x * x;
            n = l  * p / (2 * i + 1);
        }
        y = Math.Atan(x);
        // end

        return (S, y);
    }
    #endregion
}