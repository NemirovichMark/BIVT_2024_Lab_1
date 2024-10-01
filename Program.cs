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
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
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
        for (int i = 1; i <= 10; i++)
        {
            s += 1.0 / i;
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int a = 2; a <= 112; a = a + 2)
        {
            s = s + a / (a + 1.0);
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double delitel = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / delitel;
            delitel = delitel * x;
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + (i * h)) * (p + (i * h));
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * (x * x) - 7 * x;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 6; i > 1; i--)
        {
            s = s * i;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1, factorial = 1;
        for (int i = 2; i <= 6; i++)
        {
            factorial *= i;
            s += factorial;
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
        double s = 0;
        for (int i = 1, f = 1; i <= 6; i++)
        {
            f = i;
            s += Math.Pow((-1), i) * ((Math.Pow(5, i)) / f);
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 0; i < 7; i++)
        {
            s *= 3;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("a)");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.Write("б)");
        for (int n = 1; n <= 6; n++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        // code here
        // проверить если x = 0
        double s = 1;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 1; i <= 10; i++)
        {
            s /= x;
            answer += s;
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
        if (x <= -1.0) answer = 1;
        if (x > -1 && x <= 1) answer = -x;
        if (x > 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        // code here
        int x = 1, y = 1, z = 1;
        Console.WriteLine(x);
        Console.WriteLine(y);
        for (int i = 1; i <= 6; i++)
        {
            z = y;
            y = x + y;
            x = z;
            Console.WriteLine(y);

        }
    }
        public double Task_1_15()
        {
            double answer = 0;

            // code here
            double s = 0, S = 0, x = 1, y = 1, w = 2, z = 1;
            for (int i = 1; i <= 3; i++)
            {
                s = w;
                S = z;
                w = x + w;
                z = y + z;
                x = s; y = S;
                Console.WriteLine(w / z);
            }
        answer = w / z;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double a = 1;
        for (int i = 0; i < 64; i++)
        {
            answer += a;
            a = a * 2;
        }
        answer = answer / 15;
        for (; answer > 10; answer = answer / 10)
        {
            power += 1;
        }
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
        answer = Math.Round(Math.Sqrt(((x + 6350) * (x + 6350)) - (6350 * 6350)), 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int cell = 10;
        while (x > 0)
        {
            x -= 3;
            cell *= 2;
        }
        answer = cell;
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
        double s = 0;
        int i = 1;
        while (Math.Abs(Math.Cos(i * x) / (i * i)) >= 0.0001)
        {
            s += Math.Cos(i * x) / (i * i);
            i++;
        }
        answer = s;
        Console.WriteLine(answer);
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
        int z = 0;
        double s = 0;
        if (h < 0)
        {
            z = 0;
            return z;
        }
        for (int i = 0; ; i++)
        {
            s += a + i * h;
            if (s > p)
            {
                break;
            }
            z++;
        }
        answer = z;
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
        int q = 0, r = 0;
        if (M == 0) { q = 0; r = 0; return (q, r); }
        r = N;
        while (r >= M)
        {
            r = r - M;
            q++;
        }
        Console.WriteLine(q);
        Console.WriteLine(r);

        // end

        return (q, r);
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
        double s = 0;
        double distance = 10;
        int days = 10;
        for (int i = 1; i <= 7; i++)
        {
            s += distance;
            distance *= 1.1;
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        int s = 0;
        double distance = 10;
        int days = 10;
        double j = 0;
        for (int i = 1; ; i++)
        {
            j += distance;
            distance *= 1.1;
            if (j >= 100)
            {
                s = i;
                break;
            }
        }
        answer = s;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        int s = 0;
        double distance = 10;
        int days = 10;
        double j = 0;
        for (int i = 1; ; i++)
        {
            j += distance;
            distance *= 1.1;
            if (distance >= 20)
            {
                s = i;
                break;
            }
        }
        answer = s;
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
        double a = 1;
        double l = 0.1;
        for (int i = 1; i <= 10; i++)
        {
            a /= 10;
        }
        while (l > a)
        {
            l = l / 2;
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
        double chisl = x, drob = x, znak = 1;
        for (int i = 1; Math.Abs(drob) >= 0.0001; i++)
        {
            S += drob;
            chisl *= x * x;
            znak = -znak;
            drob = znak * chisl / (2 * i + 1);
            if (Math.Abs(drob) <= 0.0001)
                break;
        }
        Console.WriteLine(S);
        y = Math.Atan(x);
        // end

        return (S, y);
    }
    #endregion
}
