﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _8section1._8
{
	public class Node
	{
		private string data;
		private Node next = null;
		private Node prev = null;

		public string Data
		{
			get { return this.data; }
			set { this.data = value; }
		}

		public Node Next
		{
			get { return this.next; }
			set { this.next = value; }
		}

		public Node Prev
		{
			get { return this.prev; }
			set { this.prev = value; }
		}
	}
}
