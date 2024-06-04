namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "fly me to the moon";

            int count = 0;

            for (int i = s.Length - 1; i > 0; i--) 
            {
                if (s[i].ToString() != " ")
                {
                    count++;
                }
                else 
                {
                    break;
                }
            }
            Console.WriteLine(count);   
        }
    }
}
