using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
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
        program.Task_3_7(0.1);
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
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i += 1)
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
        double deg = 1;
        // code here
        if (x != 0)
        
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / deg;
                deg *= x;
            }
        }
        answer =Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x,2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i += 1)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int F = 1; 
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            F *= i;
            answer += F;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double F = 1, deg = -5;
        for (int i = 1; i <= 6; i++)
        {
            F *= i;
            answer += deg / F;
            deg *= -5;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        // code here
        for (int i = 0; i < 7; i++)
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
            Console.WriteLine(i);
        }
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double deg = 1;
        // code here
        if (x > 0)
            for (int i = 1; i <= 11; i++)
            {
                answer += 1/deg;
                deg *= x;
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
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0, b = 1, c = 1;
        for (int i = 1; i <= 8; i++)
        {
            Console.WriteLine(c);
            c = a + b;
            a = b;
            b = c;
            
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 0, b = 1, c = 1;
        for (double i = 0; i <= 5; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        answer = Math.Round(c / a, 1);
        
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        ulong amount = 1;
        for (int i = 0; i < 64; i++)
        {
            answer += amount / 15.0;
            amount *= 2;

        }
        power = (int)Math.Log10(answer);
        for (int i = 0; i < power; i++)
            answer /= 10;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R),2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        // code here
        while (x > 0)
        {
            x -= 3;
            answer *= 2;
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
        for (int n = 1; Math.Abs(Math.Cos(n * x)/(n * n)) >= 0.0001; n += 1)
        {
            answer += Math.Cos(n * x) / (n * n);
        }
        // end
        Console.WriteLine(answer);
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
        double sum = 0;
        if  ((h > 0 && p > 0) || (h < 0 && p < 0))
        {
            while (sum <= p)
            {
                answer += 1;
                sum += a + h * answer;

            }
        }
        // end
        Console.WriteLine(answer);
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
        if (N > 0 && M > 0)
        {
            while (N >= M)
            {
                quotient += 1;
                N -= M;
            }
            remainder = N;
        }
        Console.WriteLine(remainder);
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
        double km = 10;
        // code here
        for (int i = 0; i < 7; i++)
        {
            answer += km;
            km *= 1.1;
        }
        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double km = 10;
        double sum = 100;
        // code here
        while (sum > 0)
        {
            sum -= km;
            km *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double km = 10;
        // code here
        while (km <20)
        {
            km *= 1.1;
            answer += 1;

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
        double L = 0.1;
        // code here;
        while (L > 0.0000000001)
        {
            L /= 2;
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
        double i = 1, F = 1, E = 1, deg = 1;
        while (Math.Abs(E) > 0.0001)

        {
            E = deg / F;
            if (Math.Abs(E) > 0.0001) S += E;
            else break;
            i += 2;
            F *= (i - 2) * (i - 1);
            deg *= x * x;
            y = (Math.Exp(x) + Math.Exp(-x)) / 2;
            
        }
        // end
        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;
        
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
