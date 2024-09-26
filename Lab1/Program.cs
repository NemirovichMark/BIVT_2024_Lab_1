using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        //program.Task_3_1(0.1);
        program.Task_3_2(0.1);
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
        for (int i = 2; i <= 35; i = i + 3)
        {
            answer += i;
        }
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
            answer = Math.Round(answer, 2);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double a = 2; a <= 112; a += 2)
        {
            answer += a / (a + 1.0);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        if (x == 0)
        {
            return 0;
        }
        for (double i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / y;
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
        for (double i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
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
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
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
        for (int i = 1, y = 1; i <= 6; i ++)
        {
            y *= i;
            answer += y;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double i = 1, k = 1, y = 1; i <= 6; i++)
        {
            y *= 5 / i;
            k = -k;
            answer += k * y;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i = 1; i < 7; i++)
        {
            answer = 3 * answer;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this tsrask

        // code here
        string a = "", b = "";
        for (int i = 1; i <= 6; i ++)
        {
            a += " " + i.ToString();
            b += " 5";
        }
        Console.WriteLine("{0}\n{1}", a, b);
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return answer;
        for (double k = 1, i = 0; i <= 10; i ++)
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
        if (x <= -1.0) 
            answer = 1.0;
        else if ((-1.0 < x) && (x <= 1.0))
            answer = -x;
        else if (x > 1)
            answer = -1.0;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        for (int a = 0, b = 1, i = 1; i <= 8; i++)
        {
            Console.WriteLine("{0}", b);
            int k = a + b;
            a = b;
            b = k;
        }    
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double a = 1, b = 1, c, i = 1; i<=5; i++)
        {
            answer = a / b;
            c = a;
            a += b;
            b = c;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        for (int i = 0; i < 64; i++)
        {
            n *= 2;
        }
        n /= 15;
        while(n > 10)
        {
            n /= 10;
            power++;
        }
        answer = n;
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
        double R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 1; i <= x/3; i ++)
        {
            answer *= 2;
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
        for (double n = 1.0, y = Math.Cos(x); Math.Abs(y) >= 0.0001;)
        {
            answer += y;
            n++;
            y = Math.Cos(n * x) / (n * n);
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
        double sums = 0;
        for (int i = 0; sums <= p; i++)
        {
            sums += a + (i * h);
            if ((a < Math.Abs(h)) && (h < 0))
            {
                break;
            }
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
        int ch = 0, ost = 0;

        // code here
        if (M == 0)
        {
            return (ch, ost);
        }
        for(ost = N; Math.Abs(ost) >= Math.Abs(M);)
        {
            ch++;
            ost -= M;
        }
        // end
        ost = Math.Abs(ost);
        return (ch, ost);
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
        for (double i = 10, n = 1; n <= 7; n++)
        {
            answer += i;
            i += i / 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        for (double i = 10, s = 0; s <= 100; i += i/10)
        {
            s += i;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double i = 10;
        while(i<=20)
        {
            i += i / 10;
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
        for (double i = 0.1; i >= Math.Pow(10, -10); i/=2)
        {
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