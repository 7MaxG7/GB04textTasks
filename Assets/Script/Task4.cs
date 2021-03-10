using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaxG {
    
    /// <summary>
    /// var d = dict. OrderBy ( delegate ( KeyValuePair < string , int > pair) {
    ///     return pair. Value ;
    /// });
    /// </summary>
    public sealed class Task4 {
        
        /// <summary>
        /// а. Свернуть обращение к OrderBy с использованием лямбда-выражения =>.
        /// </summary>
        public void ToLambda() {
            Dictionary<string, int> dict = new Dictionary<string, int>() {
                {"four", 4},
                {"two", 2},
                {"one", 1},
                {"three", 3},
            };
            var d = dict.OrderBy(pair => pair.Value);
            foreach (var pair in d) {
                Debug.Log($"{ pair. Key } - { pair. Value }");
            }
        }

        /// <summary>
        /// b. * Развернуть обращение к OrderBy с использованием делегата
        /// </summary>
        public void ToDelegate() {
            Dictionary<string, int> dict = new Dictionary<string, int>() {
                {"four", 4},
                {"two", 2},
                {"one", 1},
                {"three", 3},
            };
            var d = dict.OrderBy(MyDelegate);
            foreach (var pair in d) {
                Debug.Log($"{ pair. Key } - { pair. Value }");
            }
        }
        
        private int MyDelegate(KeyValuePair<string, int> pair) {
            return pair.Value;
        }
    }
}