using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Schema;

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

        //for (double x = -4; x <= 4; x +=0.5)
        //program.Task_1_6(4);

        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);

        //for (double x = -1.5; x <= 1.5; x += 0.1)
        //program.Task_1_13(-1.5);

        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();

        //for (double x = 1; x <= 10; x++)
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
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);

        //for (double x = 0.1; x <= 1; x += 0.1)
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
        int i;
        for (i = 2; i <= 35; i = i + 3)
        {
            answer = answer + i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        int i;
        for (i = 1; i <= 10; i = i + 1)
        { 
            answer += (1.0 / i);
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
        for (int i = 2; i <= 112; i = i + 2)
        {
            answer += (i / (i + 1.0));
        }
        answer = Math.Round(answer, 0);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, y = 1;
        int i = 1;
        if (x == 0) return 0;
        while (i <= 9)
        {
            answer += Math.Cos(i * x) / y;
            i++;
            y *= x;
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
        double n, i = 0;
        while (i <= 9)
        {
            n = (p + i * h);
            answer += n * n;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        /*const double xmin = -4, xmax = 4, h = 0.5;
        double y;
        int i, n;
        n = (int)((xmax - xmin) / h + 1);
        x = xmin;
        for (i = 1; i <= n; i ++)
        {
            y = 0.5 * x * x - 7 * x;
            Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, y);
            x = x + h;

        }
        Console.WriteLine(y = 0.5 * x * x - 7 * x);*/

        answer = Math.Round((0.5 * x * x - 7 * x), 2);
        Console.WriteLine(answer);
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
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact *= i;
            answer += fact;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        const double n = -1, k = 5;
        double fact = 1, nn = 1, kk = 1;
        for (int i = 1; i <= 6; i++)
        {
            nn *= n;
            kk *= k;
            fact *= i;
            answer += nn * kk / fact;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        int num = 3;

        for (int i = 1; i <= 7; i++)
        {
            answer *= num;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

       // a)
       for (int l = 1; l <= 6; l++)
        {
            //Console.Write(l + " ");
            if (l == 1) Console.Write(l);
            else Console.Write(" " + l);
        }


        /*List<int> List1 = new List<int>();
        for (int i = 1; i <= 6; i++)

            List1.Add(i);

        string str1 = String.Join(" ", List1);
        Console.WriteLine(str1);*/

        //б)
        int i = 5;
        for (int j = 1; j <= 6; j++)
        {
            //Console.Write(j + " ");
            if (j == 1) Console.Write(i);
            else Console.Write(" " + i);
        }


        /*int n = 5;
        List<int> List2 = new List<int>();
        for (int j = 1; j <= 6; j ++)

            List2.Add(n);

        string str2 = String.Join(" ", List2);
        Console.WriteLine(str2);*/

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        answer = 1;
        double n = 1;
        if (x == 0) return 0;
        for (int i = 1; i <= 10; i++)
        {
            n *= x;
            answer += 1 / n;
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
        /*double xmin = -1.5, xmax = 1.5, h = 0.1;
        for (x = xmin; x <= xmax; x += h)
        {
            double y;
            if (x <= -1.0) y = 1.0;
            else if (x <= 1.0) y = -x;
            else y = -1.0;
            Console.WriteLine("{0,0:F2}\t{1,0:F2}", x, y);
        }*/


        /*double xmin = -1.5, xmax = 1.5, h = 0.1;
        double y;
        int i, n;
        n = (int)((xmax - xmin) / h + 1);
        x = xmin;
        for (i = 1; i <= n; i ++)
        {
            if (x <= -1.0) answer = 1.0;
            else if (x <= 1.0) answer = -x;
            else answer = -1.0;
            Console.WriteLine("\"x = {0:f2}\ty = {1:f2}", x, answer);
            x += h;
        }*/

        if (x <= -1.0) answer = 1.0;
        else if (x <= 1.0) answer = -x;
        else answer = -1.0;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int first = 1, second = 1, s = 0;
        Console.Write(first);
        Console.Write(" " + second);
        for (int i = 0; i <= 5; i++)
        {
            s = first + second;
            first = second;
            second = s;
            Console.Write(" " + s);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1, cc, zz;
        for (int j = 3; j <= 5; j++)
        {
            cc = ch1 + ch2;
            zz = zn1 + zn2;
            answer = cc / zz;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = cc;
            zn2 = zz;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        double zern = 1;
        for (int i = 1; i <= 64; i++)
            zern *= 2;
            answer += zern; //общее число зерен
        /*Console.WriteLine(answer);//1,8446744073709552E+19*/

        answer /= 15; //общ число зерен поделили на 15 - столько граммов получилось
        /*Console.WriteLine(answer);//1,2297829382473034E+18*/

        power = (int)Math.Log10(answer); //log10(1,2297829382473034E+18) = 18 - это и есть точность
        /*Console.WriteLine(power); - 18*/
        double results = 1;
        for (int i = 0; i <= 17; i ++)
        {
            results *= 10;
        }
        answer /= results;
        /*answer /= Math.Pow(10, 18); //оставляем только число, без умножения на 10**18*/
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
        answer = (R + x) * (R + x) - (R * R);
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int hour = 3; hour <= x; hour += 3)
        {
            answer *= 2;
            Console.WriteLine(answer);
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
        answer = 1;
        int p = 1, L = 30000;
        while (p <= L)
        {
            answer += 3;
            p *= answer;
            if (p > L) answer -= 3;
        }
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
        double xSecond = x * x, y = 1;
        answer = 1;
        double e = 0.0001;
        if (x >= 1) return 0;
        for (int n = 1; ; n += 1)
        {
            y *= xSecond;
            if (y >= e) answer += y;
            else break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

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
            count *= 2;
            answer += 3;
        }
        Console.WriteLine(answer);
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
        double contrib = 10000;
        double percent = 1.08;
        while (contrib <= 20000)
        {
            contrib *= percent;
            answer += 1;
        }
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
        double ch_1 = 1, zn_1 = 1, ch_2 = 2, zn_2 = 1, ch_3 = 3, zn_3 = 2;
        answer = 3;
        while (Math.Abs((ch_2 / zn_2) - (ch_3 / zn_3)) > 0.001)
        {
            ch_1 = ch_2;
            zn_1 = zn_2;
            ch_2 = ch_3;
            zn_2 = zn_3;
            ch_3 = ch_1 + ch_2;
            zn_3 = zn_1 + zn_2;
            answer++;
        }
        Console.WriteLine(answer);
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
        //1
        /*int i = 0;
        double fact = 1;
        S = 1;
        double p = 1;
        const double eps = 0.0001;
        while (true)
        {
            i++;
            fact *= i;
            p = (2 * i + 1) * Math.Pow(x, 2 * i) / fact;
            if (Math.Abs(p) < eps) break;
            S += p;
        }
        y = (1 + (2 * x * x)) * Math.Exp(x * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine(S + " " + y);

        return (S, y);*/

        //2
        int i = 0;
        double fact = 1;
        S = 1;
        const double eps = 0.0001;
        double p = 1;
        double power = x * x;
        while (true)
        {
            i++;
            fact *= i;
            p = (2 * i + 1) * power / fact;
            if (Math.Abs(p) < eps) break;
            power *= x * x;
            S += p;
        }
        y = (1 + (2 * x * x)) * Math.Exp(x * x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine(S + " " + y);

        return (S, y);

        //3
        /*int i = 0;
        double fact = 1;
        S = 1;
        double p = 1;
        const double eps = 0.0001;
        for (; x <= 1; x += 0.1)
        {
            i = 0;
            fact = 1;
            p = 1;
            S = 1;
            while (true)
            {
                i++;
                fact *= i;
                p = (2 * i + 1) * Math.Pow(x, 2 * i) / fact;
                if (Math.Abs(p) < eps) break;
                S += p;
            }
            y = (1 + (2 * x * x)) * Math.Exp(x * x);
            Console.WriteLine("{0:f2} {1:f2}", S, y);

        }
        return (S, y);*/

        // end

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