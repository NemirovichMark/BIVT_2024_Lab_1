using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
    int Factorial(int n)
    {
        if (n == 1) return 1;

        return n * Factorial(n - 1);
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
            answer = Math.Round(answer + 1/i, 3);
            i++;
        }
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i = 2;
        double j = 3;
        while (i <= 112)
        {            
            answer += i/j;
            i = i + 2;
            j = j + 2;
        }
        answer = Math.Round(answer, 4);
        // погрешность
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;


        // code here
        if (x == 0)
        {
            return 0;
        }

        double i = 1;       
        while (i <= 9)
        {
            answer += Math.Cos(i * x) / Math.Pow(x, i-1);
            i++;
        }
        
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while (i <= 9)
        {
            answer += Math.Pow(p + i * h, 2);
            i++;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;

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
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        
        for (int i = 1; i <= 6; i++)
        {
            answer += Factorial(i);
        }
        
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i);
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
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
        if (x == 0)
        {
            return 0; 
        }
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / Math.Pow(x, i); 
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else if (x < -0.9)
        {
            answer = 1;
        }
        else if (x > 0.9)
        {
            answer = -1;
        }
        else if (-0.9 <= x || 0.9 <= x)
        {
            answer = x * -1;
        }     
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task       
        int a = 1;
        int b = 0;
        for (int i = 0; i < 8; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
            Console.Write($"{temp} ");
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double b = 1;
        for (int i = 0; i < 5; i++)
        {
            answer = a + b;
            a = b;
            b = answer;                      
        }
        answer = Math.Round(b / a, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 1; i <= 64; i++)
        {
            answer += Math.Pow(1 * 2, power);
            power++;
        }
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

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

        // end

        return (S, y);
    }
    #endregion
}