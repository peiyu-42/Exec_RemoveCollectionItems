using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	// 在集合中移除多個項目
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> values = new List<int>() { 123,-46,789,0,21,0,
												-1,-10,-100,-999};
			Console.WriteLine("原來的集合:");
			ForeachValues(values);
			values.Remove(0);//移除第一個0
			values.Remove(-46);
			values.Remove(21);
			values.Remove(-1);
			Console.WriteLine("移除後的集合:");
			ForeachValues(values);
		}
		public static void ForeachValues(List<int> values)
		{
			foreach (int number in values)
			{
				Console.WriteLine(number);
			}
		}
	}
}
