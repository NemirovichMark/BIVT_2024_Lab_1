using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        program.Task_3_8(0.1);
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
        Console.WriteLine(answer);   
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        int i;
        answer += 1;
        for (i = 2; i <= 10; i += 1)
            answer += ((double)1 / i);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i;
        for (i = 2; i <= 112; i += 2)
            answer += (i / (i + 1));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        int i;
        double j = 1;
        answer = Math.Cos(x);
        for (i = 2; i <= 9; i += 1)
        {
            answer += Math.Cos(i * x) / (x * j);
            j *= x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        // code here
        double s = p;
        answer = p * p;
        for (int i = 2; i <= 10; i++)
        {
            s = s + h;
            answer += s * s;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        int i;
        for (i = 1; i <= 6; i++)
            answer = answer * i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        int i;
        for (i = 1; i <= 6; i++)
        {
            f *= i;
            answer += f;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int f = 1;
        double ch = 1;
        double s;
        int i;
        for(i = 1;i <= 6; i++)
        {
            f *= i;
            ch *= (-1) * 5;
            s = ch / f;
            answer += s;

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int i;
        answer = 3;
        for (i = 2; i <= 7; i++)
            answer *= 3;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        //это начала пунка а
        
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
        //это конец пункта а
        Console.Write("\n");
        //это начало пункта б

        for (int i = 1; i <= 6; i++)
            Console.Write("5 ");

        //это конец пункта б

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        for(int i = 0; i<= 10; i++)
        {
            if (x == 0)
                answer = 0;
            else
            {
                answer += a;
                a /= x;
            }
            
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        else
            answer = -1;
        // end
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int i;
        int a = 0, b = 0, s = 0;
        for(i = 1; i<=8;i++)
        {
            if (i <= 2)
            {
                Console.Write($"{1}, ");
                a = 1;
                b = 1;
            }
            else
            {
                s = a + b;
                a = b;
                b = s;
                Console.Write($"{s}, ");
            }
                
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 2, ch2 = 3, zn1 = 1, zn2 = 2;
        for(int i = 1; i<= 2;i++)
        {
            zn2 += zn1;
            zn1 = zn2 - zn1;
            ch2 += ch1;
            ch1 = ch2 - ch1;
        }
        answer = ch2 / zn2;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
            double k = 1;
        for(int i = 1; i<= 64;i++)
        {
            answer += k;
            k *= 2;
        }
        answer = answer / 15;
        power = (int)Math.Floor(Math.Log10(answer));
        for (int i2 = 1; i2 <= power; i2++)
            answer /= 10;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 1;
        for (int i = 1; i <= (x / 3); i++)
            k *= 2;
        answer = 10 * k;
        Console.WriteLine(answer);
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
        int n = 1, p;
        for (p = 1;p<=30000;p*=n)
        {
            answer = n;
            n += 3; 
        }
        Console.WriteLine(answer);

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
        double n = 1;
        answer = 1;
        while(n >= 0.0001)
        {
            if (Math.Abs(x) >= 1)
            {
                answer = 0;
                break;
            }
            else
                n *= (x * x);
            answer += n;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        int k = 1, n = 1;
        while (n < 100000)
        {
            k *= 2;
            n = 10 * k;
        }
        answer = (int)Math.Log2(k) * 3;
        Console.WriteLine(answer);

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
        double dengi = 10000;
        int mesyac = 0;
        while(dengi<20000)
        {
            dengi *= 1.08;
            mesyac++;
        }
        answer = mesyac;
        Console.WriteLine(answer);
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
        double ch1 = 2, ch2 = 3, zn1 = 1, zn2 = 2;
        int n = 3;
        while((ch1 / zn1) - (ch2 / zn2) >= 0.001 || (ch2 / zn2) - (ch1 / zn1) >= 0.001)
        {
            zn2 += zn1;
            zn1 = zn2 - zn1;
            ch2 += ch1;
            ch1 = ch2 - ch1;
            n++;
        }

        answer = n;
        Console.WriteLine(answer);
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
        double n = 1, zn = 1, ch = 1, i = 1;
        while(Math.Abs(n) >= 0.0001)
        {
            S += n;
            ch *= (2 * x);
            zn *= i;
            i++;
            n = (ch / zn);
        }
        y = Math.Exp(2 * x);
        // end
        Console.WriteLine(S);
        Console.WriteLine(y);
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