using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUtils
{


    static class em
    {
        public static List<T> Repeat<T>(this IEnumerable<T> source, int count)
        {
            List<T> ret = source.ToList();
            Enumerable.Range(1, count - 1).ToList().ForEach(i => ret.AddRange(source));
            return ret;
        }

        public static IEnumerable<string> _TakeLast<string>(IEnumerable<string> source, int count, Func<string, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException("source");
            //return _TakeLast(source, count, predicate);
            return null;
        }

        private static IEnumerable<string> _TakeLast<string>(IEnumerable<string> source, int count, Func<string, bool> predicate)
        {
            Debug.Assert(source != null);

            //if (count <= 0)
            //    yield break;

            return source.Where(predicate).OrderByDescending(s => s).Take(count);

        }

        
    }
}