using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class VigenereTable
  {
    const string ALPHABET_RUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    char[,] VigeneresTable;
    Caesar coderCaesar = new Caesar();

    public VigenereTable()
    {
      int k = 0;
      string str = string.Empty;
      VigeneresTable = new char[ALPHABET_RUS.Length, ALPHABET_RUS.Length];
      for (int i = 0; i < ALPHABET_RUS.Length; i++)
      {
        str = coderCaesar.encode(ALPHABET_RUS, k);
        for (int j = 0; j < ALPHABET_RUS.Length; j++)
        {
          VigeneresTable[i, j] = str[j];
        }
        k--;
      }
    }

    public string encode(string message, string key)
    {
      message = message.Replace(" ", "");
      if ((message != string.Empty) && (key != string.Empty))
      {
        string strKey = string.Empty;
        int ikey = 0;
        for (int i = 0; i < message.Length; i++)
        {
          strKey += key[ikey];
          if (ikey < key.Length - 1)
          {
            ikey++;
          }
          else
          {
            ikey = 0;
          }
        }

        string resStr = string.Empty;
        int ik = -1, jm = -1;
        for (int i = 0; i < message.Length; i++)
        {
          for (int j = 0; j < ALPHABET_RUS.Length; j++)
          {
            if (Char.ToLower(ALPHABET_RUS[j]) == message[i] || Char.ToUpper(ALPHABET_RUS[j]) == message[i])
            {
              jm = j;
            }
            if (Char.ToLower(ALPHABET_RUS[j]) == strKey[i] || Char.ToUpper(ALPHABET_RUS[j]) == strKey[i])
            {
              ik = j;
            }
          }
          resStr += VigeneresTable[ik, jm];
        }
        return resStr;
      }
      else
      {
        return "Error";
      }
    }

    public string decode(string message, string key)
    {
      if ((message != string.Empty) && (key != string.Empty))
      {
        string strKey = string.Empty;
        int ikey = 0;
        for (int i = 0; i < message.Length; i++)
        {
          strKey += key[ikey];
          if (ikey < key.Length - 1)
          {
            ikey++;
          }
          else
          {
            ikey = 0;
          }
        }

        string resStr = string.Empty;
        int ik = -1, jm = -1;
        bool contains = false;
        for (int i = 0; i < message.Length; i++)
        {
          for (int j = 0; j < ALPHABET_RUS.Length; j++)
          {
            if (Char.ToLower(ALPHABET_RUS[j]) == strKey[i] || Char.ToUpper(ALPHABET_RUS[j]) == strKey[i])
            {
              ik = j;
              for (int k = 0; k < VigeneresTable.GetLength(1); k++)
              {
                if ((Char.ToLower(VigeneresTable[ik, k]) == message[i]) || (Char.ToUpper(VigeneresTable[ik, k]) == message[i]))
                {
                  jm = k;
                  contains = true;
                }
              }
            }
          }
          if (contains)
          {
            resStr += ALPHABET_RUS[jm];
            contains = false;
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
