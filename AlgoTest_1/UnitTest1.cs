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
            for (int i = 0; i < 1000; i++)      
            {
                deq.AddFront(i+1);
            }
            
            Deque<int> deq1 = new Deque<int>();
            for (int i = 0; i < 10000; i++)     
            {
                deq1.AddFront(i + 1);
            }

            Deque<int> deq2 = new Deque<int>();
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


        // Добавление в хвост и удаление всех из головы
        //
        [TestMethod]
        public void TestDequeA_7()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq.AddTail(i + 1);
            }
            
            for (int i = 0; i < 100000; i++)
            {
                Assert.AreEqual(i+1, deq.RemoveFront());
            }

            Assert.AreEqual(0, deq.Size());
        }


        // Добавление в хвост. Проверка next и prev (head)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_1()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddTail(i + 1);
            }
            Node<int> node = deq.list.head.next;
            for (int i = 2; i < 4; i++)
            {
                Assert.AreEqual(i-1, node.prev.item);
                Assert.AreEqual(i, node.item);
                Assert.AreEqual(i+1, node.next.item);
                node = node.next;
            }
            
        }


        // Добавление в хвост. Проверка next и prev (tail)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_2()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddTail(i + 1);
            }
            Node<int> node = deq.list.tail.prev;
            for (int i = 3; i > 1; i--)
            {
                Assert.AreEqual(i - 1, node.prev.item);
                Assert.AreEqual(i, node.item);
                Assert.AreEqual(i + 1, node.next.item);
                node = node.prev;
            }

        }


        // Добавление в голову. Проверка next и prev (head)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_3()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddFront(i + 1);
            }
            Node<int> node = deq.list.head.next;
            for (int i = 3; i > 1; i--)
            {
                Assert.AreEqual(i + 1, node.prev.item);
                Assert.AreEqual(i, node.item);
                Assert.AreEqual(i - 1, node.next.item);
                node = node.next;
            }

        }


        // Добавление в голову. Проверка next и prev (tail)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_4()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddFront(i + 1);
            }
            Node<int> node = deq.list.tail.prev;
            for (int i = 2; i < 4; i++)
            {
                Assert.AreEqual(i + 1, node.prev.item);
                Assert.AreEqual(i, node.item);
                Assert.AreEqual(i - 1, node.next.item);
                node = node.prev;
            }

        }


        // Добавление в голову. Проверка next и prev на null (tail)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_5()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddFront(i + 1);
            }
            Node<int> node = deq.list.tail;

            Assert.AreEqual(null, node.next);
            Assert.AreEqual(null, node.prev.next.next);
        }


        // Добавление в голову. Проверка next и prev на null (head)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_6()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 4; i++)
            {
                deq.AddFront(i + 1);
            }
            Node<int> node = deq.list.head;

            Assert.AreEqual(null, node.prev);
            Assert.AreEqual(null, node.next.prev.prev);
        }





        // Queue_1 class tests
        //

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
