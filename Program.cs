using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        int s= 0;
        int i = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double i = 0;
        double s = 0;
        for (i = 1; i <= 10; i = i+1)
            s = s + (1/i);
        answer = Math.Round(s, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i = 0;
        double s = 0;
        for (i = 2; i <= 112; i = i + 2)
            s = s + (i / (i + 1));
        answer = Math.Round(s, 0);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double a = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                s = s + Math.Cos(i * x) / a;
                a *= x;
            }
        }
        answer = Math.Round(s, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        int i = 0;
        for(i = 0; i <= 9; i = i+1)
        { s = s + (p + i*h)*(p + i*h);
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2); 
        
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        
        const int f = 6;
        int s = 1;
        int i = 2;
        for (i = 2; i <= f; i = i + 1)
            s = s * i;
        answer = s;

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
   
        int s = 0;
        for ( int i = 1; i <= 6;  i++)
        {
            int f = 1;
            for (int a = 1; a <= i; a++)
            {
                f = f * a;
            }
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
        double s = 0;
        double a = -1, b = 5, c = 1, f = 2;
        for (int i = 1; i <= 6; i = i + 1)
        {
            s = s + a * b / c;
            a *= -1;
            b *= 5;
            c *= f;
            f++;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int c = 1;
        for(int i = 1; i <= 7; i++)
        { 
            c = c * 3;
        }
        answer = c;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5");
        Console.WriteLine("5 5 5 5 5 5'");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, a = 1;
        if (x != 0)
        {
            int i = 0;
            for (i = 0; i <= 10; i = i + 1)
            {
                s = s + 1 / a;
                a *= x;
            }
        }
        answer = Math.Round(s, 2);
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
        else if ( x <= 1)
        {
            y = -1 * x;
        }
        else if ( x > 1)
        {
            y = -1;
        }
        answer = y;
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
        double p = 0;
        double[] ch = { 1, 2, 0, 0, 0 };
        double[] zn = { 1, 1, 0, 0, 0 };

        for (int i = 2; i <= 4; i = i + 1)
        {
            ch[i] = (ch[i - 1]) + (ch[i - 2]);
            zn[i] = (zn[i - 1]) + (zn[i - 2]);
        }
        p = ch[4] / zn[4];
        answer = p;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0;
        double summer = 1;
        for (int i = 0; i < 64; i = i + 1)
        {
            s = s + summer;
            summer *= 2;
        }
        s = s / 15;
        while (s > 10)
        {
            s = s / 10;
            power = power + 1;
        }
        answer = Math.Round(s, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt((R + x)*(R + x) - R * R);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int kl = 10;
        for (int i = 3; i <= x; i = i + 3 )
        {
            kl = kl * 2;
        }
        answer = kl;
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
        int n = 1;
        int pro = 1;
        while (true)
        {
            pro = pro * n;
            if (pro * n > 30000)
            {
                break;
            }
            else
            {
                n = n + 3;
            }
        }
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
        double s = 0;
        double summer = 1;
        if (x != 1)
        {
            while (summer > 0.0001)
            {
                s += summer;
                summer = summer * x * x;
            }
        }
        answer = Math.Round(s, 2);
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
        int a = 1;
        int i = 0;
        do
        {
            a = a * 2;
            i += 3;

        } while (a < 10000);
        
        answer = i;
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
        double a = 10000;
        int i = 0;
        do
        {
            a *= 1.08;
            i = i + 1;

        } while (a < 20000);
        answer = i;
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
        double prevup = 1;
        double prevdown = 1;
        double nowup = 2;
        double nowdown = 1;
        double nextup;
        double nextdown;
        int i = 2;
        while (true)
        {
            nextup = prevup + nowup;
            nextdown = prevdown + nowdown;
            i++;
            if (Math.Abs((nextup / nextdown) - (nowup / nowdown)) <= 0.001)
            {
                break;
            }
            else
            {
                prevup = nowup;
                prevdown = nowdown;
                nowup = nextup;
                nowdown = nextdown;
            }
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
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        double sum = 0;
        double i = 0;
        double a = 1;
        while (true)
        {
            a = a * x;
            i = i + 1;
            sum = a * Math.Sin(i * Math.PI / 4);
            if (Math.Abs(a) < 0.0001)
            {
                break;
            }
            S = S + sum;
        }
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
        return (S, y);
    }
    #endregion
}
