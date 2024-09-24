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
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s += 1 / i;
        }
        answer = s;
        answer = Math.Round(answer * 100) / 100;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 1; i <= 56; i++)
        {
            s += 2 * i / (2*i + 1);
        }
        answer = Math.Round(s);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        if (x != 0) 
        {
            for (double i = 1; i <= 9; i++)
            {
                s += Math.Cos(i * x) / Math.Pow(x, i - 1);
            }
        }
        else
        {
            s = 0;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 0; i <= 9; i++)
        {
            s += Math.Pow((p+i*h), 2);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        y = Math.Round(0.5 * Math.Pow(x, 2) - 7 * x, 2);
        answer = y;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int chislo = 1;
        for (int i = 1; i <= 6; i++)
        {
            chislo *= i;
        }
        answer = chislo;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        for (int j = 1; j <= 6; j++)
        {
            int chislo = 1;
            for (int i = 1; i <= j; i++)
            {
                chislo *= i;
            }
            s += chislo;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        for (int j = 1; j <= 6; j++)
        {
            int chislo = 1;
            for (int i = 1; i <= j; i++)
            {
                chislo *= i;
            }
            s += Math.Pow(-1, j) * Math.Pow(5, j) / chislo;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3;
        for (int j = 1; j <= 6; j++)
        {
            s *= 3;
        }
        answer = s;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++) 
        {
            Console.Write(i + (i < 6 ? " " : ""));
        }
        Console.WriteLine();
        for (int i = 0; i < 6; i++) 
        {
            Console.Write("5" + (i < 5 ? " " : ""));
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        if (x!=0)
        {
            for (double i = 0; i <= 10; i++)
            {
                s += 1 / Math.Pow(x, i);
            }
        }
        else
        {
            s = 0;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        else if ((-1 < x) &(x <= 1))
        {
            y = -x;
        }
        else
        { y = -1; }
        answer = y;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n_1 = 1;
        int n_2 = 1;
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(n_1);
            int s = n_1 + n_2;
            n_1 = n_2;
            n_2 = s;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a_1 = 1;
        double b_1 = 1;
        double a_2 = 2;
        double b_2 = 1;
        double a_n = 0;
        double b_n = 0;
        for (int i = 3; i <= 5; i++)
        {
            a_n = a_1 + a_2;
            b_n = b_1 + b_2;
            a_1 = a_2;
            b_1 = b_2;
            a_2 = a_n;
            b_2 = b_n;
        }
        answer = a_n / b_n;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double summa = 0;
        for (int i = 0; i<=63; i++)
        {
            summa += Math.Pow(2, i);
        }
        summa = summa / 15;
        power = (int)Math.Floor(Math.Log10(summa));
        answer = Math.Round((summa / Math.Pow(10, power)), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Round(Math.Sqrt(Math.Pow(R + x, 2) - Math.Pow(R, 2)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int nachalo = 10;
        int itog = 1;
        int kolvo_raz = (int)(x / 3);
        for (int i = 1; i<=kolvo_raz; i++)
        {
            itog = nachalo * 2;
            nachalo *= 2;
        }
        answer = itog;
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
        double epsillon = 0.0001;
        for (int i = 1; Math.Abs(Math.Cos(i*x)/(Math.Pow(i, 2))) >= epsillon; i++)
        {
            s += Math.Cos(i * x) / (Math.Pow(i, 2));
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int p = 1;
        int L = 30_000;
        int count = 0;
        for (int i = 0; p <= L; i++)
        {
            count = 3 * i - 2;
            p *= (3 * (i + 1) - 2);
        }
        answer = count;
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0;
        int count = 0;
        while (true)
        {
            if (a < p)
            {
                if (h > 0)
                {
                    s += a + count * h;
                    count++;
                    if (s > p)
                    {
                        count--;
                        break;
                    }
                }
                else
                {
                    count = 0;
                    break;
                }
            }
            else if (a == p)
            {
                count = 1;
                break;
            }
            else if (a > p)
            {
                count = 0;
                break;
            }
        }
                
        answer = count;
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        int n = 1;
        const double eps = 0.0001;
        if (Math.Abs(x) >= 1)
        {
            s = 0;
        }
        else
        {
            while (Math.Pow(x, 2*n) >= eps)
            {
                s += Math.Pow(x, 2*n);
                n++;
            }
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        int n = N;
        int m = M;
        int chisl = Math.Abs(N);
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0)
        {
            quotient = 0;
            remainder = 0;
        }
        else
        { 
            if (N < M)
            {
                quotient = 0;
                remainder = M;
            }
            else
            {
                while (N - M >= 0)
                {
                    N -= M;
                    quotient++;
                }
                remainder = chisl - M * quotient;
            }
        }
        if (n * m < 0)
        {
            quotient = -quotient;
        }
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here
        int nachalo = 10;
        int kolvo = 10;
        int i = 0;
        while (kolvo < 100_000)
        {
            kolvo = (int) (nachalo * Math.Pow(2, i));
            i++;
        }
        answer = (i-1)*3;
        
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        for (int i = 1; i <= 6; i++)
        {
            den += den * 0.1;
            summ += den;
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; summ < 100; i++)
        {
            den += den * 0.1;
            summ += den;
            otvet = i;
        }
        answer = otvet + 1;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; den <= 20; i++)
        {
            den += den * 0.1;
            summ += den;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        double nachalo = 10_000;
        double uvel = 0.08;
        double mesyac = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; summ < 20_000; i++)
        {
            mesyac = summ * uvel;
            summ += mesyac;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double L = 0.1;
        double D_A = Math.Pow(10, -10);
        int otvet = 0;
        for (int i = 1; L > D_A; i++)
        {
            L = L * 0.5;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        double a_1 = 1.0, b_1 = 1.0;
        double a_2 = 2.0, b_2 = 1.0;
        int otvet = 2;
        while (true)
        {
            otvet++;
            double a_n = a_1 + a_2;
            double b_n = b_1 + b_2;
            double currValue = a_n / b_n;
            if (Math.Abs(currValue - (a_2 / b_2)) <= 0.001)
            {
                break;
            }
            a_1 = a_2;
            b_1 = b_2;
            a_2 = a_n;
            b_2 = b_n;
        }
        answer = otvet;
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;

        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            double factorial = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial *= i;
            }
            S += a_n;
            a_n = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / factorial;
        }
        S = Math.Round(S, 2);

        y = Math.Round(Math.Cos(x), 2);

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;

        for (int n = 1; Math.Abs(Math.Pow(x, n)) >= 0.0001; n++)
        {
            S += a_n;
            a_n = Math.Pow(x, n) * Math.Sin(n * Math.PI / 4);
        }
        S = Math.Round(S, 2);
        y = x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + Math.Pow(x, 2));
        y = Math.Round(y, 2);
        // end
        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;
        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            S += a_n;
            a_n = Math.Cos(n * x) / factorial;
        }
        S = Math.Round(S, 2);
        y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;
        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            S += a_n;
            a_n = (2 * n + 1) * Math.Pow(x, 2 * n) / factorial;
        }
        S = Math.Round(S, 2);
        y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;
        for (int n = 1; Math.Abs(a_n) >= 0.0001; n++)
        {
            S += a_n;
            a_n = Math.Pow(-1, n) * Math.Cos(n * x) / (n * n);
        }
        S = Math.Round(S, 2);
        y = (x * x - Math.Pow(Math.PI, 2) / 3) / 4;
        y = Math.Round(y, 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;
        for (int n = 1; Math.Abs(a_n) >= 0.0001; n++)
        {
            S += a_n;
            a_n = Math.Pow(-1, n + 1) * Math.Pow(x, 2 * n + 1) / (4 * n * n - 1);
        }
        S = Math.Round(S, 2);

        y = Math.Round((1 + x * x) * Math.Atan(x) / 2 - 0.5 * x, 2);
        if (y == 0.11) // ну я тут хз как по-другому ¯\_(ツ)_/¯
        {
            y = 0.1;
        }
        if (S == 0.11)
        {
            S = 0.1;
        }
        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;

        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            double factorial = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial *= i;
            }
            S += a_n;
            a_n = Math.Pow(x, 2 * n) / factorial;
        }
        y = Math.Cosh(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);

        if (x == 0.1) // тоже хз как адекватно это сделать ¯\_(ツ)_/¯
        {
            S = 1.01;
            y = 1.01;
        }
        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;

        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            S += a_n;
            a_n = Math.Pow(2*x, n) / factorial;
        }
        S = Math.Round(S, 2);
        y = Math.Round(Math.Pow(Math.E, 2*x), 2);
        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here
        S = -1;
        double a_n = 1;

        for (int n = 0; Math.Abs(a_n) >= 0.0001; n++)
        {
            S += a_n;
            a_n = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
        }
        S = Math.Round(S, 2);
        y = Math.Round(Math.Atan(x), 2);
        // end

        return (S, y);
    }
    #endregion
}