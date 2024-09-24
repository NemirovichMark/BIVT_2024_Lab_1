using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();

        [TestMethod()]
        public void Task_1_1Test()
        {
            // Arrange
            double[] x = new double[] { 0, 1.5, 1, 3 };
            double[] y = new double[] { 2, 0.7, 1, 0 };
            bool[] test = new bool[x.Length];
            bool[] answer = new bool[] { true, false, false, false };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_1(x[i], y[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }

        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            double[] x = new double[] { 0, 0.5, -0.5, 3 };
            double[] y = new double[] { 2, 0.25, 0.25, 0 };
            bool[] test = new bool[x.Length];
            bool[] answer = new bool[] { false, true, true, false };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_2(x[i], y[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }

        [TestMethod()]
        public void Task_1_3Test()
        {
            // Arrange
            double[] a = new double[] { 0, 0.5, -0.5, 3 };
            double[] b = new double[] { 2, 0.25, 0.25, 4 };
            double[] test = new double[a.Length];
            double[] answer = new double[] { 0, 0.5, -0.5, 4 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_3(a[i], b[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }

        [TestMethod()]
        public void Task_1_4Test()
        {
            // Arrange
            double[] a = new double[] { 0, 0.5, -0.5, 3 };
            double[] b = new double[] { 2, 0.25, 0.25, 4 };
            double[] c = new double[] { -2, 3, -0.25, -4 };
            double[] test = new double[a.Length];
            double[] answer = new double[] { 0, 3, -0.25, 3 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_4(a[i], b[i], c[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_5Test()
        {
            // Arrange
            double[] r = new double[] { 70, 0.86, 0, 4, 123.45 };
            double[] s = new double[] { 36.74, 0.74, 12, 0, 12.345 };
            bool[] test = new bool[r.Length];
            bool[] answer = new bool[] { true, false, false, true, true };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_5(r[i], s[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_6Test()
        {
            // Arrange
            double[] r = new double[] { 70, 0.86, 3.2, 3.2, 123.45, 6 };
            double[] s = new double[] { 36.74, 0.74, 3.5, 4.5, 12.345, 9 };
            bool[] test = new bool[r.Length];
            bool[] answer = new bool[] { false, false, false, true, false, true };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_6(r[i], s[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_7Test()
        {
            // Arrange
            double[] x = new double[] { 0, 0.5, -0.5, 3, -1.01 };
            double[] test = new double[x.Length];
            double[] answer = new double[] { 0, 0.5, 0.5, 1, 1 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_7(x[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_8Test()
        {
            // Arrange
            double[] x = new double[] { 0, 0.5, -0.5, 3, -1.01 };
            double[] test = new double[x.Length];
            double[] answer = new double[] { -1, -0.75, -0.75, 0, 0 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_8(x[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_9Test()
        {
            // Arrange
            double[] x = new double[] { 0, 0.5, -0.5, 3, -1.01 };
            double[] test = new double[x.Length];
            double[] answer = new double[] { 1, 1, 0.5, 1, 0 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_9(x[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
        [TestMethod()]
        public void Task_1_10Test()
        {
            // Arrange
            double[] x = new double[] { 0, 0.5, -0.5, 3, -1.01 };
            double[] test = new double[x.Length];
            double[] answer = new double[] { 0, -0.5, 0.5, -1, 1 };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = main.Task_1_10(x[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }

        //[TestMethod()]
        //public void Task_2_1Test()
        //{
        //    // Arrange
        //    double test = 10;
        //    double answerR = 163.4;
        //    // Act
        //    test = main.Task_2_1((int)test);
        //    // Assert
        //    Assert.AreEqual(answerR, test);
        //}
        //[TestMethod()]
        //public void Task_2_2Test()
        //{
        //    // Arrange
        //    int n = 5;
        //    double[] r = new double[] { 3, 1.5, 1 };
        //    double[] a = new double[] { 2, 1.5, 3 };
        //    double[] b = new double[] { 1, 1, 1 };
        //    int[] test = new int[r.Length];
        //    int[] answer = new int[] { 3, 2, 0 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        test[i] = main.Task_2_2(n, r[i], a[i], b[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_3Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 10, 8, 6 };
        //    double[] test = new double[n.Length];
        //    double[] answer = new double[] { 1.2, 0.8, 0.6 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        test[i] = main.Task_2_3(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_4Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 5, 4, 3 };
        //    double r1 = 1, r2 = 2, r3 = 3;
        //    double[] test = new double[2 * n.Length];
        //    double[] answer = new double[] { 2, 3, 2, 3, 1, 2 };
        //    // Act
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        test[2 * i] = main.Task_2_4(n[i], r1, r2);
        //        test[2 * i + 1] = main.Task_2_4(n[i], r1, r3);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_5Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 10, 8, 6 };
        //    double norm1 = 30, norm2 = 25.2;
        //    double[] test = new double[2 * n.Length];
        //    double[] answer = new double[] { 6, 2, 4, 1, 3, 1 };
        //    // Act
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        test[2 * i] = main.Task_2_5(n[i], norm1);
        //        test[2 * i + 1] = main.Task_2_5(n[i], norm2);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_6Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 5, 4, 3 };
        //    int[] test = new int[n.Length];
        //    int[] answer = new int[] { 3, 2, 2 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        test[i] = main.Task_2_6(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_7Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 5, 4, 3 };
        //    int[] test1 = new int[n.Length];
        //    int[] test3 = new int[n.Length];
        //    int[] answer1 = new int[] { 2, 2, 1 };
        //    int[] answer3 = new int[] { 1, 0, 0 };
        //    // Act
        //    for (int i = 0; i < answer1.Length; i++)
        //    {
        //        (test1[i], test3[i]) = main.Task_2_7(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer1.Length; i++)
        //    {
        //        Assert.AreEqual(answer1[i], test1[i]);
        //        Assert.AreEqual(answer3[i], test3[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_8Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 5, 4, 3, 0 };
        //    int[] test1 = new int[n.Length];
        //    double[] test3 = new double[n.Length];
        //    int[] answer = new int[] { 5, 3, 3, 0 };
        //    double[] answerLength = new double[] { 0.71, 1.03, 1.03, 0 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        (test1[i], test3[i]) = main.Task_2_8(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test1[i]);
        //        Assert.AreEqual(answerLength[i], test3[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_9Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 10, 8, 6, 0 };
        //    double[] test = new double[n.Length];
        //    double[] answer = new double[] { 20.1, 22.3, 22.3, 0 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        test[i] = main.Task_2_9(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_10Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 10, 8, 6 };
        //    int[] test = new int[n.Length];
        //    int[] answer = new int[] { 5, 4, 3 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        test[i] = main.Task_2_10(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //    }
        //}
        //[TestMethod()]
        //public void Task_2_11Test()
        //{
        //    // Arrange
        //    int[] n = new int[] { 10, 8, 6, 0 };
        //    int[] test = new int[n.Length];
        //    double[] testAvg = new double[n.Length];
        //    int[] answer = new int[] { 4, 3, 2, 0 };
        //    double[] answerAvg = new double[] { 4.05, 4.19, 4.29, 0 };
        //    // Act
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        (test[i], testAvg[i]) = main.Task_2_11(n[i]);
        //    }
        //    // Assert
        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Assert.AreEqual(answer[i], test[i]);
        //        Assert.AreEqual(answerAvg[i], testAvg[i]);
        //    }
        //}
        [TestMethod()]
        public void Task_2_12Test()
        {
            // Arrange
            const int n = 3;
            double[] r = new double[n] { 1.5, 0.2, 3 };
            int[] type = new int[n] { 0, 1, 2 };
            double[,] test = new double[n, n];
            double[,] answer = new double[n, n] { { 2.25, 7.07, 0.97 }, { 0.04, 0.13, 0.02 }, { 9, 28.27, 3.9 } };
            // Act
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    test[i, j] = main.Task_2_12(r[i], type[j]);
                }
            }
            // Assert
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(answer[i, j], test[i, j]);
                }
            }
            double[] testFail = new double[4];
            double[] answerFail = new double[] { 0, 0, 0, 0 };
            testFail[0] = main.Task_2_12(-0.75, 0);
            testFail[1] = main.Task_2_12(0, 2);
            testFail[2] = main.Task_2_12(1.2, 3);
            testFail[3] = main.Task_2_12(1.2, -4);
            for (int i = 0; i < testFail.Length; i++)
            {
                Assert.AreEqual(answerFail[i], testFail[i]);
            }
        }

        [TestMethod()]
        public void Task_2_13Test()
        {
            // Arrange
            const int n = 3;
            double[] A = new double[n] { 1.5, 0.2, 3 };
            double[] B = new double[n] { 3, 2.8, 2.5 };
            int[] type = new int[n] { 0, 1, 2 };
            double[,] test = new double[n, n];
            double[,] answer = new double[n, n] { { 4.5, 21.21, 2.18 }, { 0.56, 24.5, 0.28 }, { 7.5, 0, 3 } };
            // Act
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    test[i, j] = main.Task_2_13(A[i], B[i], type[j]);
                }
            }
            // Assert
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Assert.AreEqual(answer[i, j], test[i, j]);
                }
            }
            double[] testFail = new double[4];
            double[] answerFail = new double[] { 0, 0, 0, 0 };
            testFail[0] = main.Task_2_13(-0.75, 1, 0);
            testFail[1] = main.Task_2_13(0.01, 0, 2);
            testFail[2] = main.Task_2_13(1.2, 2.1, 3);
            testFail[3] = main.Task_2_13(1.2, 0.2, -4);
            for (int i = 0; i < testFail.Length; i++)
            {
                Assert.AreEqual(answerFail[i], testFail[i]);
            }
        }
    }
}