using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        program.Task_1_14();
        //program.Task_1_15();
        program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
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
        int answer = 0;

        // code here    
        
        for (int x = 2 ;x <= 35; x += 3)
        {
            answer += x;
        }
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for(double x = 1; x <= 10; x++)
        
        {
            answer += 1/x;
        }
        answer = Math.Round(answer, 2);

        // end
        
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        
        for(double x = 2; x <= 112; x += 2)
        {
            answer += x/(x+1);
        }
        answer = Math.Round(answer, 2);
        
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0, xpow = 1;

        // code here
        
        double n = 0;
        if (x == 0)
        {
            return answer;
        }
        do
        {
            n++;
            answer += Math.Cos(n*x)/xpow;
            xpow *= x;
        } while(n < 9);
        answer = Math.Round(answer, 2);        
        
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
          
        for(int n = 0; n <= 9; n++)
        {
            answer += (p + n*h)*(p + n*h); 
        }
        answer = Math.Round(answer, 2);
        
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        
        // code here
        
        answer = Math.Round(0.5*x*x - 7*x, 2);
        
        // end
        
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        
        // code here
        
        for(int x = 1; x <= 6; x++)
            answer *= x;
        
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        
        for(int x = 1; x <= 6; x++)
        {   
            int f = 1;
            for(int xn = 1; xn <= x; xn++)
            {
                f *= xn;
            }
            answer += f;
        }
        
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, ch = 1;
        
        // code here;
        
        for(int x = 1; x <= 6; x++)
        {   
            double zn = 1;
            for(int xn = 1; xn <= x; xn++)
            {
                zn *= xn;
            }
            ch *= -5;
            answer += ch/zn;
        }
        answer = Math.Round(answer, 2);

        // end
        
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for(int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        Console.WriteLine("Task11");
        Console.WriteLine("a.");
        for(int x = 1; x <= 6; x++)
        {
            Console.Write($"{x, 5}");
        }
        Console.WriteLine();
        Console.WriteLine("b.");
        for(int i = 1; i <= 6; i++)
        {
            Console.Write($"{5, 5}");
        }
        
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0, xpow = 1;
 
        // code here
        
        if (x == 0)
        {
            return answer;
        }
        for(int i = 0; i <= 10; i++)
        {
            answer += 1/xpow;
            xpow *= x;
        }
        answer = Math.Round(answer, 2);
    
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

    {
        if (x <= -1)
        {
            answer = 1;
        }
        if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        answer = Math.Round(answer, 2);
    }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        
        int x1 = 1, x2 = 1;
        Console.WriteLine();
        Console.WriteLine("Task14");
        for(int i = 1; i <= 5; i++)
        {
            if (i <= 2)
            {
                Console.Write($"{1, 5}");
            }
                if (i > 2) 
                {
                    x1 += x2;
                    x2 += x1;
                    Console.Write($"{x1, 5} {x2, 5}");
                }
        }
       
        // code here

    }
    public double Task_1_15()
    {
        double answer = 1, ch = 1, zn = 1, zn2 = 0;
        
        // code here
        
        for(int n = 2; n <= 5; n++)
        {            
            zn2 = ch;
            ch += zn;
            zn = zn2;   
            answer = Math.Round(ch/zn, 2);  
        }
        
        // end

        return answer;

    }
    public (double, int) Task_1_16()
    {
        double answer = 0, seeds = 1;
        int power = 0;

        // code here

        answer += seeds;
        for(double moves = 2; moves <= 64; moves ++)
        {
            seeds *= 2;
            answer += seeds;
        }
        answer /= 15;
        double a = answer;
        do
        {
            power++;
            answer /= 10;            
        }while(answer >= 1);
        answer = Math.Round(10*answer, 2);
        power -= 1;

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        
        double r = 6350;
        answer = Math.Sqrt(x*(2*r + x));
        answer = Math.Round(answer, 2);
        
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        
        for(int hours = 3; hours <= x; hours += 3)
        {
            answer *= 2;
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
        
        double n = 0, y = 1;
        while(Math.Abs(y) >= 0.0001)
        {
            n++;
            y = Math.Cos(n*x)/(n*n);
            if (Math.Abs(y) < 0.0001) 
            {
                break;
            }
            answer += y;
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
        int answer = 1;

        // code here

        double s = a;        
        if ((a + h) < 0 && p >= 0)
            return 0;
        for(; s <= p; answer++)
        {
            s += a + (answer)*h;
        }

        // end

        return answer - 1;
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
            return (quotient, remainder);
        }
        while (N >= M)
        {
            N -= M;            
            quotient++;
        }
        remainder = N;
        
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
        double answer = 10, pow = 1;

        // code here
        for(int day = 2; day <= 7; day++)
        {
            pow *= 1.1;
            answer += 10*pow;
        }
        // end
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;
        double  s = 10, pow = 1;
        // code here
        Console.WriteLine();
        do
        {
            pow *= 1.1;
            s += 10*pow;
            answer++;
        }while(s <= 100);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        for(double s = 10; s <= 20; s += 0.1*s)
        {
            answer += 1;
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

        double D = 0.0000000001, L = 0.1;
        for(; L > D; answer++)
        {
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
        double S = 0, z = x, i = 0, y = 0;

        // code here
        
        System.Console.WriteLine("Task3.9");
        while(Math.Abs(z) >= 0.0001)
        {
            S += z;
            i++;
            z *= (-1*(x*x)/(2*i + 1))*(2*i - 1);
            //z = Math.Pow(-1, i) * Math.Pow(x, 2*i + 1)/(2*i + 1);
            y = Math.Atan(x);
        }
        System.Console.WriteLine($"{S, 10} {y, 10}");
        
        // end

        return (S, y);
    }
    #endregion
}