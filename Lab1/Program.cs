using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
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
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int t = 0;
        

        for (int i = 2; i <= 35; i += 3)
        {
            t += i;
        }
        answer = t;

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        int n = 10; double t = 0;
        for (int i = 1; i <= n; i++)
        {
            t += 1.0 / i;
        }
        answer = Math.Round(t, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double t = 0; int numerator = 2;
        int denominator = 3;
        while (denominator <= 113)
        {
            t += (double)numerator / denominator; numerator += 2;
            denominator += 2;
        }
        answer = Math.Round(t);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if(x > 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / (Math.Pow(x, (i - 1)));
            }
        }
        else
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int k = 0; k <= 9; k++)
        {
            double term = (p + k * h) * (p + k * h); answer += term;
        }

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x; answer = Math.Round(answer, 2);
        Console.WriteLine(x);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1; for (int i = 1; i <= 6; i++)
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
        for (int i = 1; i <= 6; i++)
        {
            int q = 1; for (int j = 1; j <= i; j++)
            {
                q *= j;
            }
            answer += q;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        int n = 6;
        
        int sign = -1;
        int baseNumber = 5;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            int power = 1;
            for (int j = 0; j < i; j++)
            {
                power *= baseNumber;
            }

            answer += sign * (double)power / factorial;
            sign *= -1;
            factorial *= (i + 1);
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int o = 1;

        for (int i = 0; i <= 6; i++)
        {
            o *= 3;
        }
        answer = o;

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(); for (int i = 0; i < 6; i++)
        {
            Console.Write("5 ");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double s = 1.0; for (int i = 1; i <= 10; i++)
            {
                double cashe_x = 1; for (int q = 1; q <= i; q++)
                {
                    cashe_x *= x;
                }
                s += 1.0 / cashe_x;
                answer = Math.Round(s, 2);
            }
        }

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double k = -1.5; k <= 1.5; k += 0.1)
        {
            if (k <= -1) { Console.WriteLine(1); }
            if (k > 1) { Console.WriteLine(-1); }
            if (k > -1 && k <= 1) { Console.WriteLine(Math.Round((-1 * k), 2)); }
        }

        if (x <= -1)
        {
            answer = 1;
        }
        if (x > 1)
        {
            answer = -1;
        }
        if (x > -1 && x <= 1)
        {
            answer = -1.0 * x;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        Console.Write(a + " " + b + " ");

        for (int i = 2; i < 8; i++)
        {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }


        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 1;
        double y = 1;
        double w = 2;
        double z = 1;

        for (int i = 2; i < 5; i++)
        {
            double chisl = x + w;
            double znam = y + z;
            x = w;
            y = z;
            w = chisl;
            z = znam;
            answer = w / z;
            Console.WriteLine(answer);
        }


            // end

            return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zerno = 1; for (int i = 1; i < 65; i++)
        {
            answer += zerno;
            zerno *= 2;

        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        double ter = 1; for (int q = 1; q <= power; q++)
        {
            ter *= 10;
        }
        answer = Math.Round(Math.Abs(answer) / ter, 2);


        // end


        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt(2 * R * x + x * x);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end
        
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer += 10;
        for (int i = 1; i <= (x / 3);i++) {
            answer = answer * 2;
        }
        Console.Write(answer);
        
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

       
        double epsilon = 0.0001;
        
        int n = 1;
        double denominator = 1;

        while (true)
        {
            double term = Math.Cos(n * x) / (n * n);
            if (Math.Abs(term) < epsilon)
            {
                break;
            }
            answer += term;
            n++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        int n = 0;
        double summ;

        do
        {
            summ = a + n * h;
            if (summ <= 0 && h <= 0)
            {
                answer = 0;
                break;
            }
            s += summ;
            n++;
        } while (s <= p);

        answer = n - 1;
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
        {
            N = Math.Abs(N);
            M = Math.Abs(M);
            while ((N - M) >= 0)
            {
                N -= M;
                quotient++;
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
        double step = 10.0;
        for (int i = 1; i <= 7; i++)
        {
            answer += step;
            step *= 1.1;
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, step = 10.0;
        while (s < 100.0)
        {
            s += step;
            step *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double step = 10.0;
        while (step <= 20.0)
        {
            step *= 1.1;
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

        // code here;

        double L = 0.1; double D = 1;
        for (int i = 0; i < 10; i++)
        {
            D *= 0.1;
        }
        while (L > D)
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
        double eps = 0.0001, i = 0.0; int sign = (i % 2 == 0) ? 1 : -1; 
        double currSum = 1; 
        for (int j = 0; j < 2 * i+1; j++)
        {
            currSum *= x;
        }
        currSum *= sign;
        while (Math.Abs(currSum) >= eps)
        {
            S += currSum; i++;
            int ign = (i % 2 == 0) ? 1 : -1;
            double sum = 1; for (int j = 0; j < 2 * i + 1; j++) sum *= x;

            currSum = ign * sum / (2 * i + 1);
        }
        y = Math.Round(Math.Atan(x), 2); S = Math.Round(S, 2);
        // end

        return (S, y);
    }
    #endregion
}
