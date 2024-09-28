﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            int test;
            int answer = 222;
            // Act
            test = main.Task_1_1();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            double test;
            double answer = 2.93;
            // Act
            test = main.Task_1_2();
            // Assert
            Assert.AreEqual(Math.Abs(answer - test) < 0.0001, true);
        }

        [TestMethod()]
        public void Task_1_3Test()
        {
            // Arrange
            double test;
            double answer = 54;
            // Act
            test = main.Task_1_3();
            // Assert
            Assert.AreEqual(Math.Abs(answer - test) < 0.0001, true);
        }

        [TestMethod()]
        public void Task_1_4Test()
        {
            // Arrange
            double test1 = 0.5;
            double answer1 = -243.15;
            double test2 = 0.9;
            double answer2 = 1.36;
            double test3 = 0;
            double answer3 = 0;
            // Act
            test1 = main.Task_1_4(test1);
            test2 = main.Task_1_4(test2);
            test3 = main.Task_1_4(test3);
            // Assert
            Assert.AreEqual(Math.Abs(answer1 - test1) < 0.0001, true);
            Assert.AreEqual(Math.Abs(answer2 - test2) < 0.0001, true);
            Assert.AreEqual(Math.Abs(answer2 - test2) < 0.0001, true);
        }

        [TestMethod()]
        public void Task_1_5Test()
        {
            // Arrange
            double test1p = 0.5;
            double test1h = 2;
            double answer1 = 1232.5;
            double test2p = 2;
            double test2h = 0.5;
            double answer2 = 201.25;
            double test3p = 2;
            double test3h = 0;
            double answer3 = 40;
            double test4p = 0;
            double test4h = 2;
            double answer4 = 1140;
            // Act
            double test1 = main.Task_1_5(test1p, test1h);
            double test2 = main.Task_1_5(test2p, test2h);
            double test3 = main.Task_1_5(test3p, test3h);
            double test4 = main.Task_1_5(test4p, test4h);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
            Assert.AreEqual(answer4, test4);
        }
        [TestMethod()]
        public void Task_1_6Test()
        {
            double[] test = new double[17]; int counter = 0;
            double[] answer = new double[17] { 36, 30.62, 25.5, 20.62, 16, 11.62, 7.5, 3.62, 0, -3.38, -6.5, -9.38, -12, -14.38, -16.5, -18.38, -20 };
            // Act
            for (double i = -4; i <= 4; i += 0.5, counter++)
                test[counter] = main.Task_1_6(i);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod()]
        public void Task_1_7Test()
        {
            // Arrange
            int test;
            int answer = 720;
            // Act
            test = main.Task_1_7();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_8Test()
        {
            // Arrange
            int test;
            int answer = 873;
            // Act
            test = main.Task_1_8();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_9Test()
        {
            // Arrange
            double test;
            double answer = 8.37;
            // Act
            test = main.Task_1_9();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_10Test()
        {
            int test;
            int answer = 2187;
            // Act
            test = main.Task_1_10();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_11Test()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Task_1_12Test()
        {
            // Arrange
            double test1 = 1.35;
            double answer1 = 3.72;
            double test2 = 0.9;
            double answer2 = 19.68;
            double test3 = 0;
            double answer3 = 0;
            // Act
            test1 = main.Task_1_12(test1);
            test2 = main.Task_1_12(test2);
            test3 = main.Task_1_12(test3);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
        }

        [TestMethod()]
        public void Task_1_13Test()
        {
            // Arrange
            double[] test = new double[31] { -1.5, -1.4, -1.3, -1.2, -1.1, -1.0, -0.9, -0.8, -0.7, -0.6, -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5 };
            double[] answer = new double[31] { 1, 1, 1, 1, 1, 1, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4, 0.3, 0.2, 0.1, 0, -0.1, -0.2, -0.3, -0.4, -0.5, -0.6, -0.7, -0.8, -0.9, -1, -1, -1, -1, -1, -1 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_13(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.AreEqual(answer[i], test[i]);
        }

        [TestMethod()]
        public void Task_1_14Test()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Task_1_15Test()
        {
            // Arrange
            double test;
            double answer = 1.6;
            // Act
            test = main.Task_1_15();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_1_16Test()
        {
            // Arrange
            (double, int) test;
            double answer = 1.23;
            double power = 18;
            // Act
            test = main.Task_1_16();
            // Assert
            Assert.IsTrue(Math.Abs(answer - test.Item1) < 0.0001);
            Assert.AreEqual(power, test.Item2);
        }

        [TestMethod()]
        public void Task_1_17Test()
        {
            // Arrange
            double[] test = new double[10] { 1, 2, 3, 4, 5, 10, 50, 100, 250, 1000 };
            double[] answer = new double[10] { 112.7, 159.39, 195.22, 225.42, 252.04, 356.51, 798.44, 1131.37, 1799.31, 3701.35 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_17(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.IsTrue(Math.Abs(answer[i] - test[i]) < 0.0001);
        }

        [TestMethod()]
        public void Task_1_18Test()
        {
            // Arrange
            int[] test = new int[8] { 3, 6, 9, 12, 15, 18, 21, 24 };
            int[] answer = new int[8] { 20, 40, 80, 160, 320, 640, 1280, 2560 };
            // Act
            for (int i = 0; i < test.Length; i++)
                test[i] = main.Task_1_18(test[i]);
            // Assert
            for (int i = 0; i < test.Length; i++)
                Assert.IsTrue(Math.Abs(answer[i] - test[i]) < 0.0001);
        }

        [TestMethod()]
        public void Task_2_1Test()
        {
            // Arrange
            double test1 = 1;
            double answer1 = 0.31690467363040187;
            double test2 = 1.6;
            double answer2 = -0.22817053506882662;
            double test3 = -0.35;
            double answer3 = 1.1274055887472998;
            double test4 = 0;
            double answer4 = 1.6349839001848923;
            // Act
            test1 = main.Task_2_1(test1);
            test2 = main.Task_2_1(test2);
            test3 = main.Task_2_1(test3);
            test4 = main.Task_2_1(test4);
            // Assert
            Assert.IsTrue(Math.Abs(answer1 - test1) < 0.00005);
            Assert.IsTrue(Math.Abs(answer2 - test2) < 0.00005);
            Assert.IsTrue(Math.Abs(answer3 - test3) < 0.00005);
            Assert.IsTrue(Math.Abs(answer4 - test4) < 0.00005);
        }

        [TestMethod()]
        public void Task_2_2Test()
        {
            int test;
            int answer = 13;
            // Act
            test = main.Task_2_2();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_3Test()
        {
            // Arrange
            double test1a = 1;
            double test1h = 1;
            double test1p = 10;
            int answer1 = 4;
            double test2a = -0.1;
            double test2h = 1.9;
            double test2p = 5.85;
            int answer2 = 3;
            double test3a = 0;
            double test3h = 5;
            double test3p = 985;
            int answer3 = 20;
            double test4a = 8;
            double test4h = 2;
            double test4p = 0;
            int answer4 = 0;
            double test5a = 0.2;
            double test5h = -1.9;
            double test5p = 12;
            int answer5 = 0;
            // Act
            test1a = main.Task_2_3(test1a, test1h, test1p);
            test2a = main.Task_2_3(test2a, test2h, test2p);
            test3a = main.Task_2_3(test3a, test3h, test3p);
            test4a = main.Task_2_3(test4a, test4h, test4p);
            test5a = main.Task_2_3(test5a, test5h, test5p);
            // Assert
            Assert.AreEqual(answer1, test1a);
            Assert.AreEqual(answer2, test2a);
            Assert.AreEqual(answer3, test3a);
            Assert.AreEqual(answer4, test4a);
            Assert.AreEqual(answer5, test5a);
        }

        [TestMethod()]
        public void Task_2_4Test()
        {
            // Arrange
            double test1 = 1;
            double answer1 = 0;
            double test2 = 0.8;
            double answer2 = 2.78;
            double test3 = -0.35;
            double answer3 = 1.14;
            double test4 = 0;
            double answer4 = 1;
            // Act
            test1 = main.Task_2_4(test1);
            test2 = main.Task_2_4(test2);
            test3 = main.Task_2_4(test3);
            test4 = main.Task_2_4(test4);
            // Assert
            Assert.AreEqual(answer1, test1);
            Assert.AreEqual(answer2, test2);
            Assert.AreEqual(answer3, test3);
            Assert.AreEqual(answer4, test4);
        }

        [TestMethod()]
        public void Task_2_5Test()
        {
            // Arrange
            int test1N = 1;
            int test1M = 0;
            (int, int) answer1 = (0, 0);
            int test2N = 11;
            int test2M = 5;
            (int, int) answer2 = (2, 1);
            int test3N = 7;
            int test3M = 2;
            (int, int) answer3 = (3, 1);
            int test4N = 8;
            int test4M = 2;
            (int, int) answer4 = (4, 0);
            // Act
            (int, int) res1 = main.Task_2_5(test1N, test1M);
            (int, int) res2 = main.Task_2_5(test2N, test2M);
            (int, int) res3 = main.Task_2_5(test3N, test3M);
            (int, int) res4 = main.Task_2_5(test4N, test4M);
            // Assert
            Assert.AreEqual(answer1, res1);
            Assert.AreEqual(answer2, res2);
            Assert.AreEqual(answer3, res3);
            Assert.AreEqual(answer4, res4);
        }

        [TestMethod()]
        public void Task_2_6Test()
        {
            // Arrange
            int test;
            int answer = 42;
            // Act
            test = main.Task_2_6();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_7aTest()
        {
            // Arrange
            double test;
            double answer = 94.87;
            // Act
            test = main.Task_2_7a();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_7bTest()
        {
            // Arrange
            int test;
            int answer = 8;
            // Act
            test = main.Task_2_7b();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_7cTest()
        {
            // Arrange
            int test;
            int answer = 8;
            // Act
            test = main.Task_2_7c();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_8Test()
        {
            // Arrange
            int test;
            int answer = 10;
            // Act
            test = main.Task_2_8();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_9Test()
        {
            // Arrange
            int test;
            int answer = 30;
            // Act
            test = main.Task_2_9();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_2_10Test()
        {
            // Arrange
            int test;
            int answer = 10;
            // Act
            test = main.Task_2_10();
            // Assert
            Assert.AreEqual(answer, test);
        }

        [TestMethod()]
        public void Task_3_1Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer = new double[10] { 1, 0.98, 0.96, 0.92, 0.88, 0.83, 0.76, 0.7, 0.62, 0.54 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_1(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_2Test()
        {
            // Arrange
            double[] x = new double[8] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8 };
            double[,] test = new double[2, 8];
            double[] answer = new double[8] { 0.08, 0.19, 0.32, 0.48, 0.65, 0.83, 0.99, 1.11 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_2(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_3Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer = new double[10] { 2.69, 2.61, 2.49, 2.32, 2.13, 1.93, 1.72, 1.51, 1.32, 1.14 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_3(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_4Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer = new double[10] { 1.03, 1.12, 1.29, 1.55, 1.93, 2.47, 3.23, 4.32, 5.89, 8.15 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_4(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_5Test()
        {
            // Arrange
            double[] x = new double[21] { 5 * Math.PI / 25, 6 * Math.PI / 25, 7 * Math.PI / 25, 8 * Math.PI / 25, 9 * Math.PI / 25, 10 * Math.PI / 25, 11 * Math.PI / 25, 12 * Math.PI / 25, 13 * Math.PI / 25, 14 * Math.PI / 25, 15 * Math.PI / 25, 16 * Math.PI / 25, 17 * Math.PI / 25, 18 * Math.PI / 25, 19 * Math.PI / 25, 20 * Math.PI / 25, 21 * Math.PI / 25, 22 * Math.PI / 25, 23 * Math.PI / 25, 24 * Math.PI / 25, 25 * Math.PI / 25 };
            double[,] test = new double[2, 21];
            double[] answer = new double[21] { -0.72, -0.68, -0.63, -0.57, -0.5, -0.43, -0.34, -0.25, -0.16, -0.05, 0.07, 0.19, 0.32, 0.46, 0.6, 0.76, 0.92, 1.09, 1.27, 1.45, 1.64 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_5(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.01);
            }
        }

        [TestMethod()]
        public void Task_3_6Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer = new double[10] { 0.00, 0.00, 0.01, 0.02, 0.04, 0.07, 0.1, 0.15, 0.21, 0.29 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_6(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_7Test()
        {
            // Arrange
            double[] x = new double[19] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1 };
            double[,] test = new double[2, 19];
            double[] answer = new double[19] { 1.01, 1.01, 1.02, 1.03, 1.05, 1.06, 1.08, 1.10, 1.13, 1.16, 1.19, 1.22, 1.26, 1.29, 1.34, 1.38, 1.43, 1.49, 1.54 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_7(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.0001);
            }
        }

        [TestMethod()]
        public void Task_3_8Test()
        {
            // Arrange
            double[] x = new double[19] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1 };
            double[,] test = new double[2, 19];
            double[] answer = new double[19] { 1.22, 1.35, 1.49, 1.65, 1.82, 2.01, 2.23, 2.46, 2.72, 3.00, 3.32, 3.67, 4.06, 4.48, 4.95, 5.47, 6.05, 6.69, 7.39 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_8(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_9Test()
        {
            // Arrange
            double[] x = new double[9] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5};
            double[,] test = new double[2, 9];
            double[] answer = new double[9] { 0.1, 0.15, 0.2, 0.24, 0.29, 0.34, 0.38, 0.42, 0.46 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_9(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.IsTrue(Math.Abs((test[1, i] - test[0, i])) < 0.00005);
            }
        }
    }
}