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
        for (int num = 2; num <= 35; num += 3)
        {
            answer += num;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double z ;
        double s = 1;
        for (z = 1; z <= 10; z += 1)
        {
            s = 1/z;
            answer += s;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i;
        double s;
        for (i = 3; i <= 113; i += 2)
        {
            s = 1 - (1 / i);
            answer += s;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x!=0)
        {
            double i = 1;
            double z = 1;
            double s;
            for (i = 1; i <= 9; i += 1)
            { 
                s = Math.Cos(i * x) / z;
                z *= x;
                answer += s;
            }
        }    
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s;
        double i = 0;
        for (i = 0; i <= 9; i += 1)
        {
            s = (p + i * h) * (p + i * h);
            answer += s;
        }
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here        
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int i = 1;
        int s = 1;
        for (i = 1; i <= 6; i += 1)
        {
            s *= i;
            answer = s;
        }
        System.Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1;
        int i;
        for (i = 1; i <= 6; i += 1)
        {
            s *= i;
            answer += s;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1;
        double s = 0;
        double step = 1;
        double step1 = 1;
        for (double i = 1; i <= 6; i += 1)
        {
            f *= i;
            s = ((-1 * step) * (5 * step1)) / f;
            step *= -1;
            step1 *= 5;
            answer += s;
        }
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3;
        double i;
        for (i = 1; i <= 1; i += 1)
        {
            s  =  3*3*3*3*3*3*3;
            answer += s;
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        double s = 5;
        double i;
        for (i = 1; i <= 6; i += 1)
        {
            System.Console.Write($"{i} ");
        }
        System.Console.Write(" \n");
        for (i = 1; i <= 6; i += 1)
        {
            System.Console.Write($"{s} ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double znamen = 1;
        double s = 0;
        for (double i = 0; i <= 10; i += 1)
        {
            if (x == 0)
                answer = 0;
            else
            {
                s = 1 / znamen;
                znamen *= x;
                answer += s;
            }
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double h = - 1.5; h <= 1.5; h += 0.1)
        {
            if (x <= -1)
                answer = 1;
            else if (x > -1 && x <= 1)
            {
                answer = -x;
            }
            else if (x > 1)
            {
                answer = -1;
            }
        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        double i1 = 1;
        double i2 = 1;
        double i3;
        double c;
        System.Console.WriteLine(i1);
        System.Console.WriteLine(i2);
        for (c = 1; c <= 6; c += 1)
        {
            i3 = i1 + i2;
            i1 = i2;
            i2 = i3;
        System.Console.WriteLine(i3);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double c1 = 1;
        double znam1 = 1;
        double c2 = 2;
        double znam2 = 1;
        double znam3 = 1;
        double c3 = 1;
        double i1 = c1 / znam1;
        double i2 = c2 / znam2; 
        for (double d = 1; d <= 5; d +=1)
        {
            c3 = c1 + c2;
            c1 = c2;
            c2 = c3;
            znam3 = znam1 + znam2;
            znam1 = znam2;
            znam2 = znam3;
        }
        double i3 = c3 / znam3;
        answer += i3;
        answer = Math.Round(answer , 1);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zerno = 1;
        double d = 0;
        for (int i = 1; i <= 64; i += 1)
        {
            zerno *= 2;
        }
        zerno = zerno / 15;
        power = (int)Math.Log10(zerno);
        for (int i = 1; i < power + 1; i += 1)
        {
            zerno = zerno / 10;
        }
        answer = zerno;
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        System.Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt(((R + x) * (R + x)) - (R * R));
        answer = Math.Round(answer , 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 10;
        while (x > 0)
        {
            x -= 3;
            k *= 2;
        }
        answer += k;
        System.Console.WriteLine(answer);
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
        int n = 1;
        int L = 30000;
        int p = 1;
        for (p = 1; p < L; p *= n)
        {
            answer = n;
            n += 3;
        } 
        System.Console.WriteLine(answer);
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
        answer = 1;
        double n = 1;
        double e = 0.0001;
        double s = 0;
        if (Math.Abs(x) >= 1)
            return 0;


        for (n = 1; n >= e; n *= (x * x))
        {
            s += n;

        } 
        answer = s;
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
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
        int ameba = 10;
        while (ameba <= 100000)
        {
            if (ameba == 100000)
                System.Console.WriteLine(answer);
            else 
            {
                answer += 3;
                ameba *= 2;
            }
        }
        System.Console.WriteLine(answer);
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
        int sum = 10000;
        int t = 0;
        while (sum < 20000)
        {
            sum = (sum / 100) * 108;
            t += 1;
            answer = t;
        }
        System.Console.WriteLine(answer);
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
        double a = 1, b = 1, c = 0;
        double current = 0, previous = 0;
        int count = 0;

        do
        {
            previous = current;
            current = a / b;
            c = a;
            a += b;
            b = c;
            count++;
        }
        while (Math.Abs(current - previous) > 0.001);
        answer = count;
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
        double i = 1;
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        double t = 1, power = x;
        while (power > 0.0001)
        {   
            t = power * Math.Sin((i * Math.PI) / 4);
            S += t;
            i++;
            power *= x;
        }
        System.Console.WriteLine(S + " " + y);
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