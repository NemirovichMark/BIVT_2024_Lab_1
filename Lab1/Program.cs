using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

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
        program.Task_3_1(0.1);
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

        for (int i = 2; i <= 35; i+=3)
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
            answer += (double) 1 / i;
        }
        answer = (Math.Round(answer, 2));
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer = answer + i / (i + 1);
        }
        answer = Math.Ceiling(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double p = 1;
        if (x != 0)
        {
            for (int i = 0; i <= 8; i++)
            {
                answer += Math.Cos((i + 1) * x) / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        else
        {
            answer = 0;
        }
            // end

            return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += Math.Pow(p + i * h, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0.5 * x * x - 7 * x;
        answer = Math.Round(y, 2);
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
        int answer = 1, fact = 1;

        // code here;
        for (int i = 2; i <= 6; i++)
        {
            fact *= i;
            answer += fact;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        int fact = 1;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int s = 1;
            fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
                s *= 5;

            }
            answer += Math.Pow(-1, i) * s / fact;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1, num = 3;

        // code here
        for (int i = 1; i <= 7; i++)
        {
            answer *= num;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine($"1 2 3 4 5 6\n");
        Console.WriteLine($"5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double s = 1;
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / s;
                s *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0; 
        double y;

        // code here
        for (double i = -1.5; i <= 1.5; i += 0.1)
        {
            if (x <= -1) y = 1;
            else if (x <= 1) y = -x;
            else y = -1;
            answer = y;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a, b = 0, c = 1;
        for (int i = 1; i <= 6; i++)
        {
            a = b + c;
            b = c;
            c = a;
            Console.WriteLine(a);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double i = 1, a = 1, b = 1; 
        while (i <= 5)
        {
            double c = a + b;
            double d = a;
            a = c;
            b = d;
            i++;
        }
        answer = a / b;
        answer = Math.Round(answer, 1);
        // end

            return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zern = 2;
        for (int i = 1; i < 64; i++)
        {
            answer += zern;
            zern *= 2;
        }
        answer /= 15;
        while(answer >= 10)
        {
            power++;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0, hgor;
        int r = 6350;

        // code here
        hgor =  (r + x) * (r + x) - (r * r);
        answer = Math.Sqrt(hgor);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0, n = 10, i = 0;

        // code here
        while (i < x)
        {
            i += 3;
            n *= 2;
        }
        answer = n;
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
        int answer = 1;

        // code here
        int p = 1, l = 1;
        while(p * l <= 30000)
        {
            l += 3;
            p *= l;
        }
        answer = l;
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
        double answer = 0, eps = 0.0001, i = 1;
        int n = 0;

        // code here
        if (x < 1)
        {
            while (Math.Abs(i) > eps)
            {
                answer += i;
                n++;
                i = Math.Pow(x, 2 * n);
            }
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
        int n = 10;
        while (n < 100000)
        {
            answer += 3;
            n *= 2;
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
        while (s <= 10000 * 2)
        {
            s *= 1.08;
            answer += 1;
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

        // code here

        double a = 0, b = 1, c = 0, d = 0, e = 0;
        int i = 0;
        do
        {
            e = d;
            d = (a + b) / b;
            c = a;
            a = b;
            b = a + c;
            i++;
        }
        while (Math.Abs(d - e) >= 0.001);
        answer = i;

        // end
        
        return answer;
    }
    #endregion
    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;
        // code here
        double chis = x * x, fact = 2, k = 1;
        int a = -1, b = 4;
        while (Math.Abs(k) >= 0.0001)
        {
            S += k;
            k = a * (chis / fact);
            chis *= x * x;
            fact *= b * (b - 1);
            a *= -1;
            b += 2;
        }

        y = Math.Cos(x);

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