namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            
            // Ask the user what word they would like to find
            Console.WriteLine("What would you like to find?");
            string searchKey = Console.ReadLine();
            
            // Output the message True if the word is found
            // Output the message False if the word is not found
            Console.WriteLine(linearSearch(fruits, searchKey));
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
        static bool linearSearch(string[] list, string searchKey)
        {
            foreach (string item in list) 
                {
                    if (item == searchKey) 
                    {
                        return true;
                        break;
                    }
                }
                return false;
        }
    }
}
