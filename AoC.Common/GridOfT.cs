using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC.Common
{
    public class Grid2D<TValue> where TValue : class, ICoordinate
    {
        private readonly List<TValue> _allItems = new List<TValue>();

        
    }

    public class Grid<TKey,TValue> 
        where TKey : struct 
        where TValue : class
    {
        private readonly Dictionary<TKey, TValue> _storage = new Dictionary<TKey, TValue>();

        public List<TValue> GetAll()
        {
            return _storage.Values.ToList();
        }

        public bool TryGet(TKey key, out TValue p)
        {
            var result = _storage.TryGetValue(key, out var point);
            p = point;

            return result;
        }

        public bool Add(TKey key, TValue point)
        {
            if (_storage.ContainsKey(key))
            {
                return false;
            }

            _storage[key] = point;
            return true;
        }

        public bool Remove(TKey key)
        {
            return _storage.Remove(key);
        }
    }
}