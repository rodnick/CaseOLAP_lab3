using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class MethodXOR
  {
    public string encode(string message, string gamma)
    {
      if ((message != string.Empty) && (gamma != string.Empty))
      {
        string resStr = string.Empty;
        string[] gammaStrArr = gamma.Split(' ');
        byte[] gammaBytes = new byte[message.Length];

        for (int i = 0, j = 0; i < gammaBytes.Length; i++)
        {
          gammaBytes[i] = Convert.ToByte(gammaStrArr[j]);
          j = (j < gammaStrArr.Length - 1) ? j + 1 : j = 0;
        }

        byte[] byteArr = Encoding.Default.GetBytes(message);
        byteArr = Encoding.Convert(Encoding.Default, Encoding.GetEncoding(1251), byteArr);

        for (int i = 0; i < byteArr.Length; i++)
        {
          byteArr[i] = (byte)(byteArr[i] ^ gammaBytes[i]);
        }
        resStr = new string(Encoding.Default.GetChars(byteArr));

        return resStr;
      }
      else
      {
        return "Error";
      }
    }
  }
}
