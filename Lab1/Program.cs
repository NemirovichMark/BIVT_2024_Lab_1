using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        program.Task_3_1(0.1);
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
        int s = 0, x = 2;
        while (x <= 35)
        {
            s = s + x;
            x = x + 3;
        }
        answer = s;
        //// end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0, x = 0;
        while (x < 10)
        {
            x = x + 1;
            s = s + 1 / x;
        }
        s = Math.Round(s, 2);
        answer = s;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double x = 2, s = 0;
        while (x <= 112)
        {
            s = s + x / (x + 1);
            x = x + 2;
        }
        s = Math.Round(s, 0);
        answer = (double)s;
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, n = 0, k = 1, y = 1, i = 1 ;
        if (x == 0)
            return 0;
        else
            s = Math.Cos(x);
            while (k < 9)
            {
                k = k + 1;
                do
                {
                    y = y * x;
                    i = i + 1;
                }
                while (i != k);
                s = s + Math.Cos(k * x) /y;
                n = n + 1;
            }
        s = Math.Round(s, 2);
        answer = s;
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        int x = 0;
        while (x <= 9)
        {
            s = s + (p+x*h)* (p + x * h);
            x = x + 1;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        
            answer= (0.5 * x * x)- (7 * x);
            answer = Math.Round(answer, 2);


        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1, i = 1;
        while (i <= 6)
        {
            f = f * i;
            i = i + 1;
        }
        answer = f;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0, f = 1, i = 1;
        for (i = 1; i <= 6; i++)
        {
            f = f * i;
            s = s + f;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1, i = 1, p = 1, y = 1, k = 1 ;
        double s = 0;
        for (i = 1; i <= 6; i=i+1)
        {
            f = f * i;
            p = p * (-1);
            y = y * 5;
            s = s + p * y / f;
        }
        s = Math.Round(s, 2);
        answer = (double)s;
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 3, i = 1, s=1;
        while (i <= 7)
        {
            s = s * x;
            i = i + 1;
        }
        answer = s;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        //There is no test for this task
        int x = 5;
        for (int i=1; i<6; i=i+1)
        {
            Console.Write(i);
        }
        Console.WriteLine();
        for (int i = 1; i < 6; i = i + 1)
        {
            Console.Write(x);
        }
        Console.WriteLine();
        //code here
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1, n = 1, i = 1, y=1;
        if (x == 0)
            return 0;
        else
            while (i <= 10)
            {
                i = i + 1;
                y = y * x;
                s = s + 1 / y;
                n = n + 1;
            }
        s = Math.Round(s, 2);
        answer = s;
        // end

        return answer;
    }
    
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double h = 0.1;
        if (x <= -1)
            answer = 1;
        Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, answer);
        if ((x > -1) && (x <= 1))
            answer = -x;
        Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, answer);
        if (x > 1)
            answer = -1;
        Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, answer);

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1, i = 1, f = 0;
        while (i <= 8)
        {
            f = f + x;
            x = f - x;
            Console.WriteLine(f);
            i = i + 1;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1, i = 3, ch = 0, zn = 0;
        while (i <= 5)
        {
            ch = ch1 + ch2;
            zn = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch;
            zn2 = zn;
            i = i + 1;
        }
        answer = (double)(ch / zn);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1, x = 1, i = 1;
        while (i <= 63)
        {
            x = x * 2;
            s = s + x;
            i = i + 1;
        }
        answer = (double)(s / 15);
        while (answer >= 2)
        {
            answer = answer / 10;
            power = power + 1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine((double)answer);
        Console.WriteLine(power);
        // end

        return (answer, power);
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
        int answer =10;

        // code here
        for (int i = 3; i<=x; i=i+3)
        {
            answer = answer * 2;
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
        double eps = 0.0001, s = 0;
        int n = 1, k = 1;
        do
        {
            s = s + Math.Cos(k * x) / (n * n);
            n = n + 1;
            k = k + 1;
        } while (Math.Abs(Math.Cos(k * x) / (n * n)) >= eps);
        answer = s;
        Console.WriteLine(s);
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
        double s = a;
        int n = 0;
        if (h>0)
        {
            while (s<=p)
            {
                answer= answer + 1;
                s=  s+(a + answer * h);

            }
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
        if (M!=0)
        {
            do
            { quotient= quotient + 1;
                N = N - M;
            }
            while (Math.Abs(N)>=Math.Abs(M));
            remainder = Math.Abs(N);
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
        double s = 0, x=10;
        for (int i = 1; i <=7; i = i + 1)
        {
            s = s + x;
            x = x * 1.1;
        }
        // end
        answer=Math.Round(s,2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, x = 10;
        do
        {
            s = s + x;
            x = x * 1.1;
            answer = answer + 1;
        }
        while (s <= 100);
        
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double x = 10;
        do
        {
            x = x * 1.1;
            answer = answer + 1;
        }
        while (x<=20);
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
        double l = 0.1, d = Math.Pow(10, -10);
        do
        {
            l = l / 2;
            answer = answer + 1;
        }
        while (l >= d);
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
        double zn = 1, p = 1, i = 0, ch = 1, s0 = 0, k2 = 1;
        int k1 = 0;
        do
        {
            for (k1 = 0; k1 < 2 * i; k1 = k1 + 1)
            {
                ch = ch * x;
            }
            for (k2 = 1; k2 <= (2 * i); k2 = k2 + 1)
            {
                zn = zn * k2;
            }
            s0 = p * (ch / zn);
            p = p * -1;
            if (Math.Abs(s0) >= 0.0001)
            {
                S = S + s0;
            }
            zn = 1;
            ch = 1;
            i = i + 1;
        } while (Math.Abs(s0) >= 0.0001);
        y = Math.Round(Math.Cos(x), 2);
        S = Math.Round(S, 2);
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

        // end

        return (S, y);
    }
    #endregion
}