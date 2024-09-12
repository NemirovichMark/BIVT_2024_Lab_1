using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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

        for (int i = 2; i<=35; i += 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()   ////                     округление                 /////////////////             
    {
        double answer = 0;

        // code here
        for (int i = 1; i<= 10; i++)
        {
            answer += 1.0 / i;
        }
        // end
        answer = Math.Round(answer, 3);//В ответе 2,9289682539682538, в ответах 2,929     (округление)
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3() ////////////////              HELP              ////////////////////////////
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
        {
            answer += Math.Round(i * 1.0 / (i + 1)*1000)/1000.0;

            
        }
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_4(double x) ////                     округление                 /////////////////
    {
        double answer = 0;
        // code here
        if (x == 0) return 0;//del(0) вылез
        for (int i =0;i<9; i++)
        {

            answer += Math.Cos((1+i)*x) / Math.Pow(x, i);
        }
        // end
        answer = Math.Round(answer, 3);//В ответе 1,3640302081709366, в ответах 1.364     (округление)
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            answer += Math.Pow((p + i * h), 2);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;
            // end
        Console.WriteLine(answer);
        
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i < 7; i++)
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

        int factorial = 1;
        // code here;
        for (int n = 1; n < 7; n++)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            answer += factorial;
            factorial = 1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9() ////                     округление                 /////////////////
    {
        double answer = 0;
        int factorial = 1;
        // code here;
        for (int n = 1; n <= 6; n++)
        {
            for (int i = 1; i <= n; i++) { 
                factorial *= i;
            }
            answer += Math.Pow(-1, n) * Math.Pow(5, n) / factorial;
            factorial = 1;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5);
            Console.Write(" ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        // code here
        if (x == 0) return 0; // del(0) чтоб не вылез

        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / Math.Pow(x, i);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) answer = 1;
        else if (x == 0) answer = 0;
        else if (x <= 1) answer = Math.Round(-x, 1);
        else answer = -1;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1, n2 = 1;
        Console.Write(n1); Console.Write(" "); Console.Write(n2);
        for (int i = 0; i < 6; i++)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp + n2;
            Console.Write(" "); Console.Write(n2);
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int up1 = 1, down1 = 1, up2 = 2, down2 = 1;
        for (int i = 0; i < 5 - 2; i++)
        {
            int tempU = up1, tempD = down1;
            up1 = up2;
            down1 = down2;
            up2 =up2 + tempU;
            down2 = down2 + tempD;            
        }
    Console.WriteLine(up2*1.0/down2);
        // end
        answer = up2 * 1.0 / down2;
        return answer;
    }
    public (ulong, int) Task_1_16()   ////                HELP           ////////
    {
        ulong answer = 0;
        int power = 0;
        double Last_Squere = 1.0 / 15;
        // code here
        for (int i = 0; i <= 60; i+=4)
        {
            Console.Write(Last_Squere); Console.Write(" ");
            //Last_Squere = Last_Squere * 2;
            //answer += Math.Pow(2,i);
        }
        // end
        Console.WriteLine(answer);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt(Math.Pow(6350+x, 2)+ Math.Pow(6350,2));
        // end
        Console.WriteLine("Hello");
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here

        x = x / 3;

        for (int i = 0; i < x; i ++)
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
        int n = 1;
        // code here
        while (Math.Abs(Math.Cos(n*x)/Math.Pow(n,2))>=0.0001){
            answer+=Math.Cos(n*x)/Math.Pow(n,2);
            n+=1;
        }
        Console.WriteLine(answer);
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
