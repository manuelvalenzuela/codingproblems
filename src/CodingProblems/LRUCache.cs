using System.Collections.Generic;

namespace CodingProblems
{
    public class LRUCache
    {
        private LinkedList<int> cache;
        private Dictionary<int, int> fastAccessCache;
        private int _capacity;

        public LRUCache(int capacity)
        {
            cache = new LinkedList<int>();
            _capacity = capacity;
            fastAccessCache = new Dictionary<int, int>();
        }

        public int Get(int key)
        {
            if (!fastAccessCache.TryGetValue(key, out var actualValue))
            {
                return -1;
            }

            if (cache.First.Value == key)
            {
                return actualValue;
            }

            cache.Remove(key);
            cache.AddFirst(key);

            return actualValue;
        }

        public void Put(int key, int value)
        {
            if (fastAccessCache.TryGetValue(key, out var actualValue))
            {
                fastAccessCache[key] = value;
                cache.Remove(key);
            }
            else
            {
                if (cache.Count >= _capacity)
                {
                    fastAccessCache.Remove(cache.Last.Value);
                    cache.RemoveLast();
                }
                fastAccessCache.Add(key, value);
            }

            cache.AddFirst(key);
        }
    }
}