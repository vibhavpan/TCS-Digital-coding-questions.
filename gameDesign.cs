// See https://aka.ms/new-console-template for more information
class practise
{
    public static int replace(int number)
    {
        
        int n = number;
        string num = n.ToString();
     //   Console.WriteLine(num);

        string result="";

        foreach (char c in num)
        {
           
            int cal = Convert.ToInt32(new string(c,1));
            //Console.WriteLine("cal is "+cal);

            int new_num=9-cal;
            //Console.WriteLine("new_num is "+new_num);

            string res_num=new_num.ToString();
            //Console.WriteLine("Res_num is "+res_num);

            result += res_num;
            //Console.WriteLine("Result is "+result);
        }
        //Console.WriteLine(result);
        int res = Int32.Parse(result);
        return res;

    }
    public static void Main()
    {
        int num; 
        Int32.TryParse(Console.ReadLine(),out num);

        if(num>10000000 || num<0)
            Console.WriteLine("Invalid!!");

        else
            Console.WriteLine(replace(num));
        
    }
}
