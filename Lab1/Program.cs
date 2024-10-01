using System.Collections.Generic;
using System.ComponentModel;
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
        //program.Task_1_4(0.5);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(1.6);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
        //program.Task_2_4(0.8);
        //program.Task_2_5(8, 2);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        program.Task_3_3(0.1);
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
        int answer;

        // code here
        int s = 0;
        int i = 2;
        for (; i <= 35;)
        {
            s = s + i;
            i = i + 3;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer;

        // code here
        double s = 0;
        double a = 0;
        for (int i = 1; i <= 10; i++)
        {
            a = a + 1;
            s = s + 1 / a;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine("s = {0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double a = 2; a <= 112; a = a + 2)
        {
            s = s + a / (a + 1);
            Console.WriteLine($"s = {Math.Ceiling(s)}");
        }
        answer = Math.Ceiling(s);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        //4. Вычислить s = cos x + (cos 2x)/x + (cos 3x)/x2 + ... +(cos 9x)/ x^8   Ответ: -243,15
        double s = 0;
        double n = 1;
        double y = 1;
        if (x != 0)
        {
            for (double i = 1; i <= 9; i++)
            {

                s = s + Math.Cos(x * y) / n;
                y++;

                n = x * n;

            }
            // end
            answer = Math.Round(s, 2);
            Console.WriteLine("{0:f2}", answer);

        }
        if (x == 0)
        {
            answer = 0;
            Console.WriteLine(answer);
        }
        return answer;
    }
    public double Task_1_5(double p, double h)  //1232,5
    {
        double answer = 0;

        // code here
        double s = 0;
        double n = 0;
        for(double i = 1; i<= 10; i++)
        {
            s = s + (p + h * n) * (p + h * n);
            Console.WriteLine(s);
            n++;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        //Получить таблицу функции y(x) = 0,5x^2– 7x при изменении x от –4 до 4 с шагом 0,5.
        double y;
        y = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(y, 2);
        Console.WriteLine($"y({x}) = 0,5 * ({x})^2 - 7 * {x}\t y = {answer}");

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int i = 0, f = 1;
        while (i< 6)
        {
            i++;
            f *= i;
        }
        answer = f;
        // end

        return answer;
        
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int a = 0, s = 0, f = 1;
        while (a < 6)
        {
            a++;
            f *= a;
            s = s + f;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, f = 1, n = 1, a = 1, b = 1,t, i = 0;
        while (n <= 6)
        {
            a = a * -1;
            b = b * 5;
            t = a * b;
            i++;
            f *= i;
            s += t / f;
            n++;
            

                
            
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int a = 1;
        for (int i = 1; i <= 7; i++)
        {
            a = a * 3;
        }
        Console.WriteLine(a);
        answer = a;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        /*
        int a = 0;
        for (int i = 1; i <= 6;i++)
        {
            a++;
            Console.Write($"{a, 2}");
        }
        */
        int a = 5;
        for (int i = 1; i <= 6; i++)
        {
            a *= 1;
            Console.Write($"{a,2}"); //{a, 2}- c отступом на 2
        }
        // code here


    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1, d = 1;
        if(x != 0)
        {
            for(double i = 1;i <= 10; i++)
            {
                d = d * x;
                s += 1 / d;

            }
            answer = Math.Round(s,2);
            Console.WriteLine(answer);
        }
        if (x == 0)
        {
            answer = 0;
            Console.WriteLine(answer);
        }
        
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
            Console.WriteLine(answer);
        }
        if ((-1 < x) && (x <= 1))
        {
            answer = -x;
            Console.WriteLine(answer);
        }
        if (x > 1)
        {
            answer = -1;
            Console.WriteLine(answer);
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        double a = 1, b = 1, k = 2, s;
        Console.Write($"{a, 4}{b, 4}");
        while (k < 8)
        {
            s = a + b;
            Console.Write($"{s, 4}");
            a = b;
            b = s;
            k++;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1, b = 1, c = 2, d = 1, k= 2, s, y;
        Console.Write($"{a}/{b}  {c}/{d}");
        while (k < 5)
        {
            s = a + c;
            y = b + d;
            Console.Write($"  {s}/{y}");
            a = c;
            b = d;
            c = s;
            d = y;
            k++;
        }
        answer = c / d;
        Console.WriteLine($"  {answer}");
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0, k = 1, f, d, t, g = 1, n = 1, r, y = 1;
        for (int i = 1; i<=64; i++)
        {
            s += k;
            k *= 2;

        }
        f = s / 15;
        d = s % 15;
        t = f + d;
        r = Math.Round(Math.Log10(t));
        while (y <= r)
        {
            g = g * 10;
            y++;
        }
        answer = Math.Round(t / g, 2);
        power = (int)(r);
        Console.WriteLine(answer);
        Console.WriteLine(power);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        double d;
        d = (x + r) * (x + r) - (r * r);
        answer = Math.Round(Math.Sqrt(d), 2);
        Console.WriteLine($"На высоте {x} расстояние до линии горизонта с высоты равно {answer}");
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int hours = 0, klet = 10;
        while(hours < x)
        {
            hours += 3;
            klet *= 2;
            answer = klet;
            Console.WriteLine($"Спустя {hours} часа количество клеток в коробке стало равно {answer}");
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
        const double eps = 0.0001;
        double s = 0, a = Math.Cos(x);
        int n = 1;
        do
        {
            s = s + a;
            n = n + 1;
            a = Math.Cos(n * x) / (n * n);
        } while (Math.Abs(a) >= eps);
        answer = s;
        Console.WriteLine(answer);
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
        double s = 0, n = 0;
        int k = 0;
        if (p != 0 && h > 0)
        {
            do
            {
                s += a + n * h;
                if (s > p)
                {
                    answer = k;
                    Console.WriteLine(answer);
                    break;

                }
                k++;
                n++;


            } while (s <= p);
        }
        if (p == 0 || h < 0)
        {
            answer = 0;
            Console.WriteLine(answer);
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
        int n = 0;
        if (M != 0 && N > M)
        {
            do
            {
                n++;
                N = N - M;

            } while(N >= M);
            quotient = n;
            remainder = N;
            Console.WriteLine($"Частное равно {n}, а остаток равен {N}");
        }
        else if (M != 0 && N < M)
        {
            do
            {
                n++;
                N = N - M;

            } while (N <= M);
            quotient = n;
            remainder = Math.Abs(N);
            Console.WriteLine($"Частное равно {quotient}, а остаток равен {remainder}");
        }
        else
        {
            quotient = 0;
            remainder = 0;
            Console.Write(quotient);
            Console.Write(remainder);
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
        double cd = 1, s = 10, a = 1.1, b = 10;
        while(cd < 7)
        {
            cd++;
            b = b * a;
            s += b;

        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 10, a = 1.1, b = 10;
        int cd = 1;
        do
        {
            b = b * a;
            s += b;
            cd++;
        } while (s < 100);
        answer = cd;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double a = 1.1, b = 10;
        int cd = 1;
        do
        {
            b = b * a;
            if (b > 20)
            {
                answer = cd;
            }
            cd++;

        } while (b < 20);
        Console.WriteLine(answer);
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
        int n = 0;
        double l = 0.1, p;
        p = Math.Pow(10, -10);
        do
        {
            l = l / 2;
            n++;

        } while (l > p);
        answer = n;
        Console.WriteLine(answer);
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
        double s = 1, a, i = 0, eps = 0.0001, f = 1, u;
        do
        {
            i++;
            f *= i;
            a = Math.Cos(i * x) / f;
            if (Math.Abs(a) <= eps)
            {
                u = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
                S = s;
                y = u;
                Console.WriteLine(S);
                Console.WriteLine(y);
                break;
            }

            s += a;

        } while (Math.Abs(a) >= eps);
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