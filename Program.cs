using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        int k;
        for (k = 2; k <= 35; k = k + 3)
            answer = answer + k;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
        }
        answer=Math.Round(answer, 2);

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
        answer = Math.Round(answer, 0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double k = 1;
        for (int n = 1; n <= 9; n++)
        {
            if (k == 0)
            {
                answer = 0; 
                break;
            }
            answer = answer + Math.Cos(n * x) / k;
            k *= x; 

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double t;
        for (int n = 0; n <= 9; n++)
        {
            t = p + n * h;
            answer += t * t;

        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double t=0.5;
        const double xt = -4, xn = 4;
        
        answer = 0.5 * x * x - 7 * x;
        x = x + t;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 2; i <=6; i++)
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
        int p = 1;
        for (int i = 1; i <= 6; i++)
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
        int p = 1;
        for (int i = 1; i <= 6; i++)
        {
            p *= i;
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / p;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int a = 3, n=7;
        for (int i = 0; i < n; i++)
        {
            answer *= a;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        Console.WriteLine("a): 1 2 3 4 5 6");
        Console.WriteLine("б): 5 5 5 5 5");
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double t = 1;
        if (x==0)
            return 0;
        for (int i = 0; i <= 10; i++)
        {
            answer += 1/t;
            t *= x;
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
        else if (x > 1) 
        { 
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int f1 = 1;
        int f0 = 0;
        const double end = 8;
        for (int i = 1; i <= end; i++)
        { 
            int f2=f1;
            f1 += f0;
            f0 = f2;

        }
        Console.WriteLine(f0);
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chis1 = 1, znam1 = 1, chis2 = 2, znam2 = 1, chis3=0, znam3=0;
        for (int i = 3; i <= 5; i++)
        {
            chis3 = chis1 + chis2;
            znam3= znam1 + znam2;
            chis1 = chis2;
            znam1 = znam2;
            chis2 = chis3;
            znam2 = znam3;
        }
        answer = chis3 / znam3;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        BigInteger z = 0, kl=1;
        
        for (int i = 0;i<64;i++)
        {
            z = z + kl;
            kl *= 2;
        }
        BigInteger m = z / 15;
        answer = (double)m;
        while (answer>=10)
        {
            answer = answer / 10;
            power++;
        }
        answer=Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer=Math.Sqrt(x*(2*R+x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int n= 1;
        for(int i = 0;i<x/3;i++)
        {
            n *= 2;

        }
        answer = 10 * n;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        int n = 1;
        double eps=0.0001, t=Math.Cos(x);
        while (Math.Abs(t) >= eps)
        {
            answer += t;
            n++;
            t = Math.Cos(n * x) / (n * n);

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
        double t = 0;
        int n = 0;
        if (h < 0)
            return 0;
        else
        {
            while(true)
            {
                t += a + n * h;
                if (t > p)
                    break;
                else
                {
                    n++;
                }
            }
        }
        answer=n;
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
            return (0,0);
        else
        {
            while (Math.Abs(M) <= Math.Abs(N))
            {
                N -= M;
                quotient++;
                remainder=Math.Abs(N);
            }
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
        double S = 0;
        double d =10;
        for (int i=0; i<7;i++)
        {
            S += d;
            d += d * 0.1;
        }
        answer = Math.Round(S, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double S = 0;
        double d = 10;
        int den = 0;
        while (S<100)
        {
            S += d;
            d += d * 0.1;
            den++;
        }
        answer = den;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double S = 0;
        double d = 10;
        int den = 0;
        while (d < 20)
        {
            S += d;
            d += d * 0.1;
            den++;
        }
        answer = den;
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
        double L = 0.1;
        double D = 1e-10;
        int t = 0;
        while(L>= D)
        {
            L /= 2;
            t++;
        }
        answer = t;
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
        int edinitsa = -1;
        double t = 0;
        for (int i = 1; ; i++)
        {
            if (i%2 == 0)
            {
                edinitsa = 1;
            }
            else
            {
                edinitsa = -1;
            }
            t = edinitsa * (Math.Cos(i * x) / (i * i));
            S+= t;
            if (Math.Abs(t)<0.0001)
            {
                break;
            }
            
            y = ((x * x) -(Math.PI * Math.PI) / 3) / 4;
        }
        // end
        Console.WriteLine($"{S} {y}");
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