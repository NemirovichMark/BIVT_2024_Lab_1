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
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.1);
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
            s += i;
        answer += s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        double a = 1.0;
        for (int i = 1; i <= 10; i++)
            s += a / i;
        answer += Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double one = 1.0;
        double s = 0;
        for (int a = 2; a <= 112; a += 2)
            s = s + a / (a + one);
        answer += Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double y = 1;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 9; i++)
        {
            s += Math.Cos(i * x) / y;
            y *= x;
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
            s += (p + (i * h)) * (p + (i * h));
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
        double y = 1;
        for (double i = -4; i <= 4; i += 0.5)
        {
            y = 0.5 * (x * x) - 7 * x;
        }
        answer = Math.Round(y, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        const int n = 6;
        int p = 1;
        for (int i = 2; i <= n; i++)
        {
            p = p * i;
        }
        answer = p;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int n = 1, s = 1;
        for (int i = 2; i <= 6; i++)
        {
            n *= i;
            s += n;
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
        double z = 1;
        double c = (-5);
        for (int i = 1; i <= 6; i++)
        {
            z *= i;
            s += (c / z);
            c *= (-5);
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
        int a = 3;
        for (int i = 1; i < 7; i++)
        {
            a *= 3;
        }
        answer = a;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int x = 1; x <= 6; x++)
        {
            x += 1;
            Console.WriteLine(x);
        }
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double n = 1, s = 1;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 10; i++)
        {
            n /= x;
            s += n;
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
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        if (-1 < x && x <= 1)
        {
            y = -x;
        }
        if (x > 1)
        {
            y = -1;
        }
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1, y = 0;
        Console.WriteLine(x);
        for (int i = 1; i < 8; i++)
        {
            int sum = x + y;
            Console.WriteLine(sum);
            x = sum;
            y = x;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 1, y = 0;
        for (int i = 1; i <= 5; i++)
        {
            double sum = x + y;
            y = x;
            x = sum;
        }
        answer = x / y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        ulong k = 1;
        for (int i = 0; i < 64; i++)
        {
            answer += k / 15.0;
            k *= 2;
        }
        power = (int)Math.Log10(answer);
        for (int i = 0; i < power; i++)
        {
            answer /= 10;
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        Console.WriteLine(power + " " + answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        double d = 0;
        double dr = 0;
        dr = ((R + x) * (R + x)) - (R * R);
        d = Math.Sqrt(dr);
        answer = Math.Round(d, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        // code here
        for (int i = 3; i <= x; i += 3)
        {
            answer *= 2;
            Console.WriteLine(answer);
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
        int p = 1, n = 1;
        const int l = 30000;
        while (p * n <= l)
        {
            n += 3;
            p *= n;
            answer = n;
        }
        Console.WriteLine(answer);
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
        double s = 1, y = 1;
        const double eps = 0.0001;
        if (Math.Abs(x) >= 1)
            return 0;
        while (Math.Abs(y) >= eps)
        {
            y *= x * x;
            s += y;
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
        int k = 10, t = 0;
        while (k <= Math.Pow(10, 5))
        {
            t += 3;
            k *= 2;
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
        int t = 0;
        while (s <= 20000)
        {
            t += 1;
            s += s * 0.08;
        }
        answer = t;
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
        int answer = 2;

        // code here;
        double drob1 = 1 / 1, drob2 = 2 / 1, x = 2, y = 1;
        while (Math.Abs(drob2 - drob1) > 0.001)
        {
            answer += 1;
            double sum = x + y;
            drob1 = drob2;
            y = x;
            x = sum;
            drob2 = x / y;
        }
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
            a = p * (x1 / ((4 * i * i) - 1));
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
