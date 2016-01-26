using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class PolybiusSquare
  {
    char[,] ALPHABET_RUS =  {   {'А', 'Б', 'В', 'Г', 'Д', 'Е'},
                                {'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
                                {'Л', 'М', 'Н', 'О', 'П', 'Р'},
                                {'С', 'Т', 'У', 'Ф', 'Х', 'Ц'},
                                {'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
                                {'Э', 'Ю', 'Я', ',', '.', '-'}
                            };

    public string encode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        for (int i = 0; i < message.Length; i++)
        {
          for (int j = 0; j < ALPHABET_RUS.GetLength(0); j++)
            for (int k = 0; k < ALPHABET_RUS.GetLength(1); k++)
              if (Char.ToLower(ALPHABET_RUS[j, k]) == message[i] || Char.ToUpper(ALPHABET_RUS[j, k]) == message[i])
              {
                resStr += Convert.ToString(j + 1) + Convert.ToString(k + 1);
                break;
              }

        }
        return resStr;
      }
      else
      {
        return "Error";
      }
    }

    public string decode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        for (int i = 0; i < message.Length; i += 2)
        {
          resStr += ALPHABET_RUS[Convert.ToInt32(message[i].ToString()) - 1, Convert.ToInt32(message[i + 1].ToString()) - 1];
        }
        return resStr;
      }
      else
      {
        return "Error";
      }
    }

  }
}
