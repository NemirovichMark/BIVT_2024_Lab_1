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
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        for (double x = 0.1; x <= 1; x += 0.1)
        {
        program.Task_3_4(x);
        }
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
        int i = 0;
        for (i = 2; i <= 35; i += 3)
        {
            answer = answer + i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
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
        double y = 1;
        int i = 1;
        for (; i <= 9;)
        {
            answer += Math.Cos(i * x) / y;
            i++;
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
        for(int i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        const double xn = -4.0, xv = 4.0, h = 0.5;
        answer = 0.5 * x*x - 7 * x;
        x += h;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        const int n = 6;
        for (int i = 2; i <= n; i++)
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
        int s = 1;
        for (int i = 0; i <= 5; i++)
        {
            s *= (i + 1);
            answer += s;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double ch = 1, zn = 1;
        int sign = 1;
        for(int n = 1; n <= 6; n++)
        {
            sign = -sign;
            ch *= 5;
            zn *= n;
            answer += sign * ch / zn;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for(int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("{0} ", 5);
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double ch = 1, zn = 1;
        for(int i = 0; i <= 10; i++)
        {
            answer += ch / zn;
            zn *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        else if (x > 1) return -1;
        else return -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c;
        Console.Write($"{a} {b} ");
        for (int i = 0; i < 6; i++)
        {
            c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1, zn = 1, x = 0, c = 0;
        for (int i = 1; i < 6; i++)
        {
            c = ch / zn;
            x = ch;
            ch += zn;
            zn = x;
        }
        answer = Math.Round(c, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        BigInteger z = 0; // всего зерен
        BigInteger k = 1; // зерно в клетке
        for(int i = 0; i < 64; i++)
        {
            z += k;
            k *= 2;
        }
        BigInteger a = z / 15;
        answer = (double)a;
        while(answer >= 10)
        {
            answer = answer / 10;
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
        double r = 6350;
        answer = Math.Sqrt(2*r*x + x*x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int c = 1;
        for (int i = 0; i < x/3; i++)
        {
            c *= 2;
        }
        answer = 10 * c;
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
        double p = 1;
        int n = 1;
        while(n*p < 30000)
        {
            p *= n;
            n += 3;
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
        double a = 1;
        if (Math.Abs(x) >= 1) return 0;
        for (int i = 1; Math.Abs(a) >= 0.0001; i++)
        {
            answer += a;
            a *= x * x;
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
        for (int c = 10; c < 100000; c *= 2)
        {
            answer += 3;
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
        double p = 10000;
        int mounth = 0;
        for (; p < 20000; )
        {
            p *= 1.08;
            mounth++;
        }
        answer = mounth;
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
        double ch = 1, zn = 1, x = 0;
        double c = 0, p = 0;
        do
        {
            p = c;
            c = ch / zn;
            x = ch;
            ch += zn;
            zn = x;
            answer++;
        } while (Math.Abs(c - p) > 0.001);
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
        double a = 1, ch = 1, zn = 1;
        for(int i = 1; Math.Abs(a) >= 0.0001; i++)
        {
            S += a;
            ch *= x*x;
            zn *= i;
            a = (ch * (2*i + 1)) / zn;
        }
        y = (1 + 2 * x*x) * Math.Pow(Math.E, x*x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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