using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.5);
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
        //program.Task_2_3(0.2, -1.9, 12);
        //program.Task_2_4(0.8);
        //program.Task_2_5(0, 8);
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
        //program.Task_3_7(0.15);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        // code here

        int answer = 0;

        for (int i = 2; i <= 35; i = i + 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        // code here

        double answer = 0;

        for (double a = 1; a <= 10; a = a + 1)
        {
            answer += 1 / a;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        // code here

        double answer = 0;

        for (double a = 2; a <= 112; a += 2)
        {
            answer += a / (a + 1.0);
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        // code here

        double answer = 0;
        double zn = 1;

        if (x == 0)
        {
            return 0;
        }
        for (int i = 1; i <= 9; i += 1)
        {
            answer += Math.Cos(i * x) / zn;
            zn *= x;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        // code here

        double answer = 0;
        double umn = 0;

        for (; umn <= 9; umn += 1)
        {
            answer += (p * p) + (2 * p * (h * umn)) + ((h * h) * (umn * umn));
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int n = 1; n <= 6; n += 1)
        {
            answer *= n;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int chis = 1, digit = 1; digit <= 6; digit += 1)
        {
            chis = chis * digit;
            answer += chis;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        // code here;

        double answer = 0;
        int znak = -1, schet = 1; double chisl = 5, znam = 1;
        for (double digit = 0; schet <= 6; schet++)
        {
            Console.WriteLine($"знак{znak}");
            Console.WriteLine($"числитель{chisl}");
            Console.WriteLine($"знаменатель{znam}");
            Console.WriteLine($"номер{schet}");
            znam *= schet;
            digit = (znak * chisl) / znam;
            chisl *= 5;
            answer += digit;
            znak = -znak;
            Console.WriteLine(digit);

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

        answer = 3;
        for (int n = 2, digit = 3; n <= 7; n += 1)
        {
            answer *= digit;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        for (int x = 1; x <= 6; x++)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
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

        if (x == 0)
        {
            return 0;
        }

        double X = x;

        for (int n = 0; n <= 9; n++)
        {
            answer += (1 / X);
            X *= x;
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
        {
            answer = 1;
        }
        if ((-1 < x) & (x <= 1))
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


        int perv = 1, vtor = 1;
        for (int n = 0; n <= 8; n++)
        {
            int digit = perv + vtor;
            Console.Write($"{digit} ");
            perv = vtor;
            vtor = digit;
        }
        Console.WriteLine();



        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        double chis = 2, znam = 1, sam = 0;
        for (int step = 0; step < 4; step++)
        {
            answer = chis / znam;
            sam = chis;
            chis += znam;
            znam = sam;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        int n = 1;
        double zerna = 2;

        // code here

        for (; n <= 63;)
        {
            answer += zerna / 15;
            zerna *= 2;
            n++;

        }
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        int radius = 6350;
        answer = Math.Sqrt(2 * radius * x + x * x);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        while (x > 0)
        {
            answer *= 2;
            x -= 3;
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
        double s = 0;
        int k = 1;
        while (Math.Abs(Math.Cos(k * x) / Math.Pow(k, 2)) >= 0.0001)
        {
            s += Math.Cos(k * x) / Math.Pow(k, 2);
            k++;
        }
        Console.WriteLine(s);
        answer = s;
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
        int n = 0;
        double sum = 0;


        if (p == 0)
        {
            Console.WriteLine(answer);
            return answer;
        }

        if (((a + h) < 0) & (h < 0))
        {
            Console.WriteLine(answer);
            return answer;

        }
        else
        {
            while (sum <= p)
            {
                sum += a + n * h;
                n++;
            }
            answer = n - 1;
            Console.WriteLine(answer);
            return answer;
        }

        // end

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

        (int, int) answer = (0, 0);
        int quotient = 0;
        int remainder = N;

        if (M == 0)
        {
            Console.WriteLine(answer);
            return answer;
        }

        while (remainder >= M)
        {
            remainder -= M;
            quotient++;
        }
        answer = (quotient, remainder);
        Console.WriteLine(answer);
        return answer;

        // end
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
        double probeshal = 10;
        int dny = 0;
        double sam = 0;
        for (double nowden = 0; dny <= 6; dny++)
        {
            nowden = (probeshal * 10) / 100 + probeshal;
            sam += probeshal;
            probeshal = nowden;
        }
        sam = Math.Round(sam, 2);
        answer = sam;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double sam = 0;
        double probeshal = 10;
        int dny = 0;
        double nowden = 0;
        while (sam < 100)
        {
            nowden = (probeshal * 10) / 100 + probeshal;
            sam += probeshal;
            probeshal = nowden;
            dny++;
        }
        Console.WriteLine(dny);
        answer = dny;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double probeshal = 10;
        double newday = 0;
        int dny = 0;
        for (; newday <= 20; dny++)
        {
            newday = (probeshal * 10) / 100 + probeshal;
            probeshal = newday;
            Console.WriteLine(newday);
        }
        Console.WriteLine(dny);
        answer = dny;
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

        double digit = 0;
        double L = 0.1;
        double Da = Math.Pow(10, -10);

        digit = Math.Log(L / Da, 2);
        digit = Math.Round(digit, 0);
        answer = (int)digit;
        Console.WriteLine(answer);
        return answer;
        // end

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
        double S = 1, y = 0;

        // code here

        double znam = 1, chisl = 1;
        for (int i = 1, step = 1; ; i++)
        {
            double digit = 0;

            step = i * 2;

            chisl = Math.Pow(x, step);

            znam *= 2 * i * (2 * i - 1);

            digit = chisl / znam;

            //Console.WriteLine(digit);

            if (Math.Abs(digit) < 0.0001)
            {
                break;
            }
            S += digit;
        }
        Console.WriteLine(S);

        y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;

        Console.WriteLine(y);

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
