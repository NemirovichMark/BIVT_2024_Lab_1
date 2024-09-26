using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

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
        int s = 0;

        for (int chislo = 2; chislo < 36; chislo += 3)
        {
            s += chislo;
            Console.WriteLine($"{chislo,10}{s,10}");
        }
        answer = s;

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double x = 0, s = 0;
        for (int i = 1; i < 11; i++)
        {
            x = (1.0 / i);
            s += x;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine("answer = {0}", answer);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double x = 0, s = 0;
        for (int i = 3; i <= 113; i+=2)
        {
            x = (i - 1) / (double)i;
            s += x;
        }
        answer = Math.Round(s, 0);
        Console.WriteLine("answer = {0}", answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }
        double poww = 1.0;
        double s = 0, y = 0;

        for (int i = 1; i <= 9; i++)
        {
            y = Math.Cos(i * x) / poww;
            poww = poww * x;
            s += y;
        }
        answer = Math.Round(s, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, y = 0;
        for (int i = 0; i < 10; i++)
        {
            y = (p + i * h);
            y *= y;
            s += y;
        }
        answer = s;

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        y = 0.5 * x * x - 7 * x;
        answer = Math.Round(y,2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int fact6 = 1;
        for(int i=2;i<=6;i++)
        {
            fact6 *= i;
        }
        answer = fact6;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0, factorial = 1;
        for(int i = 1; i <= 6; i++)
        {
            factorial *= i;
            s += factorial;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, st1 = 1, st5 = 1, fctr = 1; ;
        for(int i = 1; i <= 6; i++)
        {
            st1 *= -1;
            st5 *= 5;
            fctr *= i;
            s += st1 * st5 / fctr;
        }
        answer = Math.Round(s,2);
        Console.WriteLine("answer = {0}", answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int poww = 1;
        for(int i = 1; i <= 7; i++)
        {
            poww *= 3;
        }
        answer = poww;
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
        Console.WriteLine();
        int p = 5;
        for(int i = 1; i <= 6; i++)
        {
            Console.Write(p + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if(x == 0)
        {
            return 0;
        }
        double s = 0, poww = 1;
        for(int i = 0; i <= 10; i++)
        {
            s += poww;
            poww *= 1 / x;
        }
        answer = Math.Round(s,2);
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
        else if (-1 < x & x <= 1)
        {
            y = -x;
        }
        else if (x > 1)
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
        int a1 = 1, a2 = 1, an = 0;
        Console.WriteLine(a1);
        for(int i = 1; i <= 7; i++)
        {
            Console.WriteLine(a2);
            an = a1 + a2;
            a1 = a2;
            a2 = an;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double cha1 = 1, zna1 = 1, cha2 = 2, zna2 = 1, ch = 0, zn = 0;
        for(int i = 1; i <= 3; i++)
        {
            ch = cha1 + cha2;
            zn = zna1 + zna2;
            cha1 = cha2;
            cha2= ch;
            zna1 = zna2;
            zna2 = zn;
            answer = cha2 / zna2;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        double kletki = 1, kzeren = 0;
        for (int i = 1; i <= 64; i++)
        {
            kzeren += kletki;
            kletki *= 2;
        }
        answer = kzeren / 15;
        while ((decimal)answer > 10)
        {
            answer = answer / 10;
            power += 1;
        }
        //Console.WriteLine(power);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        double rast = 0;
        rast = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(rast, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int kletok = 10, poww = 0, delklet = 1;
        poww = x / 3;
        for(int i = 1; i <= poww; i++)
        {
            delklet *= 2;
        }
        answer = kletok * delklet;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0, y = 0;
        int n = 1;
        y = Math.Cos(x);
        while (Math.Abs(y) >= 0.0001)
        {
            n += 1;
            s += y;
            y = Math.Cos(n * x) / (n * n);
        }
        answer = s;
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
        double s = a, b1 = 0, b2 = a;
        int n = 0;
        while (s <= p)
        {
            n++;
            b1 = b2;
            b2 = (a + n * h);
            s += b2;
            if ((b2 < b1 & b2 < 0 & p > 0)||(b2 > b1 & b2 > 0 & p < 0))
            {
                n = 0; 
                break;
            }
        }
        answer = n;
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
        {
            return (0, 0);
        }
        else
        {
            while (N >= M)
            {
                N = N - M;
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
        double d1 = 10, s = 0;
        for(int i = 1; i <= 7; i++)
        {
            s += d1;
            d1 = 1.1 * d1;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double d1 = 10, s = 0;
        int kd = 0;
        while (s <= 100)
        {
            s += d1;
            d1 = 1.1 * d1;
            kd += 1;
        }
        answer = kd;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double d1 = 10;
        int kd = 0;
        while (d1 <= 20)
        {
            kd += 1;
            d1 = 1.1 * d1;
        }
        answer = kd;
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
        double L = 0.1;
        int k = 0;
        while(L>Math.Pow(10,-10))
        {
            L /= 2;
            k++;
        }
        answer = k;
        Console.WriteLine(answer);
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
        double n = (-1) * Math.Cos(x), pi =Math.PI, a = pi/5, b = pi, h = pi/25;
        int i = 1;
        y = (x * x - (pi * pi) / 3) / 4;
        while (Math.Abs(n) >= 0.0001)
        {
            S += n;
            i += 1;
            if (i % 2 == 0)
            {
                n = Math.Cos(i * x) / (i * i);
            }
            else
            {
                n = (-1) * Math.Cos(i * x) / (i * i);
            }
            
        }
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