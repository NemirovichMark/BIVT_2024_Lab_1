using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        int i = 2;
        while (i <= 35)
        {
            answer += i;
            i += 3;           
        }               
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double i = 1;
        while (i <= 10) 
        {
            answer = Math.Round(answer + 1/i, 2);
            i++;
        }
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double i = 2;
        double j = 3;
        while (i <= 112)
        {            
            answer += i/j;
            i = i + 2;
            j = j + 2;
        }
        answer = Math.Round(answer, 2);
        // погрешность
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;


        // code here
        if (x == 0)
        {
            return 0;
        }

        double i = 1;       
        while (i <= 9)
        {
            double pow = 1;
            for (int p = 0; p < i-1; p++)
            {
                pow *= x;
            }
            answer += Math.Cos(i * x) / pow;
            i++;
        }
        
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while (i <= 9)
        {
            double pow = 1;
            for (int j = 0; j < 2; j++)
            {
                pow *= p + i * h;
            }
            answer += pow;
            i++;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double pow = 1;
        for (int p = 0; p < 2; p++)
        {
            pow *= x;
        }
        answer = Math.Round(0.5 * pow - 7 * x, 2);

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
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        for (int i = 1; i <= 6; i++)
        {
            int factorial = 1;
            for (int f = 1; f <= i; f++)
            {
                factorial *= f;
            }
            answer += factorial;
        }
        
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            double pow = 1;
            double pow2 = 1;
            for (int p = 0; p < i; p++)
            {
                pow *= -1;
                pow2 *= 5;
            }
            int factorial = 1;
            for (int f = 1; f <= i; f++)
            {
                factorial *= f;
            }
            answer += pow * pow2 / factorial;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");          
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{5} ");           
        }
        // code here
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0; 
        }
        for (int i = 0; i <= 10; i++)
        {
            double pow = 1;
            for (int p = 0; p < i; p++)
            {
                pow *= x;
            }
            answer += 1 / pow; 
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else if (x < -0.9)
        {
            answer = 1;
        }
        else if (x > 0.9)
        {
            answer = -1;
        }
        else if (-0.9 <= x || 0.9 <= x)
        {
            answer = x * -1;
        }     
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task       
        int a = 1;
        int b = 0;
        for (int i = 0; i < 8; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
            Console.Write($"{temp} ");
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double b = 1;
        for (int i = 0; i < 5; i++)
        {
            answer = a + b;
            a = b;
            b = answer;                      
        }
        answer = Math.Round(b / a, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double amount = 0;
        for (int i = 0; i < 64; i++)
        {
            double pow = 1;
            for (int p = 0; p < i; p++)
            {
                pow *= 2;
            }
            amount += pow;
            //answer += Math.Pow(2, i);
        }
        /* РЕШЕНИЕ 1
        string[] temp = [];
        // answer = 1.844....E+18
        // Научная нотация
        temp = Convert.ToString(answer / 15).Split('E');
        // temp = [1.229... | +18]
        answer = Math.Round(Convert.ToDouble(temp[0]), 2);
        // temp[0] - строковое представление числовой части научной нотации (1.229...) 
        power = Convert.ToInt32(temp[1]);
        // temp[1] - строковое представление символьной части научной нотации (+18) без Е
        */
        double weight = amount / 15;
       
        power = (int)Math.Floor(Math.Log10(weight));
        answer = Math.Round(weight / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const int R = 6350;
        answer = Math.Round(Math.Sqrt(x * (2 * R + x)),2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int amount = 10;
        for (int i = 3; i <= x; i += 3)
        {
            amount = amount * 2;
        }
        answer = amount;
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
        int counter = 1;
        int sum = 1;
        while (sum < 30000)
        {
            answer = counter;
            counter += 3;
            sum = sum * counter;
        }
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
        if (Math.Abs(x) >= 1)
        {
            Console.WriteLine("x должно быть меньше 1 по модулю");
            return 0;
        }
        double epsilon = 1;
        double sum = 0;
        for (double n = 0; epsilon >= 0.0001; n++)
        {
            double pow = 1;
            for (int p = 0; p < n * 2; p++)
            {
                pow *= x;
            }
            epsilon = pow;
            sum += epsilon;
        }
        answer = Math.Round(sum, 2);
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
        double pow = 1;
        for (int p = 0; p < 5; p++)
        {
            pow *= 10;
        }
        double amount = pow;
        for (int i = 10; i <= amount; i *= 2)
        {
            answer += 3;
        }
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
        double currentAmount = 10000;
        while (currentAmount < 20000)
        {
            currentAmount += currentAmount * 0.08;
            answer++;
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
        int answer = 0;
        //code here

        double threshold = 0.001;

        double numerator1 = 1, denominator1 = 1;
        double previousValue = numerator1 / denominator1;

        double numerator2 = 2, denominator2 = 1;
        double currentValue = numerator2 / denominator2;

        // 2 потому что начинаем с индекса 2
        answer = 2;

        // Начинаем цикл для поиска
        while (Math.Abs(currentValue - previousValue) > threshold)
        {
            // Обновляем числитель и знаменатель для следующего члена последовательности
            double nextNumerator = numerator1 + numerator2;
            double nextDenominator = denominator1 + denominator2;

            // Обновляем предыдущие значения
            numerator1 = numerator2;
            denominator1 = denominator2;
            numerator2 = nextNumerator;
            denominator2 = nextDenominator;

            // Обновляем значения дробей
            previousValue = currentValue;
            currentValue = numerator2 / denominator2;
            answer++;
        }
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
        S = Math.Round(S , 3);

        for (int i = 1; Math.Abs(Math.Pow(x, i)) >= 0.0001; i++)
        {
            double pow = 1;
            for (int p = 0; p < i; p++)
            {
                pow *= x;
            }
            S += pow * Math.Sin(Math.PI * i / 4);
        }

        y = Math.Abs(x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x));

        //end

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