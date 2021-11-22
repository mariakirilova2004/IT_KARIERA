using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
	public class Deque<T> : IList<T>
	{
		public Deque() : this(16)
		{
			//празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
		}
		public Deque(int capacity)
		{
			//създава дека с точно зададен капацитет
		}
		public Deque(IEnumerable<T> collection)
				: this(collection.Count())
		{
			//създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
		}
		public int Capacity; //показва капацитета
		public int Count; //показва броят елементи
		public void AddFront(T item)
		{
			//добавя елемент отпред
		}
		public void AddBack(T item)
		{
			//добавя елемент отзад
		}
		public T RemoveFront()
		{
			//връща и премахва елемента отпред
		}
		public T RemoveBack()
		{
			//връща и премахва елемента отзад
		}
		public T GetFront()
		{
			//връща, без да премахва, елемента отпред
		}
		public T GetBack()
		{
			//връща, без да премахва, елемента отзад
		}
	}

}
