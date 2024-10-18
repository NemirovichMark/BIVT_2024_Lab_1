using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //double x = double.Parse(Console.ReadLine());
        //double y = double.Parse(Console.ReadLine());
        //program.Task_1_1(x, y);
        //double x = double.Parse(Console.ReadLine());
        //double y = double.Parse(Console.ReadLine());
        //program.Task_1_2(x, y);
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //program.Task_1_3(a, b);
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());
        //program.Task_1_4(a, b, c);
        //double r = double.Parse(Console.ReadLine());
        //double s = double.Parse(Console.ReadLine());
        //program.Task_1_5(r, s);
        //double r = double.Parse(Console.ReadLine());
        //double s = double.Parse(Console.ReadLine());
        //program.Task_1_6(r, s);
        //double x = double.Parse(Console.ReadLine());
        //program.Task_1_7(x);
        //double x = double.Parse(Console.ReadLine());
        //program.Task_1_8(x);
        //double x = double.Parse(Console.ReadLine());
        //program.Task_1_9(x);
        //double x = double.Parse(Console.ReadLine());
        //program.Task_1_10(x);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //double r = double.Parse(Console.ReadLine());
        //int type = int.Parse(Console.ReadLine());
        //program.Task_2_12(r, type);
        //double A = double.Parse(Console.ReadLine());
        //double B = double.Parse(Console.ReadLine());
        //int type = int.Parse(Console.ReadLine());
        //program.Task_2_13(A, B, type);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 3);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        const double r = 2;
        if (Math.Abs(x * x + y*y - r * r) <= 0.001)
        {
            answer = true;
            Console.WriteLine("Точка лежит на окружности", answer);
        }
        else
        {
            answer = false;
            Console.WriteLine("Точка не лежит на окружности", answer);
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x)<= 1))
        {
            answer = true;
            Console.WriteLine("Точка принадлежит фигуре", answer);
        }
        else
        {
            answer = false;
            Console.WriteLine("Точка не принадлежит фигуре", answer);
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }

        }
        if (a <= 0)
        {
            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (a > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        else
        {
            if (b > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d1 = 2 * Math.Sqrt((r / Math.PI)), d2 = Math.Sqrt(2 * s);
        if (d2 <= d1)
        {
            answer = true;
            Console.WriteLine("Квадрат помещается в круг", answer);
        }
        else
        {
            answer = false;
            Console.WriteLine("Квадрат не помещается в круг", answer);
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d1 = 2 * Math.Sqrt((r / Math.PI)), d2 = Math.Sqrt(s);
        if (d2 >= d1)
        {
            answer = true;
            Console.WriteLine("Круг помещается в квадрате", answer);
        }
        else
        {
            answer = false;
            Console.WriteLine("Круг не помещается в квадрате", answer);
        }
            // end

            return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        Console.WriteLine($"y = {answer}");
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        Console.WriteLine($"y = {answer}");
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 0;
        }
        else if(-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1;
        }
        Console.WriteLine($"y = {answer}");
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= - 1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        Console.WriteLine($"y = {answer}");
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double s = 0, averagehight, r;
        for (int i = 1; i <= n; i++)
        {
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        averagehight = s / n;
        answer = averagehight;
        Console.WriteLine($"Средний рост равен {answer}");

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double k = 0, x, y;
        for(double i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if(Math.Abs((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                k++;
            }
        }
        Console.WriteLine($"В круг попало {k} из {n}");
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double k = 0, weight;
        for (double i = 1; i <= n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                k += 200;
            }
        }
        Console.WriteLine($"Ежедневно, для одного класса учеников, состоящего из {n} человек, потребутся {k / 1000}л. молока ");
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double k = 0, x, y;
        for (double i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Abs(x * x + y * y) <= r2 * r2 && (Math.Abs(x * x + y * y) <= r1 * r1) == false)
            {
                k++;
            }
        }
        Console.WriteLine($"В кольцо попало {k} из {n}");
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double k = 0, sc;
        for(double i = 1; i <= n; i++)
        {
            sc = double.Parse(Console.ReadLine());
            if (sc < norm)
            {
                k++;
            }
        }
        Console.WriteLine(k);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        int k = 0;
        for(int i = 1; i <= n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine(answer);
        // end ???

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for(int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        Console.WriteLine($"Кол. Точек Квадранта 1 = {answer1}, а кол. точек Квадранта 3 = {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double c;
        for(int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            c = Math.Sqrt(x * x + y * y);
            if(c < answerLength)
            {
                answer = i;
                answerLength = Math.Round(c, 2);
            }

        }
        Console.WriteLine($"{answer} {answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double sc;
        for(double i = 1; i <= n; i++ )
        {
            sc = double.Parse(Console.ReadLine());
            if (sc < answer)
            {
                answer = sc;
            }

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double r1, r2, r3, r4, k = 0;
        for(int i = 1; i<= n; i++)
        {
            r1 = double.Parse(Console.ReadLine());
            r2 = double.Parse(Console.ReadLine());
            r3 = double.Parse(Console.ReadLine());
            r4 = double.Parse(Console.ReadLine());
            if(r1 > 3 && r2 > 3 && r3 > 3 && r4 > 3)
            {
                k++;
            }
        }
        Console.WriteLine($"Всего {k} из {n} учеников имеют хорошие оценки, куда смотрит наше образование!?");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double er1, er2, er3, er4, a = 0;
        int k = 0;
        for(double i = 1; i<= n; i++)
        {
            er1 = double.Parse(Console.ReadLine());
            er2 = double.Parse(Console.ReadLine());
            er3 = double.Parse(Console.ReadLine());
            er4 = double.Parse(Console.ReadLine());
            if (er1 < 3 || er2 < 3 || er3 < 3 || er4 < 3)
            {
                k++;
            }
            a += er1 + er2 + er3 + er4;
        }
        answer = k;
        avg = Math.Round(a / (n * 4), 9);
        Console.WriteLine($"Количество неуспевающих равно {answer}, а средний балл по группе равен {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round(r * r, 2);
                    break;
                case 1:
                    answer = Math.Round(Math.PI * r * r, 2);
                    break;
                case 2:
                    answer = Math.Round((Math.Sqrt(3) * r * r) / 4, 2);
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        Console.WriteLine($"Площаль равна - {answer}");
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round(A * B, 2);
                    break;
                case 1:
                    if (A > B)
                    {
                        answer = Math.Round((Math.PI * A * A) - (Math.PI * B * B), 2);
                        break;
                    }
                    else
                    {
                        answer = Math.Round((Math.PI * B * B) - (Math.PI * A * A), 2);
                        break;
                    }
                case 2:
                    answer = Math.Round(0.5 * A * Math.Sqrt((B * B - (A / 2) * (A / 2))), 2);
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        Console.WriteLine($"Площаль равна: {answer}");
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        double s = 0, averagehight, r;
        for(; ;n++)
        {
            double.TryParse(Console.ReadLine(), out r);
            if (r <= 0) break;
            else
            s += r;
        }
        averagehight = s / n;
        answer = Math.Round(averagehight, 2);
        Console.WriteLine($"Средний рост равен {answer}");
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        double k = 0, x, y, i = 0;
        string input;
        while(true)
        {
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out x);
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out y);
            n += 1;
            if (Math.Abs(x * x + y * y) <= r2 * r2 && (Math.Abs(x * x + y * y) <= r1 * r1) == false) k += 1;
        }
        Console.WriteLine($"В кольцо попало {k} из {n}");
        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x, y;
        string input;
        while(true)
        {
            input = Console.ReadLine();
            if(input == "stop") break;
            double.TryParse(input, out x);
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out y);
            if (x > 0 && y > 0)
            {
                answer1++;
            }
            if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        Console.WriteLine($"Кол. Точек Квадранта 1 = {answer1}, а кол. точек Квадранта 3 = {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        double r1, r2, r3, r4, k = 0;
        string input;
        while(true)
        {
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out r1);
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out r2);
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out r3);
            input = Console.ReadLine();
            if (input == "stop") break;
            double.TryParse(input, out r4);
            if (r1 > 3 && r2 > 3 && r3 > 3 && r4 > 3)
            {
                k++;
            }
            n++;
        }
        Console.WriteLine($"Всего {k} из {n} учеников имеют хорошие оценки, куда смотрит наше образование!?");
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}