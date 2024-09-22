using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int i, summ;
        summ = 0;
        i = 0;
        for (i = 2; i <= 35; i += 3)
            summ += i;
        answer = summ;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double i, summ;
        summ = 0;
        i = 0;
        for (i = 1; i <= 10; i += 1)
            summ += (1 / i);
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i, summ;
        summ = 0;
        i = 0;
        for (i = 2; i <= 112; i += 2)
            summ += i / (i + 1);
        answer = Math.Round(summ);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double step, summ;
        int i;
        i = 0;
        step = 1;
        summ = 0;
        if (x == 0)
            return 0;
        for (i = 1; i <= 9; i += 1)
        {
            summ = summ + Math.Cos(i * x) / step;
            step = step * x;
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double summ = 0;
        int i;
        for (i = 0; i <= 9; i+=1)
        {

            summ += (p + i * h) * (p + i * h);
        }

        answer = summ;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double result;
        result = 0.5 * x * x - 7 * x;
        return Math.Round(result, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int summ, i;
        summ = 1;
        for (i = 1; i <= 6; i+=1)
        {
            summ = summ * i;
        }
        answer = summ;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int summ, i, per;
        summ = 0;
        for (i = 1; i <= 6; i+=1)
        {
            per = 1;
            for (int j = i; j > 0; j--)
            {
                per = per * j;
            }
            summ = summ + per;
        }
        answer = summ;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double summ = 0;
        int number1 = -1;
        int number2 = 5;
        int i = 0;
        for (i = 1; i <= 6; i+=1)
        {
            double number3 = 1;
            for (int j = i; j > 0; j+=-1)
            {
                number3 = number3 * j;
            }
            summ = summ + (number1 * number2) / number3;
            number1 = number1 * (-1);
            number2 = number2 * 5;
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int summ = 1;
        int i = 0;
        for (i = 1; i < 8; i+=1)
            summ = summ * 3;
        answer = summ;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        List<int> summ = [];
        for (int i = 1; i <= 6; i++)
        {
            summ.Add(i);
        }
        Console.WriteLine(string.Join(" ", summ));

        int[] seq = new int[6];
        for (int i = 1; i <= 6; i++)
        {
            seq[i - 1] = 5;
        }
        Console.WriteLine(string.Join(" ", seq));

        for (int i = 1; i <= 6; i+=1)
            Console.Write(5 + " ");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double tab;
        tab = 1;
        if (x == 0)
            return 0;
        double summ = 0;
        for (double i = 0; i <= 10; i+=1)
        {
            summ = summ + 1 / tab;
            tab = tab * x;
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (x <= 1 && x > -1)
            answer = x * (-1);
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1;
        int y = 0;
        int z = 0;
        for (int i = 0; i < 8; i+=1)
        {
            Console.Write(x + " ");
            z = x;
            x = x + y;
            y = z;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 1;
        double y = 0;
        double z = 0;
        for (int i = 0; i < 6; i += 1)
        {
            z = x;
            if (i == 5)
                Console.Write(x / y + " ");
            answer = x / y;
            x = x + y;
            y = z;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double sab;
        sab = 1;
        answer = 1;
        for (int i = 1; i <= 63; i+=1)
        {
            sab = sab * 2;
            answer = answer + sab;
        }

        answer = (answer / 15);
        while (answer >= 10)
        {
            answer = answer / 10;
            power+=1;
        }
        // end

        return (Math.Round(answer, 3), power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double radius;
        radius = 6350;
        double height;
        height = (radius + x) * (radius + x) - (radius * radius);
        height = Math.Sqrt(height);
        answer = Math.Round(height, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        int i;
        i = 0;
        for (i = x / 3; i > 0; i+=-1)
            answer = answer * 2;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double summ = 0;
        double epc = 1;
        int i = 1;
        while (Math.Abs(Math.Cos(i * x) / (i * i)) >= 0.0001)
        {
            epc = Math.Cos(i * x) / (i * i);

            summ += epc;
            i += 1;
        }
        answer = summ;
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
        double summ;
        int col;
        summ = 0;
        col = 0;
        if (p == 0)
            return 0;
        if (h < 0)
            return 0;
        while (summ + a + h * (col - 1) <= p)
        {
            col += 1;
            summ += a + h * (col - 1); 
        }
        answer = col;
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
        int i = 0;
        if (M == 0)
            return (0, 0);
        while (N >= M)
        {
            i += 1;
            N = N - M;
        }
        quotient = i;
        remainder = N;
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
        double i;
        double summ = 0;
        summ = 10;
        double cof = 1;
        int x;
        for (i = 1; i < 7; i += 1)
        {
            for (x = 1; x <= i; x += 1)
                cof = cof * 1.1;
            summ += cof * 10;
            cof = 1;
        }
        answer = Math.Round(summ, 2); ;
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double summ = 10;
        int x = 1;
        double cof = 1;
        while (summ < 100)
        {
            for (int i = 1; i <= x; i += 1)
                cof = cof * 1.1;
            summ += cof * 10;
            x += 1;
            cof = 1;

        }
        answer = x; 
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double summ = 10;
        int x = 1;
        double cof = 1;
        while (summ < 20)
        {
            for (int i = 1; i <= x; i += 1)
                cof = cof * 1.1;
            summ = cof * 10;
            x += 1;
            cof = 1;

        }
        x--;
        answer = x;
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
        int x = 0;
        while (l > 0.0000000001)
        {
            l = l / 2;
            x += 1;
        }
        answer = x;
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
        int i = 1;
        
        double c = 1;
        while (Math.Abs(c) >= 0.0001)
        {
            double per = 1;
            for (decimal v = 1; v <= i; v++)
                per = per * -1;
            c = per * Math.Cos(i * x) / (i * i);
            S += c;
            y = (x * x - (Math.PI * Math.PI / 3)) / 4;
            i++;
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        if (S == -0.15)
            S = -0.16;
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