using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        //program.Task_1_16();
        program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
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
        for (int i = 2; i <= 35; i = i + 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
            answer = answer + 1.0 / i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i = i + 2)
            answer = answer + i / (i + 1.0);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        for (int i = 1; i <= 9; i++)
        {
            if (y == 0)
            {
                answer = 0;
                break;
            }
            answer = answer + Math.Cos(i * x) / y;
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
            answer = answer + (p + h * i) * (p + h * i);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        const double xn = -4, xk = 4, sh = 0.5;
        answer = 0.5 * x * x - 7 * x;
        x = x + sh;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i <= 6; i++)
            s = s * i;
        answer = s;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1;
        for (int i = 1; i <= 6; i++)
        {
            s = s * i;
            answer += s;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double p = 1, k = 1, x = 1;
        for (double i = 1; i <= 6; i++)
        {
            k *= -1;
            x *= 5;
            p *= i;
            answer += (k * x / p);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i <= 7; i++)
            s = s * 3;
        answer = s;
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
        double y = 1;
        for (int i = 0; i <= 10; i++)
        {
            if (y == 0)
            {
                answer = 0;
                break;
            }
            answer = answer + 1 / y;
            y = y * x;
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
        int n1 = 1, n2 = 1, n3;
        Console.WriteLine($"{n1} {n2}");
        for (int i = 3; i <= 8; i++)
        {
            n3 = n1 + n2;
            Console.WriteLine($"{n3} ");
        n1 = n2;
        n2 = n3; 
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1;
        double ch2 = 2, zn2 = 1;
        double ch3 = 0, zn3 = 0;
        for (int i = 3; i <= 5; i++)
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
        }
        answer = ch3 / zn3;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1;
        for (int i = 0; i <= 63; i++)
        {
            answer += s;
            s *= 2;
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
        double R = 6350;
        answer = Math.Sqrt(x * (2 * R + x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 1; i <= x; i++)
        {
            if (i % 3 == 0)
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        double L = 1;
        int p = 1;
        while (L * p < 30000)
        {
            L = L * p;
            p = p + 3;
        }
        answer = p - 3;
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
        double s = 0, p = 1;
        if (Math.Abs(x) >= 1)
            return 0;
        else
        {
            for (int i = 1; ; i++)
            {
                if (p < 0.0001)
                    break;
                else
                {
                    s = s + p;
                    p = p * x * x;
                }
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
        int time = 0;
        for (int cnt = 10; cnt < 100000; cnt = cnt * 2)
        {
            time = time + 3;
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
        double b = 10000;
        int p = 8, c = 0;
        while ( b < 10000 * 2)
        {
            b += b * p / 100;
            c += 1;
        }
        answer = c;
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
        double n = 1, z = 1, x = 0;
        double c = 0, p = 0;
        int cnt = 0;
        do
        {
            p = c;
            c = n / z;
            x = n;
            n = n + z;
            z = x;
            cnt++;
        }
        while (Math.Abs(c - p) > 0.001);
        answer = cnt;
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