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
        program.Task_3_4(0.1);
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
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;

        }
        answer = Math.Round(answer, 2);
        // end


        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double x = 2;
        for (double i = 3; i <= 113; i += 2)
        {
            answer += x / i;
            x += 2;
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
        double y = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / y;
            y *= x;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        Console.WriteLine(answer);
        // end
        answer = Math.Round(answer, 2);
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
        int x = 1;
        for (int i = 1; i <= 6; i++)
        {
            x *= i;
            answer += x;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double x1 = -1, x2 = 5, x3 = 1;
        for (int i = 1; i <= 6; i ++)
        {
            x3 *= i;
            answer += x1 * x2 / x3;
            x1 = -x1;
            x2 *= 5;
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
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"5 ");
        }
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
        double y = 1;
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / y;
            y *= x;
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
        int x = 1; int y = 1, z = 0;
        for (int i = 1; i <= 6; i++)
        {
            z = x;
            x = y;
            y += z;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 1, y = 1, z = 0;
        for (int i = 1; i <= 4; i++)
        {
            z = x;
            x = y;
            y += z;
        }
        answer = y / x;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here 
        double x = 1;
        for (int i = 1; i <= 64; i++)
        {
            x *= 2;
        }
        answer = (x - 1) / 15;
        //Console.WriteLine(answer);
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(power);
        //Console.WriteLine(answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = (R + x) * (R + x) - R * R;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 0; i < x; i += 3)
        {
            answer *= 2;
            Console.WriteLine(answer);

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
        int k1 = 1, k2 = 1;
        while (true)
        {
            k2 *= k1;
            if (k2 > 30000) break;
            answer = k1;
            k1 += 3;
        }

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
        double k = 1;
        answer += k;
        if (Math.Abs(x) >= 1)
        {
            return 0;
        }
        for (int i = 0; k >= 0.0001; i ++)
        {
            k *= x * x;
            answer += k;
            Console.WriteLine(answer);

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
        int x = 10;
        while (x < 100000)
        {
            x *= 2;
            answer += 3;
            Console.WriteLine(answer);
        }
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
        double s = 10000;
        while (s < 20000)
        {
            s += 0.08 * s;
            answer++;
        }
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
        double x = 1, y = 1, z = 0, k1 = 0, k2 = 0;
        answer = 1;
        do
        {
            k1 = y / x;
            z = x;
            x = y;
            y += z;
            k2 = y / x;
            answer++;
            Console.WriteLine(k1 - k2);
        }
        while (Math.Abs(k1 - k2) > 0.001);
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
        double e = Math.E;
        double k = 1, k1 = 1, k2 = 1, k3 = 1;
        for (int i = 1; k >= 0.0001; i++)
        {
            k3 *= i;
            S += k;
            k1 = (2 * i + 1);
            k2 *= x * x;
            k = k1 * k2 / k3;
            y = (1 + 2 * x * x) * Math.Pow(e, x * x);
            //Console.WriteLine(S);
            //Console.WriteLine(k2);
        }

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
