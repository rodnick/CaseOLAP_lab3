using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class Atbash
  {
    const string ALPHABET_RUS_CAPITAL_LETTER = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    const string ALPHABET_RUS_SMALL_LETTER = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public string encode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        for (int i = 0; i < message.Length; i++)
        {
          if (ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) > -1)
          {
            resStr += ALPHABET_RUS_CAPITAL_LETTER[32 - ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i])];
          }
          else if (ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) > -1)
          {
            resStr += ALPHABET_RUS_SMALL_LETTER[32 - ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i])];
          }
          else
          {
            resStr += message[i];
          }
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
