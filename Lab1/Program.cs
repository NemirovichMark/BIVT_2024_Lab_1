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
        //program.Task_2_3(0.2, -1.9, 12);
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
        program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double s = 0;
        for (int i = 1; i <= 10; i++)
        {
            s += 1.0 / i;
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        double s = 0;
        for (int a = 2; a <= 112; a = a + 2)
        {
            s = s + a / (a + 1.0);
        }
        answer = s;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double del = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / del;
            del = del * x;
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + (i * h)) * (p + (i * h));
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = 0.5 * (x * x) - 7 * x;
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        int s = 1;
        for (int i = 6; i > 1; i--)
        {
            s = s * i;
        }
        answer = s;
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int s = 1, fac = 1;
        for (int i = 2; i <= 6; i++)
        {
            fac *= i;
            s += fac;
        }
        answer = s;
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double d = 1;
        double b = 1;
        for (int i = 1, f = 1; i <= 6; i++)
        {
            f *= i;
            d *= (-1);
            b *= 5;
            answer += (d * b)/ f;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        int s = 1;
        for (int i = 0; i < 7; i++)
        {
            s *= 3;
        }
        answer = s;
        Console.WriteLine(answer);

        return answer;
    }
    public void Task_1_11()
    {
        Console.Write("a)");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.Write("á)");
        for (int n = 1; n <= 6; n++)
        {
            Console.Write("5 ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 1;
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

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x <= -1.0) answer = 1;
        if (x > -1 && x <= 1) answer = -x;
        if (x > 1) answer = -1;

        return answer;
    }
    public void Task_1_14()
    {
        int x = 1, x1 = 1, s = 1;
        Console.WriteLine(x);
        Console.WriteLine(x1);
        for (int i = 1; i <= 6; i++)
        {
            s = x1;
            x1 = x + x1;
            x = s;
            Console.WriteLine(x1);
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        double x1 = 1, x2 = 1, x3 = 2, x4 = 1, s = 0, S = 0;
        for (int i = 1; i <= 3; i++)
        {
            s = x3;
            S = x4;
            x3 = x1 + x3;
            x4 = x2 + x4;
            x1 = s; x2 = S;
            Console.WriteLine(x3 / x4);
        }
        answer = x3 / x4;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
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

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        answer = Math.Round(Math.Pow(Math.Pow(x + 6350, 2) - Math.Pow(6350, 2), 0.5), 2);
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int cell = 10;
        while (x > 0)
        {
            x -= 3;
            cell *= 2;
        }
        answer = cell;
        Console.WriteLine(answer);

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double s = 0;
        int i = 1;
        while (Math.Abs(Math.Cos(i * x) / (i * i)) >= 0.0001)
        {
            s += Math.Cos(i * x) / (i * i);
            i++;
        }
        answer = s;
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
        double s = 0;
        if (h < 0)
        {
            answer = 0;
            return answer;
        }
        for (int i = 0; ;i++)
        {
            s += a + i * h;
            if (s > p) 
            {
                break;
            }
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
        if (M == 0) { quotient = 0; remainder = 0; return (quotient, remainder); }
        remainder = N;
        while (remainder >= M)
        {
            remainder = remainder - M;
            quotient++;
        }
        Console.WriteLine(quotient);
        Console.WriteLine(remainder);

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
        double dis = 10;
        int days = 10;
        for (int i = 1; i <= 7; i++)
        {
            answer += dis;
            dis *= 1.1;
        }    
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double dis = 10;
        int days = 10;
        double j = 0;
        for (int i = 1; ; i++)
        {
            j += dis;
            dis *= 1.1;
            if (j >= 100)
            {
                answer = i;
                break;
            }
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double dis = 10;
        int days = 10;
        double j = 0;
        for (int i = 1; ; i++)
        {
            j += dis;
            dis *= 1.1;
            if (dis >= 20)
            {
                answer = i;
                break;
            }
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
        double k = 1, j = 1;
        S = 0;
        for (int i = 0; ; i++)
        {
            if (i != 0) { k *= x * x; }
            if (i != 0) { j *= (i * 2 - 1) * (i * 2); }
            if (Math.Abs(k / j) < 0.0001) { break; }
            S += k / j;
        }
        double math1 = Math.Exp(x * Math.Log(Math.E));
        double math2 = 1 / math1;
        y = (math1 + math2) / 2.0;
        Console.WriteLine(S);
        Console.WriteLine(y);

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
