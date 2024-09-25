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
        //program.Task_1_18(3);
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

        int i = 2;
        while (i <= 35)
        {
            answer += i;
            i += 3;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        double i = 1;
        while (i <= 10)
        {
            answer += 1 / i;
            i += 1;
        }
        answer = Math.Round(answer, 2);
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
            answer += i / (i + 1);
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

        if (x == 0) return 0;

        int i = 1;
        double znam = 1;
        while (i <= 9)
        {
            answer += Math.Cos(x * i) / znam;
            i ++;
            znam *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        double b = 0;
        int i = 0;
        while (i <= 9)
        {
            answer += (p + b) * (p + b);
            i ++;
            b += h;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        answer = Math.Round(0.5 * x * x - 7 * x, 2); 
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here

        answer += 1; ;
        for (int i = 1; i < 7; i++)
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

        int CurrentNumber = 1, CurrentF;
        while (CurrentNumber <= 6)
        {
            CurrentF = 1;
            for (int i = 1; i <= CurrentNumber; i++)
            {
                CurrentF *= i;
            }
            answer += CurrentF;
            CurrentNumber++;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        double a = 1, b = 1, f = 1;
        for (int i = 1; i <= 6; i ++)
        {
            a *= -1;
            b *= 5;
            f *= i;
            answer += a * b / f;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        answer ++;
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
            Console.Write($"{i} "); //a)
            //Console.Write("5 "); //b)
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        if (x == 0) return 0;
        double a = x;
        for (int i = 1; i <= 11; i++)
        {
            a /= x;
            answer += a;
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

        int P1 = 1, P2 = 1, n;
        Console.Write($"{P1} {P2} ");
        for (int i = 3; i <= 8; i++)
        {
            n = P1 + P2;
            Console.Write($"{n} ");
            P1 = P2;
            P2 = n;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        double c1 = 1, z1 = 1, c2 = 2, z2 = 1, c, z;
        for (int i = 3; i <= 5; i++)
        {
            c = c1 + c2;
            z = z1 + z2;
            answer = c / z;
            c1 = c2;
            z1 = z2;
            c2 = c;
            z2 = z;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double power = 0;

        // code here

        double Current = 1, sm = 0;
        for (int i = 1; ;i++)
        {
            sm += Current;
            Current *= 2;
            if (i == 64) break;
        }
        answer = Math.Round(sm / 15000000000000000000, 2);
        power = Math.Log10(sm / 15);
        // end

        return (answer, (int) power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        const int r = 6350;
        answer = Math.Round(Math.Sqrt((x + r) * (x + r) - r * r), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        int count = 10;
        for (int i = 0; i < x; i += 3)
        {
            count *= 2;
        }
        answer = count;
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

        int r = 1, n = 1;
        const int limit = 30000;
        do
        {
            n += 3;
            r *= n;
        } while (r <= limit && (r * (n + 3)) <= limit );

        answer = n;
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

        if (x == 1) return 0;
        double current = 1;
        while (current >= 0.0001)
        {
            answer += current;
            current *= x * x;
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

        int t = 0, total = 10;
        while (total < 100000)
        {
            total *= 2;
            t += 3;
        }
        answer = t;
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

        int counter = 0;
        const int target = 20000;
        double total = 10000;
        while (total < target)
        {
            total *= 1.08;
            counter++;
        }
        answer = counter;
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

        double c1 = 1, c2 = 2, c = 3, z1 = 1, z2 = 1, z = 2;
        int number = 3;
        const double TargetDifference = 0.001;
        while (Math.Abs(c2/z2 - c/z) > TargetDifference)
        {
            c1 = c2;
            z1 = z2;
            c2 = c;
            z2 = z;
            c = c1 + c2;
            z = z1 + z2;
            number += 1;
        }
        answer = number;
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

        double sm = 1, n = 1, f = 1;
        for (int i = 0; ; i++)
        {
            if ((sm * n) / f < 0.0001) break;
            S += (sm * n) / f;
            sm += 2;
            n *= x * x;
            f *= (i + 1);
        }
        y = Math.Round((1 + 2 * x * x) * Math.Exp(x * x), 2);
        S = Math.Round(S, 2);
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