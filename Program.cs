using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

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
        program.Task_1_6(-4);
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
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        program.Task_3_1(0.1);
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
        int summ = 0;
        for (int i = 2; i <= 35; i += 3)
            summ += i;
        answer = summ;

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        

        // code here
        double summ = 1.0;


        for (int i = 2; i <= 10; i++)
            summ += 1.0 / i;
        answer = Math.Round(summ, 2);


        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        

        // code here
        double summ = 0;
       
        for (int i = 2; i <= 112; i += 2)
            summ += i / (i + 1.0);
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double summ = 0, y = 1;
        int i = 1;
        if (x == 0)
            return 0;
        while (i <= 9)
        {
            summ += Math.Cos(i * x) / y;
            i++;
            y *= x;

        }
        answer = Math.Round(summ,2);

       
      
        


        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double summ = 0;
        int i = 0;
        while (i <= 9)
        {
            summ += (p + (i * h)) * (p + (i * h));
            i++;

        }
        answer = Math.Round(summ, 2);




        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
       
        answer = (0.5 * x * x) - (7 * x);
        

        // end
        return Math.Round(answer,2);

        
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int i = 1; i <= 6; i++)
            f *= i;
        answer = f;

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here
        int summ = 0, f = 1;

        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            summ += f;
        }

        answer = summ;

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double summ = 0;
        int f = 1,five=1;
        double step = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            step *= -1;
            five *= 5;
            summ += (step * five) / f;
        }
        // end
        answer = Math.Round(summ, 2);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int i = 1, step = 3;
        while (i < 7)
        {
            step *= 3;
            i++;
        }

        // end
        answer = step;

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(5);
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double summ = 1.0;
        double step = 1;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 10; i++)
        { 
            
            step *= x;
            summ += 1.0 / step;
            
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        double y = 0;

        // code here
        if (x <= -1)
            y= 1.0;
        if ((x > -1) & (x <= 1))
            y = -x;
        if (x > 1)
            y = -1.0;
        
        // end
        answer = y;
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int fi1 = 1,summ=1,fi=0;
        
        Console.WriteLine(fi1);
        Console.WriteLine(summ);
        for (int i=1;i<=6;i++)
        {
            fi = summ + fi1;
            Console.WriteLine(fi);
            fi1 = summ;
            summ = fi;
            

        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        
        double fi1_znam = 1;
        double fi_znam = 0;
        double summ_znam = 1;
        double fi_chis = 0;
        double fi1_chis = 1;
        double summ_chis = 2;


        for (int i = 3; i <= 5; i++)
        {
            fi_znam = summ_znam + fi1_znam;
            fi1_znam = summ_znam;
            summ_znam = fi_znam;
            fi_chis = summ_chis + fi1_chis;
            fi1_chis = summ_chis;
            summ_chis = fi_chis;
            answer = fi_chis / fi_znam;
        }

            // end

            return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        
        ulong zerno = 1;
        for (int i = 0; i < 64; i++)
        {
           
            answer+= zerno/15.0;
            zerno *= 2;
        }
       
    
        power=(int)Math.Log10(answer);
        for (int i = 0; i < power; i++)
        {
            answer/= 10;
           
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        double d = 0;
        double dr = 0;
        dr = ((R + x) * (R + x)) - (R * R);
        d = Math.Sqrt(dr);
        
        answer = Math.Round(d, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int cells = 10;
        // code here
        while (x>0)
        {
            cells *= 2;
            x -= 3;

        }
            

        answer = cells;
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
        const int L = 30000;
        int p = 1;
        int i = 1;
        while (p*i <= L)
        { 
            i+= 3;
            p *= i;
        }
        answer = i;
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
        const double e = 0.0001;
        double summ = 1;
        double y = 1;
        if (Math.Abs(x) >= 1)
            return 0;
        while (Math.Abs(y) > e) 
        {
            y*= x*x;
            summ += y;
        }

        answer = Math.Round(summ,2);
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
        int cells = 10;
        int i = 0;
        while (cells <= Math.Pow(10, 5))
        {
            i += 3;
            cells *= 2;
        
        }
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

        // code here
        int i = 0;
        double summ = 10000;
        while (summ <= 20000)
        {
            summ *= 1.08;
            i++;
        }
        answer =i;
            

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
        double answer_sled = 0;
        double answer_pred = 0;
        double fi1_znam = 1;
        double fi_znam = 0;
        double summ_znam = 1;
        double fi_chis = 0;
        double fi1_chis = 1;
        double summ_chis = 2;
        int i = 2;

        do
        {
            i++;
            fi_znam = summ_znam + fi1_znam;
            fi1_znam = summ_znam;
            summ_znam = fi_znam;
            fi_chis = summ_chis + fi1_chis;
            fi1_chis = summ_chis;
            summ_chis = fi_chis;
            answer_sled = fi_chis / fi_znam;
            answer_pred = fi1_chis / fi1_znam;

        }
        while (Math.Abs(answer_sled - answer_pred) >= 0.001);
        answer = i;


        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {

        double S = 1, x1 = 1, f = 1, a = 1, i = 1;
        double y;
        const double e = 0.0001;
        int p = 1;
        // code here
        while (true)
        {
            p = -p;
            x1 *= x * x;
            f *= i * (i +1 );
            a = (p * x1) / f;
            if (Math.Abs(a) <= e)
                break;
            S += a;
            i += 2;
        }
        
        y = Math.Cos(x);
        Console.WriteLine(S + " " + y);



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
