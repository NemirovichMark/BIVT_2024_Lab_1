using System;
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
        int s = 0, x = 2;
        while (x <= 35)
        {
            s += x;
            x += 3;
        }
        Console.WriteLine(s);
        answer = s;

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        int x = 0;
        while (x < 10)
        {
            x++;
            s += (double)1 / x;
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
        int x = 2;
        while (x <= 112)
        {
            s += (double)x / (x + 1);
            x+=2;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double i;
        // code here
        double n = 1, s = 0;
        if (x!=0)
        { 
            for (i=1; i<=9; i++)
            {
                s+= Math.Cos(i * x) / n;
                n *= x;
            }
        }
        answer = Math.Round(s,2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0,a;
        int n = 0;
        while (n <= 9)
        {
            a = (p + n * h) * (p + n * h);
            s += a;
            n++;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

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
        int i = 0, f = 1;
        while (i <= 5)
        {
            i++;
            f *= i;
        }
        answer = f;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0, f = 1, i = 0;
        while (i <= 5)
        {
            i++;
            f *= i;
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
        double fact = 1, one = 1, i = 1, s=0 , p=1;
        while(i<=6)
        {
            one = -one;
            p *= 5;
            fact *= i;
            s = s + one * p / (fact );
            i++;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 1, i = 0;
        while (i <= 6)
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
        int i = 1;
        for (i=1;i<=6;i++)
        Console.Write(i);

        int x = 1;
        for (x = 1; x <= 6; x++)
        Console.Write(5);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, k=1 ;
        if (x == 0)
            return 0;
        else 
            for (int n = 0; n <= 10; n++)
            {
                s += 1 / k;
                k *= x;
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
        double h = 0.1;
        if (x <= -1)
        {
            answer = 1;
            h += 0.1;
        }
        if (x > -1 && x<=1)
        {
            answer = -x;
            h += 0.1;
        }
        if (x >1)
        {
            answer = -1;
            h += 0.1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x1 = 1, x2= 1, s = 0, i = 1;
        Console.WriteLine(x1);
        Console.WriteLine(x2);
        for (i = 1; i <= 6;)
        {
            s = x1 + x2;
            Console.WriteLine(s);
            x1 = x2;
            x2 =s;
            i++;
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double s=0,i = 0, x = 1, y = 1;
        for (i=1; i<=5;i++)
        {
            answer = x / y;
            s = x;
            x = y+x;
            y = s;
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
        double s = 0, x = 1,y=0, n=1;
        for ( int i=1;i<=64; i++)
        {
            s += n;
            n *= 2;
        }
        y=s /15;
        int k = 0;
        while (y>=2)
        {
            power++;
            y /= 10;
        }
        answer = Math.Round(y, 2);
      
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350, s = 0;
        s= (r + x) * (r + x) - (r * r);
        s = Math.Sqrt(s);
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int y = 10, h=0;
        while (h < x)
        {
            h += 3;
            y *= 2;
        }
        answer =y;
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
        int n = 1;
        double a = 1;
        while (Math.Abs(a) >= 0.0001)
        {
            a = Math.Cos(n * x) / (n * n);
            if (Math.Abs(a) >= 0.0001)
            {
                answer += a;
            }
            n += 1;
        }
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
        double s = a;
        int n = 0;
        if (h > 0)
        {
            while (s <= p)
            {
                n++;
                s += (a + n * h);
            }
        }
        answer = n;
        Console.WriteLine(n);

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
        if(M != 0)
        {
            while(Math.Abs(N) >= Math.Abs(M))
            {
                quotient++;
                N -= M;
            }
            remainder = Math.Abs(N);
        }
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
        double x = 10, day = 1,s=0;
        while(day<=7)
        {
            s += x;
            x *= 1.1;
            day++;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double x = 10, s = 0;
        int day = 0;
        while (s <= 100) 
        {
            s += x;
            x *= 1.1;
            day++;
        }
        answer = day;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double x = 10, s = 0;
        while (x<=20)
        {
            x *= 1.1;
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
        double L = 0.1, D = Math.Pow(10, -10);
        int k = 0;
        while (L>=D)
        {
            L /= 2;
            k++;
        }
        answer = k;
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
        double p = 1, f = 1, a = 1, s = 0, i = 0;
        double b = p * a / f;
        while (Math.Abs(b) > 0.0001)
        {
            s += b;
            i++;
            p *= (-1);
            f *= (2 * i) * (2 * i - 1);
            a *= x * x;
            b= p * a / f;
            y = Math.Cos(x);
        }
        S = s;
        Console.WriteLine(S);
        Console.WriteLine(y);
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