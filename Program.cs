using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;

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
        for (int i = 2; i <= 35; i += 3)
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
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
            answer = answer + i / (i + 1.0);
        // end
        answer = Math.Round(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double y = 1;
        // code here
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
        // end
        answer = Math.Round(answer, 2);
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
        const double h = 0.5;
        answer = 0.5 * x * x - 7 * x;
        x = x + h;
        answer = Math.Round(answer, 2);
        // end
        return answer;

    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int a = 1; a <= 6; a++)
            f = f * a;
        answer = f;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for (int a = 1; a <= 6; a++)
        {
            f = f * a;
            answer = answer + f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1; double c = 1; double d = 1;
        for (int a = 1; a <= 6; a++)
        {
            f = a * f;
            c = c * (-1);
            d = d * 5;

            answer = answer + c * d / f;
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
        for(int i = 1; i <= 7; i++)
        {
            answer = answer * 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("а)");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine(",");
        Console.Write("б)");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($" 5");
        }
        Console.WriteLine(".");
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
            y *= x;
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
        Console.Write($"{n1} {n2} ");
        for (int i = 3; i <= 8; i++)
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double num1 = 1, znam1 = 1;
        double num2 = 2, znam2 = 1;

        double num3 = 0, znam3 = 0;
        for (int i = 3; i <= 5; i++)
        {
            num3 = num1 + num2;
            znam3 = znam1 + znam2;

            num1 = num2;
            znam1 = znam2;
            num2 = num3;
            znam2 = znam3;
        }
        answer = num3 / znam3;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        BigInteger zerna = 0;
        BigInteger zernonakletke = 1;
        for ( int i = 0; i < 64; i++)
        {
            zerna = zerna + zernonakletke;
            zernonakletke *= 2;
        }
        BigInteger mantissa = zerna / 15;
        answer = (double)mantissa;
        
        while (answer >= 10.0)
        {
            answer = answer / 10.0;
            power++;
        }
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
        int answer = 0;

        // code here
        int n = 1;
        for (int i = 0; i < x/3; i ++)
        {
            n *= 2;
        }
        answer = 10 * n;
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
        int current = 1, product = 1;
        const int L = 30000;
        while (product * (current + 3) < L)
        {
            current += 3;
            product *= current;
            answer = current;
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
        const double epsil = 0.0001;
        double term = 1;
        while (term >= epsil && x < 1)
        {
            answer += term;
            term *= x * x;
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
        int v = 100000;
        int n = 10;
        while (n < v)
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
        double n = 10000, p = 0.08;
        while (n < 20000)
        {
            n = n + n * p;
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
        int answer = 2;

        // code here
        double  chisl= 1, znam = 1;            
        double achisl = 2, bznam = 1;         
        double epsil = 0.001;              

        while (true)
        {
            double a = achisl + chisl;
            double b = bznam + znam;
            double now = a / b;
            double pred = achisl / bznam;

            if (Math.Abs(now - pred) < epsil)
            {
                return answer + 1;
            }

            chisl = achisl;
            znam = bznam;
            achisl = a;
            bznam = b;

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
        
        double epsilon = 0.0001;
        int i = 1;
        double term = 1;
        double xstep = x*x*x;
        int sign = 1;

        while(Math.Abs(term) > epsilon)
            {
                term = sign * xstep / (4 * i * i - 1);
                if (Math.Abs(term) < epsilon)
                break;
                S += term;
                xstep *= x * x;
                sign *= -1;
                i++;
            }

        y = ((1 + x * x) * Math.Atan(x)) / 2 - (x / 2);
        Console.WriteLine($"s = {S}, y = {y}");
        // end

            return (Math.Round(S, 10), Math.Round(y, 10));
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