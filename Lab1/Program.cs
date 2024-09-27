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
        program.Task_2_3(8, 2, 0);
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
        //program.Task_3_5(double.Pi / 5);
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
        
        for (int i = 2; i <= 35; i = i + 3)
            answer += i;
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;

        for (int y = 1; y <= 10; y = y + 1)
        {
            s += (double) 1 / y;
        }
        answer = Math.Round(s,2);
        Console.WriteLine(s);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double x = 2; x <= 112; x += 2)
        {
            s = s + x / (x + 1);
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(s);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        double s = Math.Cos(x), k = x;
        int n = 1;
        if (x == 0)
            return 0;
        while (n <= 8)
        {
            s += Math.Cos(x * (n + 1)) / k;
            n++;
            k *= x;

        }
        answer += Math.Round(s, 2);
        Console.WriteLine(s);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        
        for (int i = 0; i <= 9; i ++)
        {
            s += (double)(p + i * h) * (p + i * h);
        }
        answer += s;
        //Console.WriteLine(s);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0.5 * x * x - 7 * x;
        answer += Math.Round(y,2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int p = 1;
        for (int i = 2; i <= 6; i ++ )
        {
            p = p * i;
        }
        answer += p;
        Console.WriteLine(p);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int n = 1, i = 1, p = 1, s = 0;
        while (n<=6)
        {
            while (i <= n)
            {
                p *= i;
                i++;
            }
            n++;
            s += p;
        }
        answer += s;
        Console.WriteLine(s);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0, k = -1, t = 5, p = 1;
        for (int i = 1; i <= 6; i ++)
        {
            s += k * t / p;
            k *= -1;
            t *= 5;
            p += p * i;
           
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(s);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i <= 7; i ++)
        {
            s = s * 3;
       
        }
        answer = s;
        Console.WriteLine(s);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        // code here
        
        for (int a=1; a <= 6; a ++)  //a
        {
            Console.Write(a + " ");
        }

        for (int a = 1; a <= 6; a++)  //b
        {
            Console.Write(5 + " ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double k = 1;
        if (x == 0)
            return 0;
                     
        for (int i = 0; i <= 10; i++)
        {
            answer += k;
            k /= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
        }
        else
        {
            y = -1;
        }
         answer += y;

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int a = 1, s = 0;
        for (int i = 1;i <= 8; i ++)
        {
            s += a;
            a = s - a;
            Console.WriteLine(s);
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 2, b = 3, c = 1, d = 2,x = 1, y = 1, k= 1, t = 1;
        for (int i = 1; i <= 1; i++) 
        {
            x = a + b;
            y = c + d;
            k = b + x;
            t = d + y;
            answer += k / t;
            
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        //code here
        double s = 0, p = 1;
        for (int i = 0; i <= 63; i++)
        {
            s += p;
            p *= 2;
        }
        double gram = s / 15.0;
        while (gram >= 10)
        {
            power++;
            gram /= 10;
        }

        answer = Math.Round(gram, 2);
        Console.WriteLine(power);
        Console.WriteLine(answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        double r = 6350;
        double h = 0;
        
        
        h = Math.Sqrt((r + x) * (r + x) - (r * r));
        answer += h;
        
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;


        // code here


        int k = 10, c = 0;
        while (c < x)
        {
            k *= 2;
            c += 3;
        }
        answer += k;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        double eps = 0.0001;
        double s = 0, a = Math.Cos(x);
        int n = 1;
        do
        {
            s += a;
            n += 1;
            a = Math.Cos(n * x) / (n * n);
        } while (Math.Abs(a) >= eps);
        answer = s;

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

        double s = 0, k = 0;
        if (p <= 0)
            return 0;
        if (h <= 0)
            return 0;
        while (s <= (p - (a+ k * h)))
        {
            s += a + k * h;
            k += 1;
        }
        answer =(int) k;
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
        
        if (M != 0) //иначе деление на ноль
        {
            while (N > 0)
            {
                if (N - M >= 0)
                {
                    quotient++;
                    
                }
                else
                {
                    remainder = N;
                }
                N = N - M;
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
        double answer = 0;

        // code here
        double s = 10;
        double k = 10;
        
        for (int i = 1; i <= 6; i++)
        {
            s = s * 1.1;
            k += s;
        }
        answer = Math.Round(k, 2);


        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 10;
        double k = 10;
        int count = 1;
        while (k < 100)
        {
            s = s * 1.1;
            k += s;
            count++;
        }
        answer = count;

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 10;
        int count = 0;
        while (s < 20)
        {
            s = s * 1.1;
            count++;
        }
        answer = count;
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
        double k = 0.1;
        int count = 0;
        
        while (k >= 0.0000000001)
        {
            k /= 2;
            count++;
        }
        answer += count;
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

        // end

        return (S, y);
    }
    #endregion
}