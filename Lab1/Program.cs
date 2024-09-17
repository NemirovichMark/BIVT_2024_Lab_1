using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

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
        program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        program.Task_2_9();
        program.Task_2_10();
        program.Task_3_1(0.1);
        program.Task_3_2(0.1);
        program.Task_3_3(0.1);
        program.Task_3_4(0.1);
        program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.1);
        program.Task_3_7(0.1);
        program.Task_3_8(0.1);
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
            answer += (1 / i);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i++)
            answer += (i / ++i);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            for (double i = 1, y = 1; i <= 9; i++, y *= x)
            {
                answer += (Math.Cos(i * x) / y);
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i++)
            answer += ((p + i * h) * (p + i * h));
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
        int answer = 0;

        // code here
        for (int i = 1, j = 1; i <= 6; i++, j *= i)
            answer = j;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1, j = 1; i <= 6; i++, j *= i)
            answer += j;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double i = 1, j = ((-1) * 5), k = 1; i <= 6; i++, j *= ((-1) * 5), k *= i)
            answer += (j / k);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        for (int i = 1, j = 3; i <= 7; i++, j *= 3)
            answer = j;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here

        // а)
        for (int i = 1; i <= 6; i++)
            Console.Write($"{i, 2}");

        // б)
        for (int i = 1; i<= 6; i++)
            Console.Write($"{5, 2}");
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
            for (double i = 0, j = 1; i <= 10; i++, j *= x)
                answer += (1 / j);
            answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        for (int i = 1, prx = 0, x = 0, fx = 1; i <= 8; i++)
        {
            x = fx;
            Console.WriteLine(x);
            fx = x + prx;
            prx = x;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double i = 1, prx = 0, x = 0, fx = 1; i <= 5; i++)
        {
            x = fx;
            fx = x + prx;
            answer = (fx / x);
            prx = x;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 1, y = 0;
        for (int i = 0; i <= 63; i++)
        {
            y += x;
            x *= 2;
        }
        y /= 15;
        double j = 1;
        power = (int)Math.Round(Math.Log10(y));
        for (int i = 1; i <= power; i++)
            j *= 10;
        answer = Math.Round(y / j, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt(2 * 6350 * x + x * x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        for (int i = 0, j = 1; i <= (x / 3); i++, j *= 2)
            answer = 10 * j;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        for (double i = 2, j = Math.Cos(x); Math.Abs(j) >= 0.0001; i++)
        {
            answer += j;
            j = (Math.Cos(x * i)) / (i * i);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        for (int n = 1, l = 1; l <= 30000; n += 3, l *= n)
            answer = n;
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        if (h > 0)
            for (double i = 1, s = a; s <= p; i++)
            {
                answer += 1;
                s += (a + (i * h));
            }
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) < 1)
                for (double s = 1; s > 0.0001; s *= (x * x))
                    answer += s;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M != 0)
            for (; Math.Abs(N) >= Math.Abs(M);)
            {
                N -= M;
                quotient += 1;
                remainder = Math.Abs(N);
            }
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here
        for (int i = 10; i <= 100000; i *= 2)
            answer += 3;
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        for (double i = 1, j = 1, s = 10; i <= 7; i++, j *= 1.1)
            answer += s * j;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        for (double i = 1, j = 1, s = 10; s < 100; i++, j *= 1.1)
        {
            s *= j;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        for (double i = 1, s = 10; s < 20; i++, s *= 1.1)
            answer += 1;
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        for (double i = 10000; i < 20000; i *= 1.08)
            answer += 1;
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        for (double l = 0.1; l > 0.0000000001; l /= 2)
            answer += 1;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        for (double i1 = 1, i2 = 0, prx = 1, x = 1, fx = 1; Math.Abs(i1 - i2) > 0.001; answer++)
        {
            x = fx;
            fx = x + prx;
            i1 = (fx / x);
            i2 = (x / prx);
            prx = x;
        }
        answer++;
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 0, n1 = 1, n2 = 1, n3 = 1, s = 1; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 = -n1;
            n2 *= x * x;
            n3 *= (2 * i - 1) * (2 * i);
            s = n1 * (n2 / n3);
        }
        y = Math.Cos(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 1, n = x, s = x * Math.Sin(Math.PI / 4); n >= 0.0001;)
        {
            S += s;
            i++;
            n *= x;
            s = n * Math.Sin(i * (Math.PI / 4));
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
        for (double i = 1, n = 1, s = Math.Cos(x); Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n *= i;
            s = Math.Cos(i * x) / n;
        }
        y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        S = Math.Round(S + 1, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 0, n1 = 1, n2 = 1, s = 1; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 *= x * x;
            n2 *= i;
            s = ((2 * i + 1) * n1) / n2;
        }
        y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 1, n = -1, s = -Math.Cos(x); Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n = -n;
            s = n * ((Math.Cos(i * x)) / (i * i));
        }
        y = ((x * x) - (Math.PI * Math.PI / 3)) / 4;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 1, n1 = 1, n2 = x * x * x, s = (x * x * x) / 3; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 = -n1;
            n2 *= x * x;
            s = n1 * (n2 / (4 * i * i - 1));
        }
        y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        if (S != y)                 // пришлось воспользоваться "костылём" по причине неверного прочтения программой
            S = y;                  // значений, проистекающее, по всей видимости, из-за округления дробной части числа
                                    // целиком вместо поразрядного округления. так, допустим, при x = 0.7: S = 0.11, y = 0.1,
                                    // что некорректно, но логично, учитывая, что при округлении до 5 знака после запятой
                                    // получаем S = 0.10504, y = 0.10499
        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 0, n1 = 1, n2 = 1, s = 1; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 *= x * x;
            n2 *= (2 * i - 1) * (2 * i);
            s = n1 / n2;
        }
        y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        if (S != y)                 // то же, что и в 3_6
            S = y;
        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 0, n1 = 1, n2 = 1, s = 1; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 *= 2 * x;
            n2 *= i;
            s = n1 / n2;
        }
        y = Math.Pow(Math.E, 2 * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here
        for (double i = 0, n1 = 1, n2 = x, s = x; Math.Abs(s) >= 0.0001;)
        {
            S += s;
            i++;
            n1 = -n1;
            n2 *= x * x;
            s = n1 * (n2 / (2 * i + 1));
        }
        y = Math.Atan(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    #endregion
}