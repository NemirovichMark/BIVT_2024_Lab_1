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
        int s = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            s += i;
        }
        answer = s;
        Console.WriteLine(s);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s += 1 / i;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2; i <= 112; i += 2)
        {
            s += i / (i + 1);
        }
        s = Math.Round(s, 2);
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double i = 1, y = 1;
        if (x != 0)
        {
            while (i <= 9)
            {
                s += Math.Cos(i * x) / y;
                y *= x;
                i++;
            }
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);

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
            s += (p + i * h) * (p + i * h);
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        y = 0.5 * x * x - 7 * x;
        answer = Math.Round(y, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
        }
        answer = f;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            s += f;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        double f = 1, p = -1, k = 5;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            s += p * k / f;
            p *= -1;
            k *= 5;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3;
        for (int i = 1; i < 7; i++)
        {
            s *= 3;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string s = "";
        string s1 = "";
        for (int i = 1; i <= 6; i++)
        {
            s += "" + i.ToString();
            s1 += " 5";
        }
        Console.WriteLine($" {s}, {s1}");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, k = 1;
        if (x != 0)
        {
            for (int i = 0; i <= 10; i++)
            {
                s += 1 / k;
                k *= x;
            }
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        while (x <= -1) return 1;
        while (x > -1 && x <= 1) return -x;
        while (x > 1) return -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 0, y = 1;
        int s = 0;
        for (int i = 0; i <= 8; i++)
        {
            Console.Write($" {y}");
            s = x + y;
            x = y;
            y = s;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double s = 0; //answer
        double x = 1, y = 1, z; //числитель, знаменатель и замена
        double i = 1; //счётчик
        while (i <= 5)
        {
            s = x / y;
            z = x;
            x += y;
            y = z;
            i++;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1;
        for (int i = 0; i < 64; i++)
        {
            s *= 2;
        }
        s /= 15;
        power = (int)Math.Log10(s);
        s /= Math.Pow(10, power);
        answer = Math.Round(s, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        double S = (R + x) * (R + x) - (R * R);
        S = Math.Sqrt(S);
        answer = Math.Round(S, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int s = 10; //клеток изначально
        for (int i = 1; i <= x / 3; i++) //время
        {
            s *= 2;
        }
        answer = s;
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int L = 30000;
        int p = 1;
        for (int n = 1; p * n < L; n += 3)
        {
            p *= n;
            answer = n;
            Console.WriteLine(answer);
        }
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
        double s = 0, y = 1;
        for (int i = 0; y > 0.0001 && Math.Abs(x) < 1; i += 2)
        {
            s += y;
            y *= x * x;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
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
        int s = 100000, s1 = 10, t = 0;
        while (s1 < s)
        {
            t += 3;
            s1 *= 2;
        }
        answer = t;
        Console.WriteLine(answer);
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
        int s = 0, i = 10, k = 0;
        while (s < 100)
        {
            s += i;
            i += i / 10;
            k++;
        }
        answer = k;
        Console.WriteLine(answer);
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
        int v = 0; //время
        while (s < 20000)
        {
            v++;
            s += s * 0.08;
        }
        answer = v;
        Console.WriteLine(answer);
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
        double x = 1, y = 1, z;
        int s = 1;
        double w = 0; //предыдущее число
        while (Math.Abs(x / y - w) > 0.001)
        {
            w = x / y;
            z = x;
            x += y;
            y = z;
            s++;
        }
        answer = s;
        Console.WriteLine(answer);
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
        S = 1;
        double f = 1, p = x * x, k = 1;
        for (double i = 1; Math.Abs(k) >= 0.0001; i++)
        {
            f *= i;
            k = (2 * i + 1) * p / f;
            S += k;
            p *= x * x;
        }
        S -= k;
        y = (1 + 2 * x * x) * Math.Exp(x * x);
        Console.WriteLine($"{S}, {y}");
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