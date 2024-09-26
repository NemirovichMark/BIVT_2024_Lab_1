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
        //program.Task_2_3(0.2,-1.9,12);
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
        int a = 2;

        // code here
        while (a <= 35)
        {
            answer = answer + a;
            a = a + 3;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double b = 0; int a = 1;

        // code here
        for (; a <= 10; a++)
        {
            b = 1f / a;
            answer = answer + b;

        }
        // end
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0; double b = 2; double temp = 0;

        // code here
        for (; b <= 112;)
        {
            temp = (b / (b + 1));
            answer = answer + temp;
            b = b + 2;
        
        }
        Console.WriteLine(answer);
        // end
        answer = Math.Round(answer, 0);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0; double temp = 0; double step = 1;
        if (x == 0)
            return 0;
        // code here
        for (int k = 1;k <= 9;k++)
        {

            temp = Math.Cos(x * k) / step;
            step = step * x;
            answer += temp;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0; int k = 0;

        // code here
        for (;k<=9;k++)
        {
            answer += (p + h * k) * (p + h * k);

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
        int answer = 1;

        // code here
        for (int a = 1; a <= 6; a++)
        {
            answer *= a;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;int n = 1;

        // code here;

        for(int k=1;k<=6;k++)
        {
            n *= k;
            answer += n;

        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0; double pyat = 5; int step = 1;double fac = 1;double minus = -1;


        // code here;
        for(double D=0;step<=6;step++)
        {
            fac *= step;
            D = (minus * pyat) / fac;
            pyat *= 5;
            answer += D;
            minus = -minus;

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0; int a = 1; 
        for(int b=1;b<=7;b++)
        // code here
        {
            a *= 3;
            Console.WriteLine(a);

        }
        // end
        answer = a;
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int a = 1;

        // code here
        for (; a <= 6; a++)
        {
            Console.Write(a + " ");
            
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 1; double step = x;
        if (x == 0) return 0;
        // code here
        for (int s= 0; s<=9; s++)
        {
            answer += (1 / step);
            step *= x;

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        if (x > -1 && x <= 1) return -x;
        if (x > 1) return -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1; int b = 0; int s = 1;
        for (int k=0;k<8; k++)
        {
            a = s;
            Console.WriteLine(s);
            s = a + b;
            b = a;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double a = 1; double b = 1; double s = 0;
        // code here
        a += b;
        for (int k=0;k<4;k++)
        {
            answer = a / b;
            s = a;
            a += b;
            b = s;


        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double d = 2;

        // code here
        for (int k=0;k<=62;k++)
        {
            answer += d / 15;
            d *= 2;
            //Console.WriteLine(answer);
        }
        //Console.WriteLine(answer);
        // end
        power = (int)Math.Log10(answer);
        //Console.WriteLine(power);
        answer /= Math.Pow(10, 18);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer); 
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0; int r = 6350;

        // code here
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        // end
        answer= Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;


        // code here
        while(x>0)
        {
            answer *= 2;
            x -= 3;

        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0; double n = 1;

        //code here
        while (Math.Abs(Math.Cos(n * x) / (n * n)) >= 0.0001)
        {
            answer += Math.Cos(n * x) / (n * n);
            n++;
            //Console.WriteLine(answer);

        }
        //end

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
        int answer = 0; int n = 0; double s = 0;
        if ((a + 1 * h) < 0) return answer = 0;

        // code here
        while ((s+(a+n*h))<=p)
        {
            answer++;
            s += (a + n * h);
            n++;
            Console.WriteLine(s);
        }
        // end
        Console.WriteLine(answer);
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
        if (M == 0) return (quotient, remainder);

        while (N-M >= 0)
        {
            quotient++;
            remainder = N - M;
            N = remainder;

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
        double s = 10;
        // code here
        for (int k=0;k<7;k++)
        {
            answer += s;
            s *= 1.1;
        }

        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 10;
        double total = 100;
        // code here
        while (total>=0)
        {
            total -= s;
            s *= 1.1;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10;
        // code here
        while (s<=20)
        {
            answer++;
            s *= 1.1;

        }
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

        double L = 0.1;
        double atom = Math.Pow(10, -10);
        // code here;
        while (L > atom)
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
    public (double, double) Task_3_3(double x)
    {
        double S = 1, y = 0;

        // code here
        double a = 1;
        double i = 1;
        double fact = 1;

        while (Math.Abs(a)>0.0001)
        {
            a = Math.Cos(i * x) / fact;
            S += a;
            i++;
            y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        // end
        Console.WriteLine($"{S} - {y}");
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



