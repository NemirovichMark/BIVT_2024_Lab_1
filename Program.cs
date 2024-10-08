using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
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
        //code here

        int answer = 0;
        int sum = 0;
        for(int s = 2; s<=35; s+=3)
        {
         sum += s;
        }
        answer = sum;

        //end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double s = 0;

        // code here

        double ch =1 ;
        double zn = 1;
        s += ch / zn;
        while ( zn <= 10 )
        {
            zn += 1;
            s += ch / zn;
        }
        s = Math.Round (s , 2);
        s = answer;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        // code here

        for ( int i = 2, h = 3; h<=113; i+=2, h+=2)
        {
            answer += (double)i / (double)h;
        }
        answer = Math.Round(answer,2);
        Console.WriteLine( "{0:f2}",answer);

        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double s = 0;

        // code here

        int ch = 1;
        double zn = 1;
        if (x == 0)
        {
            return 0;
        }
        while(ch <= 9)
        {
            s+=Math.Cos(ch * x) / zn;
            ch++;
            zn *= x;
        }
        s = Math.Round(s , 2);

        // end

        return s;
    }
    public double Task_1_5(double p, double h)
    {
        double s = 0;

        // code here

        for (int n = 0; n <= 9; n++)
        s += (p + h + n) * ( p + h + n);

        // end

        return s;
    }
    public double Task_1_6(double x)
    {
        //code here

        double answer = 0;
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer,2);
        Console.WriteLine("{0:f2}", answer);

        //end
        return answer;
    }
    public int Task_1_7()
    {
        int s = 0;

        // code here

        int b = 1;
        for ( int n = 1; n <= 6; n++ ) 
        b *= n;

        // end

        return s;
    }
    public int Task_1_8()
    {
        int s = 0;

        // code here

        int r = 1;
        int n;
        for( n=1 ;n <= 6; n++)
        {
         r *= n;
         s += r;
        }

        // end

        return s;
    }
    public double Task_1_9()
    {
        double s = 0;

        // code here

        int r = 1; int k = 1; int f = 1;
        for (int t = 1; t <= 6; t++)
        {
            r *= t;
            k *= (-1);
            f *= 5;
            s += k * f / r;
        }
        s = Math.Round( s , 2 );

        // end

        return s;
    }
    public int Task_1_10()
    {
        int s = 0;

        // code here

        s = 1;
        for(int n = 1; n <= 7 ; n++)
        {
            s *= 3;
        }

        // end

        return s;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int n = 1; n <=6 ; n++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        for (int n = 0; n < 6; n++)
        {
            Console.Write(5 + " ");
        }


    }
    public double Task_1_12(double x)
    {
        double s = 0;

        // code here

        double z = 1;
        for(int n = 0; n <= 10 ; n++)
        {
            if (z == 0)
            {
                s = 0;
                break;
            }
            s = s + 1 / z;
            z *= x;
        }
        s = Math.Round(s , 2);
        
        // end

        return s;
    }
    public double Task_1_13(double x)
    {
        double s = 0;

        // code here

        if ( x <= -1)
        {
            s = 1;
        }
        else if ( x > 1 )
        {
            s = -1;
        }
        else
        {
            s = -x;
        }

        // end

        return s;
    }
    public void Task_1_14()
    {
        // There is no test for this task
         int f = 0;
       int a = 1;
       int b = 1;
       for(int i = 1; i <= 8; i++)
       {
       Console.WriteLine(a);
        f = a + b;
        a = b;
        b = f;
       }
        

    }
    public double Task_1_15()
     {
        double answer = 0;
        //code here

        int n = 5;
        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        double f=0;
        
        for(int i = 1; i <= n-2; i++)
        {
            f = (a1 + a2)/(b1 + b2);
            double a3 = a1 + a2;
            double b3 = b1 + b2;
            a1 = a2;
            b1 = b2;
            a2 = a3;
            b2 = b3;
            
        }
        answer = f;
        //end
        return answer;
    }
    public (double, int) Task_1_16()
     {
        double answer = 0;
        int power = 0;
        //code here
        double a = 1;
        
        for(int i = 1; i <= 64; i++)
        {
            a = a * 2;
        }
        a = a/15;
        while(a > 10)
        {
            a = a / 10;
            power +=1;
        }
        answer = Math.Round(a, 2);
        //end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double s = 0;
        // code here

        double R = 6350;
        s=Math.Sqrt(x * ( 2 * R + x ));
        s=Math.Round(s , 2);

        // end

        return s;
    }
    public int Task_1_18(int x)
     {
        int answer = 0;
        //code here

        int n = 10;
        
        for(int i = 1; i <= (x/3); i++)
        {
            n = n * 2;
        }
        answer = n;

        //end
    
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
        int s = 0;

        // code here
        double a = 1;
        int p = 1;
        while( a * p < 30_000)
        {
            a *= p;
            p += 3;
        }
        s = p - 3;
        // end

        return s;
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
        double s = 0;

        // code here
        double z = 0, a = 1;
        if (Math.Abs(x)>=1)
            return 0;
        else
        {
           for (int i = 1; ; i++)
           {
              if (a<0.0001)
                 break;
              else
              {
                z+=a;
                a*=x*x;
              }   
           }
           s=Math.Round(s,2);
        }
        // end

        return s;
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
        int s = 0;

        // code here
        int clock = 0;
        for (int cnt = 10; cnt < 100_000; cnt *= 2)
        {
            clock += 3;

        }
        s = clock;
        // end

        return s;
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
        int s = 0;

        // code here;
        double cash = 10_000;
        int percent = 8, cnt_month = 0;
        while (cash < 10_000 * 2)
        {
            cash+=cash*percent/100;
            cnt_month+=1;
        }
        s=cnt_month;
        // end

        return s;
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
        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        double f = 0;
        int n = 2;

        while(true)
        {
            f = (a1 + a2)/(b1 + b2);
            double a3 = a1 + a2;
            double b3 = b1 + b2;
            a1 = a2;
            b1 = b2;
            n +=1;
            if(f - a2/b2 <= 0.001 & f - a2/b2 >0)
            {
                answer = n;
                break;
            }
            a2 = a3;
            b2 = b3;
        }
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
        double S = 1, y = 0;

        // code here
       double ch = 1;
       double zn= 1;
       double dit= 1;
       for ( int i = 1; Math.Abs(dit)>=0.0001; i++)
       {
        ch *= x*2;
        zn *= i;
        dit = ch/ zn;
        S += dit;
       }
       Math.Pow(Math.E, 2*x);
       System.Console.WriteLine( $" {S,10} {y,10} ");

        return (S, y);
    }
        // end
    
     public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}
