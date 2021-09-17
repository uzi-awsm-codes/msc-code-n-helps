
using System;
using System.IO;
public class Ram
{
	public static void Main(String[] args)
	{
        Console.WriteLine("enter n");
 		int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr=new int[n,n];
        
        var x=n-1;
        var y=0;
        arr[x,y]=1;
        
        printArr(arr,n);
        while(true)
        {
            
            arr[x,y]=0;
            Console.WriteLine("enter 2 up 8 down 4 left 6 right ");
     		int k = Convert.ToInt32(Console.ReadLine());
     		switch(k) 
            {
              case 2:
                if(x > 0)
                    x=x-1;
                break;
                
              case 8:
                if(x < n-1)
                    x=x+1;
                break;
                
              case 4:
                if(y > 0)
                    y=y-1;
                break;
                
              case 6:
                if(y < n-1)
                    y=y+1;
                break;
            
               default:
                Console.WriteLine("wrong input");
                break;
            
    	    }
    	    arr[x,y]=1;
    	    printArr(arr,n);
        }
        
	}
	
    public static void printArr(int[,] arr, int n)
    {
        Console.Clear(); 
       for(int i=0;i<n;i++){  
            for(int j=0;j<n;j++){  
                Console.Write(arr[i,j]+" ");  
            }  
            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
}