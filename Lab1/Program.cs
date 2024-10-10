using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

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
        int answer = 0;

        // code here
        for(int i = 2; i <= 35; i+=3){
            answer += i;
        } 
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++){
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0){
            double b = 1;
            for(int i = 1; i <= 9; i++){
                answer += Math.Cos(x * i) / b;
                b *= x;
            }
        }
        else{
            return 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double a = 0, b;
        for (double i = 0; i <= 9; i++)
        {
            b = (p + h * i) * (p + h * i);
            a += b;
        }
        answer = a;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(x);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int a = 1;
        for(int i = 2; i < 7; i++){
            a *= i;
        }
        answer = a;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int a = 1;
        for(int i = 1; i < 7; i++){
            a = a * i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double firstnum = 1, stepsecondnum = 1, thirdnum = 1;
        for(int i = 1; i < 7; i++){
            firstnum *= -1;
            stepsecondnum *= 5;
            thirdnum *= i;
            answer += ((firstnum * stepsecondnum) / thirdnum);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int a = 3;
        for(int i = 1; i < 7; i++){
            a *= 3;
        }
        answer = a;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i < 7; i++){
            System.Console.Write($"{i} ");
        }
        for(int i = 1; i < 7; i++){
            System.Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        //if(x != 0){
            //for(int i = 1; i < 11; i++){
            //answer += 1 / a;
            //a *= (int)x;
            //answer += 1 / x;
            //x *= x;
        //}
        //}
        if(x == 0){
            return 0;
        }
        for(int i = 0; i < 11; i++){
            answer += 1 / a;
            a *= x;
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
            return 1;
        }
        else if(x > -1 && x <= 1){
            return -x;
        }
        else{
            return -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int first = 1, second = 1, third = 0;
        for(int i = 0; i <= 7; i++){
            System.Console.WriteLine(first);
            third = first + second;
            first = second;
            second = third;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double firch = 1, secch  = 1, thirrr = 0;

        for(int i = 0; i < 5; i++){
            answer = firch / secch;
            thirrr = firch + secch;
            secch = firch;
            firch = thirrr;

        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        answer++;
        for (int i = 1; i < 65; i++){
            answer = answer * 2;
        }
        answer = answer - 1;
        answer = answer / 15;
        while (answer >= 10){
            answer = answer / 10;
            power += 1;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        System.Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int a = 6350;
        answer = Math.Sqrt(x * (2 * a + x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        //int a = 10;
        //for(int i = 1; i < 9; i++){
        //    a = a * 2;
        //    answer = a;
        //}
        while(x > 0){
            a = a * 2;
            answer = a;
            x = x - 3;
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        //int l = 0;
        //int n = 4;
        //int a = 7;
        //while(l <= 30000){
        //    n *= a;
        //    a += 3;
        //    l = n;
//
        //}
        //a -= 3;
        //answer = a;
        int a = 1;
        for(int i = 1; i * a <= 30000; i+=3){
            a *= i;
            answer = i;
        }
        System.Console.WriteLine(answer);
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
        double answer = 1;

        // code here
        double a = 1;
        if(x >= 1){
            return 0;
        }
        while(a >= 0.0001){
            a = a * x * x;
            answer += a;
        }
        answer = Math.Round(answer, 2);
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
        int a = 10;
        for(int i = 1; a <= 100000; i++){
            a *= 2;
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
        double a = 10000;
        while(a < 20000){
            a *= 1.08;
            answer++;
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
        int answer = 2;

        // code here;
        double firch = 1, secch  = 1, thirrr = 2, fourth = 1, ob, bo;

        while(Math.Abs((thirrr / fourth) - (firch / secch)) >= 0.001){
            answer++;
            ob = firch + thirrr;
            bo = secch + fourth;
            secch = fourth;
            fourth = bo;
            firch = thirrr;
            thirrr = ob;
        }
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
        double m1 = 1, m2 = 0;
        //int i  = 1;

        // code here
        for(int i = 1; i < 1000000; i++){
            m1 *= x;
            m2 = Math.Sin((i * Math.PI) / 4);
            if(Math.Abs(m1) < 0.0001) {
                break;
            }
            S += m1 * m2;
            

        }
        //double a = 0;
        //m1 *= x;
        //m2 = Math.Sin((i * Math.PI) / 4);
        //a = m1 * m2;
        //while(Math.Abs(a) >= 0.0001){
        //    S += a;
        //    i++;
        //    m1 *= x;
        //    m2 = Math.Sin((i * Math.PI) / 4); 
        //    a = m1 * m2;
        //}
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        //S = Math.Round(S, 2);
        //y = Math.Round(y, 2);
        System.Console.WriteLine(S);
        System.Console.WriteLine(y);
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