using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml;

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
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double i;
        for (i = 1; i <= 10; i++)
            answer += 1 / i;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i;
        for (i = 2; i <= 112; i += 2)
            answer += i / (i + 1);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double x1 = 1;
            for (double i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / x1;
                x1 *= x;
            }
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
        for (double i = 0; i <= 9; i++)
            answer += (p + i * h) * (p + i * h);
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
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int factorial = 1;
        for (int i = 1; i <= 6; i++)
            factorial *= i;
        answer = factorial;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            answer += factorial;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int factorial = 1;
        double i1 = 1;
        double i5 = 1;
        for (int i = 1; i <= 6; i++)
        {
            i1 *= -1;
            i5 *= 5;    
            factorial *= i;
            answer += (i1 * i5) / factorial;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public int Task_1_10()
    {
            int answer = 0;

        // code here
        answer = 3;
        for (int i = 2; i <= 7; i++)
            answer *= 3;
        Console.WriteLine(answer);
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
        Console.Write(" \n");
        for (int i = 0; i < 6; i++)
            Console.Write($"{5} ");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double zn = 1;
        for (int i = 0; i <= 10; i++)
        {
            if (x == 0)
                answer = 0;
            else
            {
                answer += 1 / zn;
                zn *= x;
            }
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
        for (double h = -1.5; h <= 1.5; h += 0.1)
        {

            if (x <= -1)
                answer = 1;
            else if (-1 < x && x <= 1)
                answer = -x;
            else
                answer = -1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
         int a = 1;
         int b = 1;
         int c;
         for(int i = 0; i <= 6; i++)
         {
             Console.WriteLine(b);
             c = a + b;
             a = b; b = c;
         }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1, b = 1;
        double c;
        for (int i = 0; i <= 4; i++)
        {
            c = a + b;
            a = b; b = c;
            answer = b / a;
            answer = Math.Round(answer, 1);
            Console.WriteLine(answer);
        }

        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double power = 0;

        // code here
        double grains = 1;
        double x1 = 1;//количество зерна
        for (int i = 1; i <= 64; i++)
        {
            grains *= 2;
        }
        x1 = grains / 15;
        power = Math.Log10(x1);
        for(int i = 1; i < power; i++)
        {
           x1 = x1 / 10;
        }
        answer = x1;

        Console.WriteLine(answer);
        // end

        return (Math.Round(answer, 2), (int)power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
            answer = Math.Sqrt(((R + x) * (R + x)) - R * R);
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        while(x > 0)
        {
            x -= 3;
            answer *= 2;//answer - клетки
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
        }
        Console.WriteLine(answer);
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
        double e = 0.0001;

        // code here
        answer = 1;
        double s = 1;

        if (Math.Abs(x) >= 1)
            return 0;

        for (int i = 0; ; i++)
        {
            if (s < e)
                break;
            else
            {                
                s *= (x * x);
                answer += s;
            }
            
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
        int hours = 0;
        int cell = 0;
        // code here
        cell = 10; //cell - клетка
        while (cell < 100000)
        {
            if (cell == 100000)
                Console.WriteLine(answer);
            else
            {
                hours += 3;
                cell *= 2;
            }
        }
        answer = hours;
        Console.WriteLine(answer);
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
        int summa = 0;
        int hours = 0;
        // code here;
        summa = 10000;
        while (summa < 20000)
        {
            if (summa == 20000)
                Console.WriteLine(answer);
            else
            {
                summa = (summa / 100) * 108;
                hours += 1;
            }
        }
        answer = hours;
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
        double a = 1, b = 1, c = 0;// a- числитель , b - знаменатель 
        double current = 0, previous = 0;// текущий и предыдущий
        int count = 0;//счётчик 

        do
        {
            previous = current;
            current = a / b;
            c = a;
            a += b;
            b = c;
            count++;//счётчик до выходы из цикла
        }
        while (Math.Abs(current - previous) > 0.001);
        answer = count;
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
        double n = 1; //член суммы
        double sigh = -1; //знак
        double esp = 0.0001;
        double x_pow = x * x * x ;// x в кубе 
        int i = 1;  
        while(Math.Abs(n) >= esp)
        {
            sigh = -sigh;
            n = (sigh * x_pow)/ (4 * i * i -1);
            S += n;
            x_pow *= x * x;
            i += 1; //счётчик до выхода из цикла 
        }
        y = ((1 + x * x) * Math.Atan(x) / 2) - (x / 2);
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