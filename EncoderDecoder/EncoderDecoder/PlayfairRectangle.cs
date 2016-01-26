using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class PlayfairRectangle
  {
    char[,] ALPHABET_RUS =  {   {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З'},
                                {'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П'},
                                {'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч'},
                                {'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'}
                            };

    public string encode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        int firstLetJ = 0;
        int firstLetK = 0;
        int secondLetJ = 0;
        int secondLetK = 0;
        for (int i = 0; i < message.Length; i += 2)
        {
          for (int j = 0; j < ALPHABET_RUS.GetLength(0); j++)
          {
            for (int k = 0; k < ALPHABET_RUS.GetLength(1); k++)
            {
              if (Char.ToLower(ALPHABET_RUS[j, k]) == message[i] || Char.ToUpper(ALPHABET_RUS[j, k]) == message[i])
              {
                firstLetJ = j;
                firstLetK = k;
              }
              if (Char.ToLower(ALPHABET_RUS[j, k]) == message[i + 1] || Char.ToUpper(ALPHABET_RUS[j, k]) == message[i + 1])
              {
                secondLetJ = j;
                secondLetK = k;
              }
            }
          }

          if ((firstLetJ != secondLetJ) && (firstLetK != secondLetK)) 
          {
            resStr += ALPHABET_RUS[firstLetJ, secondLetK].ToString() + ALPHABET_RUS[secondLetJ, firstLetK];
          }

          if (firstLetJ == secondLetJ)
          {
            if (firstLetK + 1 >= ALPHABET_RUS.GetLength(1))
            {
              resStr += ALPHABET_RUS[firstLetJ, 0];
            }
            else
            {
              resStr += ALPHABET_RUS[firstLetJ, firstLetK + 1];
            }

            if (secondLetK + 1 >= ALPHABET_RUS.GetLength(1))
            {
              resStr += ALPHABET_RUS[secondLetJ, 0];
            }
            else
            {
              resStr += ALPHABET_RUS[secondLetJ, secondLetK + 1];
            }
          }

          if (firstLetK == secondLetK)
          {
            if (firstLetJ + 1 >= ALPHABET_RUS.GetLength(0))
            {
              resStr += ALPHABET_RUS[0, firstLetK];
            }
            else
            {
              resStr += ALPHABET_RUS[firstLetJ + 1, firstLetK];
            }

            if (secondLetJ + 1 >= ALPHABET_RUS.GetLength(0))
            {
              resStr += ALPHABET_RUS[0, secondLetK];
            }
            else
            {
              resStr += ALPHABET_RUS[secondLetJ + 1, secondLetK];
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

    public string decode(string message)
    {
      if (message != string.Empty)
      {
        string resStr = string.Empty;
        int firstLetJ = 0;
        int firstLetK = 0;
        int secondLetJ = 0;
        int secondLetK = 0;
        for (int i = 0; i < message.Length; i += 2)
        {
          for (int j = 0; j < ALPHABET_RUS.GetLength(0); j++)
          {
            for (int k = 0; k < ALPHABET_RUS.GetLength(1); k++)
            {
              if (Char.ToLower(ALPHABET_RUS[j, k]) == message[i] || Char.ToUpper(ALPHABET_RUS[j, k]) == message[i])
              {
                firstLetJ = j;
                firstLetK = k;
              }
              if (Char.ToLower(ALPHABET_RUS[j, k]) == message[i + 1] || Char.ToUpper(ALPHABET_RUS[j, k]) == message[i + 1])
              {
                secondLetJ = j;
                secondLetK = k;
              }
            }
          }

          if ((firstLetJ != secondLetJ) && (firstLetK != secondLetK))
          {
            resStr += ALPHABET_RUS[firstLetJ, secondLetK].ToString() + ALPHABET_RUS[secondLetJ, firstLetK];
          }

          if (firstLetJ == secondLetJ)
          {
            if (firstLetK - 1 < 0)
            {
              resStr += ALPHABET_RUS[firstLetJ, ALPHABET_RUS.GetLength(0) - 1];
            }
            else
            {
              resStr += ALPHABET_RUS[firstLetJ, firstLetK - 1];
            }

            if (secondLetK - 1 < 0)
            {
              resStr += ALPHABET_RUS[secondLetJ, ALPHABET_RUS.GetLength(1) - 1];
            }
            else
            {
              resStr += ALPHABET_RUS[secondLetJ, secondLetK - 1];
            }
          }

          if (firstLetK == secondLetK)
          {
            if (firstLetJ - 1 < 0)
            {
              resStr += ALPHABET_RUS[ALPHABET_RUS.GetLength(0) - 1, firstLetK];
            }
            else
            {
              resStr += ALPHABET_RUS[firstLetJ - 1, firstLetK];
            }

            if (secondLetJ - 1 < 0)
            {
              resStr += ALPHABET_RUS[ALPHABET_RUS.GetLength(1) - 1, secondLetK];
            }
            else
            {
              resStr += ALPHABET_RUS[secondLetJ - 1, secondLetK];
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
