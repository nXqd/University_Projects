using System;
using System.Collections.Generic;

namespace ktpm_bt5.core {
    public class DataParser {
        #region lazy constructor

        private static readonly Lazy<DataParser> _instance
            = new Lazy<DataParser>(() => new DataParser());

        private DataParser() {
        }

        public static DataParser Instance {
            get { return _instance.Value; }
        }

        #endregion

        /// <summary>
        ///   Example read string to parse : abc=f1.6 , cd=f3.6768.123
        /// </summary>
        /// <returns></returns>
        public static void Run(List<String> strings) {
            var models = new Dictionary<string, int>();
            var variables = new List<String>();
            foreach (var s in strings) {
                var equalSplit = new List<string>(s.Split('='));
                if (equalSplit.Count > 1)
                    variables = new List<string>(equalSplit[1].Split('.'));
                else variables = new List<string>(equalSplit[0].Split('.'));

                int a, b = 0;

                if (!int.TryParse(variables[1], out a)) // find variables in calculated function
                    a = models[variables[1]];

                if (variables.Count > 2 && !int.TryParse(variables[2], out b)) // find variables in calculated function
                    b = models[variables[2]];

                var result = NxqdMath.Result(variables[0], a, b);
                models.Add(equalSplit[0], result);
            }
        }
    }
}