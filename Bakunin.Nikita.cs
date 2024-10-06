using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

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
        


        //double answer = 0;
        //double factorial = 1;
        //double power = 5;

        //for (int i = 1; i <= 6; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        factorial *= j;
        //    }

        //    for (int j = 1; j <= i; j++)
        //    {
        //        power *= 5;
        //    }

        //    if (i % 2 == 0)
        //    {
        //        answer += power / factorial;
        //    }
        //    else
        //    {
        //        answer -= power / factorial;
        //    }

        //    factorial = 1;
        //    power = 5;
        //}
        //Console.WriteLine(answer);
        //Console.WriteLine(answer);
        //int answer = 1;
        //int num = 3;
        //int degree = 7;
        //for (int i = 0; i < degree; i++)
        //{
        //    answer *= num;
        //}

        //program.Task_1_10();
        //program.Task_1_11();
        //for (int num = 1; num <= 6; num++)
        //{
        //    Console.Write(num);
        //    Console.Write(' ');
        //}
        //for (int num1 = 1; num1 <= 5; num1++)
        //{
        //    Console.Write(5);
        //    Console.Write(' ');
        //}
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //double answer = 0;
        //double cnt = 0;
        //double weight ;
        //int power = 0 ;
        //for (int i = 0; i < 64; i++)
        //{
        //    cnt *= 2;
        //}
        //weight = cnt / 15;
        //power = (int)Math.Log10(weight);
        //Console.WriteLine(power);

        //// end
        //return (Math.Round(answer, 2), (int)power);
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //double a = 0.2;
        //double h = -1.9;
        //double p = 12;
        //int answer = 0;
        //double sum = 0;
        //double num = 0;
        //while (sum <= p)
        //{

        //    sum += a + num * h;
        //    num++;

        //}
        //answer = (int)num - 1;
        //Console.WriteLine(answer);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //double distance = 10;
        //double totaldistance = 0;
        //for (int i = 1; i <= 7; i++)
        //{
        //    totaldistance += distance;
        //    distance += (distance / 100) * 10;

        //}
        //totaldistance = Math.Round(totaldistance, 2);

        //return totaldistance;

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
        for (int num = 2;num <= 35;num += 3)
        {
            answer += num;
        }
        
        return answer;
        
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (int num = 1; num <= 10;num++)
        {
            answer += 1.0 / num;
        }
         answer = Math.Round(answer,2);
        
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        
        for (double num = 2; num <= 112; num += 2)
        {
            answer += num / (num + 1);
        }
        answer = Math.Round(answer);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double sum = 0;
        double xdegree = 1;

        for (int i = 1; i <= 9; i++)
        {
            sum += Math.Cos(i * x) / xdegree;
            xdegree *= x;
        }

        sum = Math.Round(sum, 2);
        return sum;
    }
    public double Task_1_5(double p, double h)
    {
        double sum = 0;
        for (int num = 0; num <= 9; num++)
        {
            double val = p + (num * h);
            sum += val * val;
        }
        sum = Math.Round(sum, 2);

        return sum;
    }
    public double Task_1_6(double x)
    {

        double y = 0;
        for (double i = -4;i <= 4;i += 0.5)
        {
            y = 0.5 * x * x - 7 * x;
            y = Math.Round(y, 2);
            Console.WriteLine($"{x} {y}");
        }

        return y;
    }
    public int Task_1_7()
    {
        int answer = 1;
        int a = 6;
        for (int num = 1; num <= a; num++)
        {
            answer *= num;
        }
        return answer;
    }
    public int Task_1_8()
    {

        int sum = 0;
        int factorial = 1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            sum += factorial;
        }
        return sum;
    }
    public double Task_1_9()
    {

        double answer = 0;
        double factorial = 1;
        double sum = 0;
        double step = 1;
        double step1 = 1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            sum = ((-1 * step) * (5 * step1)) / factorial;
            step *= -1;
            step1 *= 5;
            answer += sum;

        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        int num = 3;
        int degree = 7;
        for (int i = 0; i < degree; i++)
        {
            answer *= num;
        }

        return answer;
    }
    public void Task_1_11()
    {
        for (int num = 1; num <= 6; num++)
        {
            Console.Write(num);
            Console.Write(' ');
        }
        for (int num1 = 1; num1 <= 5; num1++)
        {
            Console.Write(5);
            Console.Write(' ');
        }

    }
    public double Task_1_12(double x)
    {
        double sum = 1;
        double val = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 10; i++)
            {

                val /= x;
                sum += val;

            }
            sum = Math.Round(sum, 2);
            return sum;
        }
        else
        {
            return 0;
        }
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        return answer;
    }
    public void Task_1_14()
    {
        int a = 1;
        int b = 1;
        Console.Write(a);
        Console.Write(' ');
        Console.Write(b);
        Console.Write(' ');
        for (int i = 0; i <= 6; i++)
        {
            int c = a + b;
            Console.Write(c);
            Console.Write(' ');
            a = b;
            b = c;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        int numerator = 1;
        int denominator = 1;
        for (int i = 1; i < 5; i++)
        {
            int nextnumerator = numerator + denominator;
            int nextdenominator = numerator;

            numerator = nextnumerator;
            denominator = nextdenominator;
        }
         answer = (double)numerator / denominator;
        return answer;
    }
    public (double, int) Task_1_16()
    {

        double answer = 0;
        int power = 0;
        double cnt = 1;
        double weight;
        for (int i = 0; i < 64;i++)
        {
            cnt *= 2;
        }
        weight = cnt / 15;
        power = (int)Math.Log10(weight);
        answer = Math.Round(weight / Math.Pow(10, power), 2);
        return (answer,power);
       
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        answer = Math.Sqrt((R+x)*(R+x) - R * R);
        answer = Math.Round(answer, 2);
        

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        for (int i = 0; i < x;i += 3)
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
        double eps = 0.0001;
        int num = 1;
        while (Math.Abs(Math.Cos(num * x) / (num * num)) >= eps)
        {
            answer += Math.Cos(num * x) / (num * num);
            num++;
        }

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
        double sum = 0;
        int num = 0;
        if (h < 0)
        {
            return 0;
        }
        else
        {
            while (sum <= p)
            {
                sum += a + num * h;
                num++;

            }
            answer = num - 1;
        }

        return answer ;
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
        if (M == 0)
            {
                return (0, 0);
            }
        while (remainder >= M)
        {
            remainder -= M;
            quotient++;
        }

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
        double distance = 10;
        double totaldistance = 0;
        for (int i = 1; i <= 7; i++)
        {
            totaldistance += distance;
            distance += (distance / 100) * 10;

        }
        totaldistance = Math.Round(totaldistance, 2);

        return totaldistance;
    }
    public int Task_2_7b()
    {
        int days = 0;
        double totaldistance = 0;
        double distance = 10;
        while (totaldistance < 100)
        {
            totaldistance += distance;
            distance += (distance / 100) * 10;
            days++;
        }

        return days;
    }
    public int Task_2_7c()
    {
        int days = 0;
        double distance = 10;
        while (distance < 20)
        {
            distance += (distance / 100) * 10;
            days++;
        }

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
        double L = 0.1;
        int cnt = 0;
        while (L > Math.Pow(10, -10))
        {
            L /= 2;
            cnt++;
        }

        return cnt;
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
        double S = 1, y = 0;  
        double a = 1;
        double i = 1;
        double fact = 1;

        while (Math.Abs(a) > 0.0001)
        {
            a = Math.Cos(i * x) / fact;
            if (Math.Abs(a) > 0.0001)
            {
                i++;
                fact *= i;
                S += a;
            }
            else break;

        }

        y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));

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