using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        int i = 2;
        while (i <= 35)
        {
            answer += i;
            i += 3;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double i = 1;
        while (i <= 10)
        {
            answer += (1 / i);
            i++;
        }
        Console.WriteLine(answer);
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i = 2;
        while (i <= 112)
        {
            answer += (i / (i + 1));
            i += 2;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double drob = 0, step = 1;
        if (x == 0)
            return 0;
        // code here
        for (int k = 1; k <= 9; k++)
        {
            drob = Math.Cos(x * k) / step;
            step *= x;
            answer += drob;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        // code here
        for (int k = 0; k <= 9; k++)
        {
            answer += (p + k * h) * (p + k * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(answer, 2);
        
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int f = 1; f <= 6; f++)
        {
            answer *= f;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int f = 1;
        // code here;
        for (int pr_f = 1; pr_f <= 6; pr_f++)
        {
            f *= pr_f;
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, drob = 0;
        double f = 1; 
        int x = -1, const5 = 5;
        // code here;
        for (int pr_f = 1; pr_f <= 6; pr_f++)
        {
            f *= pr_f;
            drob = (x * const5) / f;
            answer += drob;
            x = -x;
            const5 *= 5;
            
            
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;
        // code here
        for (int stepen = 1; stepen <= 6; stepen++)
        {
            answer *= 3;
            Console.WriteLine(answer);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int x = 0; x <= 5;)
        {
            x += 1;
            Console.WriteLine(x);
        }
        int col = 0;
        while (col <= 5)
        {
            col++;
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double step_x = x;
        // code here
        if (x == 0)
            return 0;
        for (int stepen = 1; stepen <= 10; stepen++)
        {
            answer += 1 / step_x;
            step_x *= x;
            
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
            return 1;
        if (-1 < x && x <= 1)
            return -x;
        if (x > 1)
            return -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x1 = 1, x2 = 0, fib = 1;
        for (int col_p = 0; col_p < 8; col_p++)
        {
            x1 = fib;
            Console.WriteLine(x1);
            fib = x1 + x2;
            x2 = x1;
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        //code here
        double drob = 0;
        int perv_chis = 1, vtor_chis = 0;
        int perv_znamen = 1, vtor_znamen = 0;
        int fib = 1, fib2 = 1;
        double answer1 = 0, answer2 = 0;
        for (int col_p_ch = 0; col_p_ch < 6; col_p_ch++)
        {
            perv_chis = fib;
            Console.WriteLine(perv_chis);
            fib = perv_chis + vtor_chis;
            vtor_chis = perv_chis;
            answer1 = perv_chis;

        }
        for (int col_p_znm = 0; col_p_znm < 5; col_p_znm++)
        {
            perv_znamen = fib2;
            Console.WriteLine(perv_znamen);
            fib2 = perv_znamen + vtor_znamen;
            vtor_znamen = perv_znamen;
            answer2 = perv_znamen;

        }
        answer = answer1 / answer2;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double col_z = 1;
        int step = 0;
        // code here
        for (; step <= 63; step++)
        {
            answer += col_z / 15;
            col_z *= 2;
        }
        Console.WriteLine(answer);
        power = (int)Math.Log10(answer);
        Console.WriteLine(power);
        answer /= Math.Pow(10, 18);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        // code here
        answer = Math.Sqrt(((r + x) * (r + x) - r * r));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here

        while (x > 0)
        {
            answer *= 2;
            x -= 3;
        }
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
        

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int n = 1;
        for (int p = 1; p < 30000; p *= n)
        {
            answer = n;
            n += 3;
            Console.WriteLine(answer);

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
        if (x >= 1)
            return 0;

        // code here
        
        double ch_sum = 1;
        while (ch_sum > 0.0001)
        {
            answer += ch_sum;
            ch_sum *= x * x;
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
        int answer = 10;
        int x = 0;
        // code here
        while (answer <= Math.Pow(10, 5))
        {
            x += 3;
            answer *= 2;
            
        }
        Console.WriteLine(x);
        // end

        return x;
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
        for (double s = 10000; s <= 20000; )
        {
            s *= 1.08;
            answer++;
        }
        Console.WriteLine(answer);
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
        
        double perv_chis = 1, vtor_chis = 2;
        double perv_znamen = 1, vtor_znamen = 1;
        double fib = 0, fib2 = 0;
        
        answer += 2;
        while (Math.Abs(perv_chis / perv_znamen - vtor_chis / vtor_znamen) >= 0.001)
        //for (int col_p_ch = 0; col_p_ch <= 100; col_p_ch++)
        {


            fib = vtor_chis;
            Console.WriteLine($"{perv_chis} {vtor_chis}");
            vtor_chis = perv_chis + vtor_chis;
            perv_chis = fib;

            fib2  = vtor_znamen;
            Console.WriteLine($"{perv_znamen} {vtor_znamen}");
            vtor_znamen = perv_znamen + vtor_znamen;
            perv_znamen = fib2;
            
            answer++;

        }   
            
        

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
        double S = 1, y = 0;

        // code here

        double elem = 2 * x;
        double i = 2;
        double f_znamen = 2;
        double st = 2 * x;

        while (elem > 0.0001)
        {
            S += elem;
            st *= (2 * x);
            elem = (st / f_znamen);
            i++;
            f_znamen *= i;
            
            y = Math.Exp(2 * x);
        }

        // end
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);

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