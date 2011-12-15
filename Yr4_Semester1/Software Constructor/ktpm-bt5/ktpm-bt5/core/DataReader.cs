using System;
using System.Collections.Generic;
using System.IO;

namespace ktpm_bt5.core {
    public class DataReader {
        #region prop

        private const String Path = "conf/bootstrap/data.txt";

        #endregion

        #region lazy constructor

        private static readonly Lazy<DataReader> _instance
            = new Lazy<DataReader>(() => new DataReader());

        private DataReader() {
        }

        public static DataReader Instance {
            get { return _instance.Value; }
        }

        #endregion

        public static List<String> Read() {
            var results = new List<string>();

            try {
                using (var sr = new StreamReader(Path)) {
                    // remove comment line from out data
                    var firstLine = sr.ReadLine();
                    var commentLines = int.Parse(firstLine.Substring(18)) - 1;
                    for (var i = 0; i < commentLines; i++) sr.ReadLine();

                    String line;
                    while ((line = sr.ReadLine()) != null) results.Add(line.Replace(" ", ""));
                }
            }
            catch (Exception e) {
                // Let the user know what went wrong.
                Console.WriteLine(
                    "Make sure your file is avaiable in right name (data.txt) and right place (conf/bootstrap/data.txt) !");
                Console.WriteLine(e.Message);
            }

            return results;
        }
    }
}