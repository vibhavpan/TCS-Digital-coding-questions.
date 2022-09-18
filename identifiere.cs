// See https://aka.ms/new-console-template for more information
class practise
{
    public static void find(string[] kw,string key)
    {
        int flag = 0;
        key = key.Trim();   //remove extra spaces around key

        //compare with every keyword
        foreach(string s in kw)
        {
            //if key exists in keyword string,turn flag as 1
            
            if (key.Equals(s))
            {
                flag = 1;
                break;
            }
            
        }

        if(flag==1)
            Console.WriteLine(key+" is a keyword");

        else
        {
            Console.WriteLine(key + " is not a keyword");
        }

    }
    public static void Main()
    {
        string[] keyWords = {"break","continue","case","default","defer","else","for",
                            "func","goto","if","map","range","return","struct","type"
                            ,"var"};

        string key = " goto ";

        find(keyWords,key);
    }
}
