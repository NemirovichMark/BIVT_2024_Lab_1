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
        for (int i=2; i<=35; i= i+3)
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
        for (int s = 1; s <= 10; s++)
        {
            answer += 1.0/s;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double s = 1; s <= 112; s += 2)
        {
            answer += s/(s+1);
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0){return 0};
        for (int i = 1; i <= 9; i += 1)
        {
            answer += Math.Cos(i*x)/Math.Pow(x,i-1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        answer = Math.Pow(p,2);
        for (int i = 1; i <= 9; i += 1)
        {
            answer += Math.Pow(p+h*i,2);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * Math.Pow(x,2) - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int var = 1;
        for (int i = 1; i <= 6; i++)
        {
            var *= i;
            answer += var;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int var = 1;
        for (int i = 1; i <= 6; i++)
        {
            var *= i;
            answer += Math.Pow(-1,i) * Math.Pow(5,i) / var;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; i++)
        {
            answer *=3;
        }
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
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 10; i++)
        {
            answer += 1/Math.Pow(x,i);
        }
        answer = Math.Round(answer, 2);
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
        }
        if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        int store = 1;
        Console.Write(a + " " + b + " ");
        for (int i = 1; i <= 6; i++)
        {
            store = b;
            b = a + b;
            a = store;
            Console.Write(b + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double first_1 = 1;
        double first_2 = 1;
        double second_1 = 2;
        double second_2 = 1;
        double store_1 = 0;
        double store_2 = 0;
        for (int i = 1; i <= 3; i++)
        {
            store_1 = second_1;
            store_2 = second_2;
            second_2 += first_2;
            second_1 += first_1;
            first_1 = store_1;
            first_2 = store_2;
        }
        answer = second_1/second_2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double summa = 1;
        for (int i=1; i <= 63; i++)
        {
            summa += Math.Pow(2, i);
        }
        summa = summa/15;
        Console.WriteLine(summa);
        int counter = 0;
        for ( ; summa > 10; summa /= 10)
        {
            counter++;
        }
        double answer = Math.Round(summa, 2);
        power = counter;
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Round(Math.Pow((Math.Pow(r+x,2) - Math.Pow(r,2)),0.5),2);
        // end
        
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = Math.Pow(2,x / 3) * 10;
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
        int result = 1;
        int multiplier = 1;
        while (result * multiplier <= 30000)
        {
            multiplier += 3;
            result *= multiplier;
        }
        answer = multiplier;
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
        if (x == 1) 
        {
            return 0;
        }
        for (int i=0; Math.Pow(x, 2 * i) >= 0.0001; i++)
        {
            answer += Math.Pow(x, 2 * i);
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
        int answer = 0;

        // code here
        int count = 10;
        while (count <= 100000)
        {
            answer +=3;
            count *= 2;
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
        double count = 10000;
        while (count <= 20000)
        {
            answer += 1;
            count *= 1.08;
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
        double a1 = 1;
        double a2 = 1;
        double b1 = 2;
        double b2 = 1;
        double store1 = 0;
        double store2 = 0;
        int counter = 2;
        while (Math.Abs(b1/b2 - a1/a2) >= 0.001) 
        {
            counter += 1;
            store1 = b1;
            store2 = b2;
            b1 = a1 + b1;
            b2 = a2 + b2;
            a1 = store1;
            a2 = store2;
        }
        answer = counter;
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
        double val = 1;
        // code here
        for (int i = 0, fac = 1;  ; i++)
        {
            if (i > 0) 
            {fac *= i;}
            else fac = 1;
            val = ((2*i+1)*Math.Pow(x, 2 * i))/fac;
            if (val <= 0.0001) {break;}
            S += val; 
        }
        double y = (1 + 2 * Math.Pow(x, 2)) * Math.Pow(Math.E, Math.Pow(x, 2));
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
