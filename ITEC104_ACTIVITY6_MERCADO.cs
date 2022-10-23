using System;
using System.Collections.Generic;
using System.Linq;

class HashSets {

    public static void Main()
    {

        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int i;
        HashSet<string> myhash1 = new HashSet<string>();

        myhash1.Add("1");
        myhash1.Add("2");
        myhash1.Add("3");
        myhash1.Add("4");
        myhash1.Add("5");

        Console.WriteLine("===HashSet 1===");
        for(i = 0; i < arr1.Length; i++)
        {
	      Console.Write("Element {0} : ",i);
    	  arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }

        HashSet<string> myhash2 = new HashSet<string>();

        myhash2.Add("2");
        myhash2.Add("4");
        myhash2.Add("6");
        myhash2.Add("8");
        myhash2.Add("10");

        Console.WriteLine("\n");
        Console.WriteLine("===HashSet 2===");
        for(i = 0; i < arr1.Length; i++)
        {
	      Console.Write("Element {0} : ",i);
    	  arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }

        var resultUnion = myhash1.Union(myhash2);
        var resultIntersect = myhash1.Intersect(myhash2);
        var resultExcept = myhash1.Except(myhash2);

        Console.Write("\nUNION: ");
        foreach (var item in resultUnion)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nINTERSECTION: ");
        foreach (var item in resultIntersect)
        {
            Console.Write(item + " ");
        }

        Console.Write("\nSET DIFFERENCE: ");
        foreach (var item in resultExcept)
        {
            Console.Write(item + " ");
        }
        Console.ReadKey();
    }
}
