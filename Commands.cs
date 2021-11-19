using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiValueDictionary
{
    public static class Commands
    {
        private static Dictionary<string, HashSet<string>> multiDictionary = new Dictionary<string, HashSet<string>>();
        
        public static bool Add(string key, string value)
        {
            if (multiDictionary.ContainsKey(key))
            {
                if (!multiDictionary[key].Contains(value))
                {
                    multiDictionary[key].Add(value);
                    return true;
                }
                else
                {
                    Console.WriteLine("member already exists for key");
                    return false;
                }
            }
            else
            {
                multiDictionary.Add(key, new HashSet<string>(){value});
                return true;
            }
        }

        public static void PrintKeys()
        {
            var keys = multiDictionary.Keys.ToList();
            foreach (var k in keys)
            {
                Console.WriteLine(k);
            }
            if(keys.Count==0) Console.WriteLine("No Keys to print");
        }

        public static bool MemberExists(string key, string value)
        {
            if (multiDictionary.ContainsKey(key))
            {
                return multiDictionary[key].Contains(value);
            }

            return false;
        }

        public static void PrintAllMembers()
        {
            foreach (var key in multiDictionary.Keys)
            {
                foreach (var value in multiDictionary[key])
                {
                    Console.WriteLine(value);
                }
            }

            if (multiDictionary.Count==0) Console.WriteLine("No Members to print");
        }

        public static bool KeyExists(string key)
        {
            return multiDictionary.ContainsKey(key);
        }
        
        public static void PrintMembers(string key)
        {
            if (multiDictionary.ContainsKey(key))
            {
                foreach (var value in multiDictionary[key])
                {
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine("Key doesn't exist");
        }

        public static void Remove(string key, string value)
        {
            if (multiDictionary.ContainsKey(key))
            {
                if (multiDictionary[key].Contains(value))
                {
                    multiDictionary[key].Remove(value);
                    if(multiDictionary[key].Count==0) multiDictionary.Remove(key);
                    return;
                }
                Console.WriteLine("member doesn't exist");
                return;
            }

            Console.WriteLine("key doesn't exist");
        }

        public static void RemoveAll(string key)
        {
            if (multiDictionary.ContainsKey(key))
            {
                multiDictionary[key].Clear();
                multiDictionary.Remove(key);
                return;
            }

            Console.WriteLine("key doesn't exist");
        }

        public static void Clear()
        {
            multiDictionary.Clear();
        }

        public static void Items()
        {
            foreach (var key in multiDictionary.Keys)
            {
                foreach (var value in multiDictionary[key])
                {
                    Console.WriteLine("{0}: {1}",key, value);
                }
            }
        }
    }
}
