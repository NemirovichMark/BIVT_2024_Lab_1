using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Program {
    public static void Main() {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(-4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //Console.WriteLine(string.Join(" ",program.Task_1_13(-1.5m,1.5m)));
        //Console.WriteLine(string.Join(" ", program.Task_1_13a(-1.5, 1.5)));
        //program.Task_1_13a(-1.5, 1.5);
        //Console.WriteLine("==============================================");
        //program.Task_1_13(-1.5m,1.5m);
        //program.Task_1_14();
        //program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(1);
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
    public int Task_1_1() {
        int answer = 0;

        // code here
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2() {
        double answer = 0;

        // code here
        double i, s = 0;
        for (i = 1; i <= 10; i = i + 1)
            s = s + (1 / i);
        answer = Math.Round(s, 3);

        // end

        return answer;
    }
    public double Task_1_3() {
        double answer = 0;

        // code here
        double s = 0;
        for (double a = 2; a <= 112; a = a + 1) {
            s = s + a / (a + 1);
        }
        answer = Math.Round(s, 3);
        // end
        return answer;
    }
    public double Task_1_4(double x) {
        double answer = 0;

        // code here
        double s = 0;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 9; i++) {
            s = s + Math.Cos(i * x) / Math.Pow(x, i - 1);
        }
        answer = Math.Round(s, 4);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h) {
        double answer = 0;
                
        // code here
        double s = 0;
        for (int i = 0; i <= 9; i++) {

            s = s + Math.Pow(p + i * h, 2);
        }
        double a = 0;
        
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x) {
        return 0.5 * Math.Pow(x, 2) - 7 * x;
    }
    public int Task_1_7() {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i <= 6; i++) {
            s = s * i;
        }
        answer = s;
        // end

        return answer;
    }
    public int Task_1_8() {
        int answer = 0;

        // code here;
        int s = 0;
        
        for (int i = 1; i <= 6; i++) {
            int a = 1;
            for (int j = i;j > 0; j-- ) {
                a = a * j;
            }          
            s = s + a;
        }
        answer = s;      

        // end

        return answer;
    }
    public double Task_1_9() {
        double answer = 0;

        // code here;
        double s = 0;

        for (int i = 1; i <= 6; i++) {
            double a = 1;
            for (int j = i; j > 0; j--) {
                a = a*j;
            }
            s = s + (Math.Pow((-1) , i)* (Math.Pow(5, i))) / a;
        }
        answer = Math.Round(s,4);

        // end

        return answer;
    }
    public int Task_1_10() {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; i < 8; i++) {
            s = s * 3;
        }
        answer = s;
        // end

        return answer;
    }
    public void Task_1_11() {

        // There is no test for this task
        List<int> s = [];        
        for (int i = 1; i <= 6; i++) {
            s.Add(i);            
        }        
        Console.WriteLine(string.Join(" ",s));

        int[] arr = new int[6];
        for (int i = 1; i <= 6; i++) {
            arr[i-1]=5;
        }
        Console.WriteLine(string.Join(" ", arr));
        // code here

    }
    public double Task_1_12(double x) {
        double answer = 0;

        // code here
        if (x == 0)
            return 0;
        double s = 0;
        for ( double i = 0; i <= 10; i++) {
            s = s + 1 / (Math.Pow(x, i));
        }
        answer = Math.Round(s,4);
        // end

        return answer;
    }
    public decimal[] Task_1_13(decimal range_start, decimal range_end) {

        List<decimal> answer = [];
        // code here
        int index = 0;
        for (decimal x = range_start; x <= range_end; x = x + 0.1m) {
            //Console.WriteLine(++index + ")" + x);
            if (x <= -1)
                answer.Add(1m);
            if (x > -1 && x <= 1)
                answer.Add((-1m) * x);
            if (x > 1)
                answer.Add(-1m);
        }
        // end
        return answer.ToArray();
    }

    public double[] Task_1_13a(double range_start, double range_end) {

        List<double> answer = [];
        // code here
        int index = 0;
        for (double x = range_start; x <= range_end; x = x + 0.1) {
            //Console.WriteLine(++index +")" + x);
            
            if (x <= -1)
                answer.Add(1);
            if (x > -1 && x <= 1)
                answer.Add((-1) * x);
            if (x > 1)
                answer.Add(-1);
        }
        // end
        return answer.ToArray();
    }
    public void Task_1_14() {
        // There is no test for this task
        int a = 1;
        int b = 0;
        int c = 0;
        for (int i = 0; i < 8; i++) {
            Console.Write(a + " ");
            c = a;
            a = a + b;
            b = c;

        }
        // code here

    }
    public double Task_1_15() {
        double answer = 0;

        // code here
        double a = 1;
        double b = 0;
        double c = 0;
        for (int i = 0; i < 6; i++) {
            c = a;
            if (i == 5)
                Console.Write(a/b + " ");
            answer = a / b;
            a = a + b;
            b = c;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16() {
        double answer = 0;
        int power = 0;
           
        // code here
        double s = 0;
        for (double i = 0; i <= 64; i++){
            s = s + Math.Pow(2, i);
        }
       
        string an = (s/15).ToString("F0");        
        answer = Math.Round(Double.Parse(an) / (Math.Pow(10, an.Length - 1)), 4);
        power = an.Length - 1;
        // end
        return (answer, power);
    }
    public double Task_1_17(double x) {
        double answer = 0;

        // code here
        double R = 6350;
        double H = (R + x) * (R + x) - (R * R);
        H = Math.Sqrt(H);
        //answer = Math.Pow( (Math.Pow(R + x, 2) - Math.Pow(R,2) ) ,0.5);
        // end
        answer = H;
        return answer;
    }
    public int Task_1_18(int x) {
        int answer = 0;

        // code here
        answer = 10 * 2 * (x / 3);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x) {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2() {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p) {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x) {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M) {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6() {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a() {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b() {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c() {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8() {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9() {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10() {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x) {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}