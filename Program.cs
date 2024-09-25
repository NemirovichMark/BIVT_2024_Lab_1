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
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);

        /*for(double x = -4;  x <= 4;  x+=0.5)
            program.Task_1_6(4);*/

        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        program.Task_1_11();
        //program.Task_1_12(0.9);
        /*for (double x = -1.5; x <= 1.5; x += 0.1)
            program.Task_1_13(-1.5);*/
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
        int n = 2;
        while (n <= 35)
        {
            answer += n;
            n += 3;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double n = 1;
        while (n <= 10)
        {
            answer += 1 / n;
            n += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double ch = 2, zn = 3;
        while (ch <= 112 && zn <= 113)
        {
            answer += ch / zn;
            ch += 2;
            zn += 2;
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
        int n = 2;
        double k = x;
        answer += Math.Cos(x);
        while (n <= 9)
        {
            answer += Math.Cos(n * x) / k;
            k *= x;
            n++;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int n = 0;
        while (n <= 9)
        {
            answer += (p + n*h)*(p + n*h);
            n++;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int n = 1;
        answer += 1;
        while (n <= 6)
        {
            answer *= n;
            n++;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int n = 0, k = 1;
        while (n < 6)
        {
            n += 1;
            answer += k;
            //Console.WriteLine(k);
            k *= (n + 1);

            //Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int n = 1, m = 5, h = -1;
        double k = 1;
        while (n <= 6)
        {
            answer += m * h / k;
            //Console.WriteLine($"{m} {h} {n} {k} {answer}");
            m *= 5;
            h *= -1;
            k *= (n + 1);
            n += 1;

        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int n = 1;
        answer += 1;
        while (n <= 7)
        {
            answer *= 3;
            n++;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        // code here
        int n = 0;
        while (n < 6)
        {
            n++;
            Console.Write(n);
        }
        Console.WriteLine(" ");
        int k = 1;
        while (k <= 6)
        {
            Console.Write("5");
            k++;
        }


    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }
        int n = 1;
        double k = 1;
        answer = answer + 1;
        while (n <= 10)
        {
            k *= x;
            answer += 1 / k;
            n += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (x > -1 && x <= 1)
            answer = x * -1;
        if (x > 1)
            answer = -1;

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        // code here
        int ch1 = 1, ch2 = 1, n;
        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ch2 + ch1);
            n = ch2;
            ch2 += ch1;
            ch1 = n;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, ch2 = 2, zn1 = 1, zn2 = 1, n1 = 0, n2 = 0;
        for (int i = 0; i <= 3; i++)
        {
            n1 = ch2;
            ch2 += ch1;
            ch1 = n1;
            n2 = zn2;
            zn2 += zn1;
            zn1 = n2;
        }
        answer = n1 / n2;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int n = 0;
        ulong k = 1;
        while (n < 64)
        {
            answer += k;
            k *= 2;
            n++;
            Console.WriteLine(k);
            Console.WriteLine(n);
            Console.WriteLine(answer);
        }
        // end
        answer /= 15;
        power = 18;
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;

        answer = Math.Sqrt((r+x)*(r+x) - r*r);
        answer = Math.Round(answer, 2);

        return answer;

        //Console.WriteLine(answer);

        // end
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 10;
        int n = 0;
        while (n <= x)
        {
            answer = k;
            k *= 2;
            n += 3;

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
        while ((Math.Abs(Math.Cos(x * n) / n / n) > 0.0001))
        {
            answer += Math.Cos(x * n) / n / n;
            n++;
            Console.WriteLine(answer);
            Console.WriteLine(Math.Cos(x * n) / n / n);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        int s = 1, k = 1;
        // code here
        while (s <= 30000)
        {
            answer = k;
            k += 3;
            s *= k;
            Console.WriteLine(s);
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

        // code here
        if (x >= 1)
            return 0;
        if (x <= -1)
            return 0;
        double k = x;
        answer += 1;
        x = x * x;
        while (x >= 0.0001)
        {
            answer += x;
            x *= k * k;
            //Console.WriteLine(x);
            //Console.WriteLine(answer);
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

        // code here
        int k = 10;
        int n = 0;
        while (k <= 100000)
        {
            n += 3;
            answer = n;
            k *= 2;
            Console.WriteLine($"{k} {answer}");
        }
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
        double n = 10000;
        while (n <= 20000)
        {
            answer++;
            n *= 1.08;

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
        int answer = 0;

        // code here;
        double ch1 = 1, ch2 = 2, zn1 = 1, zn2 = 1, n1 = 0, n2 = 0;
        //double x1 = ch1 / zn1, x2 = ch2 / zn2;
        answer += 2;
        while (Math.Abs(ch1 / zn1 - ch2 / zn2) >= 0.001)
        {
            answer += 1;
            n1 = ch2;
            ch2 += ch1;
            ch1 = n1;
            n2 = zn2;
            zn2 += zn1;
            zn1 = n2;
        }
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
        double h = 1;
        y = (1 + 2 * x * x) * Math.Exp(x * x);
        for (int i = 0; i <= 1000000; i++)
        {
            Console.WriteLine(i);
            double ch1 = 0, ch2 = 1, ch3 = 1, res = 1;
            ch1 = (2 * i + 1);
            ch2 = h;
            h *= x * x;
            for (int n = 1; n <= i; n++)
                ch3 *= n;
            res = (ch1 * ch2) / ch3;
            if (Math.Abs(res) >= 0.0001)
                S += res;
            else
                break;
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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