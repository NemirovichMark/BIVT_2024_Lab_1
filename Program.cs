using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(1.6);
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
        int answer = 0;

        // code here;
        for (int i = 2; i <= 35; i = i+3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        for (double i = 0; i <= 8; i++)
        {

            answer += Math.Cos((i+1) * x) / Math.Pow(x, i);
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
        answer += p * p;
        for (int i = 1; i < 10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i < 7; i++)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int b = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer += b * i;
            b *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double b = 5;
        double c = 1;
        double d = 1;
        double f = 1;
        for (double i = 1; i <= 6; i++)
        {
            c = c * b;
            d = d * (-1);
            f *= i;
            answer += d * c / f;
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
        answer = 1;
        int number = 3;
        for (int i = 1; i < 8; i ++)
        {
            answer *= number;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        Console.Write("a)");
        for (int i = 1; i < 6; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        Console.Write("b)");
        int number = 5;
        for (int i = 1; i < 6; i++)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double a = 1;
        answer += 1;
        for (double i = 1; i <= 10; i++)
        {
            a = a * x;
            answer += 1 / a;
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
        if (x <= -1)
        {
            answer = 1;
        } else if ((-1 < x) && (x <= 1))
        {
            answer = -x;
        }else if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int first_number = 1, second_number = 1;
        Console.Write("{0} {1} ", first_number, second_number);
        for (int i = 2; i < 8; i++)
        {
            int next_number = first_number + second_number;
            Console.Write("{0} ", next_number);
            first_number = second_number;
            second_number = next_number;
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double first_a = 1, first_b = 1, second_a = 2, second_b = 1;
        for (double i = 1; i < 5; i++)
        {
            double number_a = first_a + second_a;
            double number_b = first_b + second_b;
            // вычисление ответа
            answer = number_a / number_b;
            // замена в числителях
            first_a = second_a;
            second_a = number_a;
            // замена в знаменателях
            first_b = second_b;
            second_b = number_b;
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double grains = 1;
        for (int i = 1; i <= 64; i++)
        {
            grains *= 2;
        }
        answer = grains / 15;
        power = 18;
        double number = 1, number_for_degree = 10;
        for (int i = 1; i <= power; i++)
        {
            number *= number_for_degree;
        }
        answer = Math.Round(answer / number, 2);
        Console.WriteLine(answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        for (double h = 1; h <= x; h++)
        {
            answer = Math.Sqrt(h * ( 2 * R + h));
            answer = Math.Round(answer, 2);
            Console.Write("{0} ", answer);
        }
        Console.WriteLine();
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer += 10;
        for (int i = 3; i <= x; i += 3)
        {
            answer *= 2;
            Console.Write("{0} ", answer);
        }
        Console.WriteLine();
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        int n = 1;
        do
        {
            s = Math.Cos(n * x) / (n * n);
            answer += s;
            n++;
        } while (Math.Abs(s) >= 0.0001);
        answer = Math.Round(answer, 2);
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
        double sum = 0;
        if (a > p) return 0;
        do
        {
            if (sum < 0) return 0;
            answer++;
            sum += a + answer * h;
        } while (sum <= p);
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
        if (M == 0) return (0, 0);
        remainder = Math.Abs(N);
        while (remainder >= Math.Abs(M))
        {
            remainder -= Math.Abs(M);
            quotient++;
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
        double first_distance = 10, total_distance = 0;
        double day_distance = first_distance;
        for (int i = 1; i <= 7; i++)
        {
            total_distance += day_distance;
            // 10% то же самое что и 0.1 
            day_distance *= 1.1;
        }
        answer = Math.Round(total_distance, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double first_distance = 10, total_distance = 0;
        double day_distance = first_distance;
        int days = 0;
        while (total_distance <= 100)
        {
            total_distance += day_distance;
            day_distance *= 1.1;
            days++;
        }
        answer = days;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double first_distance = 10;
        double day_distance = first_distance;
        int days = 0;
        while (day_distance < 20)
        {
            day_distance *= 1.1;
            days++;
        }
        answer = days;
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
        double L = 0.1;
        double Da = 10.0;
        for (int i = 0; i <= 10; i++)
        {
            Da *= 1.0 / 10;
        }
        int counter = 0;
        while (L > Da)
        {
            L /= 2;
            counter++;
        }
        answer = counter;
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
        S++;
        double a = 0; // a - член суммы
        y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
        for (int i = 1; i <= 1000; i++)
        {
            double fact = 1; // fact - факториал
            for (int n = 1; n <= i; n++)
            {
                fact *= n;
            }
            a = Math.Cos(i * x) / fact;
            if (Math.Abs(a) >= 0.0001)
            {
                S += a;
            }
            else
            {
                break;
            }
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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