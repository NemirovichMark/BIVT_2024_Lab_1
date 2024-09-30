using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

        for (int n = 2; n <= 35;)
        {
            answer += n;
            n += 3;

        }
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        for (double n = 1; n <= 10; n++)
        {
            answer += (1/n);
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (double n = 2; n <=113; n+=2)
        {
            answer+=(n/(n+1));

        }
        answer= Math.Round(answer, 0);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x);
        double b = x;
        for (double n = 1; n < 9; n++)
        {
            if (x == 0)
            {
                answer = 0;
            }
            else
            {
                answer += Math.Cos((n+1)*x)/b;
                b *= x;

            }

        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (double n = 0; n <= 9; n++)
        {
            answer+= (p + n*h)*(p + n*h);
        }

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;



        answer = Math.Round((0.5*x*x - 7*x), 2);




        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        for (int n = 1; n<=6; n++)
        {
            answer*=n;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;
        int fact = 1;
        for (int n = 2; n<=6; n++)
        {
            fact*=n;
            answer += fact;
        }
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double i = 1, a = -1 * 5 / 1;
        // code here;
        while (i != 7)
        {
            answer += a;
            i++;
            a = -1 * a * 5 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        for (int n = 1; n<=7; n++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int n = 1; n<=6; n++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        for (int i = 1; i<=6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here


    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double a = 1;
        if (x == 0) return 0;
        while (i < 12)
        {
            i++;
            answer += 1 / a;
            a *= x;

        }
        //Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x <= -1)
        {
            answer = 1;
        }
        if (-1 <= x && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        answer=Math.Round(answer, 3);
        return answer;
    }
    public void Task_1_14()
    {
        int n1 = 1;
        int n2 = 1;
        // code here
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i = 0; i<6; i++)
        {
            int nn = n1 + n2;
            Console.WriteLine(nn);
            n1=n2;
            n2=nn;
        }

        // end

    }
    public double Task_1_15()
    {
        double answer = 0;
        double np1 = 1;
        double np2 = 1;
        double n1 = 2;
        double n2 = 1;
        for (double i = 1; i <= 5; i++)
        {
            double nn1 = n1 + np1;
            double nn2 = np2 + n2;
            answer = nn1/nn2;
            np1 = n1;
            np2 = n2;
            n1 = nn1;
            n2 = nn2;
        }
        answer = Math.Round(answer, 1);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zerno = 0;
        double a = 1;

        for (int i = 1; i<= 64; i++)
        {
            zerno += a;
            a *= 2;
        }
        answer = zerno/15;

        while (answer>=10)
        {

            power+=1;
            answer = answer/10;

        }
        answer = Math.Round(answer, 2);

        Console.WriteLine(answer);
        Console.WriteLine(power);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        // code here
        answer = Math.Sqrt((R + x)*(R + x) - R*R);


        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        int i = 0;
        while (x > 0)
        {
            answer *= 2;
            x -= 3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = Math.Cos(x);
        double a = Math.Cos(x);
        int i = 2;
        for (int j = 2; j<= 1000; j++)

        {
            a = Math.Cos(j*x)/j/j;
            if (Math.Abs(a) >= 0.0001)
            {
                answer += a;
            }
            else if (Math.Abs(a) < 0.0001)
            {
                break;
            }

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
        double s = 0;

        // code here
        for (int i = 0; i<= 10000; i++)
        {
            if ((s+(a+i*h)) > (s+(a+(i+1)*h)))
            {
                answer = 0;
                break;
            }

            else if ((s+(a+i*h)) <= p)
            {
                s+=(a+i*h);
                answer+= 1;
            }
            else if ((s+(a+i*h)) > p)
            {
                return answer;
                break;
            }

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
        if (M != 0)
        {
            while (N > 0)
            {
                if ((N - M)>=0)
                {
                    quotient++;
                    remainder = N - M;
                }
                else
                {
                    remainder = N;
                }
                N = N-M;
            }
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
        double answer = 10;
        double norma = 10;

        // code here
        for (int i = 0; i<6; i++)
        {
            norma *= 1.1;
            answer += norma;

        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7b()
    {
        double answer = 10;
        int day = 1;
        double norma = 10;
        // code here
        while (answer < 100)
        {
            day++;
            norma *= 1.1;
            answer += norma;
        }
        // end
        return day;
    }
    public int Task_2_7c()
    {

        int day = 0;
        double norma = 10;
        // code here
        while (norma <= 20)
        {
            day++;
            norma *= 1.1;
        }
        // end

        return day;
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
        while (L > Math.Pow(10, -10))
        {
            answer++;
            L /= 2;
        }
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

    
    //public (double, double) Task_3_3(double x)
    //{
    //    double S = 0, y = 0;

    //    // code here
    //    S = 1;
    //    double elem = Math.Cos(x), fact = 1.0;

    //    for (int i = 1; ;)
    //    {

    //        elem = Math.Cos(i * x) / fact;
    //        if (Math.Abs(elem) < 0.0001) break;
    //        S += elem;
    //        i++;
    //        fact *= i;

    //    }
    //    y = Math.Exp(Math.Cos(x))*Math.Cos(Math.Sin(x));
    //    //S = Math.Round(S);
    //    //y = Math.Round(y);
    //    Console.WriteLine(S + " " + y);
    //    // end

    //    return (S, y);
    //}

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

    public (double, double) Task_3_3(double x)
    {
        double S = 1, y = 0;
        double element = Math.Cos(x), i1 = 1;
        for (int j = 1; ;)
        {

            element = Math.Cos(j * x) / i1;
            if (Math.Abs(element) < 0.0001) break;
            S += element;
            j++;
            i1 *= j;
        }
        Console.WriteLine($"{S} {y}");
        y = Math.Exp(Math.Cos(x))*Math.Cos(Math.Sin(x));
        return (S, y);

    }
}