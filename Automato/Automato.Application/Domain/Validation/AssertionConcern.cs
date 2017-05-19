using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Automato.App.Domain.Validation
{
    public static class AssertionConcern
    {
        public static void CollectionNotEmpty(IEnumerable<string> collection, string message)
        {
            if(collection == null || !collection.Any()) throw new ArgumentException(message);
        }

        public static void CollectionContains(IEnumerable<string> collection, string item, string message)
        {
            if (!collection.Contains(item)) throw new ArgumentException(message);
        }

        public static void CollectionContains(IEnumerable<string> collection, IEnumerable<string> items, string message)
        {
            if (items.Any(item => !collection.Contains(item))) throw new ArgumentException(message);
        }

        public static void CollectionLengthBiggerThan(IEnumerable<string> collection, int minLength, string message)
        {
            if (collection.Count() < minLength) throw new ArgumentException(message);
        }

        public static void FileExists(string fileName, string message)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException(message);
        }

        public static void FileIsEmpty(string fileName, string message)
        {
            if (new FileInfo(fileName).Length == 0) throw new ArgumentException(message);
        }
    }
}
