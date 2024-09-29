using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;


public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
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
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        program.Task_3_3(0.1);
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

        // code there
        for (int i = 2; i<=35; i+=3)
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
        for (int i = 1; i<=10; i++)
        {
            answer += (1.0 / i);
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+=2)
        {
            answer += (i / (i + 1.0));
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double pow_x = 1;
        // code here
        for (int i = 0; i<= 8; i++)
        {
            answer += Math.Cos((i + 1) * x) / pow_x;
            pow_x *= x;
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i<=9; i++)
        {
            answer += (p + i * h) * (p + i * h);  
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer++;
        for (int i = 1; i<=6; i++)
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
        int number = 1;
        for (int i = 1; i<=6; i++)
        {
            number *= i;
            answer += number;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        // code here;
        int sign = -1;
        double five_pow = 1.0;
        int fact = 1;

        for (int i = 1; i<=6; i++)
        {
            five_pow *= 5;
            fact *= i;
            answer += sign * five_pow / fact;
            sign *= -1;
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer++;
        for (int i = 1; i<=7; i++)
        {
            answer *= 3;
        }

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i<= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double pow_x = 1.0;

        if (x != 0)     //при x=0 возникает ошибка, так как делить на 0 нельзя
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1.0 / pow_x;
                pow_x *= x;
            }
        }
        answer = Math.Round(answer,2);

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here`   
        if(x<=-1)
        {
            answer = 1;
        }
        else if (x>-1 && x<=1)
        {
            answer = -1 * x;
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
        Console.Write(1 + " " + 1 + " ");
        int num1 = 1;
        int num2 = 1;
        for (int i =1; i<=6; i++)
        {
            Console.Write(num1 + num2 + " ");
            num2 = num1 + num2;
            num1 = num2 - num1;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double up1 = 1.0;
        double up2 = 2.0;
        for (int i = 1; i<=3; i++)
        {
            up2 = up1 + up2;
            up1 = up2 - up1;
        }
        answer = up2 / up1;      //знаменатель данного элемента последовательности всегда равен числителю предыдущего
        answer = Math.Round(answer,1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // кол-во зерен - сумма геометрической последовательности, где первый элемент - 1,
        // кол-во элементов - 64(на шахматной доске 64 клетки), а знаменатель - 2.
        // сумма геометрической последовательности: S = b1*(q^n - 1)/(q-1)
        // S = 2^64 - 1
        // кол-во грамм: (2^64 - 1)/15
        answer = (Math.Pow(2.0, 64) - 1.0) / 15;    //испотзую тут Math.Pow, т.к. здесь нет цикла, а писать число 64 раза - не очень хорошая идея

        do               //вычисляем степень числа в экпоненциальной записи
        {
            answer /= 10;
            power += 1;
        }
        while (answer>=10);

        answer = Math.Round(answer,2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        // формула расстояния до горизонта: d = ((R+h)^2 - R^2)^0.5
        answer = Math.Sqrt((6350 + x) * (6350 + x) - 6350 * 6350);
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 1; i<= x/3; i++)
        {
            answer *= 2;
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
        int i = 1;
        double el = Math.Cos(x);

        while (Math.Abs(el) >= 0.0001)
        { 
            answer += el;
            i++;
            el = Math.Cos(i * x) / (i*i);
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
        if (h * p >= 0)       //проверяем, что у h и p один знак
        {
            while (((2 * a + answer * h) * (answer + 1) / 2.0) <= p)
            {
                answer++;
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
        if (M == 0)
        {
            return (0, 0);
        }
        int cnt = 0;
        while (N>=M)
        {
            cnt++;
            N -= M;
        }
        quotient = cnt;
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
        answer += 10;
        double dayly = 10;
        for (int i = 2; i<=7; i++)
        {
            dayly *= 1.1;
            answer += dayly;
        }
        // end
        answer = Math.Round(answer,2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        answer += 1;
        double dayly = 10;
        double Allway = 10;
        do
        {
            dayly *= 1.1;
            Allway += dayly;
            answer += 1;
        }
        while (Allway < 100);

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        answer += 0;
        double dayly = 10;
        while (dayly<=20)
        {
            dayly *= 1.1;
            answer += 1;
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
        while (L>Math.Pow(10, -10))    //Math.Pow здесь нужно, чтобы не писать кучу десяток
        {
            L /= 2;
            answer += 1;
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
        y = Math.Pow(Math.E, Math.Cos(x))* Math.Cos(Math.Sin(x));
        S += 1;
        int i = 1;
        int i_fact = 1;
        while (Math.Abs(Math.Cos(i*x)/i_fact)>=0.0001)
        {
            S += Math.Cos(i * x) / i_fact;
            i++;
            i_fact *= i;
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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