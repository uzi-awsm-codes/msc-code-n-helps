using System;
using System.IO;
public class Code
{
	public static void Main(String[] args)
	{
		Console.WriteLine("enter n");
 		int n = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[n * n];
		
		int x = arr.Length - n;
		
		arr[x] = 1;
		
		printArr(arr,n);
		
		while(true)
        {
            Console.WriteLine("\n");
            Console.WriteLine("enter 2 up 8 down 4 left 6 right ");
     		int k = Convert.ToInt32(Console.ReadLine());
     		switch(k) 
            {
              case 2:
                arr = up(arr,n);
                break;
                
              case 8:
                arr = down(arr,n);
                break;
                
              case 4:
                arr = left(arr,n);
                break;
                
              case 6:
                arr = right(arr,n);
                break;
            
              default:
                Console.WriteLine("wrong input");
                break;
            
    	    }
            printArr(arr,n);
        }
		
	}
	
	 public static void printArr(int[] arr, int n)
    {
        Console.Clear(); 
        for (int i = 0; i < arr.Length; i++)
		{
			if (i % n == 0)
			{
				Console.WriteLine();
			}
			Console.Write(arr[i].ToString() + " ");
		}
    }
    
    public static int[] up(int[] arr, int n)
    {
        int x= Array.IndexOf(arr,1);
        arr[x]=0;
        
        if(x > n)
            x=x-n;
            
        arr[x]=1;
    	return arr;    
        
    }
    public static int[] down(int[] arr, int n)
    {
        int x= Array.IndexOf(arr,1);
        arr[x]=0;
        
        if(x < n*(n-1))
            x=x+n;
            
        arr[x]=1;
    	return arr; 
    }
    public static int[] left(int[] arr, int n)
    {
        int x= Array.IndexOf(arr,1);
        arr[x]=0;
        
        if(x > 0)
          x=x-1;
            
        arr[x]=1;
    	return arr; 
    }
    public static int[] right(int[] arr, int n)
    {
        int x= Array.IndexOf(arr,1);
        arr[x]=0;
        
        if(x < n*n-1)
            x=x+1;
            
        arr[x]=1;
    	return arr; 
        
    }
}