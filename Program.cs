using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

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
        //program.Task_2_2());
        program.Task_2_3(1, 1, 10);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        program.Task_2_9();
        //program.Task_2_10();
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

        // code here
        int s = 0;
        for (int i = 2;i <= 35;i = i + 3)
        {
            s = s + i;
        }
        answer = s;

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        for (double i = 1;i <= 10; i++)
        {
            answer = answer + 1/i;
        }
        answer = Math.Round(answer, 2);

        // code here

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        double i = 2;
        while(i <= 112)
        {
            answer = answer + (i / (i + 1));
            i++;
        }
        answer = Math.Round(answer, 2);

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }

        double xn = 1;
        for (double i = 0;i <= 8; i++)
        {
            answer = answer + (Math.Cos((x * (i + 1))) / xn);
            xn = xn * x;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        double phn = p;
        for (int i = 0;i <= 9; i++)
        {
            answer = answer + phn*phn;
            phn = phn + h;
        }
        answer = Math.Round(answer, 4);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5*x*x-7*x;
        //for (double i = -4;i <= 4;i = i + 0.5)
        //{
            //double s = 0.5 * i * i - 7 * i;
            //Console.WriteLine($"{i:f1}    {s}");
        


        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1;i <=6; i++)
        {
            answer = answer * i;
        }

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        int fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact = fact *i;
            answer = answer + fact;
        }

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double fivest = 1;
        double fct = 1;
        double p = 1;
        for (int i = 1;i <= 6; i++)
        {
            
            p = -p;
            fivest *= 5;
            fct *= i;
            answer += p * fivest / fct;
        }
        answer = Math.Round(answer, 2);
        // code here;

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        for (int i = 1;i <= 7; i++)
        {
            answer *= 3;
        }

        // code here

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string s1 = "";
        for (int i = 1;i <=6 ; i++)
        {
            s1 = s1 + (Convert.ToString(i)) + " ";
        }
        string s2 = "";
        for (int i = 1; i <= 6; i++)
        {
            s2 = s2 + (Convert.ToString(5)) + " ";
        }
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        
        double xn = 1;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 0;i <= 10; i++)
        {
            answer += 1/xn;
            xn *= x;
        }

        // end
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
       
            if (x <= -1)
            {
                answer = 1;
            }
            if (x > 1)
            {
            answer = -1;
            }
            if ((x <= -1) && (x > 1))
            {
            answer = -x;
            }
        
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        string s = "1";
        int s1 = 1;
        int s2 = 1;
        int s3 = 1;
        for (int i = 1;i <= 7; i++)
        {
            s3 = s2;
            s2 = s2 + s1;
            s1 = s3;
            s = s + " " + Convert.ToString(s1);
        }
        Console.WriteLine(s);

    }
    public double Task_1_15()
    {
        double answer = 0;
        double ch1 = 1; double ch2 = 2;double ch3 = 1;
        double zn1 = 1; double zn2 = 1;double zn3 = 1;
        for (int i = 1;i <= 3; i++)
        {
            ch3 = ch2 + ch1;
            ch1 = ch2;
            ch2 = ch3;
            zn3 = zn2 + zn1;
            zn1 = zn2;
            zn2 = zn3;
        }
        answer = ch3 / zn3;
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double sum = 0;
        int power = 0;
        double k = 1;
        for (int i = 1;i <= 64; i++)
        {
            sum = sum + k;
            k = k * 2;
            if (sum > 1000)
            {
                sum = sum / 10;
                power++;
            }
        }
        answer = sum/15;
        answer = Math.Round(answer, 4);
        Console.WriteLine(answer);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        double i = x;
       
            answer = (r + i) * (r + i) - r * r;
            answer = Math.Round(Math.Sqrt(answer),4);
            Console.WriteLine(Convert.ToString(i) + " " + Convert.ToString(answer));

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 3; i <= x;i = i + 3)
        {
            answer *= 2;
            Console.WriteLine(Convert.ToString(i) + " " + Convert.ToString(answer));
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
        double n = 1;
        double slag=0;
        while (true)
        {
            slag = Math.Cos(n * x) / n / n;
            if (slag < 0.0001)
            {
                break;
            }
            answer += slag;
            n++;
        }

        // end
        //answer = Math.Round(answer, 4);
        Console.WriteLine(Convert.ToString(answer));
        return answer;
    }
    public int Task_2_2() { 
        int answer = 0;

        // code here
        //int p = 1;
        //int n = 1;
        //while (p <= 30000)
        //{
            //n = n + 3;
            //p = p * n;
        //
       // answer = n - 3;



        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;
        double s = 0;
        double ah = a;
        while (true)
        {
            s += ah;
            ah = ah + h;
            if (s <= p)
            {
                answer++;
            }
            else
            {
                break;
            }
            if (answer > 10000)
            {
                return 0;
            }
        }
        // code here

        // end
        Console.WriteLine(answer);
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

        int big;
        int small;
        if (N > M)
        {
            big = N;
            small = M;
        }
        else
        {
            small = N;
            big = M;
        }
        while (big >= small)
        {
            big -= small;
            quotient++;
        }
        remainder = big;

        
        Console.WriteLine(quotient);
        Console.WriteLine(remainder);
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
        double norma = 10;
        // code here
        for (int i = 1;i <= 7; i++)
        {
            answer += norma;
            norma = 1.1 * norma;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 0;
        double norma = 10;
        while (s < 100)
        {
            s += norma;
            norma *= 1.1;
            answer++;
            if (s >= 100)
            {
                break;
            }
        }
        // code here

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double norma = 10;
        while (true)
        {
            if (norma > 20)
            {
                break;
            }
            else
            {

                answer++;
                norma *= 1.1;
            }
        }
            // code here

            // end
            Console.WriteLine(answer);
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
        double atom = 1;
        for (int i = 1; i <= 10; i++)
        {
            atom = atom / 10;
        }
        double l = 0.1;
        while (true)
        {
            if (atom >= l)
            {
                break;
            }
            answer++;
            l = l / 2;
        }
        // code here;

        // end
        Console.WriteLine(answer);
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
    public (double, double) Task_3_3(double t)
    {
        double S = 0, y = 0;
        for (double x = 0.1; x <= 1; x = x + 0.1)
        {
            S = 1; y = 0;
            double zn = 1, ch = 1;
            for (double i = 1; ; i++)
            {
                zn = zn * i;
                ch = Math.Cos(i * x);
                if (ch/zn < 0.0001){
                break;
                 }
                S += (ch / zn);
            }
            y = (Math.Pow(Math.E,Math.Cos(x))) * Math.Cos(Math.Sin(x));
            //y = Math.Round(y,4);
            //S = Math.Round(S,4);  
            //x = Math.Round(x,4);
            Console.WriteLine($"{x:f1} {y} {S}");
        }

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