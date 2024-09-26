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
        program.Task_3_2(0.2);
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
        int s = 0, x = 2;
        while (x < 36)
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
        double s = 0, x = 1;
        while (x < 11)
        {
            s += 1 / x;
            x++;
        }
        answer = Math.Round(s, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0, x = 2;
        while (x < 113)
        {
            s += x / (x + 1);
            x += 2;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, k = 1, y = 1;
        while (k < 10)
        {
            s += Math.Cos(k * x) / y;
            y *= x;
            k++;
        }
        answer = Math.Round(s, 2); 
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, x = 0;
        while (x < 10)
        {
            s += (p + x * h) * (p + x * h);
            x++;
        }
        answer= Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x, 2);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i=1; i < 7; i++)
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
        int s = 0, f = 1;
        for(int i = 1; i < 7; i++)
        {
            f *= i;
            s += f;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, x = 1;
        for(double i = 1; i < 7; i++)
        {
            x *= (-1) * 5 / i;
            s += x;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i < 7; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        for(int i=0; i < 6; i++)
        {
            int a = 5;
            Console.Write($"{a} ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1, y = 1;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                y /= x;
                s += y;
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
        if (x <= -1)
        {
            answer = 1;
        }
        else
        {
            if ((x > -1) && (x <= 1))
            {
                answer = -x;
            }
            else
            {
                if (x > 1)
                {
                    answer = -1;
                }
            }
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1, y = 1, z = 2;
        Console.Write($"{x} {y} ");
        for(int i=0; i < 6; i++)
        {
            z = x + y;
            x = y;
            y = z;
            Console.Write($"{z} ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, ch2 = 2, z1=1, z2=1, ch3=1, z3=1;
        for(int i = 0; i < 3; i++)
        {
            ch3 = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch3;
            z3 = z1 + z2;
            z1 = z2;
            z2 = z3;
        }
        answer = Math.Round(ch2 / z2, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0, x = 1;
        for(int i = 0; i < 64; i++)
        {
            s += x;
            x *= 2;
            //Console.WriteLine($"x={x}");
          //  Console.WriteLine($"s={s}");
        }
        //Console.WriteLine(x);
        //Console.WriteLine(s);
        s /= 15;
        while (s > 10)
        {
            s /= 10;
            power++;
        }
        answer=Math.Round(s, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350, s;
        s = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int start = 10;
        for(int i = 0; i < x / 3; i++)
        {
            start *= 2;
        }
        answer = start;
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
        int L = 30000, prod=1, n=1;
        while (prod <= L)
        {
            n += 3;
            prod *= n;
        }
        answer = n - 3;
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
        double s = 0, x_i=1;
        if ((x <= -1) || (x >= 1))
        {
            answer = 0;
        }
        else
        {
            while (x_i >= 0.0001)
            {
                s += x_i;
                x_i *= x * x;
            }
            answer = Math.Round(s, 2);
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
        int time = 0, sum = 10;
        while (sum < 100000)
        {
            time += 3;
            sum *= 2;
        }
        answer = time;
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
        double sum = 10000, multi = 1.08; 
        int time=0;
        while (sum < 20000)
        {
            sum *= multi;
            time++;
        }
        answer = time;
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
        double ch1 = 1, ch2 = 2, z1 = 1, z2 = 1, ch3 = 1, z3 = 1, x1 = 1, x2 = 0;
        answer = 2;
        while (Math.Abs(x1 - x2) > 0.001)
        {
            ch3 = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch3;
            z3 = z1 + z2;
            z1 = z2;
            z2 = z3;
            x1 = ch1 / z1;
            x2 = ch2 / z2;
            answer++;
        }

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
        double a_i = 0, b_i=1;
        int i = 2;
        a_i = x * Math.Sin(Math.PI / 4);
        b_i *= x;
        while (Math.Abs(b_i) >= 0.0001)
        {
            S += a_i;
            b_i *= x;
            a_i *= (x * Math.Sin((i * Math.PI) / 4)) / Math.Sin(((i - 1) * Math.PI) / 4);
            i++;
        }
        y=x*Math.Sin(Math.PI / 4)/(1-2*x*Math.Cos(Math.PI / 4)+x*x);
        Console.WriteLine($"S={S} y={y}");
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