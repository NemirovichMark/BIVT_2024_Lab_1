using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        program.Task_1_2();
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
        //program.Task_2_1(1.6);
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
        for (int k = 2; k <= 35; k += 3) { answer += k; }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int k = 1; k <= 10; k++) { answer += 1.0 / (double)k; Console.WriteLine(1.0 / k); }
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double k = 2; k <= 112; k += 2) 
        { 
            answer += k / (k + 1);
            //Console.WriteLine("{0} {1} {2}",k,answer, k / (k + 1));
        }
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x==0) return answer; // division by zero is not possible
        for (double k = 1; k <= 9; k++)
        {
            answer += Math.Cos(k * x) / Math.Pow(x, k - 1);
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double n = 0; n <= 9; n++) { answer += Math.Pow(p + n * h, 2); }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int k=1; k<=6; k++) { answer *= k; }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int step=1; step<=6; step++)
        {
            int result = 1;

            for (int factorial = 1; factorial <= step; factorial++) { result *= factorial; }
            answer += result;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double n=1; n<=6; n++) 
        {
            double f = 1;
            for (double k=1; k <= n; k++) { f *= k; }
            answer += Math.Pow(-1, n) * Math.Pow(5, n) / f;
        }
        answer = Math.Round(answer,4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int step = 1; step < 7; step++) { answer *= 3; }
        // end
        
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        string first, second;
        for (int a=1; a<=6; a++) { Console.Write(" "+a); }
        for (int a = 1; a <= 6; a++) { Console.Write(" "+5); }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x==0) return answer; // can't divide by 0
        for (int power = 0; power <= 10; power++)
        {
            double result = 1;
            for (int step = 1; step <= power; step++) { result *= x; }
            answer += 1/result;
        }
        answer=Math.Round(answer,4);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else if (x>1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        Console.Write("1 1");
        for (int a=1, b=1, step=1; step <= 6; step++)
        {
            int k = a + b;
            Console.Write(" {0}", k);
            a = b; b = k;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        for (double a = 1, b = 1, step = 1; step < 5; step++)
        {
            double next = a + b;
            if (step==4) { answer = next/b; }
            a = b; b = next;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code 
        answer = 1;
        for (int step = 1; step <= 64; step++) { answer *= 2; }
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 5;
        for (int step = 1; step<=x/3;  step++) { answer *= 2; }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        for (double n = 1; Math.Abs(Math.Cos(n * x) / (n * n)) >= 0.0001; n++) 
        {
            answer += Math.Cos(n * x) / (n * n);
            Console.WriteLine(answer);
        }
        Console.WriteLine(answer);
        answer =Math.Round(answer,4);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        for (int n=1, p=1; p*n<30000; n+=3)
        {
            p *= n;
            answer = n;
        }
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s=0;
        for (int n = 0; s<=p; n++)
        {
            s += a + n * h;
            if (a < Math.Abs(h) && h < 0) { break; } // if the amount is infinite, return 0
            answer = n;
        }
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        for (double i = 0; Math.Abs(x)<1 && Math.Pow(x, 2 * i) > 0.0001; i++)
        {
            answer += Math.Pow(x, 2 * i);
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M == 0) return (quotient, remainder);
        for (remainder = N; Math.Abs(remainder) >= Math.Abs(M);)
        {
            quotient++;
            remainder -= M;
        }
        remainder = Math.Abs(remainder);
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
