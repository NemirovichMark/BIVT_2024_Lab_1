using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml.Schema;

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
        //program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        //program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
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
        program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int  c = 2;
        while (c <= 35)
        {
            answer += c;
            c += 3;
        }
            // end

            return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double c = 0, x = 1;
        while (c < 10)
        {
            c += 1;
            answer = answer + (x / c);
        }
            // end

            return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double c = 3, x = 2;
        while (c <= 113)
        {
            answer = answer + (x / c);
            c += 2;
            x += 2;
        }
        // end

        return Math.Round(answer,0);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        for (int i = 1; i <= 9; i++)
        {
            double znam = 1;
            for (int k =1; k < i; k++)
            {
                znam *= x;
            }
            answer += Math.Cos(i * x) / znam;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        answer += (p * p);
        for (int i = 1; i <= 9; i++)
        {
            answer += (p + (h * i)) * (p + (h * i));
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * (x * x) - 7 * x;

        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int p = 1;
        for (int i = 1;i <= 6; i++)
        {
            p *= i;
        }
        answer = p;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int x = 1;
        for (int c = 1; c <= 6; c++)
        {
            answer += x * c;
            x *= c;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double a = 1, b = 1, x = 1;
        for ( int i = 1; i <= 6; i++)
        {
            a = a * (-1);
            b = b * (5);
            answer += ((a * b) / (x * i));
            x *= i;
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 3;
        for (int i = 1; i <= 6; i++)
        {
            x *= 3;
        }
        answer = x;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int x = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write( "{0}", i);
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("{0}", x);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double a = 1;
        answer += 1;
        for (int i = 1; i <= 10; i++)
        {
            a = a * x;
            answer += 1 / a;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)  answer = 1;
        else if ((x > -1) && (x <= 1))  answer = -x;
        else  answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int k, k1 = 0, k2 = 1;
        Console.WriteLine("1");
        for (int i = 1; i < 8; i++)
        {
            k = k1 + k2;
            k1 = k2;
            k2 = k;
            Console.WriteLine("{0}", k);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch, ch1 = 1, ch2 = 2;
        double zn, zn1 = 1, zn2 = 1;
        for (int i = 1; i <= 6; i++)
        {
            ch = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch;
            zn = zn1 + zn2;
            zn1 = zn2;
            zn2 = zn;
            answer = ch / zn;
        }
        // end

        return Math.Round(answer,1);
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int x = 2;
        double zerna = 1;
        for (int i = 1; i <= 64; i++)
        {
            zerna *= x;
        }
        double p = 1;
        for (int k = 1; k <= power; k++)
        {
            p *= 10;
        }
        answer = zerna / 15;
        answer = answer / p;
        answer = Math.Round(answer,2);
        // end

        return (answer,power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double d;
        d = x * (2 * 6350 + x);
        answer = Math.Sqrt(d);
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int c = 2;
        for (int i = 1; i < (x / 3); i++)
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
        double e = 0.0001, cs;
        int n = 1;
        for (int j = 1; j <= Math.Pow(10,10);j ++)
        {        
            cs = Math.Cos(n * x) / (n*n);            
            n++;            
            if (Math.Abs(cs) < e) break;
            answer += cs;

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
        if (a > p) return 0;
        while (s <= p)
        {
            answer++;
            s += a + answer * h;
            if (s < 0) return 0;
        }
         //end

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
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0) return (0,0);
        remainder = N;
        while (remainder >= M)
        {
            remainder -= M;
            quotient++;
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
        int c = 1;
        answer += 10;
        double b = 10;
        double pr;
        while (c <= 6)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            answer += b;
            c++;
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_2_7b()
    {
        int answer = 0;

        //code here
        answer = 1;
        double b = 10;
        double pr;
        double sum = 10;
        while (sum <= 100)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            sum += b;
            answer++;
        }
        //end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double b = 10;
        double pr ;
        double sum = 10;
        while (b <= 20)
        {
            pr = (b / 100) * 10;
            b = b + pr;
            sum += b;
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
        double atom = 1;
        for (int i = 0; i < 10; i++)
        {
            atom *= 1.0 / 10;
        }
        double nit = 0.1;
        while (nit >= atom)
        {
            nit = nit / 2;
            answer++;
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
        
        y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        for ( int i = 0; i <= Math.Pow(10,10); i++)
        {
            
            double cl = 1;
            double znam = 1;
            double chis = 1;
            for (int n = 1; n <= 2 * i; n++)
            {
                znam *= n;
            }
            for (int n = 0; n < 2 * i; n++)
            {
                chis *= x;
            }
            cl = chis / znam;
            if (Math.Abs(cl) >= 0.0001) S += cl;
            else break;
        }
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