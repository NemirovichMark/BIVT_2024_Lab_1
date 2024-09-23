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

        int x = 2;
        while (x < 36)
        {
            answer += x;
            x += 3;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        int x = 1;
        while (x < 11)
        {
            answer += (1.0 / x);
            x += 1;
        }
        answer = Math.Round(answer, 3);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        int x = 2;
        while (x < 113)
        {
            answer += (x / (x + 1.0));
            x++;
        }
        answer = Math.Round(answer, 3);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        Console.WriteLine(x);
        answer += Math.Cos(x);
        double m = 1;
        if (x == 0) return 0;
        for (int i = 2; i <= 9; i++)
        {
            m *= x;
            answer += Math.Cos(i * x) / m;
        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        int i = 0;
        while (i < 10)
        {
            answer += ((p + i * h) * (p + i * h));
            i++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        while (true)
        {
            return 0.5 * (x * x) - 7 * x;
        }
        // end
     }

   public int Task_1_7()
    {
        int answer = 1;

        // code here

        int f = 1;
        while (f <= 6)
        {
            answer *= f;
            f++;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        int i = 1, f = 1;
        while (i <= 6)
        {
            f *= i;
            answer += f;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int k = -1, i = 1, m = 5;
        double f = 1;
        while (i <= 6)
        {
            answer += (k * m) / f;
            i++;
            k = -k;
            f *= i;
            m *= 5;


        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 3, i = 1;
        while (i < 7)
        {
            x *= 3;
            i++;

        }
        answer = x;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        int a = 1, b = 5, i = 1;
        while (a != 7)
        {
            Console.WriteLine(a);
            a++;
        }
        Console.WriteLine();
        while (i != 7)
        {
            Console.WriteLine(b);
            i++;
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        int i = 0;
        double d = 1.0;
        if (x == 0) return 0;
        while (i <= 10)
        {
            answer += 1 / d;
            d *= x;
            i++;
        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        while (true)
        {
            if (x <= -1) return 1;
            if (-1 < x && x <= 1) return -x;
            if (x > 1) return -1;

        }
        // end
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int i = 1, k = 1, m = 1, j = 0;
        Console.WriteLine('1');
        Console.WriteLine('1');
        while (i != 7)
        {
            j = m + k;
            k = m;
            m = j;
            Console.WriteLine(j);
            i++;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        double x = 1, y = 1, k = 2, c = 1, i = 0, g = 0, f = 0;
        while (i != 3)
        {
            g = x + k;
            f = y + c;
            answer = g / f;
            x = k;
            k = g;
            y = c;
            c = f;
            i++;
        }
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

        int i = 1;
        double z = 1.0;
        while (i != 65)
        {
            answer += z;
            z *= 2;
            i++;
        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        answer = answer / Math.Pow(10, power);
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

        int r = 6350;
        while (x < 10000)
        {
            answer = Math.Sqrt(((r + x) * (r + x)) - (r * r));
            Console.WriteLine(answer);
            return Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int i = 1;
        while (true)
        {
            i = x / 3;
            answer = (int)Math.Pow(2, i) * 10;
            return answer;
            break;
        }
        // end


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

        int p = 1, i = 1;
        while (true)
        {
            p *= i;
            if (p >= 30000) break;
            answer = i;
            i += 3;
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

        double i = 1, s = 1;
        if (x == 0) return 1;
        if (x >= 1) return 0;
        while (true)
        {
            i *= (x * x);
            if (i < 0.0001) break;
            s += i;
        }
        answer = s;
        answer = Math.Round(answer, 4);
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

        int i = 1, s = 0, t = 0;
        while (true)
        {
            if (s > 100000) break;
            t += 3;
            s = (int)Math.Pow(2, i) * 10;
            i++;
        }
        answer = t;
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

        double s = 10000;
        int t = 0;
        while (true)
        {
            if (s > 20000) break;
            s += (s * 0.08);
            t++;
        }
        answer = t;
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
        double answer = 0;

        // code here;

        double x = 1, y = 1, k = 2, c = 1, g = 0, f = 1;
        int i = 1;
        while (true)
        {
            i++;
            g = x + k;
            f = y + c;
            if (Math.Abs(answer - (g / f)) <= 0.001) break;
            answer = g / f;
            x = k;
            k = g;
            y = c;
            c = f;
        }
        Console.WriteLine(i+1);
        // end
        return i+1;
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

        y = Math.Pow(Math.E, 2 * x);
        double f = 1;
        double ch = 1;
        for (double i = 1; ; i++)
        {
            S += ch / f;
            f *= i;
            ch *= (2 * x);
            if (Math.Abs(ch / f) < 0.0001) break;
        }
        S = Math.Round(S, 2);
        Console.WriteLine(S);
        y = Math.Round(y, 2);
        Console.WriteLine(y);
        
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