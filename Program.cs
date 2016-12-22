// boxing and unboxing.
// Boxing is the conversion of a value type to a reference type (object). Unboxing is the explicit conversion of a reference type to a value type. A value that is
// unboxed must be put into a data type equivalent to the data stored.

//Unboxing requires that that you explicitly convert an object to a value type. This can be done using a cast.

using System;
namespace BoxIT
{
	class mikesApp
	{
		public static void Main()
		{
			float val = 3.14F; //A value data type is declared and assigned the value of 3.14.
			object boxed = val; //The value type, val, is boxed into the variable, boxed. The boxed variable is an object.
			
			float unboxed = (float) boxed; //unboxing boxed into unboxed.
			
			Console.WriteLine("val: {0}", val);
			Console.WriteLine("boxed: {0}", boxed);
			Console.WriteLine("unboxed: {0}", unboxed);
			
			Console.WriteLine("\nTypes...");
			Console.WriteLine("val: {0}", val.GetType());
			Console.WriteLine("boxed: {0}", boxed.GetType());
			Console.WriteLine("unboxed: {0}", unboxed.GetType());
			Console.ReadKey(true); 
		}
	}
}
//Figure 10.2 illustrates how these are different by showing how val and boxed are stored. 