using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security;

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
        //for (double s = -1.5; s <= 1.5; s += 0.1)
        //{
            //double y = program.Task_1_13(s);
            //Console.WriteLine(y);
        //}
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
        answer = 0;
        for (int s = 2; s <= 35; s = s + 3)
        {
            answer += s;
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1;

        // code here
        answer = 1.0;
        for (int s = 2; s <= 10; s = s + 1)
        {
            answer += 1.0 / s;
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
        for (double s = 2; s <= 112; s += 2)
        {
            //for (double i = 3; i <= 113; i += 2)
            answer += s / (s + 1);
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
        double y = 1;
        for (double s = 1; s <= 9; s += 1)
        {
            if (x == 0)
            {
                return 0;
            }
            answer += Math.Cos(s*x) / y;
            y *= x;
            //answer = Math.Round(answer, 4);
            //Console.WriteLine(answer);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double g = 0;
        // code here
        for (int s = 0;s <=9; s+= 1)
        {
            g = p + s * h;
            answer += g * g;

        }
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer); 
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        double squaredx = 0;
        // code here
        for (double s = -4; s <=4; s += 0.5)
        {
            squaredx = x * x;
            answer = 0.5 * squaredx - 7 * x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int s = 1; s <= 6; s += 1)
        {
            answer *= s;

        }
        Console.WriteLine(answer);   
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;]
        int factorial = 1;
        for (int s = 1; s <= 6; s += 1)
        {
            factorial *= s;
            answer += factorial;
        
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double y = 5;
        double factorial = 1;
        double sign = -1;
        for (int s = 1; s <= 6; s +=1)
        {
            answer += sign * y / factorial;
            //Console.WriteLine($"{answer} {sign} {y} {factorial}");
            y *= 5;
            factorial *= s+1;
            sign *= -1;

        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3;
        for (int i = 1; i <= 6; i += 1)
        {
            
            //Console.WriteLine(s);
            s *= 3;

        }
        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int s = 1; s <= 6; s += 1)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i += 1)
        {
            Console.Write("5 ");
        }
        // code here
        
    }
    public double Task_1_12(double x)
    {

        double answer = 1;
        double y = x;
        // code here
        for (int s = 1; s <= 10; s += 1)
        {
            if (x == 0)
            {
                return 0;
            }
            answer += (1 / x);
            x *= y;

        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        //for (double s = -1.5; s <= 1.5; s += 0.1)
        //{
            if (x <= -1)
            {
                answer = 1;
            }
            else if (x > -1 && x <=1)
            {
                answer = -x;
            }
            else
            {
                answer = -1;
            }
        
        //}
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int first = 1;
        int second = 1;
        int third = 0;
        Console.Write(first + " " + second + " ");
        for (int s = 3; s <= 8; s += 1)
        {
            third = first + second;
            Console.Write(third + " ");
            first = second;
            second = third;
        }
        // code here


    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double firstchisl = 1;
        double firstznam = 1;
        double secondchisl = 2;
        double secondznam = 1;
        for (double s = 3; s <= 5; s += 1)
        {
            double newchisl = firstchisl + secondchisl;  
            double newznam = firstznam + secondznam; 

            firstchisl = secondchisl; // Сдвигаем 2-й предыдущий числ
            firstznam = secondznam; // Сдвигаем 2-й предыдущий знам

            secondchisl = newchisl; // Обновляем 1-й предыдущий числ
            secondznam = newznam; // Обновляем 1-й предыдущий знам

        }
        // end
        answer = secondchisl / secondznam;
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;
        double zerno = 1;
        // code here
        for (double s = 1; s <= 64; s += 1)
        {
            answer += zerno;
            zerno *= 2;
            //Console.WriteLine(zerno);
            // end
        }
        answer = answer / 15;
        while (answer > 10)
        {
            answer /= 10;
            power += 1;
        }
        answer = Math.Round(answer,2);
        //answer = Math.Log(10,answer);
        //answer = answer / power;
        //answer = Math.Round(answer, 4);
        //Console.WriteLine(answer);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        // code here
        double r = 6350;
        
        //for (int h = 1; h <= 10; h += 1)
        //{
        answer = Math.Sqrt(x * (2 * r + x));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
            //break;

        //}
        //answer  = Math.Round(answer, 1);
        //Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        //int s = x/3;
        // code here
        for (int i = x/3; i >= 1; i -= 1)
        {
            answer *= 2;
        }
        Console.WriteLine(answer);
        // end
        //Console.WriteLine(answer);
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
        int answer = 1;

        // code here
        int L = 1;
        //while (L <= 30000)
        int n = 1;
        for (; L * n < 30000; n += 3)
        {
            //answer *= L;
            L *= n;
            //n += 3;
            Console.WriteLine(n);
            Console.WriteLine(L);
            //if (L > 30000)
                //break;
        }
        answer = n - 3; //цикл завершился на один этап дальше
        //Console.WriteLine(L);
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
        const double e = 0.0001;
        double s = 1;
        double a = 1;
        if (Math.Abs(x) >= 1)
        {
            return 0;
        }
        while (Math.Abs(a) >= e)
        {
            a *= x * x;
            s += a;
            Console.WriteLine(a);
        }
        answer = s;
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
        int answer = 10;
        int start = 10;
        int v = 100000;
        int t = 3;
        // code here
        while (start <= v)
        {
            start *= 2;
            t += 3;
        }
        // end
        answer = t - 3;
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
        double s = 10000;
        double p = 1.08;
        // code here;
        while (s < 20000)
        {
            s *= p;
            Console.WriteLine(s);
            answer += 1;
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
        int answer = 2;
        const double e = 0.001;
        // code here;
        double firstchisl = 1;
        double firstznam = 1;
        double secondchisl = 2;
        double secondznam = 1;
        double current = secondchisl / secondznam;
        double previous = 0;
        while (Math.Abs(current - previous) > e)
        {
            previous = current;
            Console.WriteLine($"previous {previous}");
            double newchisl = firstchisl + secondchisl;
            double newznam = firstznam + secondznam;
            current = newchisl / newznam;
            Console.WriteLine($"curent {current}");
            firstchisl = secondchisl;
            firstznam = secondznam;

            secondchisl = newchisl;
            secondznam = newznam;
            answer += 1;
            //Console.WriteLine(current);
            Console.WriteLine($"---- {current - previous}");

        }
        //answer = (int)current;
        // end
        //Console.WriteLine(answer);
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
        double S = 0;
        double y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        int i = 1;
        double current = Math.Pow(x, i)*Math.Sin((i* Math.PI) /4);
        const double e = 0.0001;
        double current2 = Math.Pow(x, i);
        // code here
        while (Math.Abs(current2) >= e)
        {
            S += current;
            i += 1;
            current = Math.Pow(x, i) * Math.Sin((i * Math.PI) / 4);
            current2 = Math.Pow(x, i);

        }
        // end

        return (Math.Round(S,2), Math.Round(y,2));
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