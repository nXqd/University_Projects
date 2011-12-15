using ktpm_bt5.core;

namespace ktpm_bt5 {
    internal class Program {
        private static void Main() {
            var strings = DataReader.Read();
            DataParser.Run(strings);
        }
    }
}