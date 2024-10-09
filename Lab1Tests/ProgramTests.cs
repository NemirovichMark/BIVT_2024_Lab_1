using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer1, test1, 0.0001);
            Assert.AreEqual(answer2, test2, 0.0001);
            Assert.AreEqual(answer3, test3, 0.0001);
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
            Assert.AreEqual(answer1, test1, 0.0001);
            Assert.AreEqual(answer2, test2, 0.0001);
            Assert.AreEqual(answer3, test3, 0.0001);
            Assert.AreEqual(answer4, test4, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
        }

        [TestMethod()]
        public void Task_1_10Test()
        {
            int test;
            int answer = 2187;
            // Act
            test = main.Task_1_10();
            // Assert
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer1, test1, 0.0001);
            Assert.AreEqual(answer2, test2, 0.0001);
            Assert.AreEqual(answer3, test3, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test.Item1, 0.0001);
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
                Assert.AreEqual(answer[i], test[i], 0.0001);
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
                Assert.AreEqual(answer[i], test[i]);
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
            Assert.AreEqual(answer1, test1, 0.0001);
            Assert.AreEqual(answer2, test2, 0.0001);
            Assert.AreEqual(answer3, test3, 0.0001);
            Assert.AreEqual(answer4, test4, 0.0001);
        }

        [TestMethod()]
        public void Task_2_2Test()
        {
            int test;
            int answer = 13;
            // Act
            test = main.Task_2_2();
            // Assert
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer1, test1a, 0.0001);
            Assert.AreEqual(answer2, test2a, 0.0001);
            Assert.AreEqual(answer3, test3a, 0.0001);
            Assert.AreEqual(answer4, test4a, 0.0001);
            Assert.AreEqual(answer5, test5a, 0.0001);
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
            Assert.AreEqual(answer1, test1, 0.0001);
            Assert.AreEqual(answer2, test2, 0.0001);
            Assert.AreEqual(answer3, test3, 0.0001);
            Assert.AreEqual(answer4, test4, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
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
            Assert.AreEqual(answer, test, 0.0001);
        }
        [TestMethod()]
        public void Task_3_1Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer_S = new double[10] { 0.995, 0.98, 0.9553375, 0.9210666666666666, 0.8776041666666666, 0.8254, 0.7648407652777778, 0.6967025777777778, 0.6215993875, 0.5402777777777777 };
            double[] answer_y = new double[10] { 0.9950041652780258, 0.9800665778412416, 0.955336489125606, 0.9210609940028851, 0.8775825618903728, 0.8253356149096783, 0.7648421872844885, 0.6967067093471654, 0.6216099682706644, 0.5403023058681398 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_1(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_2Test()
        {
            // Arrange
            double[] x = new double[8] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8 };
            double[,] test = new double[2, 8];
            double[] answer_S = new double[8] { 0.0814177848998413, 0.1868519363168222, 0.31862200371667226, 0.4758924706809592, 0.6513119602707486, 0.8294836394694839, 0.9897546975962459, 1.112103931594239 };
            double[] answer_y = new double[8] { 0.08140964393544776, 0.18677936350519359, 0.3186429098779893, 0.47591414437456914, 0.6512392830509103, 0.8294964000072793, 0.9898495063120466, 1.1121765727275472 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_2(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_3Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer_S = new double[10] { 2.691248985686179, 2.612188250758326, 2.486877948066567, 2.3239116638734316, 2.133946805639821, 1.9284273029461472, 1.7179407535719313, 1.5124407582589754, 1.319288567445428, 1.1438419924605643 };
            double[] answer_y = new double[10] { 2.691268139166703, 2.6122204929844544, 2.486856868603152, 2.3238842457941966, 2.133930111437405, 1.9283342378052784, 1.7179999609519054, 1.5124670047163074, 1.3193027107322821, 1.1438356437916404 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_3(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_4Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer_S = new double[10] { 1.03025, 1.124, 1.2911005000000002, 1.5490244266666668, 1.9259440104166667, 2.4652848332799997, 3.231964438995851, 4.323963522624692, 5.889432173197266, 8.154786706349206 };
            double[] answer_y = new double[10] { 1.0302511704258512, 1.1240756361277793, 1.2911256547721481, 1.5490343497091896, 1.926038125031612, 2.465326593043785, 3.23198611551165, 4.323976404815291, 5.889518925092356, 8.154845485377136 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_4(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_5Test()
        {
            // Arrange
            double[] x = new double[21] { 5 * Math.PI / 25, 6 * Math.PI / 25, 7 * Math.PI / 25, 8 * Math.PI / 25, 9 * Math.PI / 25, 10 * Math.PI / 25, 11 * Math.PI / 25, 12 * Math.PI / 25, 13 * Math.PI / 25, 14 * Math.PI / 25, 15 * Math.PI / 25, 16 * Math.PI / 25, 17 * Math.PI / 25, 18 * Math.PI / 25, 19 * Math.PI / 25, 20 * Math.PI / 25, 21 * Math.PI / 25, 22 * Math.PI / 25, 23 * Math.PI / 25, 24 * Math.PI / 25, 25 * Math.PI / 25 };
            double[,] test = new double[2, 21];
            double[] answer_S = new double[21] { -0.7238669986035898, -0.6800294442208453, -0.6288481110204658, -0.569618900175326, -0.502415222304551, -0.42784355892031517, -0.3444302698749578, -0.25471794631816463, -0.154549592446217, -0.0481070331593196, 0.06595397252545787, 0.18738245716549853, 0.31773518869017325, 0.455691260522659, 0.6043531113374436, 0.7562775769271236, 0.9208780246049805, 1.0853866065595255, 1.2696395428461213, 1.4468099697676642, 1.6349839001848923 };
            double[] answer_y = new double[21] { -0.7237709894132196, -0.6803447300484264, -0.6290227871627618, -0.5698051607562256, -0.5026918508288181, -0.4276828573805389, -0.3447781804113883, -0.25397781992136625, -0.15528177591047254, -0.048690048378707496, 0.06579736267392877, 0.18818045724743715, 0.31845923534181686, 0.45663369695706757, 0.60270384209319, 0.756669670750184, 0.9185311829280497, 1.0882883786267863, 1.2659412578463942, 1.4514898205868745, 1.6449340668482262 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_5(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_6Test()
        {
            // Arrange
            double[] x = new double[10] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
            double[,] test = new double[2, 10];
            double[] answer_S = new double[10] { 0.00033333333333333343, 0.0026666666666666674, 0.008837999999999999, 0.02065066666666667, 0.039806547619047616, 0.06745585371428571, 0.1050408431962626, 0.1533464142765823, 0.21314684757672148, 0.28534915819725754 };
            double[] answer_y = new double[10] { 0.0003326695080368286, 0.002645691121938007, 0.008843952990437581, 0.020693698725171655, 0.03977975562550384, 0.0674852601839972, 0.1049908434699604, 0.15328757262331327, 0.2131976671167885, 0.2853981633974483 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_6(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_7Test()
        {
            // Arrange
            double[] x = new double[19] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1 };
            double[,] test = new double[2, 19];
            double[] answer_S = new double[19] { 1.005, 1.01125, 1.02, 1.0314127604166667, 1.0453375, 1.0618752604166668, 1.0810666666666668, 1.1029585937500002, 1.1276041666666667, 1.1550627604166668, 1.1854, 1.218792508875868, 1.2551675680555554, 1.2946807861328125, 1.3374307555555558, 1.383524079188368, 1.4330756125000002, 1.486208721375868, 1.5430555555555556 };
            double[] answer_y = new double[19] { 1.0050041680558035, 1.0112711095766704, 1.020066755619076, 1.0314130998795732, 1.0453385141288605, 1.0618778191559852, 1.081072371838455, 1.1029701685559712, 1.1276259652063807, 1.155101414123941, 1.1854652182422676, 1.2187933028874562, 1.255169005630943, 1.2946832846768448, 1.3374349463048447, 1.3835308919373588, 1.4330863854487745, 1.4862253413851736, 1.5430806348152437 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_7(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_8Test()
        {
            // Arrange
            double[] x = new double[19] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1 };
            double[,] test = new double[2, 19];
            double[] answer_S = new double[19] { 1.2213333333333334, 1.3498375, 1.4917333333333334, 1.6486979166666667, 1.8220480000000001, 2.0137348180555557, 2.2254947555555558, 2.4594963625, 2.7182539682539684, 3.00410556827381, 3.320100790857142, 3.669263142480407, 4.055133912444445, 4.481670706612723, 4.95299704839224, 5.473881853361405, 6.049530173028572, 6.685859858186858, 7.388994708994708 };
            double[] answer_y = new double[19] { 1.2214027581601699, 1.3498588075760032, 1.4918246976412703, 1.6487212707001282, 1.8221188003905089, 2.0137527074704766, 2.225540928492468, 2.45960311115695, 2.718281828459045, 3.0041660239464334, 3.3201169227365472, 3.6692966676192444, 4.0551999668446745, 4.4816890703380645, 4.953032424395115, 5.4739473917272, 6.0496474644129465, 6.6858944422792685, 7.38905609893065 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_8(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }

        [TestMethod()]
        public void Task_3_9Test()
        {
            // Arrange
            double[] x = new double[9] { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5 };
            double[,] test = new double[2, 9];
            double[] answer = new double[9] { 0.1, 0.15, 0.2, 0.24, 0.29, 0.34, 0.38, 0.42, 0.46 };
            double[] answer_S = new double[9] { 0.09966666666666667, 0.148875, 0.19733333333333333, 0.24498697916666665, 0.29148599999999997, 0.33675877083333333, 0.3804806095238096, 0.4227817489955357, 0.46368427579365074 };
            double[] answer_y = new double[9] { 0.09966865249116204, 0.14888994760949725, 0.19739555984988078, 0.24497866312686414, 0.2914567944778671, 0.33667481938672716, 0.3805063771123649, 0.4228539261329407, 0.46364760900080615 };
            // Act
            for (int i = 0; i < x.Length; i++)
                (test[0, i], test[1, i]) = main.Task_3_9(x[i]);
            // Assert
            for (int i = 0; i < x.Length; i++)
            {
                Assert.AreEqual(answer_S[i], test[0, i], 0.00005);
                Assert.AreEqual(answer_y[i], test[1, i], 0.00005);
            }
        }
    }
}