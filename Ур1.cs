using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml;


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
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }

    /////////////////////////// Оптимизировать Math.Pow (Перевести для каждого свое через for или while)////

    //                                               отступ    округление до 6 зн.п.з
    ///////////////////   Console.WriteLine($"{n,   10:    F6}");
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()   ////                     округление                 /////////////////             
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3() ////////////////              HELP              ////////////////////////////
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
        {
            answer += Math.Round(i * 1.0 / (i + 1) * 1000) / 1000.0;

        }
        // end
        Console.WriteLine();
        Console.WriteLine(answer);
        Console.WriteLine();
        return Math.Round(answer);
    }
    //Вычислить s = cos x + (cos 2x)/x + (cos 3x)/x^2+ ... + (cos 9x)/x^8
    public double Task_1_4(double x) ////                     округление                 /////////////////
    {
        double answer = 0;
        // code here
        if (x == 0) return 0;//del(0) вылез
        double DownValue = 1;
        for (int i = 0; i < 9; i++)
        {

            answer += Math.Cos((1 + i) * x) / DownValue;
            DownValue *= x;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        
        // code here
        answer = Math.Round(0.5 * x * x - 7 * x,2);
        // end
        Console.Write(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i < 7; i++)
        {
            answer *= i;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        int factorial = 1;
        // code here;
        for (int n = 1; n < 7; n++)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            answer += factorial;
            factorial = 1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    //Вычислить s = (–1)^1·5^1/1! + (–1)^2·5^2/2! + ... + (–1)^6·5^6/6!
    public double Task_1_9() ////                     округление                 /////////////////
    {
        double answer = (-1) * 5 / 1.0;
        double y = (-1)*5/1.0;
        // code here;
        for (int n = 2; n <= 6; n++)
        {

            y = y * (-1) * 5 / n;
            answer += y;
        }
        // end
        Console.WriteLine("HELP");
        Console.WriteLine(answer);
        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5);
            Console.Write(" ");
        }
        Console.WriteLine();
        // code here

    }
    // Вычислить при заданном x сумму s = 1 + 1/x + 1/x^2 + ... + 1/x^10
    public double Task_1_12(double x)
    {
        double answer = 1;
        double y = 1;
        // code here
        if (x == 0) return 0; // del(0) чтоб не вылез

        for (int i = 1; i <= 10; i++)
        {
            y /=x;
            answer += y;
        }
        // end
        Console.WriteLine(answer);
        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) answer = 1;
        else if (x == 0) answer = 0;
        else if (x <= 1) answer = Math.Round(-x, 1);
        else answer = -1;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1, n2 = 1;
        Console.Write(n1); Console.Write(" "); Console.Write(n2);
        for (int i = 0; i < 6; i++)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp + n2;
            Console.Write(" "); Console.Write(n2);
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int up1 = 1, down1 = 1, up2 = 2, down2 = 1;
        for (int i = 0; i < 5 - 2; i++)
        {
            int tempU = up1, tempD = down1;
            up1 = up2;
            down1 = down2;
            up2 = up2 + tempU;
            down2 = down2 + tempD;
        }
        Console.WriteLine(up2 * 1.0 / down2);
        // end
        answer = up2 * 1.0 / down2;
        return answer;
    }
    //public (ulong, int) Task_1_16()   ////                HELP           ////////
    //{
    //    ulong answer = 0;
    //    int power = 0;
    //    double Last_Squere = 1.0 / 15;
    //    // code here
    //    for (int i = 0; i <= 60; i += 4)
    //    {
    //        Console.Write(Last_Squere); Console.Write(" ");
    //        //Last_Squere = Last_Squere * 2;
    //        //answer += Math.Pow(2,i);
    //    }
    //    // end
    //    Console.WriteLine($"{answer},  1,16");
    //    return (answer, power);
    //}
    public (double, int) Task_1_16() /////////////        HELP
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

        // code here
        answer = Math.Sqrt((6350 + x) * (6350 + x) - 6350 * 6350);
        // end
        Console.WriteLine("Hello");
        Console.WriteLine(answer);
        return Math.Round(answer,2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here

        x = x / 3;

        for (int i = 0; i < x; i++)
        {
            answer *= 2;
        }

        // end
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        int n = 1;
        // code here
        while (Math.Abs(Math.Cos(n * x) / n / n) >= 0.0001)
        {
            answer += Math.Cos(n * x) / n / n;
            n += 1;
        }
        Console.WriteLine(answer);
        // end

        return Math.Round(answer, 2);
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }

    //Определить количество членов арифметической прогрессии, сумма которых s = a +
    //(a + h) + ... + (a + nh) не превышает заданного числа р.
    public int Task_2_3(double a, double h, double p)
    {
        if (a < p && h < 0) { return 0; }
        int answer = 0;
        double s = 0;
        int n = 0;
        double y = a + n * h;
        // code here
        while (s + y <= p)
        {
            s += y;

            n++;
            y = a + n * h;
            answer++;
            Console.WriteLine($"{answer}   {s}");
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    //Определить частное и остаток от деления двух целых чисел N и M, используя
    //операцию вычитания.
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;
        if (M == 0) { return (0, 0); }
        N = Math.Abs(N);M = Math.Abs(M);
        // code here
        while (N >= M)
        {
            quotient++;
            N-= M;
        }
        // end
        remainder = N;
        Console.WriteLine($"{quotient}   {remainder} ");
        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    //Начав тренировки, спортсмен в первый день пробежал 10 км.Каждый следующий
    //день он увеличивал дневную норму на 10 % от нормы предыдущего дня.

    //какой суммарный путь пробежит спортсмен за 7 дней;
    public double Task_2_7a()
    {
        double answer = 0;
        double LastDay = 10;
        // code here
        for (int i = 0; i < 7; i++)
        {
            answer+= LastDay;
            LastDay *= 1.1;
        }

        // end
        Console.WriteLine(answer);
        return Math.Round(answer,2);
    }
    //через сколько дней спортсмен пробежит суммарный путь 100 км;
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 0;
        // code here
        double LastDay = 10;
        // code here
        while ( s< 100)
        {
            s += LastDay;
            LastDay *= 1.1;
            answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    //через сколько дней спортсмен будет пробегать в день больше 20 км?
    public int Task_2_7c()
    {
        int answer = 0;
        // code here
        double LastDay = 10;
        // code here
        while (LastDay < 20)
        {
            LastDay *= 1.1;
            answer++;
        }
        // end
        Console.WriteLine(answer);
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
        double L = 0.1; 
        // code here;
        while (L > 0.0000000001)
        {
            L /= 2;
            answer++;
        }
        // end
        Console.WriteLine(answer);
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
    //Вычислить сумму s, прекращая суммирование, когда очередной член суммы по
    //абсолютной величине станет меньше 0,0001, при изменении аргумента x в указанном
    //диапазоне[а, b] c шагом h.Для сравнения в каждой точке вычислить также функцию y =
    //f(x), являющуюся аналитическим выражением ряда.


    public (double, double) Task_3_7(double x)
    {
        //x = 1;
        int i = 1;
        double S = 0, y = 0, k=x*x/2;
        //double a = 0.1, b = 1, h = 0.05;
        // code here
        y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        
        while (k >= 0.0001){
            S += k;
            i += 1;
            k = k * x * x / (2 * i) /( i*2-1);
        }
        S = Math.Round(S, 2) + 1;  //В начале i = 1, в условии i = 0, факториал(0) = 1  => 1/1 = 1
        y = Math.Round(y, 2);
        // end
        Console.WriteLine($"{S}     {y}");
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
