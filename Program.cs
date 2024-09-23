using System;
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
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(1);
        //program.Task_1_18(6);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0);
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
        //program.Task_3_6(1);
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
            s += x;
            x += 3;

        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        // code here
        double s = 0, x = 0;
        int n = 1;
        while (n < 11)
        {
            x = (double) 1 / n;
            s += x;
            n++;
        }
        answer = Math.Round(s,2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0, x = 2;
        while (x <= 112)
        {
            s += (double) x / (x + 1);
            x += 2;
        }
        answer = Math.Round(s);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        int n = 0;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            while (n <= 8)
            { 
                s += (double) Math.Cos((n + 1) * x) / Math.Pow(x, n);
                n++;
            }
            answer = Math.Round(s,2);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int n = 0;
        double s = 0;
        while (n <= 9)
        {
            s += (p + n * h) * (p + n * h);
            n++;
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
        int res = 1, n = 1;
        while (n <= 6)
        {
            res = res * n;
            n++;
        }
        answer = res;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int n = 1, f = 1, s = 0;
        while (n <= 6)
        {
            f *= n;
            s += f;
            n++;
        }
        answer = s;       
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int p = 1, n = 1, f = 1, a = 1;
        double s = 0;
        while (n <= 6)
        {
            p = -p;
            f *= n;
            a *= 5;
            s += (double)p * a / f;
            n++;
        }
        answer = Math.Round(s, 2);
        
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int n = 1, k = 1;
        while (k <= 7)
        {
            n = n * 3;
            k++;
        }
        answer = n;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int a = 1;
        while (a <= 6)
        {
            Console.Write($"{a} ");
            a++;
        }
        Console.WriteLine();
        int b = 5;
        for (int n = 1; n <= 6; n++)
        {
            Console.Write($"{b} ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, y = 1;
        int n = 0;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            while (n <= 10)
            {
                s += y;
                y = (double)y / x;
                n++;
            }
            answer = Math.Round(s, 2);
        }
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
        if (x > -1 && x <= 1)
        {
            y = -x;
        }
        if (x > 1)
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
        int n = 1, a = 0, b = 1, s = 0;
        while (n <= 8)
        {
            s = a + b;
            a = b;
            b = s;
            Console.Write($"{s} ");
            n++;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 0, ch = 1, zn = 1, s = 0, n = 1;
        while (n <= 5)
        {

            x = ch / zn;
            s = zn;
            zn = ch;
            ch += s;
            n++;
        }
        answer = x;
        Console.WriteLine(answer);

        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int n = 1; 
        double a = 1, s = 0, k = 0;
        while (n <= 64)
        {
            s += a;
            a *= 2;
            n++;
        }
        k = s / 15; //колво граммов
        int counter = 0;
        while (k >=  2) // k>=2, тк если к будет >=1, то в конце цикл вернет 0<k<1, а нам нужно, чтобы k было >=1. См вывод в цикле.
        {
            counter++;
            k /= 10;
            //Console.WriteLine($"{k} {counter}"); 
        }
        answer = Math.Round(k, 2);
        power = counter;
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        double s = 0;
        s = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int count = 10, hours = 0;
        while (hours < x)
        {
            count *= 2;
            hours += 3;
        }
        answer = count;
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
        int p = 1, n = 1;
        while(p * n <= 30000)
        {
            n += 3;
            p *= n;
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
        double s = 0, y = 1;
        int n = 0;
        if (Math.Abs(x) < 1)
        {
            while (y >= 0.0001)
            {
                s += y;
                y *= x * x;
                n += 2;
            }
            answer = Math.Round(s, 2);            
        }
        else
        {
            answer = 0;
        }
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
        int count = 10, hours = 0;
        while (count <= Math.Pow(10, 5))
        {
            count *= 2;
            hours += 3;
        }
        answer = hours;
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
        int month = 0;
        double s = 10000;
        while (s <= 20000)
        {
            s *= 1.08;
            month++;
        }
        answer = month;
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
        double x1 = 0, ch1 = 1, zn1 = 1, s1 = 0, x2 = 1;
        int counter = 1; // =1 тк x1 в начале получается = 1/1, а это 1 элемент
        while (Math.Abs(x2 - x1) >= 0.001)
        {

            x1 = ch1 / zn1;
            s1 = zn1;
            zn1 = ch1;
            ch1 += s1;

            x2 = ch1 / zn1;
            counter++;
        }
        answer = counter;
        //end

        
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
        double S = 0, y = 0, a = 1, b = 1;
        int i = 1;

        // code here
        while (Math.Abs(b) >= 0.0001)
        {
            b *= x;
            a = b * Math.Sin((i * Math.PI) / 4);
            S += a;
            i++;
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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
        const double e = 0.0001;
        double last = 1;
        double i = 1;
        // code here
        while (Math.Abs(last) >= e)
        {

            last = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1);
            S += last;
            i += 1;
        }
        y = ((1 + Math.Pow(x, 2)) * Math.Atan(x)) / 2 - x / 2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"{S} {y}");
        // end

        return (Math.Round(S, 2), Math.Round(y, 2));
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