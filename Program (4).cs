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
        //Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
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

        // code here
        
        for (int i = 2; i < 36; i += 3)
        {
            answer += i;
        }
        //Console.WriteLine(answer);
        // end
       

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i += 1)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i += 2)
        {
            answer += (i) / (i + 1);
        }
        answer = Math.Round(answer);
        // end


        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double stepen = 1;
        for (int i = 1; i <= 9; i++)
        {
            
            answer += (Math.Cos(i * x)) / stepen;
            stepen = stepen * x;
        }
        if (x == 0)
        {
            return 0;
        }
        
        answer = Math.Round(answer,2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        answer += p * p;
        for (int i = 1; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        //Console.WriteLine(answer);
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
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i <= 6; i++) 
        {
            s = s * i;
        }
        answer = s;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1, fact = 1; i <= 6; i++)
        {
            fact = fact * i;
       
            answer += fact;
            

        }
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double znak = 1, s = 1;
        for (double i = 1; i<=6; i++)
        {
            znak = -znak;
            s *= 5 / i;
            answer += znak * s;
        }
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i<=7; i++)
        {
            s *= 3;
        }
        answer = s;
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string a = "", b = "";
        for (int i = 1; i<=6; i++)
        {
            a += i.ToString() + " ";
            b += "5 ";
        
        }
        Console.WriteLine($"а) {a},\nб) {b}.");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return answer;
        for (double i = 0, s = 1; i<=10; i++)
        {
            answer += 1 / s;
            s = s * x;

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        if (-1 < x && x <= 1) answer = -x;
        if (x > 1) answer = -1; 
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0;
        int b = 1;
        int s = 0;
        for (int i = 1; i<=8; i++)
        {
            Console.WriteLine(b);
            s = a + b;
            a = b;
            b = s;
            
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double b = 1;
        double s = 1;
        for (int i = 1; i <= 5; i++)
        {

            //Console.WriteLine(a/b);
            s = a;
            a += b;
            b = s;
        }
        answer = a / b;
        answer = Math.Round(answer,1);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1;
        for (int i = 0; i<=63; i++)
        {
            s *= 2;
            //Console.WriteLine(s);
        }
        answer = s / 15;
        power = (int)Math.Log10(answer);
        answer = Math.Round(answer / Math.Pow(10, power), 2);
        //Console.WriteLine(answer);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int s = 10;
        for (int i = 1; i <= x/3; i++)
        {
            s = s * 2;
            //Console.WriteLine(s);
        }
        answer = s;
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = Math.Cos(x);
        for (double i = 1;Math.Abs(s) >= 0.0001;)
        {

            
            answer += s;
            i++;
            s = Math.Cos(i * x) / (i * i);

        }
        
       
        //Console.WriteLine(answer);
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
        
        for ( double n = 0, s=0; s<=p; n++)
        {
            s += a + n * h;
            if (a < Math.Abs(h) && h < 0)
            {
                break;
            }
            answer =(int) n;

        }
        
        Console.WriteLine(a);
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
        if (M == 0) return (quotient, remainder);
        for (remainder = N; remainder >= M;)
        {
            quotient++;
            remainder -= M;
        }
        remainder = Math.Abs(remainder);
        //nsole.WriteLine( remainder);
        
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
        for (int i = 1; i<8; i++)
        {
            answer += s;
            s += s / 10;

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 10;
        for (double i = 0; i < 100;)
        {
            i += s;
            answer++;
            s += s / 10;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 10;
        for (int i = 0; s<= 20; i++)
        {
            s += s / 10;
            answer++;
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

        // code here;
        double L = 0.1;
        for (int i = 0; L > 1E-10; i++)
        {
            L = L / 2;
            answer++;
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
        double S = 0, y = 0;

        // code here
        
        // end
        S = 1;
        for (double i = 1, f = 1, n = 1; Math.Abs(n) >= 0.0001; i++)
        {
            f *= i;
            n = Math.Cos(i * x) / f;
            S += n;
        }
        y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
      
       

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