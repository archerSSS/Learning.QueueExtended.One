using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;


namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        // Простое добавление
        //
        [TestMethod]
        public void TestDequeA_1()
        {
            Deque<int> deq = new Deque<int>();
            deq.AddFront(1);
            int i = deq.RemoveFront();

            Assert.AreEqual(1, i);
        }


        // Простое добавление разного количества элементов в три хранилища
        //
        [TestMethod]
        public void TestDequeA_2()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 1000; i++)      // 1mc
            {
                deq.AddFront(i+1);
            }
            
            Deque<int> deq1 = new Deque<int>();
            for (int i = 0; i < 10000; i++)     // 16mc
            {
                deq1.AddFront(i + 1);
            }

            Deque<int> deq2 = new Deque<int>();
            for (int i = 0; i < 100000; i++)    // ~1.9c
            {
                deq2.AddFront(i + 1);
            }


            Assert.AreEqual(1000, deq.Size());
            Assert.AreEqual(10000, deq1.Size());
            Assert.AreEqual(100000, deq2.Size());
        }

        
        // Добавление и удаление. Проверка на порядок добавленных
        //
        [TestMethod]
        public void TestDequeA_3()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 5; i++)
            {
                deq.AddFront(i + 1);
            }
            
            Assert.AreEqual(5, deq.RemoveFront());
            Assert.AreEqual(4, deq.RemoveFront());
        }


        // Добавление и удаление дважды чередуя. Проверка на сохранение порядка элементов.
        //
        [TestMethod]
        public void TestDequeA_4()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 5; i++)
            {
                deq.AddFront(i + 1);
            }

            Assert.AreEqual(5, deq.RemoveFront());

            for (int i = 0; i < 2; i++)
            {
                deq.AddFront(i + 10);
            }

            Assert.AreEqual(11, deq.RemoveFront());
            Assert.AreEqual(10, deq.RemoveFront());
            Assert.AreEqual(4, deq.RemoveFront());
        }


        // Добавление и удаление всех
        //
        [TestMethod]
        public void TestDequeA_5()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 100000; i++)        // ~1.9mc
            {
                deq.AddFront(i + 1);
            }
               
            for (int i = 0; i < 100000; i++)        // 467mc
            {
                deq.RemoveFront();
            }

            Assert.AreEqual(0, deq.Size());
        }


        // Добавление в хвост и удаление всех из
        //
        [TestMethod]
        public void TestDequeA_6()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq.AddTail(i + 1);
            }

            for (int i = 0; i < 100000; i++)
            {
                deq.RemoveTail();
            }

            Assert.AreEqual(0, deq.Size());
        }





        // Простое добавление
        //
        [TestMethod]
        public void TestDequeB_1()
        {
            Deque<int> deq = new Deque<int>();
            deq.AddFront(1);
            int i = deq.RemoveFront();

            Assert.AreEqual(1, i);
        }


        // Простое добавление разного количества элементов в три хранилища
        //
        [TestMethod]
        public void TestDequeB_2()
        {
            Deque_1<int> deq = new Deque_1<int>();
            for (int i = 0; i < 1000; i++)
            {
                deq.AddFront(i + 1);
            }

            Deque_1<int> deq1 = new Deque_1<int>();
            for (int i = 0; i < 10000; i++)
            {
                deq1.AddFront(i + 1);
            }

            Deque_1<int> deq2 = new Deque_1<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq2.AddFront(i + 1);
            }


            Assert.AreEqual(1000, deq.Size());
            Assert.AreEqual(10000, deq1.Size());
            Assert.AreEqual(100000, deq2.Size());
        }


        // Добавление и удаление. Проверка на порядок добавленных
        //
        [TestMethod]
        public void TestDequeB_3()
        {
            Deque_1<int> deq = new Deque_1<int>();
            for (int i = 0; i < 5; i++)
            {
                deq.AddFront(i + 1);
            }

            Assert.AreEqual(5, deq.RemoveFront());
            Assert.AreEqual(4, deq.RemoveFront());
        }


        // Добавление и удаление дважды чередуя. Проверка на сохранение порядка элементов.
        //
        [TestMethod]
        public void TestDequeB_4()
        {
            Deque_1<int> deq = new Deque_1<int>();
            for (int i = 0; i < 5; i++)
            {
                deq.AddFront(i + 1);
            }

            Assert.AreEqual(5, deq.RemoveFront());

            for (int i = 0; i < 2; i++)
            {
                deq.AddFront(i + 10);
            }

            Assert.AreEqual(11, deq.RemoveFront());
            Assert.AreEqual(10, deq.RemoveFront());
            Assert.AreEqual(4, deq.RemoveFront());
        }


        // Добавление и удаление всех
        //
        [TestMethod]
        public void TestDequeB_5()
        {
            Deque_1<int> deq = new Deque_1<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq.AddFront(i + 1);
            }

            for (int i = 0; i < 100000; i++)
            {
                deq.RemoveFront();
            }

            Assert.AreEqual(0, deq.Size());
        }


        // Добавление в хвост и удаление всех из
        //
        [TestMethod]
        public void TestDequeB_6()
        {
            Deque_1<int> deq = new Deque_1<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq.AddTail(i + 1);
            }

            for (int i = 0; i < 100000; i++)
            {
                deq.RemoveTail();
            }

            Assert.AreEqual(0, deq.Size());
        }
    }
}
