using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.IO.Pipes;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for(int s = 2; s <= 35; s += 3)
        {
            answer+=s;
        }
        System.Console.WriteLine("1)"+answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double ch = 1; 
        for(double zn = 1; zn<= 10; zn++)
        {
            answer += ch/zn;
        }
        answer = Math.Round(answer,2);
        System.Console.WriteLine("2)"+answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(double ch = 2; ch <= 112; ch += 2)
        {
            answer+=ch/(ch+1);
        }
        answer = Math.Round(answer,1);
        System.Console.WriteLine("3)"+answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if(x == 0) return 0;
        {
            double step = 1;
            for( int i = 0; i <= 9; i++)
            {
                answer+=Math.Cos(i*x)/step;
                step*=x;
            }
        }
        
        answer = Math.Round(answer,2);
        System.Console.WriteLine("4)"+answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int k = 0; k <= 9; k++)
        {
            double a = (p+k*h)*(p+k*h);
            answer+=a;
        }
        System.Console.WriteLine("5)"+answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5*x*x-7*x;
        answer=Math.Round(answer,2);
        // end
        System.Console.WriteLine("6)"+answer);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int fct = 1;
        for (int i = 2; i <= 6; i++) fct *= i;
        answer = fct;
        // end
        System.Console.WriteLine("7)"+answer);

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fct;

        for(int i = 1; i <= 6; i++)
        {
            fct = 1;
            for(int a = 2; a <= i; a++) fct *= a;
            answer += fct;
        }
        System.Console.WriteLine("8)"+answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        double fact;
        for (double i = 1; i <= 6; i++)
        {
            fact = 1;
            for (double j = 2; j <= i; j++) fact *= j;
            
            double a = (i % 2 == 0) ? 1 : -1;
            double b = 1;
            for (int k = 0; k < i; k++) b *= 5; 

            answer += a * b / fact;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine("9)"+ answer);
        // end

        return answer;

       
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for(int step = 2; step <= 7; step++)
        answer *= 3;
        System.Console.WriteLine("10)"+answer);


        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i <= 6; i++) 

        System.Console.WriteLine($"{i} ");
        System.Console.WriteLine('\n');
        for (int i = 1; i <= 6; i++) 

        System.Console.WriteLine("5 ");
        System.Console.WriteLine('\n');
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double step = 1;
            for(int i = 0; i <= 10; i++)
            {
                answer += 1 / step;
                step *= x;
            }
            answer = Math.Round(answer, 2);
            System.Console.WriteLine("12)"+answer);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double h = -1.5; h <= 1.5;h += 0.1 )
        {
            if(h<=-1)
            {
                System.Console.WriteLine("13)"+1);
            }
            if(h>1)
            {
                System.Console.WriteLine("13)"+-1);
            }
            if(h>-1 && h<1)
            {
                System.Console.WriteLine("13)"+Math.Round((-1*h),2));
            }
        }
        if(x<=-1)
        {
            answer=1;
        }
        if (x>1)
        {
            answer=-1;
        }
        if(x>-1&&x<=1)
        {
            answer=-1.0*x;
        }
        System.Console.WriteLine("13)"+answer);

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        System.Console.WriteLine("14)"+a+" "+b+" ");
        for(int i = 2; i<8 ;i++)
        {
            int sled = a+b;
            System.Console.WriteLine("14)"+sled+" ");
            a=b;
            b=sled;
            
        }
        
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int chis2 = 2;
        int zn2 = 1;
        int chis3 = 3;
        int zn3 = 2;

        int chis5 = chis2+chis3;
        int zn5 = zn2+zn3;
        answer = (float) chis5/zn5;
        answer = Math.Truncate(10*answer)/10;
        System.Console.WriteLine("15)"+answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
       for(int kl = 0; kl < 64; kl++)
       {
        answer += 1;
        answer *= 2;
       }
       answer /= 15;
       while(answer >= 10)
       {
        answer /=10;
        power++;
       }
       answer = Math.Round(answer,4);
       System.Console.WriteLine("16)"+$"{answer} {power}");
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350.0;
        answer = Math.Round(Math.Sqrt(x*(2*r+x)),2);
        System.Console.WriteLine("14)"+answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for ( int am = 3; am <= x; am += 3)
        answer *= 2;
        
        System.Console.WriteLine("18)"+answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double eps = 0.0001, i = 1, next = Math.Cos(x);
        while(Math.Abs(next)>=eps)
        {
            answer += next;
            i += 1;
            double a = i * i;
            next = Math.Cos(i*x)/a;
        }
        System.Console.WriteLine("2,1)"+answer);
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
        double s = 0, summ;
        int n = 0;
        do
        {
            summ = a + n * h;
            if (summ <= 0 && a<=0) return 0;
            s += summ;
            n++;
        } while (s<=p);
        answer = n - 1;
        System.Console.WriteLine("2,3)"+answer);
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
        if(M != 0 )
        {
            N = Math.Abs(N);
            M = Math.Abs(M);
            while ((N-M)>=0)
            {
                N-=M;
                quotient++;
            }
            remainder=N;
        }
        System.Console.WriteLine("2,5)"+$"{quotient} {remainder}");
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
        double sh = 10.0;
        for(int i = 1; i <= 7; i++)
        {
            answer+=sh;
            sh*=1.1;
        }
        answer=Math.Round(answer,2);
        System.Console.WriteLine("2,7a)"+answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, sh = 10.0;
        while(s<100.0)
        {
            s+=sh;
            sh*=1.1;
            answer+=1;
        }
        System.Console.WriteLine("2,7b)"+answer);

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double sh = 10.0;
        while(sh<=20.0)
        {
            sh*=1.1;
            answer+=1;
        }
        System.Console.WriteLine("2,7c)"+answer);
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
        double L = 0.1, D = Math.Pow(10, -10);
        while(L > D)
        {
            L /= 2;
            answer += 1;
        }
        System.Console.WriteLine("2,9)"+answer);
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
    public(double, double) Task_3_1(double x)
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
        double fct = 4; 
        double i = 1;
        double frs = 1;
        double mins = -1;
        double temp = x*x;
        
        while (Math.Abs(frs)>0.0001)
        {
            mins = -mins;
            frs = (mins*x*temp)/(fct-1);
            temp *= x*x;
            i += 1;
            fct = 4 * i * i;
            S += frs;
        }
        y = (((1 + x * x)* Math.Atan(x))/2)-(x/2);
        System.Console.WriteLine($"s={S},y={y}");

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
