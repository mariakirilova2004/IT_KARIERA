﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01
{
    public class ArrayList<T> 
    {
        private const int Initial_Capacity = 2;
        private T[] items;
        public ArrayList()
        {
            this.items = new T[Initial_Capacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get 
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set 
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count++] = item;
        }

        public void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = items[i];
            }
            this.items = copy; 
        }
        public T RemoveAt(int index)
        {
            if(index >= this.items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            T element = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            this.Count--;
            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return element;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.items.Length; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
    }
}
