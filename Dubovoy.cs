using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.IO.Pipes;
using System.Linq.Expressions;
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
        program.Task_2_10();
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

        // code here
        int answer = 0;
        int a = 2; while (a <= 35)
        {
            answer += a;
            a += 3;
        }
        // end
        Console.WriteLine(answer); ;
        return answer;
    }
    public double Task_1_2()
    {

        // code here
        double answer = 0;
        double temp = 0; int a = 1;

        for (; a <= 10; a++)
        {
            temp = 1f / a;
            answer += temp;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {

        // code here
        double answer = 0;
        double chisl = 1; double znam = 2; double temp = 0;

        for (; znam <= 113; znam += 2)
        {
            temp = chisl / znam;
            answer += temp;

            chisl += 2;

        }
        answer = Math.Round(answer, 0);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {

        // code here
        double answer = 0; double drob = 0; double temp = 1;

        if (x == 0)
            return 0;

        for (int a = 1; a <= 9; a++)
        {
            drob = Math.Cos(x * a) / temp;
            temp *= x;
            answer += drob;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0; int chag = 0;

        // code here
        for (; chag <= 9; chag++)
        {
            answer += (p + h * chag) * (p + h * chag);
            Console.WriteLine(answer);

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

        int temp = 1;
        // code here;

        for (int i = 1; i <= 6; i++)
        {
            temp *= i;
            answer += temp;

        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0; int step = 1; double pyat = 5; int minus = -1; double fak = 1;

        // code here;
        for (double temp = 0; step <= 6; step++)
        {
            fak *= step;
            temp = (minus * (pyat)) / fak;
            pyat *= 5;
            answer += temp;
            minus = -minus;
            Console.WriteLine(answer);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        int step = 0;
        // code here
        answer = 1;
        for (; step <= 6; step++)
        {
            answer *= 3;
            Console.WriteLine(answer);
        }

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");

        }


        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        double ix = x;

        // code here
        answer = 1;

        if (x == 0) return 0;

        for (double step = 0; step <= 9; step++)
        {
            answer += (1 / ix);
            ix *= x;

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
        if (x <= -1) answer = 1;
        if (-1 < x && x <= 1) answer = -x;
        if (x > 1) answer = -1;

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int perv = 1;

        int vtor = 0;

        int sum = 1;

        for (int step = 0; step < 8; step++)
        {
            perv = sum;
            Console.WriteLine(perv + " ");
            sum = perv + vtor;
            vtor = perv;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        double perv = 1; double vtor = 1;

        double summa = 0;

        // code here
        perv += vtor;
        for (int step = 0; step < 4; step++)
        {
            answer = perv / vtor;
            summa = perv;
            perv += vtor;
            vtor = summa;


        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        int step = 1;
        double zern = 2;

        // code here

        for (; step <= 63; step++)
        {
            answer += zern / 15;
            zern *= 2;

        }
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, 18);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        int R = 6350;

        // code here

        answer = Math.Sqrt((R + x) * (R + x) - R * R);

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
            answer *= 2;
            x -= 3;
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

        int perv = 1;

        int L = 30000;

        int sum = 0;

        // code here
        sum = 1;
        while (sum < L)
        {
            answer = perv;
            perv += 3;
            sum *= perv;
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

        double limit = 0.0001;

        double sum = 0;

        double perem = 1;

        // code here
        if (x >= 1)
            return 0;

        while (perem > limit)
        {
            sum += perem;
            perem *= x * x;

        }
        answer += sum;
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

        int limit = 100000;

        int chas = 0;


        // code here

        while (answer <= limit)
        {
            chas += 3;
            answer *= 2;
            Console.WriteLine(chas);
        }
        answer = chas;
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

        double start = 10000;

        // code here;

        for (int mesac = 1; start <= 20000; mesac++)
        {
            start *= 1.08;
            answer = mesac;
            Console.WriteLine(answer);
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
        double x = 1, y = 1, xpred = 1, ypred = 0, nast = 0, pred = 0, a = 0, b = 0;
        int number = 2;
        //Пердпоостановка
        a = x;
        b = y;
        x += xpred;
        y += ypred;
        xpred = a;
        ypred = b;
        nast = x / y;
        pred = xpred / ypred;

        while (Math.Abs(nast - pred) > 0.001)
        {
            a = x;
            b = y;
            x += xpred;
            y += ypred;
            xpred = a;
            ypred = b;
            nast = x / y;
            pred = xpred / ypred;
            Console.WriteLine($"{nast} : {pred}");
            number++;
        }

        Console.WriteLine(number);
        return number;
        // code here

    }

    // end


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
        // code here

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