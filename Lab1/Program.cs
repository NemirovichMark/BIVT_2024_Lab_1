using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        program.Task_3_5(double.Pi/5);
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
        for (int i =2; i<=35; i +=3)
        {
            answer += i;
        }
    
        
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0/i;
        }
        answer = Math.Round(answer, 2);
        // end

        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+=2)
        {
            answer += i/(i+1.0);
        }
        answer = Math.Round(answer, 2);
        // end

        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double c=1;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 1; i <=9; i++)
        {
            answer+= Math.Cos(i*x)/c;
            c *=x;
        }
        answer= Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9 ; i++ )
        {
            answer+= (p+i*h)*(p+i*h);
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0.5*(x*x) - 7*x;
        answer = y;
        answer = Math.Round(answer, 2);
        // end
    
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer*= i;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int v = 1;
        for (int i = 1; i <= 6; i++)
        {
            v *= i;
            answer += v;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int u =-1;
        double t = 5;
        int o = 1;
        for ( int i = 1; i<= 6; i ++)
        {
            o *= i;
            answer += u*t/o;
            u *= -1;
            t*=5;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i =1; i <=6; i++)
        {
            answer*= 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for ( int i= 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for ( int i= 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
         Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double r = 1;
        if (x == 0)
        {
            return 0;
        } 

        for ( int i = 0; i<=10; i++)
        {
            
            answer+= 1/r;
            r *= x;
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
        if (x <= -1)
        {
            answer =1;
        }
        if (-1 <x && x <= 1)
        {
            answer =-x;
        } 
        if (x>1)
        {
            answer =-1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int k = 1;
        int l = 1;
        int h = 1;
        Console.Write(l+" ");
        Console.Write(k+" ");
        for ( int i = 1; i<= 6; i ++)
        {
            h = l;
            l = k+l;
            k = h;
            Console.Write(l+" ");

        }
        // code here
       

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double h = 1;
        double l = 1;
        double h2 = 2;
        double l2 =1;
        double pop1 = 0;
        double pop2 = 0;
        for (double i =1; i <= 3; i++)
        {
            pop1 =h2;
            pop2 = l2;
            h2 = h2+ h;
            l2 = l2+l;
            h = pop1;
            l = pop2;
            answer= (h2)/(l2);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        double kiki= 0;
        for( int i = 1; i <= 63; i++)
        {
            answer *=2;
            kiki += answer;
        }
        answer = kiki;
        answer = answer/15;
        for (  ; answer>10;answer=answer/10)
        {
            power += 1;
            
        }

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
        int R = 6350;
        answer =Math.Sqrt((R+x)*(R+ x) - R*R);
        answer=Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int count = 10;
        for ( int i = 3; i <= x; i+=3 )
        {
            count*=2;
        }
        answer = count;
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
        for (int i = 1; ; i++)
        {
            double var = Math.Cos(i*x)/(i*i);
            if (Math.Abs(var)<0.0001)
            {
                break;
            }
            answer+= var;
        }

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

        // code here
        double count = 0;

        for ( int i = 0; ; i++)
        {
            if (h<0)
            {
                return 0;
            }
            
            count += a+i*h;
            if (count > p)
            {
                break;
            }
            
            answer++;
        }
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
            if (M == 0)
            {
                quotient = 0;
                remainder = 0;
                return(quotient, remainder);
            }
            remainder = N;
            while(remainder>=M)
        {
            remainder = remainder-M;
            quotient++;
        }
            Console.WriteLine(quotient);
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
        double d1 = 10;
        for( int i = 1; i <= 7; i++)
        {
            answer+= d1;
            d1 = d1*1.1;
            
        }
        answer=Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        Double path = 0;
        double d1 = 10;
        while(path < 100)
        {
            path+= d1;
            d1 = d1*1.1;
            answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        int cd = 0;
        double d1 = 10;
        for( int i = 0; ; i++)
        {
            d1 = d1* 1.1;
            cd++;
            if (d1> 20)
            {
                break;
            }
        }
        answer = cd;
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
        double l =0.1;
        for ( int i =0; l > 0.0000000001; i++)
        {
            l = l /2;
            answer+=1;
        }
        // end
        Console.WriteLine(answer);
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
        y = (x*x-(Math.PI*Math.PI)/3)/4;
        int e = -1;
        for ( int i = 1; ; i++)
        {
            double p = e*(Math.Cos(i*x)/(i*i));
            
            if (Math.Abs(p)< 0.0001)
            {
                break;
                
            }
            S+= p;
            e*=-1;
            
        }
        // end
        Console.WriteLine(S);
        Console.WriteLine(y);

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