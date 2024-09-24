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
        program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int s = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            s += i;
        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        
        for (double i = 1; i <= 10; i ++) 
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);

        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0, i = 2;
        while (i <= 112)
        {
            s += i / (i + 1);
            i += 2;
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (x == 0) return 0;
        for(double i = 0; i < 9; i++)
        {
            y = Math.Cos((i+1) * x) / Math.Pow(x, i);
            answer += y;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0,y;
        for (double i = 0; i <= 9; i++)
        {
            y = (p + h*i) * (p + h*i);
            s += y;
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
        double y;
        
       
        
        y = 0.5 * x * x - 7 * x;
        answer = Math.Round(y, 2); 
            
        

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int s = 1;
        for(int i = 1; i <= 6; i++)
        {
            s *= i;
        }
        Console.WriteLine(s);
        answer = s;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0, y = 1;
        for (int i = 1; i <= 6; i ++)
        {
            s += y * i;
            y *= i;
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
        double ch1 = 1, ch2 = 1, zn = 1;
        for (double i = 1; i <= 6; i++)
        {
            ch1 *= (-1);
            ch2 *= 5;
            zn *= i;
            answer += ch1 * ch2/zn;

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3, i = 1, c = 3;
        while (i < 7)
        {
            s *= c;
            i += 1;

        }
        answer = s;
        Console.WriteLine(s);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5" + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        // code here
        double y = 1;
        if (x == 0) return 0;
        for (int i = 1; i <= 10; i++)
        {
            y *= x;
            answer += 1 / y;

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
        double y = 0;
        if (x <= -1)
            y = 1;
        else if (x > -1 && x <= 1)
            y = -x;
        else if (x > 1)
            y = -1;
        answer = Math.Round(y, 1);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int y1 = 0, y2 = 1, y = 0;
        Console.Write(y2 + " ");
        for (int i = 1; i < 8; i++)
        {
            y = y1 + y2;
            Console.Write(y + " ");
            y1 = y2;
            y2 = y;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1, zn = 1, dr = 0, ch1 = 0;
        for (int i = 1; i <= 5; i++)
        {
            dr = ch / zn;
            ch1 = zn;
            zn = ch;
            ch += ch1;
        }
        Console.WriteLine(dr);
        answer = dr;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1, y = 1;
        for (int i = 1; i < 64; i++)
        {
            y *= 2;            
            s += y;
        }
        s /= 15;
        power = 18;
        answer = s;
        answer = answer / Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350, d = 0;
        d = Math.Sqrt(x * (2 * R + x));
        answer = Math.Round(d, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int y = x / 3, k = 10;
        while (y != 0)
        {
            k *= 2;
            y -= 1;
        }
        Console.WriteLine(k);
        answer = k;
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
        int p = 1, n = 1;
        while ((p * (n + 3)) < 30000)
        {
            n += 3;
            p *= n;

        }
        answer = n;
        Console.WriteLine(answer);
   
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
        double s = 1, y = 1;
        if (Math.Abs(x) >= 1) return 0;
        while (y >= 0.0001)
        {
            y *= x * x;
            s += y;
        }
        Console.WriteLine(Math.Round(s, 2));
        answer = Math.Round(s, 2);


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
        int t = 0;

        for (int k = 10; k <= 100000; k *= 2)
            t += 3;
        Console.WriteLine(t);
        answer = t;
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
        int mounth = 0;
        double s = 10000;
        while (s < 20000)
        {
            s *= 1.08;
            mounth++;
        }
        answer = mounth;
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
        int k = 1;
        double ch = 1, zn = 1, dr1 = 0, ch1 = 0, r = 10, dr2 = 0;
        while (r > 0.001)
        {
            dr1 = ch / zn;
            ch1 = zn;
            zn = ch;
            ch += ch1; 
            dr2 = ch / zn;
            k++;
            r = Math.Abs(dr1 - dr2);
        }
        Console.WriteLine(k);
        answer = k; 

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
        y = Math.Exp(2 * x);
        double n = 0, ch = 1, zn = 1;
        //while (n >= 0.0001)
        //{
        //    n = ch / zn;
        //    S += n;
        //    ch *= 2 * x;
        //    zn *= (i + 1);
        //    i++;
        //}
        //S -= n;
        for (int i = 0; i < 100000; i++)
        {
            n = ch / zn;
            if (n > 0.0001)
            {
                S += n;
            }
            else
            {
                break;
            }
            ch *= 2 * x;
            zn *= (i + 1);
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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