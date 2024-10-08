using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

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
        int answer = 0;

        // code here
        for(int i = 2; i<=35; i+=3)
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
        for(double i = 1; i<=10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i+=2)
        {

            answer += i/ (i+1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double del = 1;
        if (x == 0) return answer;
        else for(int i = 1; i<=9; i++)
        {
               
                
               answer += Math.Cos(x*i)/del;
                del *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int i = 0; i<10; i++)
        {
            answer += (p + (i * h)) * (p + (i * h));
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        // end

        return Math.Round(0.5*x*x-7*x,2);
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i<=6; i++)
        {
            answer *=i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int del = 1;
        for (int i = 1; i <= 6; i++)
        {
            int k = 1;
            
            del *= i;
            answer += del;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
      int del = -1;
        double del1 = 1.0;
        int del2 = 1;

        for (int i = 1; i<=6; i++)
        {
            del1 *= 5;
            del2 *= i;
            answer += del * del1 / del2;
            del *= -1;
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for( int i = 1; i<=7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string answer = "";
        for (int i = 1; i < 7; i++)
        {
            answer += $"{i}";
          
            if (i < 6)
            {
                answer += " ";
            }
        }

        answer = "";
        for (int i = 1;i<7; i++)
        {
            answer += "5";
            if (i <6)
            {
                answer += " ";
            }
        }
        // code here
        Console.WriteLine(answer);
    }
    
    public double Task_1_12(double x)
    {
        double answer = 0;
        double del = 1;
        if (x == 0)
        {
            answer = 0;
        }
        // code here
                            
        else for (double i = 0; i <= 10; i++)
        {
                answer += 1 / del;
                del *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer= -x;
        else answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 0;
        int a1 = 1;
        for (int i=1; i <= 8; i++)
        {
            Console.Write(a1);
            int count = a + a1;
            a = a1; 
            a1 = count;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double a1 = 2;
        for (int i = 1; i <=3; i++)
        {
            double count = a + a1;
            a = a1;
            a1 = count;
        }
        double b = 1;
        double b1 = 1;
        for (int   i = 1; i <= 3; i++)
        {
            double count = b + b1;
            b = b1;
            b1 = count;
        }
        answer = a1/b1;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int del = 1;
        for (int i = 0; i < 64; i++)
        {
           
            
            answer +=del ;
            delegate *= 2;
        }
        answer /= 15;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }

        // end
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        double ans = (r + x) * (r + x) - (r * r);
        answer = Math.Sqrt(ans);

        // end
        answer = Math.Round(answer,2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
        {
            answer = answer * 2;
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
        
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int p = 1;
        int n = 1;
        int L = 30000;
        while (p * n <= L)
        {
            p *= n;
            answer = n;
            n += 3;
        }
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
        if (x == 1) return 0;
        double i = x * x;
        double s = 1;
        while (i >= 0.0001)
        {
            s += i;
            i *= x * x;
        }
        // end
        answer = Math.Round(s, 2);
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
        for (int i = 10; i <= 100000; i *= 2)
        {
            answer += 3;
        }
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
        int c = 0;
        double s = 30000;
        while ( s < 60000)
        {
            s = s * 1.08;
            c++;
        }
        answer = c;
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
        double a = 1;
        double b = 1;
        double c = 0;
        double l = 0;
        for (int i = 2; Math.Abs((a / b) - l) >= 0.001;i++)
        {
            l = a / b;
            c = a;
            a += b;
            b = c;
            answer = i;
        }

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
        double n = 1, i = 1, x1 = 1, fact = 1;
        S = 1;
        while (Math.Abs(n) >= 0.0001)
        {
            x1 *= x * 2;
            fact *= i;
            n = x1 / fact;
            if (Math.Abs(n) >= 0.0001)
            {
                S += n;
                i++;
            }

        }
        y = Math.Pow(Math.E, 2 * x);
        Console.WriteLine(S);
        Console.WriteLine(y);
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