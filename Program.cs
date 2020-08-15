using System;
using System.Collections.Generic;
using System.Linq;


/*
Write a generic class that meets the following requirements:
    1) That constrains a developer to only instantiate the class based on value types
2)    Contains a private generic collection
3)    Has a method to add items to the private collection
4)    Has a method that will return an item from the list(e.g.item 3 or item 4 in the list)
5)    Has a method that returns a sorted collection with the items in descending order
*/
namespace GenericsQuestion
{
    public class GenericClass<T> where T: struct
    {
        private List<T> _collection;

        public void Add(T item) 
        {
            _collection.Add(item);
        }
        public T Return(int x)
        {
            return _collection[x];
        }
        public List<T> Order()
        {
            IEnumerable<T> results1 = _collection.OrderByDescending(n => n);
            return results1.ToList();
        }
    }
}
