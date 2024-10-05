using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Xml.XPath;

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
        for (int i = 2; i < 36; i += 3)
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
        for (double i = 1; i < 11; i += 1)
        {
            answer += 1/i;
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
            answer += (i - 1) / i;

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double varieble = 1;
        if (x == 0) return 0;

        for (int i = 1; i <= 9; i += 1)
        {
            answer += ((Math.Cos(i * x)) / varieble);
            varieble *= x;
        }

        answer =  Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        
        // code here
        double s = 0;
        for (double i = 0; i < 10; i += 1)
        {
            s += Math.Pow(p + i * h, 2);
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = (0.5 * Math.Pow(x,2)) - (7 * x);
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int factorial = 1;
        for (int i = 1; i < 7; i += 1)
        {
            factorial *= i;
        }
        answer = factorial;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1;
        for (int i = 1; i < 7; i++)
        {
            factorial *= i;
            answer += factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double factorial = 1;
        for (int i = 1; i < 7; i++)
        {
            factorial *= i;
            answer += (Math.Pow(-1, i) * Math.Pow(5, i)) / factorial;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i < 8; i ++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here

        string First_String = "a) ";
        string Second_String = "б) ";
        int repeat = 6;
        for (int i = 1; i < repeat + 1; i++)
        {
            if (i != repeat)
            {
                First_String += $"{i} ";
            }
            else
            {
                First_String += $"{i}, ";
            }
        }

        for (int i = 1; i < repeat + 1; i++)
        {
            if (i != repeat)
                Second_String += "5 ";
            else
                Second_String += "5. ";
        }
        Console.WriteLine(First_String);
        Console.WriteLine(Second_String);
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for (double i = 0; x != 0 && i < 11; i++)
        {
            answer += (1 / Math.Pow(x, i));
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
        {
            answer = 1;
        }
        if (-1 < x && x <= 1)
        {
            answer = - x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int Num1 = 1;
        int Num2 = 2;
        int aa = 0;
        Console.WriteLine(Num1);
        Console.WriteLine(Num2);
        for (int i = 0; i < 6; i++)
        {
            aa = Num1 + Num2;
            Num1 = Num2;
            Num2 =  aa;
            Console.WriteLine(aa);
        }

        //end

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double Num1_Chisl = 1;
        double Num2_Chisl = 2;
        double Num1_Znam = 1;
        double Num2_Znam = 1;
        double Next_Num_Chisl = 0;
        double Next_Num_Znam = 0;
        for (int i = 0; i < 3; i++)
        {
            Next_Num_Chisl = Num1_Chisl + Num2_Chisl;
            Next_Num_Znam = Num1_Znam + Num2_Znam;
            Num1_Chisl = Num2_Chisl;
            Num1_Znam = Num2_Znam;
            Num2_Chisl = Next_Num_Chisl;
            Num2_Znam = Next_Num_Znam;
        }
        answer = Next_Num_Chisl / Next_Num_Znam;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;


        // code here
        double j = 1;
        for (int i = 1; i <= (8 * 8); i++)
        {
            answer += j;
            j *= 2;
        }
        answer /= 15;
        power = 18;
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt(x * (2 * 6350 + x));
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer += 10;
        for (int i = 0; i <= x; i += 3)
        {
            if (i % 3 == 0 & i != 0)
            {
                answer *= 2;
            }
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
        int L = 1;
        for (int i = 1; L < 30000; i += 3)
        {
            if (L * i < 30000)
            {
                answer = i - 3;
                L *= i;
            }
            else
            {
                answer = i - 3;
                break;
            }
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
        // code here
        double answer = 1.0, n = 1;
        if (Math.Abs(x)>= 1)
        {
            return  0;
        }
        while (Math.Abs(n) >= 0.0001)
        {
            n = x * n * x;
            answer = answer + n;
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
        int answer = 0;
        //В задаче 18 уровня I определить 
        // через какое время в замкнутом объеме будет находиться 10^5 клеток.
        // code here
        int Current = 10;
        int counter = 0;
        int Maximum  = 100000;
        for (int i = 0; Current < Maximum; i += 3)
        {
            counter += 3;
            Current *= 2;
        }
        answer = counter;
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
        double max = 20000;
        for (double start = 10000; start <= max; answer += 1)
        {
            if (start * 1.08 < max)
            {
                start *= 1.08;
            }
            else
            {
                answer += 1;
                break;
            }
        }
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
        // В задаче 15 уровня I вычислить член последовательности
        // который отличается от предыдущего члена не более чем на 0,001
        // code here;
        answer += 2;
        double a = 1, b= 1, c= 2, d= 1, x = c / d, y = 0;
        while (Math.Abs(x - y) > 0.001)
        {
            y = x;
            double z = (a + c);
            double w = (b + d);
            x = z / w;
            a = c;
            b = d;
            c = z;
            d = w;
            answer += 1;
        }
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
        double fak = 4;
        double i = 1;
        double perv = 1;
        double minus = -1;
        double temp = x * x;
        while (Math.Abs(perv) > 0.0001)
        {
            minus = -minus;
            perv = (minus * x * temp) / (fak - 1);
            temp *= x * x;
            i += 1;
            fak = 4 * i * i;
            S += perv;
        }

        y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"s = {S}, y = {y}");
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