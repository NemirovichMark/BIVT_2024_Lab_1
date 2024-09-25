using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
        program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(1.35);
        //program.Task_1_13(-1.5);
        //Console.WriteLine (program.Task_1_14_rec(10));
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(3);
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

        for (int i = 2; i <= 35; i += 3)
        {
            answer = answer + i;

        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1.0;
        for (double i = 2; i <= 10; i += 1)
        {
            answer = answer + 1.0 / i;

        }
        // code here
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (double i = 2; i <= 112; i += 2)
        {
            answer = answer + i / (i + 1);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);


        // code here
        return answer;
        // end

    }
    public double Task_1_4(double x)
    {

        double answer = 0;
        if (x == 0) return 0;
        for (double i = 1, l = 1; i <= 9; i += 1, l = l * x)
        {
            answer = answer + Math.Cos(i * x) / l;
        }

        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (double i = 0, l; i <= 9; i += 1)
        {
            l = p + i * h;
            answer = answer + l * l;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        for (double i = -4; i <= 4; i += 0.5)
        {
            answer = 0.5 * x * x - 7 * x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
    return answer;
        // code here

        // end
    }
    public int Task_1_7()
    {
        int answer = 6;
        int i = 6;
        while (i > 1)
        {
            answer = answer * (i - 1);
            i = i - 1;
        }
        // code here

        Console.WriteLine(answer);


        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        for (int i = 1, l = 1; i <= 6; i += 1, l = l * i)
        {
            answer = answer + l;
        }

        // code here;

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        for (double i = 1, l = 5, h = -1, f = 1; i <= 6; i += 1)
        {
            answer = answer + l * h / f;
            l = l * 5;
            h = h * (-1);
            f = f * (i + 1);

        }
        // code here;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;
        int i = 1, x = 3;
        while (i < 7)
        {
            answer = answer * x;
            i += 1;
        }

        // code here

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public void Task_1_11()
    {

        Console.WriteLine("1, 2, 3, 4, 5, 6");
        Console.WriteLine("5, 5, 5, 5, 5, 5");



    }
    public double Task_1_12(double x)
    {
        double answer = 1.0;
        if (x == 0) return 0;
        for (double i = 1, n = x; i <= 10; i += 1, n = n * x)
        {
            answer = answer + 1.0 / n;
        }

        // code here
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
            if (x <= -1.0)
            {
                answer = 1.0;
            }
            if (x > -1.0 && x <= 1.0)
            {
                answer = -x;
            }
            if (x > 1)
            {
                answer = -1.0;
            }
        Console.Write(answer);
        // code here
        
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int i = 0, k = 0, t = 1;
        for (int n = 0; n < 10; n += 1)
        {

            k = i + t;
            i = t;
            Console.WriteLine(i);
            t = k;
        }
        return;
        // code here

    }

        public double Task_1_15()
    {
        double answer = 1, i = 0, q = 0, c = 2, k = 1 ;
        while (i < 4)
        {
            q = q + 1;
            answer = c / k;
            k = c;
            c = c + q;
            i += 1;
        }
        // code here
        
        Console.WriteLine (answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1, n = 1;
        int power = 0;

        for (double i = 1; i <= 64; i+=1)
        {
            answer = answer + n;
            n = n * 2;
            Console.WriteLine (n);
           
        }
        answer = answer / 15;
        while(answer >= 9)
        {
            answer = answer / 10;
            power += 1;
        }

        // code here
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        answer = Math.Sqrt(x*(x+2*R));
        // code here
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10, i = 3;
      
    while (i <= x)
    {
        answer = answer * 2;
            i += 3;
    }
            
       
        // code here
    Console.WriteLine (answer);
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
        int answer = -2, p = 1;

        // code here
        while (p <= 30000)
        {
            answer += 3;
            p = p * answer;
            
        }
        answer = answer - 3;
        Console.Write (answer);
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
        double answer = 1.0, n = 1;
        if (Math.Abs(x)>= 1)
        {
            return  0;
        }
        while (Math.Abs(n) >= 0.0001)
        {
            n = x * n * x;
            answer = answer + n;
        }
        answer = Math.Round(answer, 2);
        Console.Write(answer);
        // code here

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
        int answer = 0, i = 10;
        while (i <= 100000)
        {
            i = i * 2;
            answer += 3;
        }
        // code here
         Console.Write(answer);
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
        int answer = 0, s = 10000;
         while (s <= 20000)
        {
            s = s + (s / 100) * 8;
            answer += 1; 
        }
        // code here;
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
        int answer = 2;
        double a =1, b=1, c=2, d=1, x=c/d, y=0;
        while (Math.Abs(x - y) > 0.001)
        {
            y = x;
            double z = (a + c);
            double p = (b + d);
            x = z / p;
            a = c;
            b = d;
            c = z;
            d = p;
            answer += 1;
        }

        // code here;
        Console.WriteLine (answer);
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
        double S = 0, k = x;
        double y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        int i = 1;
        double n = k * Math.Sin((i * Math.PI) / 4);
        double l = k;
        // code here
        while (Math.Abs(l) >= 0.0001)
        {
            S = S + n;
            i += 1;
            k = k * x;
            n = k * Math.Sin((i * Math.PI) / 4);
            
            l = k;

        }
        // end

        return (Math.Round(S, 2), Math.Round(y, 2));
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