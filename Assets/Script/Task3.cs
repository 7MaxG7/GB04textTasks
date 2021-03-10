using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal.Profiling.Memory.Experimental;

namespace MaxG {

    public sealed class Task3<T> {
        
        /// <summary>
        /// Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в
        /// данной коллекции:
        /// a. для целых чисел;
        /// b. * для обобщенной коллекции;
        /// </summary>
        public Dictionary<T, int> AmountCounter(List<T> source) {
            Dictionary<T, int> counter = new Dictionary<T, int>();
            for (int i = 0; i < source.Count; i++) {
                if (!counter.ContainsKey(source[i])) {
                    counter[source[i]] = 0;
                }
                ++counter[source[i]];
            }
            return counter;
        }

        /// <summary>
        /// ** используя Linq.
        /// </summary>
        public Dictionary<T, int> LinkAmountCounter(List<T> source) {
            return source.GroupBy(item => item).ToDictionary(
                item => item.Key,
                item => item.Count()
            );
        }
    }
}