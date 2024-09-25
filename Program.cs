using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();    +
        //program.Task_1_2();    +
        //program.Task_1_3();    +
        //program.Task_1_4(0.9);   +
        //program.Task_1_5(0, 2);    +
        //program.Task_1_6(4);       +
        //program.Task_1_7();        +
        //program.Task_1_8();        +
        program.Task_1_9();        
        //program.Task_1_10();       + 
        //program.Task_1_11();       +
        //program.Task_1_12(0.9);    +
        //program.Task_1_13(-1.5);   +
        //program.Task_1_14();       +
        //program.Task_1_15();       +
        //program.Task_1_16();       //
        //program.Task_1_17(10);     +
        //program.Task_1_18(24);     +
        //program.Task_2_1(0);       
        //program.Task_2_2();
        //program.Task_2_3(1, 1, 10);    +
        //program.Task_2_4(0.8);
        //program.Task_2_5(-11, -5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();       //ошибка в тесте          
        //program.Task_2_8();
        //program.Task_2_9();       
        //program.Task_2_10();
        /*
        for (double i = 0.1; i <= 1; i += 0.1)
            program.Task_3_1(i);
        */
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
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i += 1)
            answer += (1 / i);

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;


        // code here
        for (double i = 3; i <= 113; i += 2)
            answer += (i - 1) / i;

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double varieble = 1;
        if (x == 0) return 0;

        for (int i = 1; i <= 9; i += 1)
        {
            answer += ((Math.Cos(i * x)) / varieble);
            varieble *= x;
        }

        answer =  Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i += 1)
            answer += Math.Pow(p + i * h, 2);

        Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - 7 * x; 
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i <= 6; i += 1)
            answer *= i;

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        answer += 1;
        int Summa = 0;
        for (int i = 1; i <= 6; i += 1)
        {
            answer *= i;
            Summa += answer;
        }

        Console.WriteLine(Summa);
        // end

        return Summa;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int Fact = 1;
        double varieble1 = -1;
        double varieble2 = 5;
        for (int i = 1; i <= 6; i += 1)
        {
            Fact *= i;
            answer += (varieble1 * varieble2) / Fact;
            varieble1 *= -1;
            varieble2 *= 5;
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
        answer += 1;
        for (int i = 0; i < 7; i += 1)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string FirstStr = "а) ";
        string SecondStr = "б) ";
        int j = 7;
        for (int i = 1; i < j; i += 1)
            if (i + 1 != j)
                FirstStr += $"{i} ";
            else
                FirstStr += $"{i}, ";

        for (int i = 1; i < j; i += 1)
            if (i + 1 != j)
                SecondStr += "5 ";
            else
                SecondStr += "5.";
        Console.WriteLine(FirstStr);
        Console.WriteLine(SecondStr);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;

        for (int i = 0; i <= 10; i += 1)
            answer += 1 / (Math.Pow(x, i));

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
            answer = 1;
        if (x > 1)
            answer = -1;
        if (x > -1 & x <= 1)
            answer = -1 * x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int StartNum1 = 1;
        int StartNum2 = 1;
        int NextNum = 0;
        Console.WriteLine(StartNum1);
        Console.WriteLine(StartNum2);
        for (int i = 0; i < 6; i += 1)
        {
            NextNum = StartNum1 + StartNum2;
            StartNum1 = StartNum2;
            StartNum2 = NextNum;
            Console.WriteLine(NextNum);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int StartNumChisl1 = 1;
        int StartNumChisl2 = 2;
        int StartNumZnam1 = 1;
        int StartNumZnam2 = 1;
        int NextNumChisl = 0;
        int NextNumZnam = 0;
        for (int i = 0; i < 3; i += 1)
        {
            NextNumChisl = StartNumChisl1 + StartNumChisl2;
            NextNumZnam = StartNumZnam1 + StartNumZnam2;
            StartNumChisl1 = StartNumChisl2;
            StartNumZnam1 = StartNumZnam2;
            StartNumChisl2 = NextNumChisl;
            StartNumZnam2 = NextNumZnam;
        }
        answer = (double) NextNumChisl / NextNumZnam;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double j = 1;
        for (int i = 1; i <= (8 * 8); i++)
        {
            answer += j;
            j *= 2;
        }
        answer /= 15;
        power = 18;
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
        answer = Math.Sqrt(Math.Pow((6350 + x), 2) - Math.Pow(6350, 2));
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
        for (int i = 0; i <= x; i += 3)
        {
            if (i % 3 == 0 & i != 0)
            {
                answer *= 2;
                //Console.WriteLine(answer);
            }
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
        for (double i = 1; i <= 1000000000; i  += 1)
        {
            if (Math.Abs((Math.Cos(i * x)) / (Math.Pow(i, 2))) >= 0.0001)
                answer += ((Math.Cos(i * x)) / (Math.Pow(i, 2)));
            else
                break;
        }
        answer = Math.Round(answer, 2);
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
        double Progressia = 0;
        for (int n  = 0; n < 10000000; n += 1)
        {
            if (Progressia <= p)
            {
                Progressia += a + n * h;
            }

            else
            {
                answer = n - 1;
                break;
            }
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
        if (M > 0)
        {
            while (N >= M)
            {
                N -= M;
                quotient += 1;
            }
        }

        if (M == 0)
            N = 0;

        if (M < 0)
        {
            while (N <= M)
            {
                N -= M;
                quotient += 1;
            }
        }

        remainder = Math.Abs(N);
        Console.WriteLine(quotient);
        Console.WriteLine(remainder);
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
        double S = 10;
        answer = S;
        for (int i = 0; i < 6; i++)
        {
            S *= 1.1;
            answer += S;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double S = 10;
        double Run = 10;
        answer += 1;        //468, 470 отвечают за первый день
        while (Run < 100)
        {
            S *= 1.1;
            Run += S;
            answer += 1;
        }
        

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double S = 10;
        Console.WriteLine($"{S}, {answer}");
        while (S < 20)
        {
            S *= 1.1;
            answer += 1;
            Console.WriteLine($"{S}, {answer}");
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
        double Atom = Math.Pow(10, -10);
        while (L > Atom)
        {
            L /= 2;
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
        y = Math.Cos(x);
        double variable2 = 1;
        double variable3 = 1;

        for (int i = 0; i <= 1000000; i++)
        {
            double variable1 = 0;
            double variableRes = 1;

            if (i % 2 == 0)
                variable1 = 1;
            if (i % 2 == 1)
                variable1 = -1;

            if (i > 0)
            {
                variable2 *= x * x;
                variable3 *= (2 * i) * (2 * i - 1);
            }

            variableRes = variable1 * variable2 / variable3;

            if (Math.Abs(variableRes) >= 0.0001)
                S += variableRes;
            if (Math.Abs(variableRes) < 0.0001)
                break;

        }

        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"{S}, {y}");
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