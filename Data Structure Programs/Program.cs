namespace Data_Structure_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Ordered_List ordered_List=new Ordered_List();

            //Console.WriteLine("Enter word to search");
            //string word = Console.ReadLine();
            //ordered_List.Ordered(word);
            char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
            BalancingParentheses balancingParentheses= new BalancingParentheses();
            bool result = balancingParentheses.Isbalanced(expression);
            if (result)
            {
                Console.WriteLine("Parantheses Balanced");
            }
            else
            {
                Console.WriteLine("Parantheses not Balanced");
            }

        }
    }
}