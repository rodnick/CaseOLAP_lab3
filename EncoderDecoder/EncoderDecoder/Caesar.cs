using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class Caesar
  {
    const string ALPHABET_RUS_CAPITAL_LETTER = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    const string ALPHABET_RUS_SMALL_LETTER = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public string encode(string message, int offset = 3)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        offset = offset % 32;
        for (int i = 0; i < message.Length; i++)
        {
          if (ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) > -1)
          {
            if (((ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) + offset) > 32) || ((ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) + offset) < 0))
            {
              resStr += ALPHABET_RUS_CAPITAL_LETTER[ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) + offset - (offset > 0 ? 33 : -33)];
            }
            else
            {
              resStr += ALPHABET_RUS_CAPITAL_LETTER[ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) + offset];
            }
          }
          else if (ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) > -1)
          {
            if (((ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) + offset) > 32) || ((ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) + offset) < 0))
            {
              resStr += ALPHABET_RUS_SMALL_LETTER[ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) + offset - (offset > 0 ? 33 : -33)];
            }
            else
            {
              resStr += ALPHABET_RUS_SMALL_LETTER[ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) + offset];
            }
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

    public string decode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        for (int i = 0; i < message.Length; i++)
        {
          if (ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) > -1)
          {
            if ((ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) - 3) < 0)
            {
              resStr += ALPHABET_RUS_CAPITAL_LETTER[30 + ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i])];
            }
            else
            {
              resStr += ALPHABET_RUS_CAPITAL_LETTER[ALPHABET_RUS_CAPITAL_LETTER.IndexOf(message[i]) - 3];
            }
          }
          else if (ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) > -1)
          {
            if ((ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) - 3) < 0)
            {
              resStr += ALPHABET_RUS_SMALL_LETTER[30 + ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i])];
            }
            else
            {
              resStr += ALPHABET_RUS_SMALL_LETTER[ALPHABET_RUS_SMALL_LETTER.IndexOf(message[i]) - 3];
            }
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
