
namespace Leetspeak
{
    public class LeetspeakTranslator
    {
        public string Translate(string input)
        {

            char[] array = input.ToCharArray();


            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'e' || array[i] == 'E')
                {
                    array[i] = '3';
                }
                else if(array[i] == 'o' || array[i] == 'O')
                {
                    array[i] = '0';
                }
                else if (array[i] == 'I')
                {
                    array[i] = '1';
                }
                else if(array[i] =='t' || array[i] == 'T')
                {
                    array[i] = '7';
                }
                else if (array[i] == 's')
                {
                    array[i] = 'z';
                }
                
            }
            string finalResult = string.Join("",array);
            return finalResult;
             
        }

        public static void Main()
        {
            
        }
        
    }
    
}




