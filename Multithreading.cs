using System;
using System.Threading;

public class MyThread {

        public static void Thread1() {
                for (int i = 0; i < 10; i++) {
                        Console.WriteLine("Thread1 {0}", i);
                }
        }

        public static void Thread2() {
                for (int i = 0; i < 10; i++) {
                        Console.WriteLine("Thread2 {0}", i);
                }
        }
}

public class MyClass {

        public static void Main() {
                Console.WriteLine("Before start thread");

                Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1 ) );
                Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2 ) );

                tid1.Start();
                tid2.Start();
        }
}