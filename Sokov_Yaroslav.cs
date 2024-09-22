using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        //for (double x = -4; x <= 4; x += 0.5)
        //{
        //    program.Task_1_6(x);
        //}
        //program.Task_1_6(x);
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
        //for (int x = 1; x <= 10; x++)
        //{
        //    program.Task_1_17(x);
        //}
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        double a = 0.1, b = 0.8, h = 0.1;

        for (double x = a; x <= b; x += h)
        {
            program.Task_3_2(x);
        }       
        
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
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for  (int i = 1; i <= 10; i++)
        {
            answer += (double) 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+=2)
        {
            answer += (double)i / (i + 1);
        }
        answer = Math.Round(answer, 2);
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
            double denominator = 1;
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / denominator;
                denominator *= x;
            }
            answer = Math.Round(answer, 2);
            

            return answer;
        }
        // end

    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for  (int i = 0; i < 10; i ++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int n = 1; n <= 6; n ++)
        {
            answer *= n;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1;
        for (int n = 1; n <= 6; n ++)
        {            
            answer += factorial;
            factorial += factorial * n;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double n1 = -1, n2 = 5, factorial = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer += n1 * n2 / factorial;
            n1 *= -1; 
            n2 *= 5; 
            factorial += factorial * i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int p = 1; p <= 7; p ++)
        {
            answer *= 3;
        }
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

        Console.WriteLine("\n");
        for (int simbol = 1; simbol <= 4; simbol++)
            Console.Write("_-_");
        Console.WriteLine("\n");

        for (int j = 1; j <= 6; j++)
        {
            Console.Write("5 ");
        }
        Console.ReadLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return 0;
        else
        {
            double n = 1;
            for (int i = 1; i <= 10 + 1; i++)
            {
                answer += 1 / n;
                n *= x;
            }
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
        else
        {
            if (-1 < x && x <= 1)
                answer = -x;
            else
                answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int f1 = 0, f2 = 1;
        for (int i = 1; i <= 8; i++)
        {
            int answer = f2;
            f2 += f1;
            f1 = answer;
            Console.WriteLine(answer);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double n = 1, z = 1, x = 0;
        for (int i = 1; i <= 5; i++)
        {
            answer = n / z;
            x = n;
            n += z;
            z = x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double power = 0;

        // code here
        double s = 1;

        for (int i = 1; i <= 64; i++)
        {
            s *= 2;
        }
        s /= 15;
        //s = Math.Pow(2, 64) / 15;

        power = Math.Log10(s);
        for (int i = 1; i <= power; i++)
        {
            s /= 10;
        }

        answer = Math.Round(s, 2);

        // end

        return (answer, (int) power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;

        answer = Math.Pow(((r + x) * (r + x) - r * r), 0.5);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
            answer *= 2;
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
        double l = 1;
        int p = 1;
        while (l * p < 30_000)
        {
            l *= p;
            p += 3;
        }
        answer = p - 3;
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
        double s = 0, p = 1;
        if (Math.Abs(x) >= 1)
            return 0;
        else
        {
            for (int i = 1; ; i++)
            {
                if (p < 0.0001)
                    break;
                else
                {
                    s += p;
                    p *= x * x;
                }
            }
            answer = Math.Round(s, 2);
        }
        
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
       int time = 0;

       for (int cnt = 10; cnt < 100_000; cnt *= 2)
        {
            time += 3;
        }
       answer = time;
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
        double balance = 10_000;
        int percent = 8,cnt_mounth = 0;
        while (balance < 10_000 * 2)
        {
            balance += balance * percent / 100;
            cnt_mounth += 1;
        }
        answer = cnt_mounth;
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
        double n = 1, z = 1, x = 0;
        double current = 0, previous = 0;
        int cnt = 0;

        do
        {
            previous = current;
            current = n / z;
            x = n;
            n += z;
            z = x;
            cnt++;
        }
        while (Math.Abs(current - previous) > 0.001);
        answer = cnt;

        //answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double s = 0, y = 0;

        // code here
        int ch = 1;

        for (int i = 0; ; i++)
        {
            ch *= -1;

        }
            
        // end

        return (s, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double s = 0, y = 0;

        // code here
        // фор для икса написал выше, где вызываются тесты
        double n_x = 0;
        double ch = x;

        for (int i = 1; ;i++)
        {
            n_x = ch * Math.Sin(i * Math.PI / 4);
            ch *= x;
            if (ch < 0.0001)
                break;
            else
                s += n_x;
        }  
        
        y = (x * Math.Sin(Math.PI / 4)) / (1 - (2 * x * Math.Cos(Math.PI / 4)) + (x * x));

        s = Math.Round(s, 2);
        y = Math.Round(y, 2);

        //Console.WriteLine($"s = {s}\ty = {y}");
        // end

        return (s, y);
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
