using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Runtime.CompilerServices;
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
    for(int i = 2; i<36; i+=3){
        answer+=i;
    }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double b = 1;
        for(double i = 2; i<11; i++){
        b += 1/i;
        }

        answer = Math.Round(b, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double b = 0;

        for(double i = 3; i<114; i+=2){
        b += (i-1)/i;
        }
        answer = Math.Round(b, 2);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for(double i = 1; i<10 && x != 0; i++){
            answer += Math.Cos(x*i)/Math.Pow(x, i-1);
            if(x == 0){
                answer = 0;
            }
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int i = 0; i<10; i++){
            answer += Math.Pow((p+h*i), 2);
        }
        answer = Math.Round(answer, 4);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Pow(x, 2) * 0.5 - (7 * x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for(int i = 1; i<7; i++){
            answer*=i;
        }

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int b = 1;
        // code here;
        for(int i = 1; i<7; i++){
            for(int y = 1; y<i+1; y++){
                b*=y;
            }
            answer+=b;
            b = 1;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double z = 1;
        // code here;
        for(int i = 1; i<7; i++){
            for(int y = 1; y<i+1; y++){
                z *= y;
            }
            answer += (Math.Pow(-1, i)*Math.Pow(5, i))/z;
            z = 1;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for(int i = 1; i<7; i++){
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i <= 6; i++)
        {
            Console.Write(i);
        }
        for(int i = 1; i <= 6; i++)
        {
            Console.Write(5);
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for(int i = 0; i<11 && x != 0; i++){
            answer+=1/Math.Pow(x, i);
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1){
            answer = 1;
        }
        if(x <= 1 && x>-1){
            answer = -x;
        }
        if(x > 1){
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        int c = 0;
        Console.WriteLine(1);
        Console.WriteLine(1);
        for(int  i = 0; i <= 5; i++)
{
        c = a+b;
        Console.WriteLine(c);
        a = b;
        b = c;
}

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double y = 0;
        double[] array = [1, 1, 2, 0, 0];
        double[] array1 = [1, 2, 3, 0, 0];
        for(int i = 3; i<5; i++){
            array[i] = array[i-1]+array[i-2];
            array1[i] = array1[i-1]+array1[i-2];
        }
        for(int i = 0; i<5; i++){
            y = array1[i]/array[i];
        }
        answer = Math.Round(y, 4);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double j = 1; 
        for (int i = 1; i <= (8 * 8); i++) 
        { 
            answer += j; 
            j *=2; 
        } 
        answer /= 15; 
        power = 18; 
        answer /= Math.Pow(10, power); 
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt(Math.Pow(r+x, 2)-r*r);;
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int y = 10;
        for(int i = 1; i < (x/3)+1; i++){
            y *= 2;
        }
        answer = y;



        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        for(double i = 1;;i++)
        {
            if(Math.Abs(Math.Cos(i*x)/Math.Pow(i, 2))>0.0001){
                answer+=Math.Cos(i*x)/Math.Pow(i, 2);
            }
            else
                break;
        }
        answer = Math.Round(answer, 2);
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

        double s = 0;
        for(double i = 0; i<1000000 && h>0; i++)
        {
            s += a+i*h;
            if (s>p)
                break;
            answer++;
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
        for(int i = 0; Math.Abs(N)>=Math.Abs(M); i++){
            if(M==0){
                N = 0;
                break;
            }
            N=Math.Abs(N)-Math.Abs(M);
            quotient++;
        }
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
        double s = 10;
        double daily = 0;
        for(int i = 0; i<7; i++){
            answer+=s;
            s +=(s/100)*10;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        answer ++;
        double s = 10;
        double sm = s;
        for(int i = 1; sm<=100;){
            s = s+(s/100)*10;
            sm+=s;
            Console.WriteLine(s);
            Console.WriteLine(sm);
            answer ++;
        }
Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 10;
        double sm = s;
        for(int i = 1; s<20; i++){
            s = s+(s/100)*10;
            sm+=s;
            answer = i;
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
        double l = 0.1;
        double d = Math.Pow(10, -10);
        while(l>=d){

            answer++;
            l/=2;
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
        y = Math.Cos(x);
        double variable2 = 1;
        double variable3 = 1;


        for (int i = 0; i <= 1000000; i++)
        {
            double variable1 = 0;   
            double variableRes = 1;

            if (i % 2 == 0)
                variable1 = 1;
            if (i % 2 == 1)
                variable1 = -1;

            if (i > 0)      
            {
                variable2 *= x * x;
                variable3 *= (2 * i) * (2 * i - 1);
            }

            variableRes = variable1 * variable2 / variable3;

            if (Math.Abs(variableRes) >= 0.0001)
                S += variableRes;
            if (Math.Abs(variableRes) < 0.0001)
                break;

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