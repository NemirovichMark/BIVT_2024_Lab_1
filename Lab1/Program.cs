using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        for (int x=2; x<=35; x+=3)
        {
            answer += x;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double x=1; x<=10; x++)
        {
            answer += 1 / x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double x = 2; x <= 112; x += 2) 
        {
            answer += x/(x+1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double b = 1;
        // code here
        if (x==0) return 0;
        else
        {
            for (double a=1; a<=9; a++)
            {
                answer += Math.Cos(a * x) / b;
                b *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double a = 0; a<=9; a++)
        {
            answer += (p + a * h) * (p + a * h);
        }
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer =Math.Round( 0.5 * x * x - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int a =2; a<=6; a++)
        {
            answer *= a;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int b = 1;
        // code here;
        for (int a =1; a<=6; a++)
        {
            b *= a;
            answer += b;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        int b = 1;
        int a = 5;
        int c = -1;
        // code here;
        for (int x = 1; x <= 6; x++)
        {
            b *= x; //факториал
            double umn = c * a;
            answer += umn/ b;
            a *= 5;// коэф
            c *= -1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int a=1; a<=7; a++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int a = 1; a <= 6; a++)
        {
            Console.WriteLine($"{a,10}, ' '");
        }
        for (int x = 1; x <= 6; x++)
        {
            Console.WriteLine("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        if (x == 0) return 0;
        else
        {
            for (int b = 0; b <= 10; b++)
            {
                answer += 1 / a;
                a *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        if (x > 1) return -1;
        else
        {
            return -x;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int q1= 1, q2=1;
        for (int x=1; 1<=8; x++)
        {
            if (x <= 2) Console.WriteLine($"{q1,10}");
            else
            {
                int q = q1;
                q1 = q2;
                q2 = q + q1;
                Console.WriteLine($"{q2,10}");
            }
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1, b = 1, a1=1, b1=1, aa=1, bb=1;
        for (int x = 1; x<=5; x++)
        {
            answer = a / b;
            if (a == 1) a++;
            else
            {
                aa = a;
                bb = b;
                a += a1;
                b += b1;
                a1 = aa;
                b1 = bb;
            }
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int a = 1;
        for (int i =0; i<64; i++)
        {
            a *= 2;
        }
        a = a / 15;
        power = (int)Math.Log10(a);
        answer = Math.Round(a / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt(2*R*x+x*x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int q = 10;
        for (int i=1; i<=(x/3); i++)
        {
            q *= 2;
        }
        answer = q;
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
        double p = 1;
        int a = 1;
        while (p<=30000)
        {
            a += 3;
            p *= a;
        }
        answer = a-3;
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
        double s = 1; //сумма
        double q = 1;
        if (Math.Abs(x) < 1)
        {
            while (q >= 0.0001)
            {
                q = q * x * x;
                s += q;
            }
            answer = Math.Round(s, 2);
        }
        else answer = 0;
        
        
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
        int q = 10;
        int n = 0;
        while (q<100000)
        {
            n += 3;
            q *= 2;
        }
        answer = n;
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
        double s = 10000; //сумма вклада
        double r = 0.08;  //процент
        int t = 0; //время
        while (s<20000)
        {
            s += s * r;
            t += 1;
        }
        answer = t;
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

        // code here;
        double a = 1, b = 1, c = 1; //числитель и знаменатель
        double q = 0;               //предыдущая дробь
        for (int i=0; Math.Abs(q - a / b) > 0.001;i++)
        {
            q = a / b;
            c = a;
            a += b;
            b = c;
            answer++;
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
        double s= 1; //член последовательности
        double a = 1, b = 1; //числитель и знаменатель
        for (double i = 1; Math.Abs(s)>=0.0001;i++)
        {
            S += s;
            a *= x * x;
            b *= i;
            s = ((2 * i + 1) * a) / b;
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