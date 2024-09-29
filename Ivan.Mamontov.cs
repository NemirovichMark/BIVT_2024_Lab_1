using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;

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
        //program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i = i + 3)
            answer = answer + i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        for (double i = 1; i < 11; i = i + 1)
        {
            answer = answer + 1 / i;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2; i < 113; i = i + 2)
        {
            s = i / (i + 1);
            answer = answer + s;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double xs = 1;
        for (int i = 1; i < 10; i++)
        {
            answer = answer + Math.Cos(i * x) / xs;
            xs *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 0; i < 10; i++)
        {
            answer = answer + (p + h * i) * (p + h * i);

        }

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;

        answer = Math.Round(answer, 2);



        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int s = 1;

        for (int x = 2; x < 7; x++)
        {
            s *= x;

        }
        answer = s;


        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1;
        for (int x = 1; x < 7; x++)
        {
            s = s * x;
            answer = answer + s;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here
        double s = 0, f = 1;
        int p = 1;
        for (int i = 1; i < 7; i++)
        {
            f *= i;
            p *= 5;
            s = ((i % 2) * -2 + 1) * p / f;
            answer = answer + s;

        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int x = 3;
        for (int i = 1; i < 8; i++)
        {
            answer *= x;
        }


        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i < 7; i++)
        {
            Console.Write(i + " ");
        }
        int x = 5;
        //Console.WriteLine();
        for (int i = 1; i < 7; i++)

        {
            Console.Write(5 + " ");
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

        double s = 1;
        for (int i = 0; i < 11; i++)
        {
            answer = answer + 1 / s;
            s *= x;
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
        if (-1 <= x && x <= 1)
        {
            answer = -x;
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

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double v = 1, n = 1, next = 0;

        for (int i = 0; i < 5; i++)
        {
            answer = v / n;
            next = v + n;
            n = v;
            v = next ;
              
        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1;
        for (int i = 1; i < 65; i++)
        {
            s = s * 2;
        }

        answer = s ;
        answer = answer / 15;
        while (answer >= 10)
        {
            answer = answer / 10;
            power = power + 1;
        }
        answer = Math.Round(answer, 2);


        Console.WriteLine(answer);






        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;

        answer = Math.Sqrt(x * (2 * R + x));

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 0; i < x; i += 3)
        {
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int n = 1, p = 1, l = 30000;
        while (p * n <= l)
        {
            p = p * n;
            n = n + 3;


        }
        answer = n - 3;

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
        double e = 0.0001, sum = 0, a = 1;
        int n = 0;
        if (Math.Abs(x)>=1)
        {
            
            return 0;
        }
       
        while (Math.Abs(a) >= e)
        {
            sum += a;
            n++;
            a *= x * x;


        }
        answer = sum;
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

        // code here
        int ameba = 10, count = 100000, s = 0;
        while (ameba <= count)
        {
            s = s + 3;
            ameba *= 2;

        }

        answer = s;

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
        double money = 10000, procent = 1.08, finish = 20000;
        int month = 0;
        while (money < finish)
        {
            money *= procent;
            month++;
        }
        answer = month;
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
        
        // code here
        double answer = 0;
        double v = 1, n = 1, next = 0;
        double Panswer = 0;
        double epsilon = 0.001;
        int i= 0;
        do
        {
            Panswer = answer;
            answer = v / n;
            next = v + n;
            n = v;
            v = next;
            i++;

        }
        while (Math.Abs(answer - Panswer) >= epsilon || Panswer == 0);
        answer = i;





        // end

        return (int)answer;
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
        double S = 0, y = 0, a = 1, e = 0.0001, numer, minus;

        // code here
        for (int i = 1; Math.Abs(a) >= e; i++)
        {
            minus = 1;
            for (int j = 1; j <= i + 1; j++)
                minus = minus * -1;
            numer = 1;
            for (int k = 1; k <= 2 * i + 1; k++)
                numer = numer * x;
            a = (minus * numer) / (4 * i * i - 1);
            if (Math.Abs(a) < e) break;
            S = S + a;
        }
        y = (((1 + x * x) * Math.Atan(x)) / 2) - (x / 2);
        


       



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