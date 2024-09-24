using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

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
        //program.Task_1_18(3);
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
        program.Task_3_2(0.1);
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
        {
            ; answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += (1.0 / i);
        }
        answer = Math.Round(answer, 2);
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

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        else
        {
            for (int i = 0; i <= 8; i++)
            {
                answer += Math.Cos(x * (i + 1)) / Math.Pow(x, i);
            }
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += Math.Pow(p + h * i, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * Math.Pow(x, 2) - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int value = 1;
        for (int i = 1; i <= 6; i++)
        {
            value *= i;
        }
        answer = value;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int value = 1;
        for (int i = 1; i <= 6; i++)
        {
            value *= i;
            answer += value;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double value = 1;
        for (int i = 1; i <=6; i++)
        {
            value *= i;
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / value; ;
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
        for (int i = 1; i <= 7; i++)
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
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;

        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / Math.Pow(x, i);
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
        if (-1 < x && x < 1) answer = -x;
        if (x >= 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0, b = 1, temp;

        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(b);
            temp = a;
            a = b;
            b = temp + b;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double numerator = 1, denominator = 1, temp;

        for (int i = 0; i < 4; i++)
        {
            temp = numerator;
            numerator = numerator + denominator;
            denominator = temp;
        }

        answer = numerator / denominator;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double amount = 0;
        
        for (int i = 0; i < 64; i++)
        {
            amount += Math.Pow(2, i);
        }

        answer = amount / 15;
        double temp = answer;

        while (temp >= 10)
        {
            temp /= 10;
            power++;
        }

        answer = Math.Round(answer / Math.Pow(10, power), 2);
        // end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Round(Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int amount = 10;

        for (int i = 0; i < x; i += 3)
        {
            amount *= 2;
        }
        answer = amount;
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

        int l = 30000, p = 1;

        for (int n = 1; p * n <= l; n += 3)
        {
            p *= n;
            answer = n;
        }



        //int l = 30000, p = 1, n = 1;

        //do
        //{
        //    n += 3;
        //    p *= n;
        //}
        //while (p * n <= l);

        //answer = n;



        //int l = 30000, p = 1, n = 1;

        //while (p * n <= l)
        //{
        //    n += 3;
        //    p *= n;
        //}
        //answer = n;

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

        if (x >= 1) return 0;

        double s = 0, e = 0.0001;

        for (int i = 0;  ; i++)
        {
            double n = Math.Pow(x, i * 2);
            s += n;

            if (n < e) break;
        }

        answer = Math.Round(s, 2);

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

        int amount = (int)Math.Pow(10, 5), i = 0;

        do
        {
            amount /= 2;
            i += 3;

        } while (amount > 10);

        answer = i;

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
        double value = 10000, double_value = value * 2, percent = 8;
        int months = 0;

        while(value < double_value)
        {
            value *= 1 + (percent / 100);
            months++;
        }

        answer = months;

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

        double numerator = 1, denominator = 1, temp, previous_value, current_value;

        do
        {
            previous_value = numerator / denominator;

            temp = numerator;
            numerator = numerator + denominator;
            denominator = temp;

            current_value = numerator / denominator;

            answer++;

            Console.WriteLine($"{previous_value} {current_value} {answer}");

        } while (Math.Abs(previous_value - current_value) > 0.001);

        answer++;  // Я начинаю счёт со второго члена последовательности, добавил 1 здесь, так как не хочу изменять шаблон

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
        double sum_member;

        for (int i = 1; ; i++)
        {
            sum_member = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);

            if (Math.Abs(Math.Pow(x, i)) >= 0.0001) S += sum_member;
            else break;
        }

        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + Math.Pow(x, 2));

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