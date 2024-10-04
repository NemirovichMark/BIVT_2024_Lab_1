using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Resolvers;

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
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        program.Task_1_14();
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
        program.Task_3_2(0.1);
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
        int i;
        for (i = 2; i <= 35; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i += 1)
            answer += 1/(double)i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
            answer += i/(double)(i+1);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double st = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / st;
            st *= x;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i = i + 1)
            answer += (p + i * h) * (p + i * h);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double h = 0.5;
        answer = 0.5 * x * x - 7 * x;
        x += h;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i += 1)
            answer *= i;
            // end

            return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int p = 1;
        for (int i = 1; i <= 6; i += 1)
        {
            p *= i;
            answer += p;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double p = 1, k = 1, x = 1;
        for (double i = 1; i <= 6; i++)
        {
            k *= -1;
            x *= 5;
            p *= i;
            answer += (k * x / p);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int i;
        for (i = 1; i <= 7; i += 1)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("a): 1 2 3 4 5 6");
        Console.WriteLine("б): 5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // code here
        double p = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 11; i++)
            {
                answer += 1.0 / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int p = 1, n = 0;
        for (int i = 1; i <= 8; i++)
        {
            int s = p;
            p += n;
            n = s;
            Console.WriteLine(n);
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int ch1 = 1, ch2 = 2, zn1 = 1, zn2 = 1, save = 1;
        for (int i = 2; i <= 5; i++)
        {
            save = ch2;
            ch2 += ch1;
            ch1 = save;
            save = zn2;
            zn2 += zn1;
            zn1 = save;
        }
        answer = Math.Round(((double)ch2 / zn2), 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double s = 1;

        // code here
        for (int i = 0; i <= 63; i++)
        {
            answer += s;
            s *= 2;
        }

        answer /= 15;
        power = (int) Math.Log10(answer);
        for (int i = 1; i <= power; i++)
            answer /= 10;
        answer = Math.Round(answer, 2);
        // end

        return (answer, (int) power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = (r + x) * (r + x) - (r * r);
        answer = Math.Round(Math.Sqrt(answer), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int w = 1; w <= x; w++)
        {
            if (w % 3 == 0)
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;

        // code here
        int p = 1;
        while (p <= 30000)
        {
            answer += 3;
            p *= answer;
        }
        // end

        return (answer - 3);
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
        double answer = 1;

        // code here
        if (Math.Abs(x) < 1)
        {
            for (double z = 1; z > 0.0001; z *= (x * x))
                answer += z;
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
        int k = 10;
        while (k <= Math.Pow(10, 5))
        {
            k *= 2;
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
        double s = 10000;
        while (s < 20000)
        {
            s *= 1.08;
            answer += 1;
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
        int i = 1, ch1 = 1, ch2 = 2, zn1 = 1, zn2 = 1, save = 1;
        double d = 0;
        while (true)
        {
            i++;
            double d1 = (double) ch1 / zn1;
            double d2 = (double) ch2 / zn2;
            d = Math.Abs(d2 - d1);
            if (d < 0.001) 
                break;
            save = ch2;
            ch2 += ch1;
            ch1 = save;
            save = zn2;
            zn2 += zn1;
            zn1 = save;
        }
        answer = i;
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
        double n = 1;
        y = (x * Math.Sin((double.Pi) / 4)) / (1 - 2 * x * Math.Cos((double.Pi) / 4) + x * x);
        for (double i = 1; Math.Abs(n) >= 0.0001; i++)
        {
            n = Math.Pow(x, i) * Math.Sin(i * (double.Pi) / 4);
            S += n;
        }
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
        Console.WriteLine($"{x}\t{y}\t{S}");
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

        // end

        return (S, y);
    }
    #endregion
}