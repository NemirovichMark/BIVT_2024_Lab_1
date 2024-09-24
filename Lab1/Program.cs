using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        program.Task_2_1(0);
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
        program.Task_3_1(0.1);
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
        int s = 0;

        for (int x = 2; x <= 35; x += 3)
        {
            s += x;  
        }

        answer = s;
        //Console.WriteLine($"{s, 10}");
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double x = 1; x <= 10; x++)
        {
            s += 1 / x;
           
        }
        answer = Math.Round(s, 2);
        //Console.WriteLine($"{s, 10}");
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
            s += x / (x + 1);
        }

        answer = Math.Round(s);
        //Console.WriteLine($"{s,10}");
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return 0;

        else
        {
            double n = 1;
            double s = 0;

            for (int i = 1; i <= 9; i++)
            {
                s += Math.Cos(i * x) / n;
                n *= x;
            }

            answer = Math.Round(s, 2);
            //Console.WriteLine($"{x, 10} {s, 10}");
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, b = 0;

        for (int i = 0; i <= 9; i++)
        {
            s += (p + b) * (p + b);
            b += h;
        }

        answer = s;
        Console.WriteLine($"{s}");
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        double y = 0;
        y = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(y, 2);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;

        for (int x = 1; x <= 6; x++)
        {
            f *= x;
        }

        answer = f;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        int s = 0;

        for (int x = 0; x <= 5; x++)
        {
            f += f * x;
            s += f;
        }

        answer = s;
        //Console.WriteLine($"{f, 10}");
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        double s = 0;
        int f = 1;
        double n1 = 1, n2 = 1;

        for (int i = 0; i <= 5; i++)
        {
            n1 *= -1;
            n2 *= 5;
            f += f * i;
            s += n1 * n2 / f;
        }

        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int p = 1;

        for (int i = 1; i <= 7; i++)
        {
            p *= 3;
        }

        answer = p;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 0; i <= 6; i++)
        {
            Console.Write($"{i,3}");
        }

        Console.WriteLine();

        for (int i = 0; i <= 6; i++)
        {
            Console.Write($"{5,3}");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }

        else
        {
            double s = 0;
            double n = 1;
            
            for (int i = 0; i <= 10; i++)
            {
                s += 1 / n;
                n *= x;
            }

            answer = Math.Round(s, 2);
            //Console.WriteLine($"{s}");
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
            Console.WriteLine($"{x} 1");
            return 1;
        }

        else if (-1 < x && x <= 1)
        {
            Console.WriteLine($"{x} {-x}");
            return -x;
        }

        else if (x > 1)
        {
            Console.WriteLine($"{x} -1");
            return -1;
        }

        else
        {
            Console.WriteLine("Error");
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int fibo1 = 1;
        int fibo0 = 0;

        for (int i = 1; i <= 8; i++)
        {
            int fibo2 = fibo1;
            fibo1 += fibo0;
            fibo0 = fibo2;
        }

        //Console.WriteLine($"{fibo0, 10}");
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double fibo1 = 1;
        double fibo0 = 1;

        for (int i = 1; i <= 8; i++)
        {
            answer = Math.Round(fibo1 / fibo0, 1);
            double fibo2 = fibo1;
            fibo1 += fibo0;
            fibo0 = fibo2;
        }

        //Console.WriteLine($"{fibo1, 10} {fibo0, 10} {answer, 10}");
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;

        // code here
        double power = 0;
        double s = 1;

        for(int i = 0; i < 64; i++)
        {
            s *= 2;
        }

        s /= 15;
        power = Math.Log10(s);

        for (int i = 1; i <= power; i++)
        {
            s /= 10;
        }
        
        answer = Math.Round(s, 2);
        //Console.WriteLine($"{s}, {power} iahdwoihdaoih");
        // end

        return (answer, (int)power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        double s = Math.Sqrt((r + x) * (r + x) - (r * r));
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int n = 10;

        for (int i = 1; i <= x / 3; i++)
        {
            n *= 2;
        }

        answer = n;
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
        double e = 0;
        int n = 1;

        while (true)
        {
            s += e;
            e = Math.Cos(n * x) / (n * n);
            n++;

            if (Math.Abs(e) < 0.0001)
            {
                break;
            }

        }
       
        answer = s;
        //Console.WriteLine(s);
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
        int cnt = 0;
        double s = 0;

        if (h < 0)
            return 0;

        else
        {
            for (int i = 0; ; i++)
            {
                s += a + (i * h);

                if (s > p)
                    break;

                else
                    cnt++;
            }
        }
        answer = cnt;
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
        if (M == 0)
        {
            return (0, 0);
        }

        while(Math.Abs(M) <= Math.Abs(N))
        {
            N -= M;
            quotient++;
            remainder = Math.Abs(N);
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

        // code here
        double answer = 0;
        double dist = 10; 
        double s = 0;

        for (int i = 1; i <= 7; i++)
        {
            s += dist;
            dist += dist * 0.1;
        }
        
        answer = Math.Round(s, 2);
        //Console.WriteLine(s);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        // code here
        double dist = 10; 
        double s = 0;
        int cnt = 0;

        while (s < 100)
        {
            s += dist;
            dist += dist * 0.1;
            cnt++;
        }

        answer = cnt;

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double dist = 10; 
        int cnt = 0;

        while (dist < 20)
        {
            dist += dist * 0.1;
            cnt++; 
        }
        
        answer = cnt;

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
        double D = 1e-10;
        double L = 0.1;
        int cnt = 0;

        while(D <= L){
            L /= 2;
            cnt++;
        }
        
        answer = cnt;
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
        
        // code here
        double S = 0, y = 0, dith = 0;
        double denominador = 1;
        double numerador = 1;
        

        for (int i = 0; ; i++)
        {
            numerador = Math.Pow(x, 2 * i);
            if (i == 0)
            {
                denominador = 1;
            }
           
            else
            {
                denominador *= 2 * i * (2 * i - 1); 
            }
            

            dith = Math.Pow(-1, i) * numerador / denominador;
            S += dith;
            
            if (Math.Abs(dith) < 0.0001)
            {
                break;
            }
        }

        y = Math.Round(Math.Cos(x), 2);
        S = Math.Round(S, 2);
        //Console.WriteLine($"{S} = S {y} = y");
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