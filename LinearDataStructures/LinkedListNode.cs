﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear
{
	public class LinkedListNode<T>
	{
		public LinkedListNode(T value)
		{
			Value = value;
		}

		public LinkedListNode(LinkedListNode<T> next, T value)
		{
			Next = next;
			Value = value;
		}

		public T Value
		{
			private set;
			get;
		}

		public LinkedListNode<T> Next
		{
			set;
			get;
		}
	}

}