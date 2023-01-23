namespace Data_Structure_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ordered_List ordered_List=new Ordered_List();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            ordered_List.Ordered(word);
        }
    }
}