using System;
using System.Collections.Generic;
using System.Linq;

namespace Automato.Application.Validation
{
    public static class AssertionConcern
    {
        public static void CollectionNotEmpty(IEnumerable<string> collection, string message)
        {
            if(collection == null || !collection.Any()) throw new ArgumentNullException(message);
        }

        public static void CollectionContains(IEnumerable<string> collection, string item, string message)
        {
            if (!collection.Contains(item)) throw new ArgumentException(message);
        }

        public static void CollectionContains(IEnumerable<string> collection, IEnumerable<string> items, string message)
        {
            if (!items.Any(item => !collection.Contains(item))) throw new ArgumentException(message);
        }

        public static void CollectionLengthBiggerThan(IEnumerable<string> collection, int minLength, string message)
        {
            if (collection.Count() < minLength) throw new ArgumentOutOfRangeException(message);
        }
    }
}
