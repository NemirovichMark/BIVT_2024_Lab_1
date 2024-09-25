using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        // program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.5);
        //program.Task_1_4(0.9);
        //program.Task_1_4(0);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        // program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        // program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        // program.Task_1_15();
        // program.Task_1_16();
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
        int i = -1;
        while (i<35)
        {
            i += 3;
            answer += i;
        }

    
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_2()
    {

        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
            answer = Math.Round(answer, 2);
        }

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
        {
            answer += (double)i / (i + 1); 
        }

        answer = Math.Round(answer, 2);

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        if (x == 0) return 0;
        
        for (double i = 1, p = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / p;
            p *= x;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while (i<=9)
        {
            answer += (p + i * h) * (p + i * h);
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0.5 * x * x - 7 * x;
        y=Math.Round(y, 2); 
        Console.WriteLine("x={0:f2} \t y={1:f2}",x,y);
        answer = y;
        x -= 0.5;
                        
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
      
     
        for (int i = 2; i <= 6; i++)
        {
            answer*= i;
            
        }
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int p = 1;
        for (int i = 1; i <= 6; i++) 
        {
            p *= i;
            answer += p;
            
        }
       
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
       
        
        int n = 6;

        for (double i = 1,p=1, k = 1; i <= n; i++)
        {
            p *= 5 / i;
            k=-k;
            answer += k * p;


        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int n = 3;
       for (int i=1; i<=7; i++)
        {
            answer *= n;
        }
       Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i=1; i<=6; i++)
        { 
            Console.Write(i + " ");
        }
        Console.WriteLine();
        
        for (int i=1; i<=6;i++)
        {
            Console.Write("5 ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        // code here
        double chisl = 1;
        if (x == 0) return 0;
       
        for (int i=1; i<=10; i++)
        {
            chisl/= x;
            answer += chisl;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
       
        if (x <= -1.0) answer = 1.0;
        else if (x <= 1.0) answer = -x;
        else answer = -1.0;

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a1 = 1;
        int a2 = 1;
        Console.Write($"{a1}, {a2}");
        for (int i = 0; i <6; i++)
        {
            int next = a1 + a2;
            Console.Write($", {next}");
            a1 =a2;
            a2=next;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int ch1 = 1;
        int zn1 = 1;
        int ch2 = 2;
        int zn2 = 1;
        int ch; int zn;
        for (int i=3;i<=5; i++)
        {
            ch = ch1 + ch2;
            zn= zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch;
            zn2 = zn;
          
        }
        answer = (double)ch2 / zn2;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double y = 1;
        for (int i=0; i<64; i++)
        {
            y *= 2;

        }
        y /= 15;
        while (y>10)
        {
            y /= 10;
            power++;
        }

        answer = y;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        double h = (r + x) * (r + x) - r * r;
        h = Math.Sqrt(h);
        answer = Math.Round(h, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 3; i <= x; i += 3)
        {
            answer *= 2;
        }
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
        double s = 0, p = Math.Cos(x), n=1;
        const double eps = 0.0001;
        while (Math.Abs(p)>=eps)
        {
            p = Math.Cos(n * x) / (n * n);
            s += p;
            n++;
            
          
        }
        answer = s;
        answer=Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        double s = 0;
        int n = 0;
        while (s<=p)
        {
            s += (a + n * h);
            n++;
            if (h < 0) return 0;
        }
        n = n - 1;
        answer = n;
        Console.WriteLine(answer);
       
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
       if (M==0)
        {
            return (quotient, remainder);
        }
       while (Math.Abs(N)>=Math.Abs(M))
        {
            quotient++;
            N -= M;
        }
       remainder = Math.Abs(N);
       Console.WriteLine(remainder);

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
        for (double s=10, n=1; n<=7; n++)
        {
            answer += s;
            s *= 1.1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        for (double s=10, km=0; km<100; answer++)
        {
            km += s;
            s *= 1.1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        for (double s = 10; s <= 20; answer++) 
        {
            s *= 1.1;
            
        }
        Console.WriteLine(answer);
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
        double l = 0.1;
        while (l>Math.Pow(10,-10))
        {
            l /= 2;
            answer++;
        }
        Console.WriteLine(answer);
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
        double S = 1, y = 0;

        // code here
        
        double n = 1, i = 1, f = 1, st = 1, k = 1;
        const double eps = 0.0001;
        for (i=1; Math.Abs(n) >= eps; i++)
        {
            k = -k;
            st *= x * x;
            f =f*( 4 * i * i - 2 * i);
            n = (k * st )/ f;
            S += n;
        }
        y = Math.Cos(x);
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);



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