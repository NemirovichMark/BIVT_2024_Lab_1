using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

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
        //program.Task_1_6(-4.0);
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
        //program.Task_1_18(3);
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
        int i = -1;
        while (i<35)
        {
            i += 3;
            answer += i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double d = 1; d <= 10; d++)
        {
            answer += 1 / d;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double d = 2;
        while(d <= 112)
        {
            answer += d / ( d + 1 ) ;
            d += 2;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double y = 1;

        if  (x == 0)
        {
            Console.WriteLine("0");
            return 0;
        }

        while (i <= 9)
        {
            answer += Math.Cos(i*x) / y;
            y *= x;
            i++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine($"x={y}\t {answer}");
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while (i<=9)
        {
            answer += ((p + h * i) * (p + h * i));
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        //while (x<=4)
        //{
        double y = 0.5 * x * x - 7 * x;
        Console.WriteLine("x={0:f2} \t y = {1:f2}", x, y);
        answer = Math.Round(y, 2);
        //x += 0.5;
        //}
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        int n = 6;
        // code here
        for (int i = 1; i <=n; i++)
        {
            answer = answer * i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int p = 1;
        int n = 6;
        // code here;
        for (int i = 1; i<=n; i++)
        {
            p = p * i;
            answer += p;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        
        // code here;
        double p = 1;
        double y = 1;
        for (double i = 1; i <= 6; i++)
        {
            y *= (5 / i);
            p = -p;
            answer += (p * y);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        int n = 3;
        // code here
        for (int i = 1; i<=7; i++)
        {
            answer *= n;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 0; i<=10; i++)
        {
            answer += 1 / y;
            y *= x;
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        // code here
        //for (double i = x; i>=-1.5 && i<=1.6; i+=0.1)
        //{
        //if (i <= -1.0) answer = 1.0;
        //else if (i <= 1.0) answer = -i;
        //else answer = -1.0;
        //Console.WriteLine("x={0:f2} \t y = {1:f2}", i, answer);
        //}
        //Console.WriteLine() ;

        if (x <= -1.0) answer = 1.0;
        else if (x <= 1.0) answer = -x;
        else answer = -1.0;

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1;
        int n2 = 1;
        Console.Write(n1 + " " + n2 + " ");
        for (int i = 0; i <= 5; i++)
        {
            int sum = n1 + n2;
            n1 = n2;
            n2 = sum;
            Console.Write(sum + " ");

        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int ch1 = 1;
        int zn1 = 1;
        int ch2 = 2;
        int zn2 = 1;
        int ch; int zn;
        for (int i = 3; i<=5; i++)
        {
            ch = ch1 + ch2;
            zn = zn1 + zn2;
            ch1 = ch2;
            ch2 = ch;
            zn1 = zn2;
            zn2 = zn;
        }
        answer = (double)ch2 / zn2;
        Console.WriteLine(answer) ;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double y = 1;
        for (int i = 0; i < 64; i++)
        {
            y *= 2;

        }
        y /= 15;
        while (y > 10)
        {
            y /= 10;
            power++;
        }
        answer = y;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer) ;
        Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        //while (x <= 10)
        //{
            answer = Math.Round(Math.Sqrt((r + x) * (r + x) - r * r),2);
            //x++;
        //}
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int a = 3; a<=x; a+=3)
        {
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
        const double eps = 0.0001;
        double n = 1;
        double y = Math.Cos(x);
        while (Math.Abs(y) >= eps)
        {
            answer += y;
            n++;
            y = Math.Cos(n * x) / (n * n);
        }
        // end
        answer = Math.Round(answer,2);
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

        // code here
        double s = 0;
        int n = 0;
        while (s <= p)
        {
            s += (a + n * h);
            n++;
            if (h < 0)
            {
                return 0;
            }
        }
        n = n - 1;
        answer = n;
        // end

        return (answer);
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
        if (M == 0)
        {
            return (quotient, remainder);
        }
        while (Math.Abs(N) >= Math.Abs(M))
        {
            quotient++;
            N -= M;
        }
        remainder = Math.Abs(N);
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
        double p = 10;
        for (int n = 1; n<=7; n++)
        {
            answer += p;
            p += (p / 10);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double p = 10;
        for (double s = 0; s<100; answer++)
        {
            s += p;
            p += (p / 10);
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double p = 10;
        while (p <= 20)
        {
            p += (p / 10);
            answer++;
        }
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
        double l = 0.1;
        while (l > Math.Pow(10,-10))
        {
            l /= 2;
            answer++;
        }
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
        double i = 0, f = x, n = 1, p = 1;
        const double eps = 0.0001;
        while (Math.Abs((n)) >= eps)
        {
            n = (p * f / (2 * i + 1));
            S += n;
            p = -p;
            f *= (x * x);
            i++;
        }
        y = Math.Atan(x);
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
        // end

        return (S, y);
    }
    #endregion
}