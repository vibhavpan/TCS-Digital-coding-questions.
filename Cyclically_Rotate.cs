using System;
class HelloWorld {
    
  static void rotate(int []c,int k)
  {
      //get length of c
      int l=c.Length;  
      
      //make an another array of length same as c
      int []n=new int[l];
 
  //repeat till k
    for(int u=0;u<k;u++)
    {
    
     for(int j=0;j<4;j++)         //pointer for array c
       for(int g=j+1;g<=4;g++)    //pointer for array n
       {
            n[0]=c[4];            //copy last element of c to first of n
            n[g]=c[j];            //copy subsequent elements.
            
       }
      
      for(int h=0;h<l;h++)        //update c to new array n
        c[h]=n[h];
    }   
       foreach(int i in n)        //print array
            Console.WriteLine(i);
    
      }
      
      
      
  
  public static void Main() {
    
    int []c={10,20,30,40,50};
    rotate(c,2);                //cyclically rotate c for 2 times.
  }
}


