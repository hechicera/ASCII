using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Alphabet = new List<string>();
            Alphabet.Add(" #  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### ");
            Alphabet.Add("# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # ");
            Alphabet.Add("### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   #  ");
            Alphabet.Add("# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       ");
            Alphabet.Add("# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #  ");

            int L = 4;
            int H = 5;
            int num = 0;
            string T = Console.ReadLine();
            char[] inputText = T.ToCharArray();

            for (int j = 0; j < 5; j++)
            {
                string[] lineConstruct = new string[inputText.Length];
                string[] heightConstruct = new string[H];
                for (int i = 0; i < inputText.Length; i++)
                {
                    if (inputText[i] == 97 || inputText[i] == 123)
                    {
                        num = ((inputText[i] - 97) * L);
                        lineConstruct[i] += Alphabet[j].Substring(num, L);
                    }
                    else
                    if (inputText[i] > 97 && inputText[i] < 123)
                    {
                        num = ((inputText[i] - 97) * 4) - 1;
                        lineConstruct[i] += Alphabet[j].Substring(num, L);
                    }
                    else
                    if (inputText[i] < 97 || inputText[i] > 123)
                    {
                        lineConstruct[i] += Alphabet[j].Substring(103, L);
                    }
                    heightConstruct[j] += lineConstruct[i];
                }
                Console.WriteLine(heightConstruct[j]);
            }

            Console.ReadKey();
        }
    }
}
