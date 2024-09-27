using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

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
        int s = 0;
        for (int i = 2; i <= 35; i = i + 3)
        {
            s = s + i;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 1;
        for (double i = 2; i <= 10; i = i + 1)
        {
            s = s + (1/i);
        }
        {
            s = Math.Round(s, 3);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2, j = 3; i <= 112; i = i + 1, j = j + 1)
        {
            s = s + (i / j);
        }
        {
            s = Math.Round(s, 3);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double t = 2, s = Math.Cos(x), k = 0, xx = x;
        while (t < 10)
        {
            if (x == 0) { return 0; }
            k = Math.Cos(t * x) / xx;
            s = s + k;
            t += 1;
            xx = xx * x;
        }
        answer = Math.Round(s, 4);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0, count = 0, j = 0, answ = 0;
        answ = p * p;
        while (count < 9)
        {
            count += 1;
            s = s + h;
            j = p + s;
            answ += j * j;
            
        }
        answer = answ;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;


        // code here
        answer = 0.5 * x * x - 7 * x;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int x = 6, sum = 1;
        while (x > 0)
        {
            sum = sum * x;
            x = x - 1;
        }
        answer = sum;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int x = 1, s = 0, xx = x;
        while (x != 7)
        {
            s += xx;
            x = x + 1;
            xx = xx * x;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 1, kol = 1, fact = kol;
        while (kol != 7)
        {
            s = s * ((-1) * 5);
            fact *= kol;
            answer += s / fact;
            kol += 1;

        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3 * 3 * 3 * 3 * 3 * 3 * 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        string str_a = "1", str_b = "5";
        for (int i = 2; i <= 6; i++)
        {
            str_a += " " + i.ToString();
            str_b += " 5";
        }
        Console.WriteLine(str_a);
        Console.WriteLine(str_b);
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double kol = 1, s = 1, xx = x;
        while (kol != 11)
        {
            if (x == 0) { return 0; }
            s = s + (1 / x);
            kol += 1;
            x = x * xx;

        }
        answer = Math.Round(s, 4);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x<= -1)
        {
            answer = 1;
        }
        if (x > -1 && x <= 1)
        {
            answer = (-x);
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
        int count = 2, ch1 = 1, ch2 = 1, ch3 = 0;
        string str = "1 1";
        while (count < 8)
        {

            ch3 = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch3;
            str += " " + ch3.ToString();
            count += 1;
        }
        Console.WriteLine(str);
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, ch2 = 1, pereh = 0;
        double zn1 = 0, zn2 = 1;
        for (int k = 1; k < 5; k++)
        {
            pereh = ch1;
            ch1 = ch2;
            ch2 = pereh + ch2;

            pereh = zn1;
            zn1 = zn2;
            zn2 = pereh + zn2;

            answer = ch2 / zn2;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double weight = 0, col = 0, amount = 1;
        while (col != 64)
        {
            col += 1;
            amount = amount * 2;

            weight += Math.Round(amount / 15, 4);

        }
        while (weight >= 10)
        {
            power++;
            weight /= 10;
        }
        
        answer = Math.Round(weight, 4);
        //число дел на 10 до тех пор пока оно больше 10 = мальтиса = сколько раз мы сдвинули = power
        // end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt((R+x)*(R+x) - (R*R));
        answer = Math.Round(answer, 2);
        // end
       

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        int xx = x / 3, ameba = 10;
        while (xx > 0)
        {
            ameba *= 2;
            xx -= 1;
        }
        answer = ameba;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = Math.Cos(x), n = 1, cosik = Math.Cos(x);
        while (Math.Abs(cosik) >= 0.0001)
        {
            if (n * x > 1 && n * x < -1)
            {
                answer = 0;
                break;
            }
            n++;
            cosik = Math.Cos(n * x) / (n * n);
            s += cosik;
        }
        answer = Math.Round(s, 4);

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
        double s = 0;
        int n = 0;
        while (s <= p && a <= p)
        {
            if (a < Math.Abs(h) && h < 0) { return 0; }
            s += (a + (n * h));
            if (s <= p) { n++; }

        }
        answer = n;
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
        
        while (Math.Abs(N) >= Math.Abs(M))
        {
            if (M == 0) { quotient = 0; remainder = 0;
                return (quotient, remainder );
            }
            N = N - M;
            quotient = quotient + 1;
        }
        remainder = Math.Abs(N);
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

        double day = 10, nextday = 0, count = 7;
        for (count = 7; count > 0; count--)
        {
            nextday = day + (day * 0.1);
            answer += day;
            day = nextday;
        }
        // end
        answer = Math.Round(answer, 4);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double day = 10, nextday = 0, kms = 0;
        while (kms <= 100)
        {
            nextday = day + (day * 0.1);
            kms += day;
            day = nextday;
            answer++;
        }
        // end
        
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double day = 10, nextday = 0;
        while (day <= 20)
        {
            nextday = day + (day * 0.1);
            day = nextday;
            answer++;
        }
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
        double L = 0.1, d = 1E-10;
        while (L > d)
        {
            L = L / 2;
            answer++;
        }
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
        S = 1;
        double e = 0.0001, i = 1;
        double ch = (0.1 * 0.1) / (1 * 2), i2 = i * 2, fact = 1, prost = 1;
        while (Math.Abs(ch) >= e)
        {

            //x += h;
            i2 = i * 2;
            prost *= x * x;
            while (i2 > 0)
            {
                fact *= i2;
             
                i2 = i2 - 1;
            }
            ch = prost / fact;
            S += ch;
            i++;
            S = Math.Round(S, 4);
        }
        
        //while (S >= 10) { S /= 10; }
        S = Math.Round(S, 4);
        y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, (-1) * x)) / 2;
        y = Math.Round(y, 4);
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