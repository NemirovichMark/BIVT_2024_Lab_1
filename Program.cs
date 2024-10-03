using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(-4);
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
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int summ = 0;
        for (int x = 2; x <= 35; x += 3)
        {
            summ += x;
        }
        Console.WriteLine(summ);
        return summ;

    }
    public double Task_1_2()
    {
        double summ = 0.0;
        for (int a = 1; a <= 10.0; a += 1)
        {
            summ += 1.0 / a;
        }
        summ = Math.Round(summ, 2);
        Console.WriteLine("summ = {0:f2}", summ);
        return summ;
    }

    public double Task_1_3()
    {
        double summ = 0.0;

        for (double a = 2.0; a <= 112.0; a += 2.0)
        {
            summ += a / (a + 1.0);
        }
        summ = Math.Round(summ, 2);
        Console.WriteLine("summ = {0:f2}", summ);
        return summ;
    }
    public double Task_1_4(double x)
    {
        double summ = 0.0;
        int countersu = 1;
        double zn = 1;
        if (x == 0)
        {
            return 0;
        }
        while (countersu <= 9)
        {
            summ += Math.Cos(countersu * x) / zn;
            countersu++;
            zn *= x;
        }
        summ = Math.Round(summ, 2);
        return summ;
    }
    public double Task_1_5(double p, double h)
    {
        double summ = 0;

        int counter = 10;
        for (int i = 0; i < counter; i++)
        {
            double prsumma = p + i * h;
            summ += prsumma * prsumma;
        }

        // end

        return summ;
    }
    public double Task_1_6(double x)
    {
        double answer = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(answer, 2);
        // code here
        Console.WriteLine(answer);
        return answer;

        //end


    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        int counter = 1;
        while (counter < 7)
        {
            answer *= counter;
            counter++;
        }
        return answer;
        // end

    }
    public int Task_1_8()
    {
        int summ = 0;

        // code here;
        int sch = 1;
        int pr = 1;
        while (sch <= 6)
        {
            pr *= sch;
            summ += pr;
            sch++;
        }
        // end

        return summ;
    }
    public double Task_1_9()
    {


        // code here;
        double summ = 0;
        int n = 6;
        int x = 5;

        for (int i = 1; i <= n; i++)
        {

            int sign = (i % 2 == 0) ? 1 : -1;


            double power = 1;
            for (int j = 1; j <= i; j++)
            {
                power *= x;
            }

            double factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }

            double term = sign * power / factorial;
            summ += term;
        }
        // end
        summ = Math.Round(summ, 2);
        return summ;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int sch = 0;
        while (sch < 7)
        {
            answer *= 3;
            sch++;
        }
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int sch = 0;
        while (sch <= 5)
        {
            sch++;
            Console.Write(sch + " ");
        }
        Console.Write("  ");
        int sch2 = 0;
        while (sch2 <= 5)
        {
            Console.Write(5 + " ");
            sch2++;
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        int i = 0;
        double d = 1.0;
        if (x == 0) return 0;
        while (i <= 10)
        {
            answer += 1 / d;
            d *= x;
            i++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;

    }
    public double Task_1_13(double x)
    {

        // code here
        if (x <= -1)
        {
            return 1;
        }
        else if (x > -1 && x <= 1)
        {
            return -x;
        }
        else
        {
            return -1;
        }


        // end

    }
    public void Task_1_14()
    {
        // There is no test for this task
        int counter = 8;
        int ch1 = 1;
        int ch2 = 1;
        int ch3 = 0;
        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        for (int i = 2; i < counter; i++)
        {
            ch3 = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch3;
            Console.WriteLine(ch3);
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1;
        double ch2 = 2;
        double ch3 = 0;
        double zn1 = 1;
        double zn2 = 1;
        double zn3 = 0;
        for (int x = 0; x < 3; x++)
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            answer = ch3 / zn3;
            ch2 = ch3;
            zn1 = zn2;
            zn2 = zn3;
        }
        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0.0;
        int power = 0;
        int i = 1;
        double mnozh = 1.0;
        while (i != 65)
        {
            answer += mnozh;
            mnozh *= 2;
            i++;
        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        answer = answer / Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);

        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const int R = 6350;
        answer = Math.Sqrt((x + R) * (x + R) - (R * R));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int i = 0; i < x; i += 3)
        {
            answer *= 2;
        }
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        // code here
        int n = 1;
        double total = Math.Cos(n * x) / (n * n);
        while (Math.Abs(total) >= 0.0001)
        {
            answer += Math.Cos(n * x) / (n * n);
            n++;
            total = Math.Abs(Math.Cos(n * x) / (n * n));
        }
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
        int counter = 0;

        // code here
        double s = 0;
        do
        {
            if (p > (a + counter * h))
            {
                counter++;
                s += a + counter * h;
            }
            else
            {
                counter = 0;
                break;
            }
        } while (s <= p);



        // end

        return counter;
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
        int quotient = 0, remainder = N;

        // code here
        if (M == 0)
        {
            return (0, 0);
        }

        while (remainder >= M)
        {
            remainder -= M;
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
        double start = 10.0;
        int counter = 0;
        while (counter < 7)
        {
            answer += start;
            start *= 1.1;
            counter++;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        double total = 0;
        double start = 10;
        int days = 0;
        while (total < 100)
        {
            total += start;
            start *= 1.1;
            days++;
        }
        Console.WriteLine(days);
        // end

        return days;
    }
    public int Task_2_7c()
    {
        int days = 0;

        // code here
        double start = 10;
        while (start <= 20)
        {
            start *= 1.1;
            days++;
        }

        // end

        return days;
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
        int counter = 0;

        // code here;
        double length = 0.1;
        double atom = Math.Pow(10, -10);
        while (length > atom)
        {
            length /= 2;
            counter++;
        }

        // end

        return counter;
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
        double summ = 0;
        double xx = x;
        double znach = 1;
        for (int i = 0; Math.Abs(znach) >= 0.0001; i++ )
        {
            if (i > 0)
            {
                xx *= x * x;
            }
            znach = xx / (2 * i + 1);
            if (i % 2 != 0)
            {
                znach = -znach;
            }
            if (Math.Abs(znach) >= 0.0001)
            {
                summ += znach;
            }
        }
        
        double y = Math.Atan(x);
        Console.WriteLine(summ);
        Console.WriteLine(y);
        return (summ, y);
    }
    #endregion
}