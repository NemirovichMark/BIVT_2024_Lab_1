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
        //program.Task_1_7();
        //program.Task_1_8();
        program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(1.6);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
        //program.Task_2_4(0.8);
        //program.Task_2_5(1, 0);
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
        int s = 2;
        while(s <= 35){ 
            answer += s;
            s += 3;
        }
        //Console.WriteLine($"answer: {answer}, s: {s}");
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double x = 1;
        while(x != 11) {
            answer += 1 / x;
            x++;
        }
        //Console.WriteLine(answer);
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double x = 2;
        while (x+1 != 115){
            //Console.WriteLine($"x: {x} x+1: {x+1}");
            answer += x / (x + 1);
            x+=2;
            
        }
        Console.WriteLine(Math.Round(answer, 2));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0.0) return 0.0;
        double y = 1, z = 1;
        while(y != 10){
            answer += Math.Cos(x * y) / z;
            y++;
            z *= x;
        }
        //Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        int i = 0;
        while(i != 10) {
            answer += (p + h * i) * (p + h * i);
            i++;
        }
        //Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;


        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int i = 1;
        answer++;
        while (i < 7) {
            answer *= i;
            i++;
        }

        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int i = 1, fact = 1;
        while (i != 7) {
            answer += fact;
            i++;
            fact *= i;
        }
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double i = 1, y = -1 * 5 / 1;
        // code here;
        while (i != 7) {
            answer += y;
            i++;
            y = -1 * y * 5 / i;
            //Console.WriteLine($"y: {y}");

        }
        //Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        int i = 1;
        while (i != 7) {
            answer *= 3;
            i++;
            
        }
        //Console.WriteLine($"Answer: {answer}, power: {i}");
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i < 7; i++){
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i < 7; i++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double counter = 1;
        if (x == 0) return 0;
        while (i != 12) {
            answer += 1 / counter;
            counter *= x;
            i++;
        }
        //Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)   
    {
        double answer = 0;

        // code here
        if(x <= -1) {
            answer = 1;
        }else if(-1 < x && x <= 1) {
            answer = -x;
        }
        else {
            answer = -1;
        }
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1, y = 0, sum = 1;
        for (int i = 0; i < 8; i++) {
            x = sum;
            Console.Write(x + " ");
            sum = x + y;
            y = x;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double x = 1, y = 1, sum = 0;
        Console.WriteLine(x/y);
        x += y;
        for (int i = 0; i < 4; i++) {
            //Console.WriteLine($"{x / y} : {x} / {y}");
            answer = x / y;
            sum = x;
            x += y;
            y = sum; 
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        ulong amount = 1;
        for (int i = 0; i < 64; i++) {
            answer += amount / 15.0;
            amount = amount << 1;
            //Console.WriteLine(amount);
        }
        
        string sAnswer = answer.ToString();
        bool read = false;
        string sPower = "";
        for (int i = 0; i < sAnswer.Length; i++) { 
            if(read) sPower += sAnswer[i];
            if (sAnswer[i] == '+') read = true;
        }
        power = int.Parse(sPower);
        sPower = "";

        for (int i = 0; i < 5; i++){
            sPower += sAnswer[i];
        }
        answer = double.Parse(sPower);
        answer = Math.Round(answer, 2);
        Console.WriteLine(power + " " + answer); 
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round( Math.Sqrt( (6350.0 + x) * (6350.0 + x) - 6350.0 * 6350.0), 2);
        // end
        //Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer += 10;
        while(x > 0) {
            answer = answer << 1;
            x -= 3;
            //Console.WriteLine($"Hours left: {x}, amount: {answer}");
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
        double y = Math.Round(Math.Cos(x), 6), i = 1.0;

        while (Math.Abs(y) > 0.0001){
            i += 1;
            answer += y;
            y = Math.Cos(x * i) / (i * i);
            y = Math.Round(y, 6);
        }
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
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
        double sum = 0;
        int count = 0;
        while( sum < p ) {
            Console.WriteLine((a + h * answer));
            answer++;
            sum += (a + h * answer);
            count++;
            if (count > 99) return 0;
            Console.WriteLine($"a\"{a}\" + h\"{h}\"*i\"{answer}\" => sum = {sum}? {p}");
           
        }
        Console.WriteLine(answer);
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
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0) return (0, 0);
        while (N >= M) { 
            quotient++;
            N -= Math.Abs(M);
            Console.WriteLine(N);
        };
        remainder = N;
        Console.WriteLine(quotient + " " + remainder);
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
        double running = 10.0;
        for (int i = 0; i < 7; i++){
            answer += running;
            running *= 1.1;
        }
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double running = 10.0, sum = 0;
        while(sum < 100) {
            sum += running;
            running *= 1.1;
            answer++;
        }
        //Console.WriteLine($"days: {answer} km: {sum}");
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double running = 10.0;
        while (running < 20.0){
            running *= 1.1;
            answer++;
            
        }
        //Console.WriteLine(answer);
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
        double size = Math.Pow(10, -10), length = 0.1;
        while (length > size)
        {
            length /= 2;
            answer++;
        }
        //Console.WriteLine(answer);
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
        S = 1;
        double elem = Math.Cos(x), i = 1.0, fact = 1.0;
        while (Math.Abs(elem) > 0.0001) {
            elem = Math.Cos(i * x) / fact;
            i++;
            fact *= i;
            S += elem;
            y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
            //Console.WriteLine($"Sum: {S}, elem: {elem} fact: {fact}");
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine(S + " " + y);
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