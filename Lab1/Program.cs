using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_3();
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        program.Task_2_1(0);
        Console.WriteLine(program.Task_2_3(0.2, -1.9, 12));
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
        program.Task_3_5( 25 * Math.PI / 25 );
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }

    public double CustomPow(double x, double y) {
        if (y == 0) {
            return 1;
        }
        if (y == 1) {
            return x;
        }
        if (y < 0) {
            return 1 / CustomPow(x, -y);
        }
        return x * CustomPow(x, y - 1);
    }

    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i = i + 3) {
            answer += i;
        }
        // end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += (1.0 / i);
        }
        // // end

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2.0; i < 112; i+=2.0) {
            answer += i /(i + 1.0);
        }
        // end

        return Math.Ceiling(answer);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double powX = 1;


        if (x > 0) {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < i; j++) {
                    powX *= x;
                }
                answer += Math.Cos(i * x) / powX;
                powX = 1;  
            }
            
            answer += Math.Cos(x);
        }
    
        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        int n = 10;

        for (int i = 0; i < n; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * (x * x) - 7 * x;

        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
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
        int factorial = 1;


        // code here;
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
        answer += factorial;
        factorial = 1;
    }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double powFive = 1, powMinusOne = -1, factorial = 1;


        // code here;
        for (int i = 1; i <= 6; i++)
        {            
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
                powFive *= 5;
                powMinusOne *= -1;
            }

            answer += powMinusOne * powFive / factorial;
            powFive = 1;
            powMinusOne = -1;
            factorial = 1;
        }
        // end

        return Math.Round(-answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i = 1; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < 6; i++)
        {
            Console.Write("5 ");
        }
        Console.WriteLine();
    }
    public double Task_1_12(double x)
    {
        double answer = 0, powX = 1;

        if (x == 0) {
            return 0;
        }

        // code here
        for (int i = 0; i <= 10; i++)
        {   
            for (int j = 1; j <= i; j++) {
                powX *= x;
            }

            answer += 1 / powX;
            powX = 1;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            return 1;
        } else if (-1 < x && x < 1) {
            return -x;
        } else {
            return -1;
        }
        // end
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;

        for (int i = 0; i < 8; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_15()
    {
        double a = 1;
        double b = 1;
        double c = 2;
        double d = 1;

        for (int i = 2; i < 5; i++)
        {
            double e = c + a;
            double f = d + b;
            a = c;
            b = d;
            c = e;
            d = f;
        }
        
        return c / d;
    }
 public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 1.0;
        double p = 1;
        for (int i = 1; i <= 64; i++)
        {
            x *= 2;
        }

        answer = x / 15;
        power = (int)Math.Log10(answer);

        for (int i = 1; i <= power; i++)
        {
            p *= 10;
        }
        answer = Math.Round(answer / p, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Round(Math.Sqrt(((R + x) * (R + x)) - (R * R)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        while (x > 0) {
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

        for (double i = 1, num = Math.Cos(x); Math.Abs(num) >= 0.0001; i++, num = Math.Cos(i * x) / (i * i)){
            answer += num;
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
        double s = 0;

        // code here
        if ((a + 1 * h) < 0) {
            return answer = 0;
        }

        while (s + (a + answer * h) <= p) {
            s +=a + answer * h;
            answer++;
            Console.WriteLine(answer);
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
        if (M == 0) {
            return (quotient, remainder);
        }
        while (Math.Abs(N) >= Math.Abs(M) ) {
            quotient++;
            N -= M;
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
        double s = 10;

        // code here
        for (int i = 1; i <= 7; i++) {
            answer += s;
            s *= 1.1;
        }
        // end

        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double oneDay = 10;
        double allDays = 0;

        // code here
        while(allDays < 100) {
            answer++;
            allDays += oneDay;
            oneDay *= 1.1;
        }           
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double oneDay = 10;
        // code here
        while (oneDay <= 20) {
            oneDay *= 1.1;
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
        double atomSize = 1;

        for (int i = 0; i < 10; i++) {
            atomSize *= 10;
        }

        atomSize = 1 / atomSize;

        double l = 0.1;

        // code here;
        while (l > atomSize) {
            l /= 2;
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
        double eps = 0.0001, i = 1, powMinusOne = -1;
        double k = -1 * (Math.Cos(i * x)) / (i * i);

        // code here
        while(Math.Abs(k) >= eps) {
            S += k;
            i++;
            powMinusOne *= -1;
            k = powMinusOne * (Math.Cos(i * x)) / (i * i);
        }
        // end
        
        y = (x * x - Math.PI * Math.PI / 3) / 4;
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
