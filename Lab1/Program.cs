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
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double ch = 1, zn = 1; zn <= 10; zn++)
            answer += ch / zn;
        answer = Math.Round(answer, 2);

        
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

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return answer;
        for (double zn = 1, k = 1; k<=9; k++)
        {
            answer += Math.Cos(k * x) / zn;
            zn *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int k=0;k<=9;k++)
        {
            answer += (p + h * k) * (p + h * k);
        }
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
        answer = 1;
        for (int x = 1; x <= 6; x++)
            answer *= x;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1, k = 1; i <= 6; i++)
        {
            k *= i;
            answer += k;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double i = 1,n = 1, f = 1; i <= 6; i++)
        {
            f *= 5 / i;
            n = -n;
            answer += n * f;
        }
        answer = Math.Round(answer, 2);
        
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; i++)
            answer *= 3; 
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int i1 = 1;
        for (; i1 <= 8; i1++) { 
            Console.Write(i1);
            Console.Write(' ');
        }

        Console.WriteLine();
        int i2 = 5;
        int cnt = 0;
        for (; cnt <= 5; cnt++)
        { 
            Console.Write(i2);
            Console.Write(' ');
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if(x == 0) return answer;
        for (double k = 1, i = 0; i <= 10; i++)
        {
            answer += 1 / k;
            k *= x;
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
            answer = 1;
        else if (-1 < x && x <= 1) 
            answer = -x;
        else if (x > 1) 
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        Console.WriteLine();
        int cnt = 1;
        
        for (int i1 = 0, i2 = 1; cnt <= 8;)
        {
            
            Console.Write(i2);
            Console.Write(' ');
            int i3 = i1+i2;
            i1 = i2;
            i2 = i3;
            cnt++;
        }
        
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double ch = 1, zn = 1, ch2, i = 1; i <= 5; i++)
        {
            answer = ch / zn;
            ch2 = ch;
            ch += zn;
            zn = ch2;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double klet = 0.5;
        for (int i = 0; i < 64; i++)
        {
            klet *= 2;
            answer += klet;

        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        for (int i = 1; i <= power; i++)
            answer /= 10;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const double r = 6350;
        answer = Math.Sqrt((x + r) * (x + r) - r * r);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 10;
        for (int i = 0; i < x; i += 3)
        {
            k *= 2;

        }
        answer = k;
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
        x *= x;
        double plus = 1;
        while ((plus >= 0.0001) && (Math.Abs(x) < 1))
        {
            answer += plus;
            plus *= x;
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
        int i = 0;
        for (int klet = 10; klet < 100000; i += 3)
        {
            klet *= 2;

        }
        answer += i;
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
        for (double vklad = 10000; vklad < 20000; answer++)
            vklad += vklad * (8.0 / 100);
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
        int znam_predpred = 1, znam_pred = 1, ch_predpred = 1, ch_pred = 2;
        double drob_pred = 1, drob = 2;
        int i = 2;
        while (Math.Abs(drob_pred - drob) > 0.001)
        {
            drob_pred = drob;
            drob = (double)(ch_pred + ch_predpred) / (znam_pred + znam_predpred);
            i++;
            int ch = ch_pred + ch_predpred, znam = znam_pred + znam_predpred;
            ch_predpred = ch_pred;
            ch_pred = ch;
            znam_predpred = znam_pred;
            znam_pred = znam;

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
        for (double i = 1, k = x, n = 1; Math.Abs(k) >= 0.0001; i++)
        {
            n = k * Math.Sin(i * Math.PI / 4);
            S += n;
            k *= x;
        }
        y = x * Math.Sqrt(2) / (2 - 2 * Math.Sqrt(2) * x + 2 * x * x);

        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
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
