using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

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
        program.Task_3_4(0.1);
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
        for (int i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
      double s = 0;
        for (int i = 1; i < 11; i = i + 1)
            s = s + 1.0 / i;
        answer = Math.Round(s, 2); 
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
      double s = 0;
       for (int i = 2; i <= 112; i = i + 2)
            s = s + i / (i + 1.0);
        answer = Math.Round(s);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        if (x == 0) return 0;
        for (int i = 0; i <= 8; i = i + 1)
        {
            double t = 1;
            for (int j = 0; j < i; j++)
            {
                t *= x;
            }
            s = s + Math.Cos((i +1) * x) / t;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        s = s + Math.Pow(p, 2);
        for (int i = 1; i < 10; i = i + 1)
        {
            s = s + Math.Pow(p + i * h, 2);
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        s = 0.5 * (x * x) - 7 * x;
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int factr  = 1;
        for (int i = 1; i <= 1; i = i + 1 )
        {
            factr = factr * i;
        }
        for (int i = 2; i <= 2; i = i + 2 )
        {
            factr = factr * i;
        }
        for (int i = 3; i <= 3; i = i + 3)
        {
            factr = factr * i;
        }
        for (int i = 4; i <= 4; i = i + 4)
        {
            factr = factr * i;
        }
        for (int i = 5; i <= 5; i = i + 5)
        {
            factr = factr * i;
        }
        for (int i = 6; i <= 6; i = i + 6)
        {
            factr = factr * i;
        }
        answer = factr;
        Console.WriteLine( answer );

  
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        for (int i = 1; i <= 6; i = i + 1)
        {
            int factr = 1;
            for (int j = 1; j <= i; j = j + 1)
            {
                factr = factr * j;
            }
            s = s + factr;
         
        }
        answer = s;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        double factr = 1;
        double t = 1;
        for (int i = 1; i <= 6; i = i + 1)
        {
            factr = factr * i;
            int n;
            if (i % 2 == 0)
            {
                n = 1;
            }
            else
            {
                n = -1;
            }
            t *= 5;
            s = s + n * Math.Pow(5, i) / factr;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine (answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int j = 1;
        int n = 3;
        for (int i = 0;  i < 7; i = i + 1)
        {
            j = j * n;
        }
        answer = j;
        Console.WriteLine (answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("а:");
        for (int i = 1; i <= 6; i = i + 1)
        {
            Console.Write (i + " ");
        }
        Console.WriteLine();
        Console.Write("б:");
        for (int i = 1; i <= 6; i = i + 1)
        {
            Console.Write ("5 ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double y = 1;
        double s = 1;
        if (x == 0) return 0;
        for (int i = 1; i <= 10; i = i + 1)
        {
            y = y * x;
            s +=  1 / y; 
        }
        answer = Math.Round(s, 2);
        Console.WriteLine (answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }else if (x > -1 && x <= 1)
        {
            answer = -x;
        }else if (x > 1)
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int j = 1;
        int y = 1;
        Console.WriteLine(j);
        Console.WriteLine(y);
        for (int i = 2; i < 8; i = i + 1)
        {
            int n = j + y;
            Console.WriteLine(n);
            j = y;
            y = n;
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int a1 = 1;
        int a2 = 2;
        int b1 = 1;
        int b2 = 1;

        for (int i = 3; i <= 5; i = i + 1)
        {
            int ax = a1 + a2; 
            int bx = b1 + b2; 
            answer = (double)ax / bx; 
            
            a1 = a2;
            b1 = b2;
            a2 = ax;
            b2 = bx;
        }

        
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zer = 1;
       
        for (int i = 1; i <= 64; i = i + 1)
        {
            zer = zer * 2;
            answer = zer / 15;
        }
        
        power = 18;
        double t = 1;
        for (int i = 0; i < power; i++)
        {
            t *= 10;
        }

        answer = answer / t;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end
        
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        for (double y = 1; y <= x; y = y + 1)
        {
            answer = Math.Sqrt(y *( 2 * r + y));
            answer = Math.Round(answer, 2);
            Console.WriteLine("{0}", answer);
        }
        Console.WriteLine();
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        
        
        for (int i = 3; i <= x; i = i + 3)
        {
            
            a = a * 2;
            
        }
        answer = a;
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
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int l = 30000;
        int p = 1;
        int i;
        for (i = 1; p * i <= l; i = i + 3)
        {
            p = p * i;
        }
        answer = i - 3;
        Console.Write(answer);
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
    
        double s = 0;
        double y = 1;
        int k = 0;
        if (Math.Abs(x) < 1)
        {
            while (y >= 0.0001)
            {
                s = s + y;
                y *= x * x;
                k = k + 2;
            }
            answer = Math.Round(s, 2);
        }
        else
        {
            answer = 0;
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
        int a = 10; 
        int b = 3;
        int t = 0;
 
        while (a <= 100000)
        {
            a *= 2;
            t = t + b;            
        }
        answer = t;
        Console.WriteLine(answer);

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
        double s = 10000;
        double p = 0.08;
        double d = s * 2;
        int i;
        for ( i = 0; s < d; i = i + 1)
        {
            s += s * p;
        }
        answer = i;
        Console.WriteLine(answer);
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
        double a1 = 1;
        double a2 = 1;
        double x2 = 0;
        double x1 = 1;
        double s = 0;
        int count = 1;
        while (Math.Abs(x2 - x1) >= 0.001)
        {
            x1 = a1 / a2 ;
            s = a2;
            a2 = a1;
            a1 += s;

            x2 = a1 / a2;
            count++;
        }

        answer = count;

        Console.WriteLine(answer);
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
        double a = 1;  //скобки
        double b = 1;  //x в степени 
        double f = 1; //факториал
        double g = (a * b) / f;
        int i = 0; 
        while (g >= 0.0001)
        {
            S = S + g;
            a = a + 2;
            b = b * x * x;
            f = f * (i + 1);
            g = (a * b) / f;
            i = i + 1;
        }
        y = Math.Round((1 + 2 * x * x) * Math.Exp(x * x), 2);
        S = Math.Round(S, 2);

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