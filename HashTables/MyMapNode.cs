using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class MyMapNode<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() %size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach(KeyValue<K,V> item in linkedlist)
            {
                if(item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V> { key = key, value = value };
            linkedlist.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K,V> foundItem = default(KeyValue<K,V>);
            foreach (KeyValue<K,V> item in linkedlist)
            {
                if(item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if(itemFound)
            {
                linkedlist.Remove(foundItem);
            }
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {

            LinkedList<KeyValue<K, V>> linkedlist = items[position];
            if(linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }

    }
    public struct KeyValue<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }
}
