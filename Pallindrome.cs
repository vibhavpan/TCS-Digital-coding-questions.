namespace TCS
{
    internal class Program
    {
       
        
        static void pallindrome(string pal)
        {
            char[] words = pal.ToCharArray();


            int count = 0;

            string result="";

            for(int y=0;y<words.Length;y++)
                for(int g=y+1;g<words.Length;g++)
                {
                //if same character
                if (words[y] == words[g] )
                    {
                        count++;
                      
                        for (int i = 0; i <= g; i++)
                        {
                            if (words[i] != '0')
                            {
                                result += words[i];
                                words[i] = '0';

                                if(result.Length==1)
                                    Console.WriteLine(result);
                            }

                        }
                        Console.WriteLine(result);
                        result = "";

                        
                    }
                   
                    result = "";
                }
            
        }
        static void Main(string[] args)
        {
            string pal = "nayannamantenet";

            pallindrome(pal);
        }
    }
}
