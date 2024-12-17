namespace ASSIGNMENT_7_2_2
{
    internal class Program
    {
        public static string ReverseVowels(string s)
        {
            //Convert string to a character array to manipulate it
            char[] charArray = s.ToCharArray();

            //Initialize a pointer for the start and end of the string
            int start = 0;
            int end = charArray.Length - 1;

            //Define vowels (both Lowercase and uppercase)
            string vowels = "aeiouAEIOU";

            //use two pointers to swap vowels 
            while (start < end)
            {
                //Move start pointer to the next vowel
                if (!vowels.Contains(charArray[start]))
                {
                    start++;
                    continue;
                }

                //Move end pointer to the previous vowel
                if (!vowels.Contains(charArray[end]))
                {
                    end--;
                    continue;
                }

                //Swap vowels
                char temp = charArray[start]; // Store the vowel at start
                charArray[start] = charArray[end]; // Swap vowels
                charArray[end] = temp; //Place temp (original start vowel) at end


                //Move both pointers inward
                start++;
                end--;
            }

            //Return the modified string
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string input1 = "hello";
            string output1 = ReverseVowels(input1);
            Console.WriteLine($"Input: {input1}\nOutput: {output1}");

            string input2 = "avacado";
            string output2 = ReverseVowels(input2);
            Console.WriteLine($"Input: {input2}\nOutput: {output2}");
        }
    }
}
                
          
