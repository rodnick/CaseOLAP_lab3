using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class AffineCryptosystem
  {
    const string ALPHABET_RUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    public string encode(string message, string a, string b)
    {
      if ((message != string.Empty) && (a != string.Empty) && (b != string.Empty))
      {
        string resStr = string.Empty;
        int keyA = Convert.ToInt32(a);
        int keyB = Convert.ToInt32(b);
        int g = 33;
        int alf = 0;
        int bet = 0;

        for (int i = 0; i < message.Length; i++)
        {
          for (int j = 0; j < ALPHABET_RUS.Length; j++)
          {
            if (Char.ToLower(ALPHABET_RUS[j]) == message[i] || Char.ToUpper(ALPHABET_RUS[j]) == message[i])
            {
              alf = keyA * j + keyB;
              bet = alf % g;
              resStr += ALPHABET_RUS[bet];
              break;
            }
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
