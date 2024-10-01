using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.task_1_1();
        //program.task_1_2();
        //program.task_1_3();
        //program.task_1_4(0.9);
        //program.task_1_5(0, 2);
        //program.task_1_6(4);
        //program.task_1_7();
        //program.task_1_8();
        //program.task_1_9();
        //program.task_1_10();
        //program.task_1_11();
        //program.task_1_12(0.9);
        //program.task_1_13(-1.5);
        //program.task_1_14();
        //program.task_1_15();
        //program.task_1_16();
        //program.task_1_17(10);
        //program.task_1_18(24);
        //program.task_2_1(0);
        //program.task_2_2();
        //program.task_2_3(8, 2, 0);
        //program.task_2_4(0.8);
        //program.task_2_5(11, 5);
        //program.task_2_6();
        //program.task_2_7a();
        //program.task_2_7b();
        //program.task_2_7c();
        //program.task_2_8();
        //program.task_2_9();
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

        int answer = 0;
        int a1 = 2;
        while (a1 <= 35)
        {
            answer += a1;
            a1 += 3;
        }
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        double sum = 0.0;
        for (int i = 1; i <= 10; i++)
        {
            sum += 1.0 / i;
        }
        double roundsum = Math.Round(sum, 2);
        answer = roundsum;
        
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        double sum = 0.0;
        for (int i = 2; i <= 112; i += 2)
        {
            sum += (double)i / (i + 1);
        }
        double roundsum = Math.Round(sum);
        answer = roundsum;

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        double X = 0.5;
        double exponent = 1.0;
        double sum = 0.0;
        if (X == 0.0)
            return 0;
        else
        {
            for (int n = 1; n < 10; n++)
            {
                double value = Math.Cos(n * X);
                value /= exponent;
                sum += value;
                exponent *= X;
            }
            answer = Math.Round(sum, 2);
        }


        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        double P = 0;
        double H = 0;
        double answer = 0;
        for (int n = 0; n < 10; n++)
        {
            double currentTerm = P + n * H;
            answer += currentTerm * currentTerm;
        }

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        //double X;
        double Y;
        Console.WriteLine("     X |      Y(X) ");

        //for (X = -4; X <=4; X += 0.5)
        {
            Y = 0.5 * X * X - 7 * X;
            Console.WriteLine($"{X,7}|{Y,11:F2}");
        }

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here

        int factorial = 1;
        for (int i = 1; i <= 6; i++)
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

        int factorial = 1;
        int firstTerm = -1;
        int secondTerm = 5;

        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            answer += (double)firstTerm * secondTerm / factorial;
            firstTerm *= -1;
            secondTerm *= 5;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        int basis = 3;
        int exponent = 7;
        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= basis;
        }
        answer = result;

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

        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            Console.Write(5 + " ");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        double X = 1.35;
        if (X == 0.0)
            return 0;
        else
        {
            double sum = 1.0;
            double one = 1.0;

            for (int i = 1; i <= 10; i++)
            {
                one /= X;
                sum += one;
            }
            answer = Math.Round(sum, 2);
        }


        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        Console.WriteLine("    X  |     Y");

        for (double X = -1.5; X <= 1.6; X += 0.1)
        {
            double Y;

            if (X <= -1)
            {
                Y = 1;
            }
            else if (X > -1 && X <= 1)
            {
                Y = -X;
            }
            else
            {
                Y = -1;
            }
            Console.WriteLine($"{X,6:f1} | {Y,6:f1}");
        }


        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int count = 8;
        int[] fibonacci = new int[count];

        fibonacci[0] = 1;
        fibonacci[1] = 1;

        for (int i = 2; i < count; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Ïåðâûå 8 ÷ëåíîâ ïîñëåäîâàòåëüíîñòè Ôèáîíà÷÷è:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(fibonacci[i]);
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        int[] numerators = new int[5];
        int[] denominators = new int[5];

        numerators[0] = 1;
        denominators[0] = 1;

        numerators[1] = 2;
        denominators[1] = 1;

        for (int i = 2; i < 5; i++)
        {
            numerators[i] = numerators[i - 1] + numerators[i - 2];
            denominators[i] = denominators[i - 1] + denominators[i - 2];
        }

        double answer = (double)numerators[4]/denominators[4];

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        double answer = 1;
        double power = 0;
        double grains = 1;

        for (int i = 1; i <= 63; i++)
        {
            grains *= 2;
            answer += grains;
        }

        answer = answer / 15;

        while (answer >= 10)
        {
            answer = answer / 10;
            power ++;
        }
        answer = Math.Round(answer, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        int R = 6350;
        int h = 1000;
        double answer = Math.Sqrt(h * (2 * R + h)); 
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        int count = 10;
        Console.WriteLine("Âðåìÿ (÷) | Êîë-âî êëåòîê");

        int currentCount = count;
        for (int hours = 3; hours <= 24; hours += 3)
        {
            currentCount *= 2;

            Console.WriteLine($"{hours,10} {currentCount,16}");
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

        double X = 1;
        double sum = 0;
        double currentTerm = 1;
        int i = 1;

        while (Math.Abs(Math.Cos(i * X) / (i * i)) >= 0.0001)
        {
            currentTerm = Math.Cos(i * X) / (i * i);
            sum += currentTerm;
            i += 1;
        }
        answer = sum;

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

        double a = 1;
        double h = 1;
        double p = 10;
        int n = 0;

        while (true)
        {
            double currentTerm = a + n * h;
            answer += currentTerm;

            if (answer > P)
                break;

            n++;
        }
        Console.WriteLine(answer);

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

        int n = 11;
        int m = 5;

        if (m == 0)
            return (0, 0);

        int quotient = 0;
        int remainder = n;

        while (remainder >= m)
        {
            remainder -= m;
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

        double a1 = 10;
        double sum = 0.0;

        for (int day = 1; day <= 7; day++)
        {
            sum += a1;
            a1 += a1 * 0.1;
        }
        answer = Math.Round(sum, 2);

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        double a1 = 10;
        double sum = 0.0;
        int days = 0;

        while (sum < 100)
        {
            sum += a1;
            a1 += a1 * 0.1;
            days++;
        }
        answer = days;

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        double a1 = 10;
        int days = 0;

        while (a1 <= 20)
        {
            days++;
            a1 += a1 * 0.1;
        }
        answer = days;

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
        double D_A = 0.0000000001;
        int cuts = 0;

        while (L > D_A)
        {
            L /= 2;
            cuts++;
        }
        answer = cuts;

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
        
        double i = 0, f = x, n = 1, m = 1;
        double eps = 0.0001;
        while (Math.Abs((n)) >= eps)
        {
            n = (m * f / (2 * i + 1));
            S += n;
            m = -m;
            f *= (x * x);
            i++;
        }
        S = S - n;
        y = Math.Atan(x);

        // end

        return (S, y);
    }
    #endregion
}
