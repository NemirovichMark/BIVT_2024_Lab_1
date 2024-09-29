using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        //program.Task_3_8(0.1);
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int s = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            s += i;
        }
        answer = s;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 1; i <= 10; i += 1)
        {
            s += 1.0 / i;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 2; i <= 112; i += 2)
        {
            s += i / (i + 1.0);
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double n = 1;
        if (x == 0) return 0;
        for (int i = 0; i <= 8; i += 1)
        {
            s += Math.Cos((i + 1) * x) / n;
            n *= x;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        s = Math.Pow(p, 2);
        for (int i = 1; i < 10; i += 1)
        {
            s += (p + i * h) * (p + i * h);
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        s = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int n = 1;
        for (int i = 1; i <= 6; i += 1)
        {
            n *= i;
        }
        answer = n;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        for (int i = 1; i <= 6; i += 1)
        {
            int f = 1;
            for (int j = 1; j <= i; j+=1)
            {
                f *= j;
            }
            s += f;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int n = 1;
        double a = 5;
        double b = -1;
        double s = 0;
        for (int i = 1; i <= 6; i += 1)
        {
            n *= i;
            s += (b * a) / n;
            b *= (-1);
            a *= 5;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 1;
        int n = 3;
        for (int i = 0; i <= 6; i += 1)
        {
            x *= n;
        }
        answer = x;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i += 1)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i += 1)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        double k = 1;
        if (x == 0) return 0;
        for (int i = 1; i <= 10; i += 1)
        {
            k *= x;
            s += 1 / k;
        }
        answer = Math.Round(s, 2);
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
        else if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int number1 = 1;
        int number2 = 1;
        int n = 0;
        Console.Write(number1 + " ");
        Console.Write(number2 + " ");
        for (int i = 3; i <= 8; i++)
        {
            n = number2;
            number2 = number1 + number2;
            number1 = n;
            Console.Write(number2 + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int x1 = 1;
        int y1 = 1;
        int x2 = 2;
        int y2 = 1;
        for (int i = 3; i <= 5; i += 1)
        {
            int numerator = x1 + x2;
            int denominator = y1 + y2;
            answer = (double)numerator / denominator;
            x1 = x2;
            y1 = y2;
            x2 = numerator;
            y2 = denominator;
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
        double x = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += x / 15;
            x *= 2;
        }
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        for (double i = 1; i <= x; i += 1)
        {
            answer = Math.Sqrt(i * (2 * r + i));
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int y = 10;
        for (int i = 3; i <= x; i += 3)
        {
            y *= 2;
        }
        // end
        answer = y;
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double n = 1;
        double m = Math.Cos(x);
        while (Math.Abs(m) >= 0.0001)
        {
            answer += m;
            n += 1;
            m = Math.Cos(x * n) / (n * n);
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
        double s = 0;
        int n = 0;
        if (p <= 0 || h < 0) return 0;
        while (s <= (p - (a + n * h)))
        {
            s += a + n * h;
            n += 1;
        }
        answer = n;
        Console.WriteLine(answer);
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
        if (N <= 0 || M <= 0) return (0,0);
        while (N >= M)
        {
            N -= M;
            quotient++;
        }
        remainder = N;
        Console.WriteLine($"{quotient} {remainder}");
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
        double len = 10;
        double x = len;
        for (int i = 2; i <= 7; i += 1)
        {
            len *= 1.1;
            x += len;
        }
        answer = Math.Round(x, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        answer = 1;
        double len = 10;
        double x = len;
        while (x <= 100)
        {
            len *= 1.1;
            x += len;
            answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double len = 10;
        answer = 1;

        while (len <= 19)
        {
            len *= 1.1;
            answer++;
        }
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
        double atom = Math.Pow(10, -10);
        while (L >= atom)
        {
            L = L / 2;
            answer++;
        }
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
        double m = 1;
        double n = 1;
        double a = 0;
        for (int i = 1; ; i++)
        {
            a = 2 * i + 1;
            n *= -1;
            m = n * Math.Pow(x, a) / a;
            if (Math.Abs(m) >= 0.0001)
            {
                S += m;
            }
            else { break; }
        }
        y = Math.Atan(x);
        //Console.WriteLine($"{S} {y}");
        // end

        return (S, y);
    }
    #endregion
}