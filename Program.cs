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
        program.Task_2_1(0);
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
        for (int x = 2; x <= 35; x += 3)
            answer += x;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int x = 1; x <= 10.0; x++)
            answer += 1.0 / x;
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int x = 2; x <= 112; x += 2)
            answer += x / (x + 1.0);
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        if (x == 0) return 0;
        for(int i=1;i<=9;i++)
        {
            answer += Math.Cos(i * x) / y;
            y *= x;
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
        for (int n = 0; n <= 9; n++)
            answer += (p + h * n) * (p + h * n);
        answer = Math.Round(answer, 2);
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
        int f = 1;
        for (int x = 1; x <= 6; x++)
        {
            f *= x;
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
        int f = 1;
        for(int x = 1;x<=6;x++)
        {
            f *= x;
            answer += f;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1, c = 1, b = 1;
        for(int a = 1; a<=6;a++)
        {
            
            c = c * (-1);
            b = b * 5;
            f *= a;
            answer += (c * b) / f;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int k = 1;
        for (int n = 1; n <= 7; n++)
        {
            k *= 3;
        }
        answer = k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int x = 1; x <= 6; x++)
            Console.Write(x);
        Console.WriteLine();
        for (int x = 1; x <= 6;x++)
            Console.Write(5);

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double f = 1.0;
        if (x == 0) return 0;
        for(int a =0; a<= 10;a++)
        {
            answer += 1.0 / f;
            f *= x;
    
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x<=-1)
        {
            answer =1;
        }
        else if(x >1)
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

        // code here

    }
    public double Task_1_15()
    {
        // code here
        double answer = 0;
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1;
        double zn2 = 1;
        double ch3 = 0;
        double zn3 = 0;
        for (int x = 1; x <= 3; x++)
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
            answer = ch3 / zn3;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const int R = 6350;

        // code here
        answer += Math.Sqrt(((x + R) * (x + R)) - (R * R));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
 
        for(int h = 0; h<x; h+=3)
        {
            answer *= 2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0.0;
        const double eps = 0.0001;
        int n = 1;
        double a;
        // code here
        do
        {
            a = Math.Cos(x * n) / (n*n);
            answer += a;
            n++;
            
        } while (Math.Abs(a) > eps);
        Console.WriteLine(answer);//1,6349839001848923 ответ выводт консоль
                                  
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
        double answer = 10;
        double s = 0;
        // code here
        for(int x =0; x<=7;x++)
        {
            s += answer * 10 / 100;
            answer += s;
        }    
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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