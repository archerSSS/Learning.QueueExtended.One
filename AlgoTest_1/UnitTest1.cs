﻿using System;
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


        // Добавление в голову и хвост и удаление из хвоста
        //
        [TestMethod]
        public void TestDequeA_8()
        {
            Deque<int> deq = new Deque<int>();

            for (int i = 1; i <= 10; i++)
            {
                deq.AddFront(i * (-1));
                deq.AddTail(i);
            }

            for (int i = 10; i > -11; i--)
            {
                if (i == 0) continue;
                Assert.AreEqual(i, deq.RemoveTail());
            }
        }


        // Добавление в голову и удаление из головы и хвоста
        //
        [TestMethod]
        public void TestDequeA_9()
        {
            Deque<int> deq = new Deque<int>();

            for (int i = 1; i <= 10; i++)
            {
                deq.AddFront(i);
            }

            for (int i = 5; i > 0; i--)
            {
                Assert.AreEqual(6 - i, deq.RemoveTail());
                Assert.AreEqual(5 + i, deq.RemoveFront());
            }
        }


        // Удаление из пустого списка
        //
        [TestMethod]
        public void TestDequeA_10()
        {
            Deque<int> deq = new Deque<int>();
            Assert.AreEqual(0, deq.RemoveFront());
        }


        // Удаление из пустого списка
        //
        [TestMethod]
        public void TestDequeA_11()
        {
            Deque<int> deq = new Deque<int>();
            Assert.AreEqual(0, deq.RemoveTail());
        }


        // Удаление из пустого списка
        //
        [TestMethod]
        public void TestDequeA_12()
        {
            Deque<String> deq = new Deque<String>();
            Assert.AreEqual(null, deq.RemoveFront());
        }


        // Удаление из пустого списка
        //
        [TestMethod]
        public void TestDequeA_13()
        {
            Deque<string> deq = new Deque<String>();
            Assert.AreEqual(null, deq.RemoveTail());
        }


        // Добавление-Удаление. 
        // Tail-Tail; Head-Head; Tail-Head; Head-Tail
        //
        [TestMethod]
        public void TestDequeA_HeadTail_1()
        {
            Deque<int> deq = new Deque<int>();

            // Добавление в хвост и удаление из хвоста
            //
            for (int i = 0; i < 100000; i++)
            {
                deq.AddTail(i + 1);
            }
            for (int i = 100000; i > 0; i--)
            {
                Assert.AreEqual(i, deq.RemoveTail());
            }
            
            // Добавление в голову и удаление из головы
            //
            for (int i = 0; i < 100000; i++)
            {
                deq.AddFront(i + 1);
            }
            for (int i = 100000; i > 0; i--)
            {
                Assert.AreEqual(i, deq.RemoveFront());
            }

            // Добавление в хвост и удаление из головы
            //
            for (int i = 0; i < 100000; i++)
            {
                deq.AddTail(i + 1);
            }
            for (int i = 1; i <= 100000; i++)
            {
                Assert.AreEqual(i, deq.RemoveFront());
            }

            // Добавление в голову и удаление из хвоста
            //
            for (int i = 0; i < 100000; i++)
            {
                deq.AddFront(i + 1);
            }
            for (int i = 1; i <= 100000; i++)
            {
                Assert.AreEqual(i, deq.RemoveTail());
            }
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


        // Добавление в голову и удаление с головы и хвоста. Проверка next и prev на null (head)
        //
        [TestMethod]
        public void TestDequeA_NextPrev_7()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 10; i++)
            {
                deq.AddFront(i + 1);
            }

            int i1 = deq.RemoveFront();
            int i2 = deq.RemoveTail();

            Node<int> node1 = deq.list.head;
            Node<int> node2 = deq.list.tail;
            
        }


        // Добавление. Удаление в цикле с проверкой на количество
        //
        [TestMethod]
        public void TestDequeA_Size_1()
        {
            Deque<int> deq = new Deque<int>();
            for (int i = 0; i < 100000; i++)
            {
                deq.AddFront(i + 1);
            }

            Assert.AreEqual(100000, deq.Size());
            while (deq.Size() > 0)
            {
                deq.RemoveTail();
            }
            Assert.AreEqual(0, deq.Size());
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


        // Проверка работы со списком напрямую. 
        // Добавление-Удаление. 
        // Tail-Tail; Head-Head; Tail-Head; Head-Tail
        //
        [TestMethod]
        public void TestStepList_1()
        {
            StepList<int> list = new StepList<int>();

            // Добавление в хвост и удаление из хвоста
            //
            for (int i = 0; i < 100000; i++)
            {
                list.AddTail(new Node<int>(i + 1));
            }
            for (int i = 100000; i > 0; i--)
            {
                Assert.AreEqual(i, list.RemoveTail());
            }
            
            // Добавление в голову и удаление из головы
            //
            for (int i = 0; i < 100000; i++)
            {
                list.AddHead(new Node<int>(i + 1));
            }
            for (int i = 100000; i > 0; i--)
            {
                Assert.AreEqual(i, list.RemoveHead());
            }

            // Добавление в хвост и удаление из головы
            //
            for (int i = 0; i < 100000; i++)
            {
                list.AddTail(new Node<int>(i + 1));
            }
            for (int i = 1; i <= 100000; i++)
            {
                Assert.AreEqual(i, list.RemoveHead());
            }

            // Добавление в голову и удаление из хвоста
            //
            for (int i = 0; i < 100000; i++)
            {
                list.AddHead(new Node<int>(i + 1));
            }
            for (int i = 1; i <= 100000; i++)
            {
                Assert.AreEqual(i, list.RemoveTail());
            }
        }






        // Палиндром
        //
        [TestMethod]
        public void TestDequePalindrome_1()
        {
            String str1 = "sattas";
            String str2 = "1122";
            String str3 = "grey";
            String str4 = "t1oo1t";
            String str5 = "sayayas";
            
            Deque<char> deq1 = new Deque<char>();
            Deque<char> deq2 = new Deque<char>();
            Deque<char> deq3 = new Deque<char>();
            Deque<char> deq4 = new Deque<char>();
            Deque<char> deq5 = new Deque<char>();

            PalindromeAnalizer pda = new PalindromeAnalizer();
            deq1 = pda.StringToDeque(str1);
            deq2 = pda.StringToDeque(str2);
            deq3 = pda.StringToDeque(str3);
            deq4 = pda.StringToDeque(str4);
            deq5 = pda.StringToDeque(str5);

            Assert.AreEqual(true, pda.IsPalindromic(deq1));
            Assert.AreEqual(false, pda.IsPalindromic(deq2));
            Assert.AreEqual(false, pda.IsPalindromic(deq3));
            Assert.AreEqual(true, pda.IsPalindromic(deq4));
            Assert.AreEqual(true, pda.IsPalindromic(deq5));
        }
    }
}