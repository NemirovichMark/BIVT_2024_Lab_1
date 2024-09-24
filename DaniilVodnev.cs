using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        //program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        program.Task_3_5(double.Pi/5);
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
        for (int i = 2; i < 36; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i++)
            answer += 1 / i;
        
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i += 2)
            answer += i / (i + 1);

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
    
        double y = 1;
        for (int n = 1; n < 10; n++)
        {
            answer += Math.Cos(x*n) / y;
            y *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
            answer += (p + h * i) * (p + h * i);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        System.Console.WriteLine($"x {x} y {answer}");
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int n = 2; n < 7; n++)
            answer *= n;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int factorial = 1;
        // code here;
        for (int n = 1; n < 7; n++)
        {
            factorial *= n;
            answer += factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, numerator = 1, minusOneDegree = 1;
        int denominator = 1, fiveDegree = 1;

        // code here;
        for (int n = 1; n < 7; n++)
        { 
            minusOneDegree *= -1;
            fiveDegree *= 5;
            numerator = fiveDegree * minusOneDegree;
            denominator *= n;
            answer += numerator / denominator;

        }
        answer = Math.Round(answer, 2);
        // end
        
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int n = 1; n < 8; n++)
             answer *= 3;

        // int n = 7;
        // while (n > 0)
        // {
        //     answer *= 3;
        //     n--;
        // }

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i < 7; i++)
        {
            System.Console.Write($"{i} ");
        }
        System.Console.WriteLine();
        for (int i = 1; i < 7; i++)
        {
            System.Console.Write("5 ");
        }
        System.Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0, denominator = 1;

        // code here
        if (x == 0) return 0;
        for (int i = 0; i < 11; i++)
        {
            answer += 1 / denominator;
            denominator *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int previous = 0, next = 1, tmp;

        for (int n = 0; n < 8; n++)
        {   
            System.Console.WriteLine(next);
            tmp = previous + next;
            previous = next;
            next = tmp;
            
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double previous = 1, next = 1, tmp;
        // code here
        for (int n = 0; n < 5; n++)
        {
            answer = next / previous;
            tmp = next + previous;
            previous = next;
            next = tmp;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        for (int n = 1; n < 65; n++)
            answer *= 2;
        answer--;
        answer /= 15;
        while (answer >= 10)
        {
            answer /= 10;
            power += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const int R = 6350;
        
        answer = Math.Sqrt(x * (2 * R + x));

        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        while (x > 0)
        {
            x -= 3;
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
        double a;
        const double E = 0.0001;
        int n = 1;
        a = Math.Cos(x*n) / (n*n);
        while (Math.Abs(a) >= E)
        {
            n ++;
            answer += a;
            a = Math.Cos(x*n) / (n*n);
        }     
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
        double s;

        // code here
        s = a + answer * h;
        if (h < 0) return 0;
        while (s <= p)
        {
            answer++;
            s += a + answer * h;
        }
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
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0) return (0, 0);
        while (N >= M)
        {
            quotient++;
            N -= M;
        }
        remainder = N;
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
        double answer = 0, perDay = 10;

        // code here
        for (int n = 0; n < 7; n++)
        {
            answer += perDay;
            perDay *= 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 0, perDay = 10;

        // code here
        while (s < 100)
        {
            s += perDay;
            perDay *= 1.1;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double perDay = 10;

        // code here
        while (perDay <= 20)
        {
            perDay *= 1.1;
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
        double D = 1, L = 0.1;

        // code here;
        for (int n = 0; n < 10; n++)
            D *= 0.1;

        while (L > D)
        {
            L /= 2;
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
        double S = 0, y = 0, i = 1, j = -1, a;
        const double Stop = 0.0001;
        // code here
        a = j * (Math.Cos(i*x) / (i*i));

        while (Math.Abs(a) >= Stop)
        {
            S += a;
            i++;
            if (i % 2 == 0) j = 1;
            else j = -1;
            a = j * (Math.Cos(i*x) / (i*i));
        }
        y = ((x * x) - ((Math.PI * Math.PI) / 3)) / 4;
        
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