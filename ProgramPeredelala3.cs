using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        for (int i = 2; i <= 35; i += 3) {
            answer += i;
        }
        // end
        Console.WriteLine(answer); 
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i += 1)
        {
            answer += 1 / i;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <=112;i += 2)
        {
            answer += i / (i + 1);
        }

        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double Y = 1;

        // code here
        for (double i = 1; i <= 9; i += 1)
        {
            if (Y == 0)
            {
                answer = 0;
                break;
            }
            answer = answer + Math.Cos(i * x) / Y;
            Y *= x;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(double i = 0; i <=9; i += 1)
        {
            answer = answer + (p + h * i) * (p + h * i);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        const double xh = -4, xk = 4, h = 0.5;
        answer = 0.5 * x * x - 7 * x;
        x = x + h;
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i<=6; i+=1 )
        {
            answer *= i;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; i += 1)
        {
            int answer2 = 1;
            for(int j = 1; j <= i; j+= 1)
            {
                answer2 *= j;
            }
            answer += answer2;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double f = 1;
        double c = 1;
        double d = 1;
        // code here;
        for (int a = 1; a <= 6; a += 1)
        {
            f = a * f;
            c = c * (-1);
            d = d * 5;
            answer = answer + c * d / f;
        } // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
            return answer;
        
    }
    public int Task_1_10()
        {
            int answer = 1;

            // code here
            for (int i = 0; i < 7; i += 1)
            {
                answer *= 3;
            }
            // end
            Console.WriteLine(answer);
            return answer;
        }
        public void Task_1_11()
        {
            int answer = 1;

            // There is no test for this task
            for (int i = 1; i < 7; i += 1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < 7; i += 1)
            {
                Console.Write(5 + " ");
            }
            // code here

        }


        public double Task_1_12(double x)
    {
        double answer = 1;
        double powerOfX = x;

        for (int i = 1; i <= 10; i += 1)
        {
            if (x == 0)
            {
                Console.Write(answer);
                return (answer);
            }
            answer += 1 / powerOfX;
            powerOfX *= x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end
        Console.WriteLine(answer);
        return answer;
        }
        public void Task_1_14()
        {
            // There is no test for this task
            int first = 1;
            int second = 1;
            Console.Write(first + " ");
            Console.Write(second + " ");
            for (int i = 0; i < 6; i++)
            {
                int next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }
            // code here

        }
        public double Task_1_15()
        {
            double answer = 0;

            // code here
            double num1 = 1, znam1 = 1;
            double num2 = 2, znam2 = 1;

            double num3 = 0, znam3 = 0;
            for (int i = 3; i <= 5; i++)
            {
                num3 = num1 + num2;
                znam3 = znam1 + znam2;

                num1 = num2;
                znam1 = znam2;
                num2 = num3;
                znam2 = znam3;
            }
            answer = num3 / znam3;
        answer = Math.Round(answer, 2);
        Console.Write(answer);
            // end

            return answer;
        }
        public (double, int) Task_1_16()
        {
            double answer = 0;
            int power = 0;

            // code here
            double sumGrains = 0;
            double grains = 1;
            for (int i = 0; i < 64; i++)
            {
                sumGrains += grains;
                grains *= 2;
            }
            answer = sumGrains / 15;
            while (answer >= 10.0)
            {
                answer = answer / 10.0;
                power++;
            }
            answer = Math.Round(answer, 2);
            Console.Write(answer);
            // end

            return (answer, power);
        }
    public double Task_1_17(double x)
        {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;

        }
        public int Task_1_18(int x)
        {
            int answer = 0;

        // code here
        int n = 1;
        for (int i = 0; i < x/3; i++)
        {
            n *= 2;
        }
        answer = 10 * n;
        // end
        Console.Write(answer);
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
            int step = 3;
            int firstNum = 1;
            int prod = 1;

            // code here
            while (prod * firstNum <= 30000)
            {
                prod *= firstNum;
                answer = firstNum;
                firstNum += step;
            }
            Console.Write(answer);
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
            if (Math.Abs(x)>=1) { return 0; }
            double answer = 1;
            double step = 1;
            double epsilon = 0.0001;
            int n = 1;
            double currentPower = x * x;
            // code here
            while (Math.Abs(step) > epsilon)
            {
                step = currentPower;
                answer += step;
                n++;
                currentPower *= x * x;
            }
            answer = Math.Round(answer,2);
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
            double targetCell = 100000;
            double firstCell = 10;
            double divisionTime = 3;
            double doubling = Math.Log(targetCell / firstCell, 2);
            answer = (int)(Math.Ceiling(doubling * divisionTime / 3) * 3);
            // code here
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
            double rate = 0.08;
            double time = Math.Log(2) / Math.Log(1 + rate);
            answer = (int)Math.Ceiling(time);
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
            int answer = 1;
            double previousValue = 1.0;
            double currentValue = 2.0;
            double epsilon = 0.001;
            double difference = Math.Abs(currentValue - previousValue);

            // code here;
            int numerator1 = 1, denominator1 = 1;
            int numerator2 = 2, denominator2 = 1;
            while (difference > epsilon)
            {
                answer++;
                int nextNumerator = numerator1 + numerator2;
                int nextDenominator = denominator1 + denominator2;
                numerator1 = numerator2;
                denominator1 = denominator2;
                numerator2 = nextNumerator;
                denominator2 = nextDenominator;
                previousValue = currentValue;
                currentValue = (double)nextNumerator / nextDenominator;
                difference = Math.Abs(currentValue - previousValue);
            }
        answer++;
            Console.Write(answer);
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
        decimal xDec = (decimal)x;

        decimal S = 0;
        decimal epsilon = 0.0001m;
        decimal term = 1.0m;
        int i = 0;
        decimal xPower = 1.0m;
        int factorial = 1;

        while (Math.Abs((double)term) >= (double)epsilon)
        {
            if (i > 0)
            {
                xPower *= xDec * xDec;
                factorial *= i;
            }

            term = (2 * i + 1) * xPower / factorial;
            S += term;
            i++;
        }

        double S_double = (double)S;

        double xSquared = x * x;
        double y = (1 + 2 * xSquared) * Math.Exp(xSquared);

        return (S_double, y);
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