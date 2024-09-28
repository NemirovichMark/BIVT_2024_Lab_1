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
        int answer = 0;  int s = 2;

        // code here
        while (s <= 35)
        {
            answer = answer + s;
            s = s + 3; 
        }
        Console.WriteLine("answer= {0}", answer);
        // end

        return answer;
    }
    public double Task_1_2()
    { 
        double answer = 0;
        // code here
        for (int a = 0; a <= 9;a++)
            answer =answer + 1 / (a + 1.0);
        answer = Math.Round(answer, 2);
        Console.WriteLine("answer= {0}", answer);
        // end
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        // code here
        for (int a = 0; a <= 112; a=a+2)
            answer = answer + a / (a+1.0);
        answer = Math.Round(answer, 0);
        Console.WriteLine("answer= {0}", answer);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0, h;
        // code here
        if (x == 0) return 0;
        double k = x;
        answer = answer + Math.Cos(x);
        for (h = 2; h <= 9; h++)
        {
            answer += (Math.Cos(h * x) / k);
            k *= x;
            Console.WriteLine("answer= {0}", answer);
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0; int n; 
        // code here
        for ( n = 0 ; n <= 9; n++)
        {
            answer += (p + h * n) * (p + h * n);
            Console.WriteLine("answer= {0}", answer);
        }
        // end
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        // code here
        answer = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine("answer= {0}", answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1 ;
        // code here
        for ( int i = 1; i <= 6; i++)
            answer = answer * i;
        Console.WriteLine("answer= {0}", answer);
        // end
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0, x = 1;
        // code here
        for ( int k = 1; k <= 6; k++)
        {
            x = x * k;
            answer = answer + x;
        }
        Console.WriteLine("answer= {0}", answer);
        // end
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0; double p = 5;
        double fac = 1; 
        int minus = -1;
        // code here;
        for (int step = 1; step<=6; step++)
        {
            fac = fac * step;
            answer = answer + (minus * p) / fac;
            p = p * 5;
            minus = -minus; 
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3; int h = 3 ;
        // code here
        for (int k = 1; k<=6; k++)
            answer = answer * h;
        Console.WriteLine("answer= {0}", answer);
        // end
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int p = 1; p <= 6; p++)
            Console.WriteLine(p);
        for (int k = 0; k <= 5; k++)
            Console.WriteLine(5);
        
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double fak = x;
        if (x == 0)
            return 0;
        // code here
        for (int c = 0; c <= 9; c++)
        {
            answer = answer + (1 / fak);
            fak = fak * x;
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
        if (x <= -1)
            return 1;
        if (x > 1)
            return -1;
        if (x <= 1 && x > -1)
            return -x;

        // end
        return answer;
    }
    public void Task_1_14()
    {
        int k = 1; int b = 0;
        int answ = 1;
        // There is no test for this task
        // code here
        for (int c = 0; c < 8; c++)
        {
            k = answ;
            Console.WriteLine(answ);
            answ = k + b;
            b = k;
        }
        //end
    }
    public double Task_1_15()
    {
        double answer = 0, chis1 = 1, chis2 = 2, zn1 = 1, zn2 = 1, k1 = 0,k2 = 0;
        // code here
        for (int c = 0; c <= 3; c++)
        {
            k1 = chis2;
            chis2 += chis1;
            chis1 = k1;
            k2 = zn2;
            zn2 += zn1;
            zn1 = k2;
        }
        // end
        answer = k1/k2;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0; double a = 2;
        // code here
        for ( int  shag = 0; shag <= 62; shag++)
        {
            answer = answer + a / 15;
            a = a * 2;
        }
        // end
        power = (int)Math.Log10(answer);
        answer /=  Math.Pow(10, 18);
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0; int R = 6350;
        // code here
        answer = Math.Sqrt(((R + x)*(R + x))- (R*R));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int colvo = 10;
        // code here
        while (x>0)
        {
            colvo = colvo * 2;
            x = x - 3;
            Console.WriteLine(colvo);
        }
        // end
        return colvo;
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
        int answer = 0; int p = 1;int k = 1;
        // code here
        while (k < 30000)
        {
            answer = p;
            p = p + 3;
            k = k * p;
            Console.WriteLine(answer);
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
        double answer = 0; double k = 1;
        if (Math.Abs(x) >= 1) return answer = 0;
        // code here
        while (k >0.0001)
        {
            answer += k;
            k *= x * x;
        }
        answer = Math.Round(answer, 2);
        
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
        int k = 10; int vrema = 0;
        // code here
        while (k < 100000)
        {
            k = k * 2;
            vrema = vrema + 3;
            Console.WriteLine(vrema);
        }
        // end
        return vrema;
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
        double p = 10000; int answer = 0;
        // code here;
        for ( int k = 1; p <= 20000; k ++) 
        {
            p = p * 1.08;
            answer = k;
            Console.WriteLine(answer);
        }
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
        double chis1 = 1, chis2 = 2, zn1 = 1, zn2 = 1, k1 = 0, k2 = 0;
        // code here
        answer += 2;
        while (Math.Abs(chis1 / zn1 - chis2 / zn2) >= 0.001)
        {
            k1 = chis2;
            chis2 += chis1;
            chis1 = k1;
            k2 = zn2;
            zn2 += zn1;
            zn1 = k2;
            answer++;
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
        double S = (Math.Sin((Math.PI) / 4)) * x, y = 0;
        double i = 2;
        double k = x;                                                                                                                                      
        // code here
        while(Math.Abs(k)>0.0001)
        {
            k *= x;
            S += (k * Math.Sin((i * Math.PI) / 4));
            i++;   
        }
        // end
        y = ((x * Math.Sin((Math.PI) / 4)) / (1 - 2 * x * Math.Cos((Math.PI) / 4) + x * x));
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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