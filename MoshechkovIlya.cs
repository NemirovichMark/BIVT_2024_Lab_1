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
        for (int i = 2; i <=35 ; i+=3)
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
        for (double i = 1; i <= 10; i++)
        {
            answer += (1 / i);
            
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        for (double i = 3; i <= 113; i += 2)
        {
            answer += (i - 1) / i;
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        
        
        double a = 1;  // для рассета знаменателя

        for (int i = 1; i <= 9; i++)
        {
            if (x == 0)
            { break; }
            answer += Math.Cos(i * x) / a;
            a *= x;
            
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
        for (int i = 0; i <=9 ; i++)
        {
            answer = answer + (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        for (double i = -4; i <= 4; i += 0.5)
        {
            answer = 0.5 * x * x - 7 * x;

            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
        {
             answer *= (i);
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int a = 1;
        for (int i = 1; i <= 6; i++)
        {
            a *= i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int p = -1;
        int x = 1;
        double a = 1;
        for (int i = 1; i <=6 ; i++)
        {
            a *= i;
            x *= 5;
            answer += p * x / a;
            p = -p;
        }
            answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 1; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
       
        for (int  i = 1; i <=6; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
     
            Console.Write($"{5} ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        

        for (int i = 0; i <= 10; i++)
        {
            if (x == 0)

                { break; }

            answer += (1 / (Math.Pow(x,i)));
            
        }
            answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        
            if (x <= -1.0) answer = 1.0;
            else if (x <= 1.0) answer = -x;
            else answer = -1.0;

            Console.Write($"x= {x}    ");
            Console.WriteLine($"answer= {answer} ");

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine(b);
        for (double i = 1; i < 8; i++)
        {
            c = a;
            a = b;
            b = c + b;

            Console.WriteLine(b);
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 0;
        double b = 1;
        double c = 0;
        Console.WriteLine(b);
        for (double i = 0; i < 5; i++)
        {
            c = a;
            a = b;
            b = c + b; 
            
        }
        answer = b / a;
        
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        power = 18;
        answer = Math.Pow(2, 64)/15/ Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        for (int i = 1; i <= 10; i++)
        {
            answer = (6350 + x) * (6350 + x) - 6350 * 6350;
            answer = Math.Sqrt(answer);
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        x = x / 3;
        int n = 1;
        for (int i = 0 ; i < x; i++)
        {
            n *= 2;
            answer = 10 * n;
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        answer = 1;
        double p = 30000;
        do
        {
            answer += 3;
            p /= answer;
        }
        while (answer <= p);

        
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
        double e = 0.0001;
        double i = 0;
        answer = 1;
        double a = 0;
        if (Math.Abs(x) == 1)
        {
            answer = 0;
            
        }
        else
        { 
            do
            {
            
            i += 2;
            a=Math.Pow(x, i);
            answer += a;
            }
        
            while (a >= e);

            answer = Math.Round(answer, 2);
        }
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
        int a = 10;

        do
        {
            a *= 2;
            answer++;
        }
        while (a<=100000);
        answer = answer * 3;
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
        
        do
        {
            s *= 1.08;
            answer++;
        }
        while (s < 20000);
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
        double a = 0;
        double b = 1;
        double c = 0;
        double s = 0;
        for (answer =0;; answer++)
        {
            c = a;
            a = b;
            b = c + b;
            if (Math.Abs(b / a - s) <= 0.001)
            {
                break;
            }
            s = b / a;

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
        double answer = 0;
        double n = 0;
        int i = 0;
        int fac = 1;
        do
        {

            n = Math.Pow(2 * x, i) / fac;
            S += n;
            i++;
            fac *= i;
            
        }
        while (n >= 0.0001);
        y = Math.Exp(2 * x);
        
        y = Math.Round(y, 2);

        S = Math.Round(S, 2);

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