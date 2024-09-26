using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        int answer = 0;

        // code here
        for (int i=2; i<=35; i+=3)
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
        for (double i=1;i<=10;i++)
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
        for (double i=2;i<=113;i+=2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double n = 1;
        answer = Math.Cos(x);
        for ( int i=2;i<=9;i++)
        {
            n = n * x;
            answer += Math.Cos(i * x) / n;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i=0;i<=9;i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer= Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i=1;i<=6;i++)
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
        int n = 1;
        for (int i=1;i<=6;i++)
        {
            n = n * i;
            answer += n;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double factorial = 1;
        double chislo = 1;
        double stepen = 1;
        for (int i=1;i<=6;i++)
        {
            factorial *= i;
            chislo *= -1;
            stepen *= 5;
            answer += chislo * stepen / factorial;
        }
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i=2;i<=7;i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i=1;i<=6;i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int j = 1; j<=6;j++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        answer = 1;
        double n = x;
        for (int i=1;i<=10;i++)
        {
            if (x <= 0)
            {
                answer = 0;
                break;
            }
            else
            {
                answer += 1 / n;
                n *= x;
            }
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
        if (x<= -1)
        {
            answer = 1;
        }
        else if (x> -1 && x<= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int chislo1 = 1;
        int chislo2 = 1;
        int mind = 0;
        Console.Write(chislo1 + " ");
        Console.Write(chislo2 + " ");
        for (int i = 3; i <= 8; i++)
        {
            mind = chislo2;
            chislo2 = chislo1 + chislo2;
            chislo1 = mind;
            Console.Write(chislo2 + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chisl1 = 1;
        double chisl2 = 2;
        double znam1 = 1;
        double znam2 = 1;
        double mindch = 0;
        double mindzn = 0;
        for (int i=3;i<=5;i++)
        {
            mindzn = znam2;
            znam2 = znam1 + znam2;
            znam1 = mindzn;
            mindch = chisl2;
            chisl2 = chisl1 + chisl2;
            chisl1 = mindch;
        }
        answer = chisl2 / znam2;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 2;
        for (int n=1; n<=63;n++)
        {
            answer += x / 15;
            x *= 2;
        }
        power=(int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt((R+x)*(R+x)-R*R);
        answer= Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        while (x>0)
        {
            answer *= 2;
            x -= 3;
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
        double k = 1;
        double a = Math.Cos(x);
        while (Math.Abs(a)>= 0.0001)
        {
            answer += a;
            k++;
            a = Math.Cos(x * k) / (k * k);
        }
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
        double suma = 0;
        if (p<=0 || h<0)
        {
            return 0;
        }
        while (suma<=(p-(a+answer*h)))
        {
            suma += a + answer * h;
            answer += 1;
        }
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
        if (N<=0 || M<=0)
        {
            return (0, 0);
        }
        while (N >= M)
        {
            N -= M;
            quotient++;
        }
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
        double dlina = 10;
        answer = dlina;
        for (int i=2;i<=7;i++)
        {
            dlina = dlina * 1.1;
            answer += dlina;
        }
        answer = Math.Round(answer,2);

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double dlina = 10;
        double alld = dlina;
        answer = 1;
        while (alld <= 100)
        {
            dlina = dlina * 1.1;
            alld += dlina;
            answer++;
        }

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double dlina = 10;
        answer = 1;
        while (dlina < 19)
        {
            dlina = dlina * 1.1;
            answer++;
            Console.Write(dlina + " ");
            Console.WriteLine(answer);
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
        double L = 0.1;
        double Da = Math.Pow(10, -10);
        while (L >= Da)
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
        double summa = 1;
        double stepen = 1;

        for (int i = 1; ; i++)
        {
            stepen *= -1;
            summa = stepen * Math.Cos(i * x) / (i * i);

            if (Math.Abs(summa) >= 0.0001)
            {
                S += summa;
            }
            else
            {
                break;
            }
        }

        y = (x * x - Math.PI * Math.PI / 3) / 4;
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