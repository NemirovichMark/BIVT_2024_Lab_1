using System;
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
        //program.Task_1_12(1.35);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(1);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
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
        for (int i = 2; i < 36; i += 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i += 1)
        {
            answer += 1 / i;
            
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2, j = 3; i < 113; i += 2, j += 2)
        {
            answer += i / j;
        }
        answer = Math.Round(answer);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (double i = 1, j = 0; i < 10; i += 1, j += 1)
        {
            answer += (Math.Cos(x * i) / (Math.Pow(x, j)));
        }

        answer = Math.Round(answer, 2);
        if (x == 0)
        {
            answer = 0;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i < 10; i++)
        {
            answer += (Math.Pow(p + i * h, 2));
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round((0.5 * x * x - 7 * x), 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1, j = 1; i <= 6; i++)
        {
            j *= i;
            answer += j;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1, f = 1; i <= 6; i++)
        {
            f *= i;
            answer += Math.Pow((-1), i) * ((Math.Pow(5, i)) / f);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
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
        for (int n = 1; n <= 6; n++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / (Math.Pow(x, i));
        }
        answer = Math.Round(answer, 2);
        if (x == 0)
        {
            answer = 0;
        }
        Console.WriteLine(answer);
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
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c = 0;
        Console.WriteLine(a);
        Console.WriteLine(a);
        for (int i = 1; i <= 6; i++)
        {            
            c = b;
            b = a + b;
            a = c;
            Console.WriteLine(b);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1, b = 1, c = 0;
        for (int i = 1; i <= 5; i++)
        {
            answer = b / a;
            c = b;
            b = a + b;
            a = c;            
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 0; i < 64; i++)
        {
            answer += Math.Pow(2, i);
        }
        // end
        answer = answer / 15;
        for (; answer > 10; answer = answer / 10)
        {
            power += 1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(Math.Pow(Math.Pow(x + 6350, 2) - Math.Pow(6350, 2), 0.5), 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = x / 3; i > 0; i--)
        {
            answer *= 2;
        }
        // end
        Console.WriteLine(answer);
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
        int n = 1;
        for (; answer*n < 30000; n=n+3)
        {
            answer *= n;
        }
        answer = n-3;
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
        double slog = 1;
        // code here
        if ( x == 1 )
        {
            Console.WriteLine(0);
            return 0;            
        }
        for (double n = 0; slog > 0.0001; n++)
        {
            slog = Math.Pow(x, 2 * n);
            answer += slog;        
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
        for (int kolvo = 10; kolvo <= 100000; answer=answer+3)
        {
            kolvo *= 2;
        }
        // end
        Console.WriteLine(answer);

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
        for (double s = 10000; s <= 20000; s *= 1.08)
        {
            answer++;
        }
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
        int answer = 1;
        double razn = 1;
        // a < b; c = empty; ot 
        double a = 1, b = 1, c = 0, doo = 0, posle = 0;
        for (; razn > 0.001; answer++)
        {
            doo = b / a;
            c = b;
            b = a + b;
            a = c;
            posle = b / a;
            razn = Math.Abs(posle - doo);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 1, y = 0, ch = 1, znam = 1;

        // code here 
        for (int i = 1; Math.Abs(ch) >= 0.0001; i++)
        {
            znam = 1;
            for (int j = 2 * i; j > 1; j--)
            {
                znam *= j;
            }
            //Console.WriteLine(znam);
            ch = Math.Pow((-1), i) * (Math.Pow(x, (2 * i)) / znam);
            if (Math.Abs(ch) <= 0.0001)
            {
                break;
            }
            S += ch;
            y = Math.Cos(x);
            //Console.WriteLine($"ch = {ch}");
            //Console.WriteLine(S);            
        }
        Console.WriteLine(S);
        Console.WriteLine(y);
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