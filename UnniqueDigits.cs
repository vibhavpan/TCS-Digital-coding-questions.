// See https://aka.ms/new-console-template for more information
class practise
{
    public static int find(int num1,int num2)
    {
        int m = num1;
        int a=0;
        int count = 0;
        int n = 0;
        int s = 0;

        for (int i = num1; i <= num2; i++)
        {
                //get the rightmost digit 
                a = i % 10;

                //get the second rightmost digit
                m = i / 10;
                
                //get third rightmost digit
                n = m % 10;
                s = m / 10;

                //check if any of them are same,if no increase counter
                if (a - m != 0 && n-s!=0 && a-s!=0 && a-n!=0)
                {
                    
                    count++;
                }
            
            
        }
        return count;
    }
    public static void Main()
    {
        int num=11; 
        
        //print unique number till 11 to 15 
        Console.WriteLine(find(num,15));
        
    }
}
