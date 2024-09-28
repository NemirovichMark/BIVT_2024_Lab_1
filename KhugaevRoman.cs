using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

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
        //program.Task_1_13(0);
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
        program.Task_3_2(0.1);
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
        int answer = 0,i = 2;
        for (; i <= 35; i+=3)
        {
            answer+=i;
            Console.WriteLine($"a = {answer}, i = {i}");

        }

        // code here

        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0, i = 1;
        for (; i <= 10; i ++)
        {
            answer += 1/i;
            Console.WriteLine($"a = {answer}, i = {i}");

        }

        // code here

        Console.WriteLine(Math.Round(answer, 3));

        return Math.Round(answer,3);
    }
    public double Task_1_3()
    {
        double answer = 0, i = 2;
        for (; i <= 112; i +=2)
        {
            answer += i/(i+1);
            Console.WriteLine($"a = {answer}, i = {i}");

        }

        // code here

        Console.WriteLine(Math.Round(answer, 4));

        return Math.Round(answer, 4);
    }
    public double Task_1_4(double x)
    {
        double answer = 0, i = 1, j = 1;
        for (; i <= 9; i++)
        {
            if (x != 0)
            {
                //j должна быть равна x в степени i - 1
                answer += Math.Cos(x * i) / j;
                j *= x;
            }
            
            Console.WriteLine($"a = {answer}, i = {i}");

        }

        // code here

        Console.WriteLine(Math.Round(answer, 4));

        return Math.Round(answer, 4);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0, i = 0;
        for (; i <= 9; i++)
        {
            answer += (p + i * h)* (p + i * h);
            Console.WriteLine($"a = {answer}, i = {i}");

        }

        // code here

        Console.WriteLine(Math.Round(answer, 3));

        return Math.Round(answer, 3);
    }
    public double Task_1_6(double x)
    {
        //Далее код через массивы - БАН
        /* 
        double answer = 0;
        int count = 0, count2 = 0;

        //считаем сколько нам понадобится места под ответы в массиве
        for (double i = -4; i <= 4; i += 0.5)
        { count += 1; }

        // создаем массив с ответами
        double[] a = new double[count];

        //Добавляем ответы в массив
        for (double i = -4; i <= 4; i += 0.5)
        {
            a[count2] = (0.5 * i * i - 7 * i);
            count2++;

        }

        //Преобразуем х в id нужного ответа в массиве, увеличив его в два раза получив от -8 до 8, а затем прибавив 8, от 0 до 16
        x = x * 2 + 8;
        //Массив принимает только int, поэтому преобразуем double в int
        int x2 = (int)x;
        Console.WriteLine(x2);
        return a[x2];
        */

        ////Далее цикл для защиты

        //for (double i = -4; i <= 4; i += 0.5)
        //{
        //    Console.WriteLine((0.5 * (i * i) - (7 * i)));

        //}

        return (0.5 * x * x - 7 * x);

    }
    public int Task_1_7()
    {
        int answer = 1, i = 6;
        for (int j = 1; j <= i; j++)
        {
            answer *= j;
            Console.WriteLine($"a = {answer}, j = {j}");

        }
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        for (int i = 1,dop_a = 1; i <= 6; i++)
        { 
            for (int j = 1; j <= i; j++)
            {
                dop_a *= j;
                Console.WriteLine(dop_a);

            }
            answer += dop_a;
            dop_a = 1;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, i = 1;

        for (double j = 5,k=0,facktorial = 1; i <= 6; i++)
        {
            for (int r = 1; r <= i; r++)
            {
                facktorial *= r;

            }

            if (i % 2 == 0)
            {
                k = 1;
            }
            else
                { k = -1; }
            answer += (k * j)/ facktorial;
            j *= 5;
            facktorial = 1;

        }

        return Math.Round(answer, 4);
    }
    public int Task_1_10()
    {
        int answer = 1;

        for(int i = 1;i<=7; i++)
        {
            answer *= 3;
            Console.WriteLine(answer);
        }

        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++)
        {          
            Console.Write(i + " ");
        }

        Console.WriteLine(" ");

        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        for (double i = 1, x2 = 0; i <= 10; i++)
        {
            Console.WriteLine($"a = {answer}, x1 = {x2}");
            for (double stepen = 1, x1 = 1; stepen <= i; stepen++)
            {
                x1 *= x;
                Console.WriteLine($"krug {stepen}, x1 = {x1}");
                x2 = x1;
            }
            if (x2 != 0)
            {
                answer += 1 / x2;
            }
            else
            {
                return answer = 0;
            }


        }
        Console.WriteLine(answer);
        if (answer != 0)
        { 
            return Math.Round(answer, 4);
        }
        else
        { 
            return answer;
        }
    }

    public double Task_1_13(double x)
    {
        double answer = 0;


        for (double i = -1.5; i <= 1.5; i += 0.1)
        {
            if (i <= -1)
            {
                Console.WriteLine("1");
            }
            else if (i > 1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                // В этой строчке я вначале умножаю на -1, затем округляю до одного знака и затем конвертирую в стринг
                string i_str = Math.Round((-1 * i), 1).ToString();
                Console.WriteLine(i_str);
            }


        }

        if (x <= -1)
        {
            return 1;
        }
        else if (x > 1)
        {
            return -1;
        }
        else
        {
            return (-1 * x);
        }

        

        ////Далее цикл для защиты



    }
    public void Task_1_14()
    {
        //// Число Фибоначчи - решение через тупость
        //int first = 1, second = 1;
        //int third = first + second;
        //int fourth = second + third;
        //int fifth = third + fourth;
        //int sixth = fourth + fifth;
        //int seventh = fifth + sixth;
        //int eight = sixth + seventh;
        //Console.WriteLine(first.ToString());
        //Console.WriteLine(second.ToString());
        //Console.WriteLine(third.ToString());
        //Console.WriteLine(fourth.ToString());
        //Console.WriteLine(fifth.ToString());
        //Console.WriteLine(sixth.ToString());
        //Console.WriteLine(seventh.ToString());
        //Console.WriteLine(eight.ToString());

        // Число Фибоначчи - решение через цикл

        Console.WriteLine("1");
        Console.WriteLine("1");
        for (int i = 2, first = 1, second = 1; i < 8; i ++)
        {
            Console.WriteLine((first + second).ToString());

            second = first + second;
            first = second - first;

        }
    }
    public double Task_1_15()
    {
        //Проанализировав задание, мы понимаем, что и числитель и знаменатель являются числами Фибоначчи, только для: знаменателя = число Фибоначчи (F), числитель = число Фибоначчи (F+1)

        int answer = 1;
        int zn = 1, ch = 1;

        //Знаменатель
        for (int i = 2, first = 1; i < 5; i ++ )
        {

            zn = first + zn;
            first = zn - first;

        }

        //Числитель
        for (int i = 2, first = 1; i < (5+1); i ++)
        {

            ch = first + ch;
            first = ch - first;

        }
        Console.WriteLine($"{ch}/{zn}");
        double zn_d = zn, ch_d = ch;
        return ch_d/zn_d;
    }
    public (double, int) Task_1_16()
    {
        //Сумма зерен на 64 клетках равна колву зерен на 65 клетках минус 1.
        double answer = 1;
        int power = 0;
        double zerno = 1;
        for (int i = 2; i <= 65; i +=1)
        {
            zerno *= 2;
            answer += zerno;
        }
        //cколько весят все зерна
        answer = (zerno - 1)/15;

        //длина числа, из которой нужно вычесть 4 (знак до запятой, запятая, два знака после запятой)
        int len = answer.ToString().Length;


        power = len - 4;
        Console.WriteLine(power);
        
        answer = answer/Math.Pow(10,18);
        answer = Math.Round(answer, 2);


        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0, Rad = 6350;

        answer = (Rad + x) * (Rad + x) - (Rad * Rad);
        answer = Math.Sqrt(answer);

        //for (double i = 1; i < 10; i++)
        //{
        //    answer = (Rad+i) * (Rad + i)-(Rad*Rad);
        //    answer = Math.Sqrt(answer);
        //    Console.WriteLine(i + "             km = " + Math.Round(answer, 4));
        //}
        Console.WriteLine(Math.Round(answer, 4));
        return Math.Round(answer, 4);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        //узнаем сколько раз клетки делились
        x = (x / 3);

        //узнаем 2 в cтепени того, сколько раз клетки делились, ибо колво амёб умножается на два каждый час, значит нужно узнать во сколько раз их стало больше за всё время
        double i = x;
        i = Math.Pow(2,i);
        x = Convert.ToInt32(i);


        return answer * x;
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
        int p = 1, n = 4;
        //Я прямо в цикле пишу L/n, так как когда р будет уже больше 30000, будет поздно, значит, надо сыграть на опережение и сделать так, чтобы цикл закончился на шаге до 30000
        for (int L = 30000; p <= L/n; n += 3)
        {  
            p *= n;
            Console.WriteLine(p + "  -  " + n);
        }
        //Несмотря на то, что мы закончили цикл, он прибавил к n один лишний шаг, до обрывания.
        return n -3;
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
        //Проверяем условие на выполнение
        if ((x >= 1) || (x <= -1))
        {
            return 0;
        }

        //Проверяем, что члены прогрессиии действительно будут уменьшаться
        else if (x == 0)
        {
            return 1;
        }


        double n = 1, s = 1;

        for (double L = 0.0001; Math.Pow(x, 2*n) >= L; n ++)
        {
            s += Math.Pow(x, 2 * n);
            Console.WriteLine(s+"  -  " + Math.Pow(x, 2 * n));
        }


        return Math.Round(s, 4);
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
        //Вопрос задачи по факту звучит так: 2 в какой степени (делёной на 3), будет при умножении на 10 давать 10**5?
        //Для начала отбросим 10
        //нам нужен логарифм 2 10**4 => логарифм 10000 по основанию 2
        //Такого логарифма нет, однако ответ, согласно тестам обязан быть целым - следовательно нужно найти ближайшее целое значение дающее больше 10000.
        double n = 1;
        
        for (; Math.Pow(2, n) <= 10000; n++)
        {
            Console.WriteLine(Math.Pow(2, n));
        }

        int i = Convert.ToInt32(n);
        return i*3;
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
        int mec = 0;

        //ежемесячно вклад становится больше на 1.08. Используется сложный процент.
        for (double L = 10000; L < 20000; mec++)
        {
            L *= 1.08;
            Console.WriteLine(L);
        }

    
        return mec;
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
        //Проанализировав задание, мы понимаем, что и числитель и знаменатель являются числами Фибоначчи, только для: знаменателя = число Фибоначчи (F), числитель = число Фибоначчи (F+1)

        int answer = 1;
        double zn = 1, ch = 2;
        double drob1 = 3, drob2 = 4;
        double i = 1;

        for (double first = 1; Math.Abs(drob1-drob2)>0.001;i++)
        {
            //В этом ряду мы используем знаменатель как часть ряда числителя
            ch = zn + ch;
            zn = ch - zn;
            first = zn - first;

            Console.WriteLine($"{ch}/{zn}");
            drob2 = ch / zn;

            drob1 = zn / first;
            Console.WriteLine("raznic " + (drob1 - drob2));
            Console.WriteLine("1 " + drob1);
            Console.WriteLine("2 " + drob2);
            Console.WriteLine(i);
        }
        
        int i_i = Convert.ToInt32(i);

        //В цикле мы пропустили 2 первых дроби, однако цикл прокрутился на одну больше чем нуджно, следовательно, прибавив еденицу к ответу мы его получим
        return i_i+1;
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

        double i = 1, proverka = Math.Pow(x, i), fact = 1;
        for (; Math.Abs(proverka) > 0.0001; i++)
        {
            proverka = Math.Pow(x, i);
            S += proverka * Math.Sin(i*Math.PI/4);
            y = (x* Math.Sin(Math.PI / 4)) / (1-2*x*(Math.Cos(Math.PI / 4))+x*x);
            Console.WriteLine($"Sum: {S}, elem: {proverka} fact: {fact}");
        }
    

        return (S,y);
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