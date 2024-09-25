using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
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
        program.Task_3_1(0.1);
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
        int s = 0;
        for (int i = 2; i < 36; i = i + 3)
            s += i;
        //Console.WriteLine($"s= {s}", s);


        // end

        return answer=s;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i=1; i<=10; i++)
        {
            answer += 1 / i;
            ///Console.WriteLine($"s= {s}", s);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double a=2; a<=113; a+=2)
        {
            answer += a / (a+1);
            //Console.WriteLine($"answer={answer}", answer);
        }

        // end

        answer = Math.Round(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double n = 1;
        if (x == 0)
            return 0;
        else
        {
            for (double i = 1; i <= 9; i++)
            {
                s += Math.Cos(x * i) / n;
                n *= x;
                //Console.WriteLine($"s={s}", s);
            }

        }
        // end
        answer = Math.Round(s, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, a=0;
        for (int i=0; i<=9; i++)
        {
            a = p + i * h;
            s += a * a;
            //Console.WriteLine($"s={s}",s);
        }
        // end

        return answer=s;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        y = 0.5 * (x * x) - 7 * x;
        //Console.WriteLine($"{y}", y);

        // end
        answer = Math.Round(y, 2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int x = 1;
        for (int i=1; i<=6; i++)
        {
            x *= i;
            //Console.WriteLine($"{x}", x);
        }
        // end
        return answer = x;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s=0, x=1;
        for (int i=1; i<=6; i++)
        {
            x *= i;
            s += x;
            //Console.WriteLine($"{s}", s);
        }

        // end

        return answer=s;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, p=-5;
        int fact = 1;
        for (int i=1; i<=6; i++)
        {
            fact *= i; // вычисляю факториал
            s += p / fact;
            p *= -5;
            //Console.WriteLine($"{s}", s);
        }
        // end
        answer = Math.Round(s, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 3;
        for (int i=1; i<7; i++)
        {
            x *= 3;
            //Console.WriteLine($"{x}", x);
        }
        // end

        return answer=x;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i=1; i<=6; i++)
            Console.Write($"{i, 2}");
            Console.WriteLine($"{""}");
        int s = 5;
        for (int i = 1; i <= 6; i++)
            Console.Write($"{s, 2}");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0, n=1;
        if (x == 0)
            return 0;
        else
        {
            for (double i = 0; i <= 10; i++)
            {
                s += 1 / n;
                n *= x;
                //Console.WriteLine($"{s}", s);
            }
        }
        // end
        answer = Math.Round(s, 2);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer= 1;
        if (-1 < x && x <= 1)
            answer= -x;
        if (x > 1)
            answer =-1;
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1, y = 1;
        Console.WriteLine("");
        for (int i=1; i<=5; i++)
        {
            if (i <=2)
            {
                Console.Write($"{1, 3}");
            }
            if (i>2)
            {
                x += y;
                y += x;
                Console.Write($"{x, 3} {y, 3}");
                Console.WriteLine("");
            }
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 11;

        // code here
        double ch = 1, zn = 1, p = 0;
        for (int n=2; n<=5; n++)
        {
            p = ch;
            ch += zn;
            zn = p;
            answer = Math.Round(ch / zn, 2);
            //Console.WriteLine($"{ch}");
            //Console.WriteLine($"{zn}");
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        decimal  s=1, k=1;
        for (double kletka = 1; kletka<64; kletka++)
        {
            k *= 2;   //в каждой клетке в 2 раза больше => возвожу 2 до 63 степени
            s += k;
            //Console.WriteLine($"{s}", s);
        }
        answer = (double)s / 15;  // узнаю кол-во гр
        //Console.WriteLine($"{answer}");
        //power = answer / 10;
        while ((decimal) answer> 1)
        {
            answer /= 10;
            power++;
            //Console.WriteLine($"{answer}");
        }
        power -= 1;// вычитаем единицу, которая перед запятой
        answer *= 10;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350, k=0;
        double a = 0;
        for (int i=1; i<=x; i++)
        {
            k = (r + i) * (r + i) - r * r;
            a = Math.Sqrt(k);
            //Console.WriteLine($"{a}");
        }
        answer = Math.Round(a, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int s = 0, a=10;
        for (int i=0; i<x; i+=3)
        {
            a *= 2;
            
            //Console.WriteLine($"{a}", a);
        }
        // end

        return answer=a;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s=0;
        int n = 1;
        double epsilon = 0.0001;
        double term = 0;
        do
        {
            s += term;
            term = Math.Cos(n * x) / (n * n);
            n++;
            //Console.WriteLine($"{s}");
        }
        while (Math.Abs(term) >= epsilon);
       
        // end
        answer = Math.Round(s, 2);
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
        double s = 0;
        int n=0;
        if (h < 0)
            return 0;
        else
        {
            for (int i=0; ; i++)
            {
                s += a + (i * h);
                if (s > p)
                {
                    break;
                }
                else
                    n++;
                //Console.WriteLine($"{s}");
                //Console.ReadKey();
            }
        }
        
        answer = (int) n;
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
        if (M==0)
        {
            return (0, 0);
        }
        while (Math.Abs(M) <= Math.Abs(N)) 
        {
            N -= M;
            quotient++;
            remainder = Math.Abs(N);
        }
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
        double s = 0, k=0.1, d=10;
        for (int i=1; i<=7; i++)
        {
            s += d;
            d += d * k;
            
            Console.WriteLine($"{s}");
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, k = 1.1, d = 10;
        int n = 0;
        while (s< 100)
        {
            s += d;
            d *= k;
            n++;
            //Console.WriteLine($"{n}");
        }
        // end

        return answer= n;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 0, k = 1.1, d = 10;
        int n = 0;
        while ( d < 20)
        {
            s += d;
            d *= k;
            n++;
            //Console.WriteLine($"{n}");
        }
        // end

        return answer = n;
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
        double L= 0.1;
        int n = 0;
        while (L> 0.0000000001)
        {
            L /= 2;
            n++;
            //Console.WriteLine($"{n}");
        }
        // end

        return answer= n;
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
        double ch = x * x, f = 2, k = 1;
        int st = -1, cnt = 4;
        while (Math.Abs(k)>=0.0001)
        {
            S += k;
            k = st * (ch / f);
            ch *= x * x;
            f *= cnt * (cnt - 1);
            st *= -1;
            cnt += 2;
        }
        // end
        //S = Math.Round(S, 2);
        y = Math.Cos(x);
        Console.WriteLine(S);
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