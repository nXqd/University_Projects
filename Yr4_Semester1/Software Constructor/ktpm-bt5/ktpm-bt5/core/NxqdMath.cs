using System;

namespace ktpm_bt5.core {
    public class NxqdMath {
        public static int Result(String function, int a, int b) {
            switch (function) {
                case "f1":
                    return a + 1;
                case "f2":
                    return a - 1;
                case "f3":
                    return a + b;
                case "f4":
                    return a - b;
                case "f5":
                    return a;
                case "f6":
                    Console.WriteLine(" {0} ", a);
                    return int.MinValue;
            }
            return 0;
        }
    }
}