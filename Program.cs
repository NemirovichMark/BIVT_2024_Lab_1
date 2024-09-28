using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
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
        
        int x = 2;

        for (int i = 2; i <= 35; i+=3)
        {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0.0;
        double z = 1,sum = 0.0;


        // code here
        for (int i = 1; i <= 10; i++)
        {
            sum += z / i;
            answer = Math.Round(sum, 2);
        }
            
        // end



            return answer;
    }
    public double Task_1_3()
    {
        double answer = 0.0, sum = 0.0;
        
        // code here
        for (double i = 0; i <= 112; i+=2)
        {
            sum += i / (i + 1);
            answer = Math.Round(sum);
            
            
        }
        // end
        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double x1 = 1;
        //code here
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / x1;
                x1 *= x;

            }

        }
        
        //end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            double y = p + i * h;
            answer += y * y;
        }
        // end
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        
        // code here
        for (double i = -4; i <= 4; i += 0.5)
        {
            answer = 0.5 * x * x - 7 * x;
            answer = Math.Round(answer, 2);
           
        }
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        long fac = 1;
        for (int i = 1; i <= 6; i++)
        {
            fac *= i;
            
        }
        // end
        answer = (int)fac;
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        long sum = 0;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            long fac = 1;
            for (int k = 1; k <= i; k++)
            {
                fac *= k;
            }
            sum += fac;
        }
        // end
        answer = (int)sum;
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, sum, x_pow = 5;
        
        // code here;

        int fac = 1, sign = -1;
        
        for (int i = 1; i <= 6; i++)
        {
            
            fac *= i;
            sum = sign * x_pow / fac;
            answer += sum;
            sign = -sign;
            x_pow *= 5;
        }
        answer = Math.Round(answer,2);



        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        int n = 3;
        // code here
        for (int i = 0; i < 7; i++)
        {
            answer *= n;
        }
        // end1

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(5);
        }
        Console.ReadLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double n = 1;
        // code here
        if (x == 0)
        {
            return 0;
        }
            for (int i = 1; i <= 10; i++)
        {
            n /= x;
            answer += n;
        }
        // end
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 1;
        }
        if ((-1 < x) && (x <= 1))
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int k = 1, k1 = 0, temp =1;

        for (int i = 0; i< 8; i++)
        {
            k = temp;
            Console.WriteLine(k + " ");
            temp = k + k1;
            k1 = k;
        }



        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double chis1 = 1, zn1 = 1, chis2 = 2, zn2 = 1;
        double temp;



        // code here
        for (int i = 0; i < 5; i++)
        {
            temp = chis2;
            chis2 += chis1;
            chis1 = temp;
            temp = zn2;
            zn2 += zn1;
            zn1 = temp;


        }
        answer = chis1 / zn1;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 1, y;
        for (int i = 1; i <= 64; i++)
        {
            x *= 2;
        }
        y = x / 15;
        power = (int)Math.Log10(y);
        answer = Math.Round(y / Math.Pow(10,power), 2);
        
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        // code here
        answer = Math.Sqrt((R+x)*(R+x) - R*R);
        answer = Math.Round(answer,2);
        
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 0; i < x; i+= 3)
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
        double i = 1.0;

        while (true)
        {
            if (Math.Abs(Math.Cos(x * i) / (i * i)) <= 0.0001)
                break;
            answer += Math.Cos(x * i) / (i * i);
            i += 1;

        }
        answer = Math.Round(answer, 2);
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
        double sum = 0;
        // code here
                      
        int n = 0;
        if (h<0)
        {
            return 0;
        }
        else
        {
            while (sum <= p)
            {
                sum += a + n * h;
                n++;
            }
            answer = n - 1;
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
        int quotient = 0, remainder = N;

        //code here
        if (M == 0)
            {
                return (0, 0);
            }
        while ( remainder >= M)
        {
            remainder -= M;
            quotient++;
        }
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
        double dist = 10, sumdist = 0;
        // code here
        for (int i = 1; i <= 7; i++)
        {
            sumdist += dist;
            dist += (dist / 100) * 10;
        }
        answer = Math.Round(sumdist,2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double dist = 10, sumdist = 0;
        // code here
        while (sumdist < 100)
        {
            sumdist += dist;
            dist += (dist / 100) * 10;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double dist = 10;

        while (dist < 20)
        {
            dist += (dist / 100) * 10;
            answer++;
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
        while (L > Math.Pow(10,-10))
        {
            L = L / 2;
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

        double S =1, y, x_pow = 1;

       
        double eps = 0.0001, term = 1, factorial = 1, i = 1;
        int sign = 1;

        while (true)
        {
            sign = -sign;
            x_pow *= x * x;
            factorial *= i * (i + 1);
            term = sign * x_pow / factorial;
            if (Math.Abs(term) <= eps)
                break;
            S += term;
            i += 2;
        }

        S = Math.Round(S, 2);
        y = Math.Round(Math.Cos(x), 2);
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