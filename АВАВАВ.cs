using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        program.Task_2_1(0);
        //program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        program.Task_2_9();
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
            answer += i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i += 1)
            answer += ((double)1 / i);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
            answer += i / (i + 1);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        if (x == 0)
        {
            return 0;

        }
        else
        {
            double x1 = 1;
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(x * i) / x1;
                x1 *= x;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while (i <= 9)
        {
            answer += (p + (h * i)) * (p + (h * i));
            i++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here


        answer = 0.5 * x * x - 7 * x;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        // end
        return answer;


    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        int i = 1;
        while (i <= 6)
        {
            answer *= i;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int i = 1; int a = 1;
        while (i <= 6)
        {
            a *= i;
            answer += a;
            i++;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double n1 = 1; double n2 = 1; int f = 1;
        for (int i = 0; i <= 5; i++)
        {
            f += f * i;
            n1 *= -1;
            n2 *= 5;
            answer += (n1 * n2) / f;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
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
            Console.Write($"{i,2}");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{5,2}");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        int i = 0;
        double a = 1;
        while (i <= 10)
        {
            if (a != 0)
            {
                answer += 1 / a;
                a *= x;
            }
            else
            {
                return 0;
            }
            i += 1;
        }
        answer = Math.Round(answer, 2);
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
        else if (-1 < x & x <= 1)
        {
            answer = -x;
        }
        else { answer = -1; }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int num = 0;
        int a = 1;
        int b = 1;
        Console.Write($"{a,4}");
        Console.Write($"{b,4}");
        for (int i = 3; i <= 8; i++)
        {
            num = a + b;
            Console.Write($"{num,4}");
            a = b;
            b = num;


        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        double num1 = 0;
        double num2 = 0;
        for (int i = 2; i <= 5; i++)
        {
            num1 = a1 + a2;
            num2 = b1 + b2;
            a1 = a2;
            a2 = num1;
            b1 = b2;
            b2 = num2;
        }
        answer = num1 / num2;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;


        // code here
        double power = 0;
        int i = 1;
        double p = 1;
        while (i <= 64)
        {
            p *= 2;
            answer += p;
            i++;
        }
        p /= 15;
        power = Math.Log10(p);
        for (int x = 1; x <= power; x++)
        {
            p /= 10;
        }
        answer = Math.Round(p, 2);
        // end

        return (answer, (int)power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = Math.Round(Math.Sqrt((r + x) * (r + x) - r * r), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int num = 10;
        for (int i = 0; i < x; i += 3)
        {
            num *= 2;
        }
        answer = num;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double e = 0;
        int n = 1;
        while (true)
        {
            answer += e;
            e = Math.Cos(n * x) / (n * n);
            n++;
            if (Math.Abs(e) < 0.0001)
            {
                break;
            }
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
        int n = 0;
        double s = 0;
        if (h > 0)
        {
            while (s < p)
            {
                n++;
                s += (a + n * h);

            }
            answer = n;
        }
        else
        {
            return 0;
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
        if (M == 0)
        {
            return (0, 0);
        }
        else
        {
            while (N >= M)
            {
                quotient++;
                N -= M;
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
        for (int i = 1; i <= 7; i++)
        {
            answer += 10 + answer / 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        int n = 0;
        while (n <= 100)
        {
            answer++;
            n += 10 + n / 10;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double n = 10;
        while (n <= 20)
        {
            answer++;
            n += n / 10;
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
        double n = 0.1;
        while (n >= Math.Pow(10, -10))
        {
            answer++;
            n /= 2;
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
        double S = 1, y = 0;

        // code here
        double up = 0;
        double down = 1;
        double number = 0;
        for (int i = 1; ; i++)
        {
            up = Math.Cos(i * x);
            down *= i;
            number = up / down;
            if (Math.Abs(number) < 0.0001)
            {
                break;
            }
            else
            {
                S += number;
            }
        }
        y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
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