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
        for (int k = 2; k <= 35; k += 3) { answer += k; }

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / i);
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
            answer = answer + i / (i + 1);
        }
        answer = Math.Round(answer, 0);
        
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        for (double a = 1, y = 1; a <= 9; a++)
        {
            answer += Math.Cos(a * x) / y;
            y *= x;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer = answer + Math.Pow(p + i * h, 2);
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        return Math.Round(0.5 * x * x - 7 * x, 2);
        // end

        
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int j = 1;
        for (int i = 1; i <= 6; i++)
        {
            j = j * i;
        }
        answer = j;

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int k = 1;
            for (int j = 1; j <= i; j++)
            {
                k = k * j;
            }
            answer = answer + k;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        int t = -1;
        int v = 5;
        for (int i = 1; i <= 6; i++) {
            double a = 1;
            for (int j = i; j > 0;j--)
            {
                a = a * j;
            }
            s = s + (t * v) / a;
            t = t * (-1);
            v = v * 5;
        }
        answer = Math.Round(s, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int a = 1;
        for (int i = 1; i <= 7; i++)
        {
            a = a * 3;
        }
        answer = a;

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }

        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / Math.Pow(x, i);
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
        else if (x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double d = 1, j = 1, c, i = 1; i <= 5; i++)
        {
            answer = d / j;
            c = d;
            d += j;
            j = c;
        }

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double s = 0;
        int a = 0;

        // code here
        double n = 1;
        for (int i = 0; i < 64; i++, n *= 2) ;
        n /= 15;
        a = (int)Math.Log10(n);
        s = Math.Round(n / Math.Pow(10, a), 2);
        // end

        return (s, a);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        for (int i = 3; i <= x; i += 3)
        {
            a = a * 2;
        }
        answer = a;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double a = Math.Cos(x);
        while(Math.Abs(a)>=0.0001)
        {
            answer += a;
            i++;
            a = Math.Cos(i * x) / Math.Pow(i, 2);
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
        double d = 0;
        for (int i = 0; d <= p; i++)
        {
            d += a + i * h;
            if (a < Math.Abs(h) && h < 0) { break; } 
            answer = i;
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
        if (M != 0)
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                N -= M;
                quotient++;
            }
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
        double d1 = 10;
        for (int i = 1; i <= 7; i++)
        {
            answer += d1;
            d1 = d1 * 1.1;

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double a = 10;
        double f = 0;
        while (f < 100)
        {
            f += a;
            a = a * 1.1;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        int ñ = 0;
        double d1 = 10;
        for (int i = 0; ; i++)
        {
            d1 = d1 * 1.1;
            ñ++;
            if (d1 > 20)
            {
                break;
            }
        }
        answer = ñ;
        Console.WriteLine(answer);

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
        double l = 0.1;
        while (l > Math.Pow(10, -10))
        {
            l = l / 2;
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
        y = (Math.Pow(x, 2) - (Math.Pow(Math.PI, 2) / 3)) / 4;
        for (int i = 1; ; i++)
        {
            double p = Math.Pow(-1, i) * (Math.Cos(i * x) / Math.Pow(i, 2));

            if (Math.Abs(p) < 0.0001)
            {
                break;

            }
            S += p;

        }
        // end
        Console.WriteLine(S);
        Console.WriteLine(y);


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
