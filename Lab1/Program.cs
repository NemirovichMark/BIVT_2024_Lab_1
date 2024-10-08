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
        program.Task_1_5(0,2);
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
        program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        program.Task_2_9();
        program.Task_2_10();
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
         for (int i = 2; i <= 35;i+=3){
            answer=answer+i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1;i <= 10;i+=1){
            answer+=1/i;
        }
        answer=Math.Round(answer,2);
        // en

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        
        // code here
        double a=2;
        for (double i=3;i<=113;i+=2){
            answer+=a/i;
            a+=2;
        }
        answer=Math.Round(answer,0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        // code here
        double x1=1;
        if (x!=0){
        for (double i=1;i<=9;i+=1){
           
            double cos=Math.Cos(x*i);
            answer+=cos/x1;
            x1*=x;
        }
        }
         answer=Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        // code here
        double q=1;
        for (double i=0;i<=9;i+=1){
            q=(p+i*h)*(p+i*h);
            answer+=q;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
       answer=0.5*x*x-7*x;
        answer=Math.Round(answer,2);
        return answer;
        // end
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        // code here
        answer=1;
        for (int i=1;i<=6;i+=1){
            answer*=i;
        }
        // end
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        // code here;
        int number = 1;
       for (int i=1;i<=6;i+=1){
         number*=i;
        answer+=number;
       }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
         double q2=1;
         double q1=1;
         double number=1;
        for (int i=1;i<=6;i+=1){
        q1*=-1;
        q2*=5;
       number*=i;
        answer+=q1*q2/number;
        }
        answer=Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        // code here
        answer=3;
       for (int i=2;i<=7;i+=1) {
            answer*=3;
       }
        // end
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6;i+=1){
    Console.WriteLine(i);
    }
    Console.WriteLine("");

    for (int i = 1;i<=6;i+=1) {
        Console.WriteLine("5");
    }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        answer=1;
        double number=1;
        if(x==0) {
            return 0;
        }
        for (int i = 1;i<=10;i++) {
        number*=x;
        answer+=1/number;
        }
        answer=Math.Round(answer,2);
        Console.WriteLine(answer);
        
        // end


        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double y=0;
        if (x<=-1) {
            y=1;
        }
        if (x<=1 && x>-1) {
            y=-x;
        }
        if (x>1){
            y=-1;
        }
        answer=y;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int[] mass=new int[8];
        mass[0]=1;
        mass[1]=1;
        for (int i=2;i<=mass.Length-1;i++){
            mass[i]=mass[i-2]+mass[i-1];
        }
        for (int i=0;i<=mass.Length-1;i++){
            Console.WriteLine(mass[i]);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double[] mass1=new double[5];
        double[] mass2=new double[5];
        mass1[0]=1;
        mass1[1]=2;
        mass2[0]=1;
        mass2[1]=1;
        for (int i=2;i<=mass1.Length-1;i++){
            mass1[i]=mass1[i-2]+mass1[i-1];
            mass2[i]=mass2[i-2]+mass2[i-1];
        }
        answer=mass1[4]/mass2[4];
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        answer=1;
        double ch=1;
        for (int i=1;i<64;i++){
            ch*=2;
            answer+=ch;
        }   
        answer/=15;
        
    //      Console.WriteLine(answer);
        while (answer>9){
         power++;
         answer/=10;
        }
        //Console.WriteLine(power);
        //Console.WriteLine(answer);
        // end
        answer=Math.Round(answer,2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        // code here
        double r = 6350;

        answer = Math.Sqrt((r+x)*(r+x) - r*r);
        // end
        answer=Math.Round(answer,2);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer=10;
        int del=x/3;
        for (int i=1;i<=del;i++){
            answer*=2;
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
        int p=1;
        int number=3;
       for (int n=1;p<=30000;n+=number){
        p*=n;
         answer=n-number;
       }
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
        double n=1;
       while(Math.Abs(x)<1 && n>=0.0001){
        answer+=n;
        n*=x*x;

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
        int a=10;
        for (int time=1;a<100000;time++){
            a*=2;
            answer=time*3;
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
        double v=10000;
        int day=0;
       while (v<=20000){
            day++;
            v+=v*0.08;
       }
       answer=day;
        //end
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
        answer=1;
       double ch=1;
        double z=1;
        double chis;
        double del=0;
       for ( double i=1;Math.Abs(ch/z-del)>0.001;i++){
        chis=ch+z;
        del=ch/z;
        z=ch;
        ch=chis;
        answer++;
       }
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
        double a=1;
        double a1=1;
        double a2=1;
        double a3=1;
        double f1=2;
        S=1;
        for (double i=1;Math.Abs(a)>=0.0001;i++){
            a1*=-1;
            a2*=x*x;
            a3*=i*f1;
            f1=4*i+2;
        a=a1*a2/a3;
        if (Math.Abs(a)>=0.0001){
        S+=a;
        }
        y=Math.Cos(x);
        }
        Console.WriteLine("S " + S);
        //Console.WriteLine(y);
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
