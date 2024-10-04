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

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(-4);
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
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(0, 5, 985);
        //program.Task_2_4(0.8);
        //program.Task_2_5(-7, -2);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        program.Task_3_3(0.1);
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
        int answer = 0, s = 2, summa = 0;
        while (s <= 35)
        {
            summa += s;
            s += 3;
        }
        answer = summa;
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1, n = 2;
        while (n <= 10)
        {
            answer += 1 / n;
            n++;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0, down = 3;
        double up = 2;
        while (up <= 112)
        {
            answer += up / down;
            up += 2;
            down += 2;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x), k = 2, y = x;
        if (x == 0)
        {
            return 0;
        }
        else
        {
            while (k <= 9)
            {
                answer += Math.Cos(k * x) / y;
                y *= x;
                k++;
            }
            Console.WriteLine(answer);
            answer = Math.Round(answer, 2);
        }
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = p * p, k = 1;
        while (k <= 9)
        {
            answer += (p + k * h) * (p + k * h);
            k++;
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = 0.5 * x * x - 7 * x;
        answer= Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1, n = 2;
        while (n <= 6)
        {
            answer *= n;
            n++;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0, f = 1, n = 2, counter = 1;
        while (counter <= 6)
        {
            answer += f;
            f *= n;
            n++;
            counter++;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, n1 = -1, n2 = 5;
        int counter = 1, f = 1;
        while (counter <= 6)
        {
            answer += (n1 * n2) / f;
            n1 *= -1;
            n2 *= 5;
            counter++;
            f *= counter;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;
        for (int counter = 0; counter < 6; counter++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        for (int counter = 1; counter <= 6; counter++)
        {
            if (counter == 6)
            {
                Console.Write($"{counter} ");
                Console.WriteLine();
            }
            else
            {
                Console.Write($"{counter} ");
            }

        }
        for (int counter_5 = 0; counter_5 < 6; counter_5++)
        {
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 1, x1 = x;
        int counter = 0;
        if (x == 0) { return 0; }
        else
        {
            while (counter < 10)
            {
                answer += 1 / x1;
                x1 *= x;
                counter++;
            }
            Console.WriteLine(answer);
            answer = Math.Round(answer, 4);
            return answer;

        }
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        {
            if (x <= -1) { Console.Write("1 "); answer = 1; }
            if (x > -1 && x <= 1) { Console.Write($"{-x} "); answer = -x; }
            if (x > 1) { Console.Write("-1 "); answer = -1; }
        }
        return answer;
    }
    public void Task_1_14()
    {
        int n1 = 1, n2 = 1;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int counter = 1; counter <= 3; counter++)
        {
            n1 = n1 + n2;
            Console.WriteLine(n1);
            n2 = n2 + n1;
            Console.WriteLine(n2);
        }
    }
    public double Task_1_15()
    {
        double answer = 0, num_1 = 1, den_1 = 1;
        double num_2 = 2, den_2 = 1;
        double n1 = 0, n2 = 0;
        n1 = num_1 / den_1;
        n2 = num_2 / den_2;
        for (int counter = 1; counter <= 2; counter++)
        {
            num_1 = num_1 + num_2;
            den_1 = den_1 + den_2;
            n1 = num_1 / den_1;
            num_2 = num_2 + num_1;
            den_2 = den_2 + den_1;
            n2 = num_2 / den_2;
        }
        answer = n1;
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int counter = 1;
        int power = 0;
        do
        {
            answer *= 2; counter++;
        } while (counter < 66);
        counter = 0;
        answer /= 15;
        while (answer >= 10)
        {
            answer /= 10;
            counter++;
            power = counter;
        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10, counter = 3;
        while (counter <= x)
        {
            answer *= 2;
            counter += 3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0, k = 1;
        double slagaemoe = 1;
        while (Math.Abs(slagaemoe) >= 0.0001)
        {
            slagaemoe = Math.Cos(k * x) / (k * k);
            k++;
            answer += slagaemoe;
        }
        //answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
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
        double summa = a, n = 1;
        if (h <= 0) { return answer = 0; }
        while (summa <= p)
        {
            summa += a + n * h;
            n++;
            answer++;
        }
        Console.WriteLine(answer);
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
        int N1 = N, M1 = M;
        if (N == 0 || M == 0 || (N == 0 && M == 0)) { return (quotient, remainder); }
        while (Math.Abs(N) >= Math.Abs(M))
        {
            N -= M;
            quotient++;
            remainder = N;
        }
        if (N1 < 0 && M1 < 0) { return (quotient, Math.Abs(remainder)); }
        Console.WriteLine($"{quotient} {remainder}");
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
        double s = 10, answer = s;
        for (int counter = 1; counter < 7; counter++)
        {
            s = s * 1.1;
            answer += s;
            Console.WriteLine(s);

        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7b()
    {
        double s = 10, S = s;
        int answer = 1;
        while (S < 100)
        {
            s *= 1.1;
            S += s;
            answer++;
            Console.WriteLine(S);
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10;
        for (; ; )
        {
            if (s > 20) { break; }
            s *= 1.1;
            answer++;
            Console.WriteLine(s);
        }
        Console.WriteLine(answer);
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
        double L = 0.1;
        //double atom = 1 / 10;
        //for (int i = 0; i<9; i++)
        //{
        //    atom *= 1 / 10;
        //}
        //Console.WriteLine(atom);
        while (L > Math.Pow(10, -10))
        {
            L *= 0.5;
            answer++;
        }
        Console.WriteLine(answer);
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
        double S = 1, y = 0;
        double element = Math.Cos(x), i1 = 1;
        for (int i = 1; ;)
        {
            element = Math.Cos(i * x) / i1;
            if (Math.Abs(element) < 0.0001) { break; }
            S += element;
            i++;
            i1 *= i;
            y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
            Console.WriteLine($"{S} {y}");
        }
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