using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
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

        //double x=-4;
        //while (x <= 4)
        //{
        //    program.Task_1_6(4);
        //    x += 0.5;
        //}

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

        for (int i = 2; i <= 35; i += 3)
        {
            answer = answer + i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1.0; i <= 10.0; i += 1.0)
        {
            double slagaemoe = 0.0;
            slagaemoe = 1 / i;
            answer = answer + slagaemoe;
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(int i = 2; i <= 112; i += 2)
	    {

            answer = answer + i / (i + 1.0);
        }
        Console.WriteLine(answer);
        answer = Math.Round(answer, 0);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a;
        answer = Math.Cos(x);
        double y = 1; // знаменатель
        for (int i = 2; i <= 9; i++)
        {
            if (x == 0)
            {
                return 0;
            }
            y = y * x;
            a = Math.Cos(i * x) / y;
            answer = answer + a;
            

        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            answer = answer + (p + i * h) * (p + i * h);

        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        //code here
        return Math.Round(0.5 * Math.Pow(x, 2) - 7 * x, 2);

        //const double xh = -4.0, xk = 4.0, h = 0.5;

        //int i, n;
        //n = (int)((xk - xh) / h + 1);
        //x = xh;
        //for (i = 1; i <= n; i = i + 1)
        //{
        //    answer = 0.5 * Math.Pow(x, 2) - 7 * x;
        //    Console.WriteLine("x = {0:f2}\ty = {1:f2}", x, answer);
        //    x = x + h;
        //}
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int j = 1; j <= 6; j++)
        {
            answer = answer * j;
        }

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; i += 1)
        {
            int f = 1;
            for (int j = 1; j <= i; j++)
            {
                f = f * j;
            }
            answer = answer + f;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f = 1;
        double chislitel1 = -1;
        double chislitel2 = 5;
        for (int i = 1; i <= 6; i++)
        {
            answer = answer + chislitel1 * chislitel2 / f;
            chislitel1 = -chislitel1;
            chislitel2 = chislitel2 * 5;
            f = f * (i + 1);
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        
        //  answer = answer + (Math.Pow(-1, i) * Math.Pow(5, i)) / f;

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 1; i < 7; i += 1)
        {

            answer = answer * 3;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        Console.Write("a) ");
        for (int i = 1; i <= 6; i++)
        {
            if (i < 6)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(i + ",\n");
            }
        }
        Console.Write("b) ");
        for (int i = 1; i <= 6; i++)
        {
            if (i != 6)
            {
                Console.Write(5 + " ");
            }
            else
            {
                Console.Write(5 + ".");
            }
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        answer = 1;
        double y = x;

        for (int i = 0; i < 10; i++)
        {
            
            if (x == 0)
            {
                return 0;
            }
            
            answer = answer + (1 / x);
            x = y * x;

        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for(double i = -1.5; i <= 1.5; i += 0.1)
        {
            if (x <= -1)
            {
                return 1;
            } else if (x>-1 && x <= 1)
            {
                return -x;
            }
            else
            {
                return -1;
            }
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here

        int x = 1, x1 = 1, x2 = 1;
        for (int j = 1; j <= 8; j++)
        {
            if (j >= 3)
            {
                x = x1 + x2;
                x1 = x2;
                x2 = x;
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
            }

        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        // ch и zn образуют дробь, с которой дальше проходят операции
        int ch = 1, ch1 = 1, ch2 = 2;
        int zn = 1, zn1 = 1, zn2 = 1;
        for (int i = 1; i <= 5; i++)
        {
            if (i < 3)
            {
                Console.WriteLine((double)i / 1);
            }
            else if (i <= 5)
            {
                ch = ch1 + ch2;
                ch1 = ch2;
                ch2 = ch;

                zn = zn1 + zn2;
                zn1 = zn2;
                zn2 = zn;

                Console.WriteLine($"{ch}/{zn}");
            }
            if (i==5)
            {
                answer = (double)ch/zn;
            }

        }

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double s = 1;
        double newkletka = 1;

        // code here
        //64 поля в шахматной доске
        for (int i = 1; i <= 64; i++)
        {
            s = s + newkletka;
            newkletka = newkletka * 2;


        }
        Console.WriteLine(newkletka);
        Console.WriteLine(s);
        answer = s / 15;
        
        while (answer > 10)
        {
            answer = answer / 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        int r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer =10;
        for(int i = 3; i <= x; i += 1)
        {
            if (i % 3 == 0)
            {
                answer = answer * 2;
                
            }
        }
        //end

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

        int n = 4;
        int p = 1;
        for (int i = n; i < 10000; i += 3) //абстрактное число, до которого будет точно найден ответ
        {
            if (p * i < 30000)
            {
                p = p * i;
                n = i;
            }

            else
            {
                answer = n;
                break;
            }
        }
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
        double y = x;

        //// code here

        answer = 1;
        if (Math.Abs(x) >= 1)
        {
            return 0;
        }

        for (int i = 0; Math.Abs(x) >= 0.0001; i++)
        {

            x = y * x;
            if (i % 2 == 0)
            {
                answer = answer + x;
            }

        }

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
        int answer = 0;

        // code here

        int kletki = 10;
        int i = 0;
        do
        {
            i += 3;
            if (i % 3 == 0)
            {
                kletki = kletki * 2;
            }
            
        } while (kletki < 100000);
        answer = i;

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
        double sum = 10000;
        double nachsum = 10000;
        double r =1 + 0.08;
        int time = 0;

        do
        {
            time += 1;
            sum = sum * r;
            Console.WriteLine($"year {time} summa {sum}");
        } while (sum < 2 * nachsum);
        answer = time;
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

        // code here

        int ch = 1, ch1 = 1, ch2 = 2;
        int zn = 1, zn1 = 1, zn2 = 1;
        double prevdrob = 0; 
        double newdrob = 0;
        double raznitsa = 0;
        int i = 2; // так как по условию уже даны первые 2 числа, 
        //следующее число уже будет третьим
        do
        {
            i += 1;
            prevdrob = (double)ch / zn;

            ch = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch;

            zn = zn1 + zn2;
            zn1 = zn2;
            zn2 = zn;
            newdrob = (double)ch / zn;
            raznitsa = newdrob - prevdrob;
        } while (Math.Abs(raznitsa) > 0.001);
        answer = i;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        int p = 1; // первый множитель
        double f = 1; //факториал
        int i = 0;
        const double e = 0.0001;
        double xpow = 1;
        double slagaemoe = p * xpow / f;

        y = Math.Cos(x);

        while (Math.Abs(slagaemoe) >= e)
        {
            S = S + slagaemoe;
            i++;
            p = -p; //меняется на противоположное
            xpow = xpow * x * x;
            f = f * (2 * i - 1) * (2 * i); //считается следующий факториал
            slagaemoe = p * xpow / f;
            
        }

        S = Math.Round(S, 2);
        y = Math.Round(y, 2);

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