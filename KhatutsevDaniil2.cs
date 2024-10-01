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
        //for (double x = -4.0; x < 4.1; x += 0.5)
        //{
        //Console.WriteLine(program.Task_1_6(x));
        //}
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0);
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
        //program.Task_3_7(1);
        for (double x = 0.1; x <= 1.0; x += 0.05)
        {
            program.Task_3_7(x);
        }
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here

        for (int n = 2; n < 36; n += 3)
        {
            answer += n;
        }

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        for(double n = 1; n < 11; n++)
        {   

            answer += 1 / n;
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        for (double n = 3; n < 114; n += 2)
        {
            answer += (n-1) / n;
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        double curr_znam = 1.0;

        for (int n = 1; n < 10 && x != 0; n++)
        {
            answer += (double) Math.Cos(x * n) / curr_znam;
            curr_znam *= x;
            
        }

        answer = Math.Round(answer, 2);

        // ends

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        for (double n = 0; n < 10; n++)
        {
            double curr_znach = (p + n * h);
            answer += curr_znach * curr_znach;
        }

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        answer = 0.5 * x * x - 7 * x;

        // end 

        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here

        int fact = 1;
        for (int n = 1; n < 7; n++)
        {
            fact *= n;
        }
        answer = fact;

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        int fact = 1;
        for (int n = 1; n < 7; n++)
        {
            fact *= n;
            answer += fact;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        int fact = 1;
        int curr_zhac_1 = -1;
        int curr_zhch_5 = 5;
        for (int n = 1; n < 7; n++)
        {
            fact *= n;
            answer += (double)curr_zhac_1 * curr_zhch_5 / fact;
            curr_zhac_1 *= -1;
            curr_zhch_5 *= 5;
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        answer = 3;
        for (int n = 0; n < 6; n++)
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

        for (int n = 1; n < 7; n++)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine();
        for (int n = 1; n < 7; n++)
        {
            Console.Write("{0} ", 5);
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

        double curr_znam = 1;

        for (int n = 0; n < 11 && x != 0; n++)
        {
            answer += 1 / curr_znam;
            curr_znam *= x;
        }

        answer = Math.Round(answer, 2);

        // end

        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        if (x < -1)
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

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int prew = 1, curr = 1;

        for (int n = 0; n < 8; n++)
        {
            Console.Write("{0} ", prew);
            int tempcurr = curr + prew;
            prew = curr;
            curr = tempcurr;
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        int prewc = 1, prewz = 1, currc = 2, currz = 1;

        for (int n = 0; n < 5; n++)
        {
            answer = (double)prewc / prewz;
            int tempc = currc + prewc;
            int tempz = currz + prewz;
            prewc = currc;
            prewz = currz;
            currc = tempc;
            currz = tempz;
        }

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        double cz = 0.0;
        double currzeren = 1.0 / 15.0;

        for (int n = 1; n < 64; n++)
        {
            currzeren *= 2;
            cz += currzeren;
        }

        answer = cz;

        while (answer > 9.9)
        {
            power++;
            answer /= 10;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);


        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        int r = 6350;

        answer = Math.Sqrt((r + x) * (r + x) - (r * r));
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

        for (int n = 3; n < x + 1; n += 3)
        {
            answer *= 2;
        }

        // end

        Console.WriteLine(answer);

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

        int ymn = 1, start = 1;

        while ((ymn * start) < 30000) 
        {
            ymn *= start;
            start += 3;
        }

        answer = start - 3;
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

        double currx = 1.0;
        double res = 0.0;

        while (currx > 0.0001 && currx != 0.0 && x != 1)
        {
            res += currx;
            currx *= (x * x);
        }

        answer = Math.Round(res, 2);

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

        int colvo = 10;

        while (colvo < 100000)
        {
            colvo *= 2;
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

        double count = 10000;

        while (count < 20000)
        {
            answer++;
            count *= 1.08;
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

        // code here;

        int prewc = 1, prewz = 1, currc = 2, currz = 1;
        double prewd = (double)prewc / prewz;
        double currd = (double)currc / currz;

        answer += 2;
        // потому что первые два элемента не в цикле

        //Console.WriteLine("{0} {1}", prewd, currd);
        do
        {
            int tempc = currc + prewc;
            int tempz = currz + prewz;
            prewc = currc;
            prewz = currz;
            currc = tempc;
            currz = tempz;
            prewd = (double)prewc / prewz;
            currd = (double)currc / currz;
            answer++;
            //Console.WriteLine("{0} {1}", prewd, currd);
        } while (Math.Abs(currd - prewd) > 0.001);

        // end

        Console.WriteLine(answer);
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

        double e = 2.71828;
        double currfact = 1.0;
        double currpow = 1.0;

        y = (Math.Pow(e, x) + Math.Pow(e, (-x))) / 2;

        for (int i = 0; i <= 10000000; i++)
        {

            currpow *= x * x;
            currfact *= (2 * i) * (2 * i - 1);

            double currplus = currpow / currfact;

            if (Math.Abs(currplus) < 0.0001)
            {
                break;
            }
            else
            {
                S += currplus;
            }
                

        }

        S = Math.Round(S, 4);
        y = Math.Round(y, 4);

        // end

        Console.WriteLine("{0} {1}", S, y);

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