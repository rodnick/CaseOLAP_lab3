using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderDecoder
{
  class MethodOfPermutations
  {
    public string encode(string message, string rowCount, string colCount,
                          string keyRecord, string keyRead)
    {
      if ((message != string.Empty))
      {
        int rows = Convert.ToInt16(rowCount);
        int cols = Convert.ToInt16(colCount);
        string[] keyRecordArray;
        string[] keyReadArray;

        if (keyRecord == string.Empty)
        {
          keyRecordArray = new string[rows];
          for (int i = 0; i < rows; i++)
          {
            keyRecordArray[i] = (i + 1).ToString();
          }
        }
        else
        {
          keyRecordArray = keyRecord.Split(' ');
        }

        if (keyRead == string.Empty)
        {
          keyReadArray = new string[cols];
          for (int i = 0; i < cols; i++)
          {
            keyReadArray[i] = (i + 1).ToString();
          }
        }
        else
        {
          keyReadArray = keyRead.Split(' ');
        }

        if ((keyRecordArray.GetLength(0) != rows) || (keyReadArray.GetLength(0) != cols))
          return "Error";

        string resStr = string.Empty;
        char[] bufStr = new char[rows * cols];
        int k = 0, l = 0;
        for (int i = 0; i < rows; i++)
        {
          k = Convert.ToInt16(keyRecordArray[i]);
          for (int j = 0; j < cols; j++)
          {
            bufStr[(k - 1) * cols + j] = message[i * cols + j];
          }
        }

        for (int i = 0; i < rows; i++)
        {
          k = Convert.ToInt16(keyReadArray[i]);
          for (int j = 0; j < cols; j++)
          {
            resStr += bufStr[k - 1 + (j * cols)];
          }
        }

        return resStr;
      }
      else
      {
        return "Error";
      }
    }

    public string decode(string message, string rowCount, string colCount,
                          string keyRecord, string keyRead)
    {
      if ((message != string.Empty))
      {
        int rows = Convert.ToInt16(rowCount);
        int cols = Convert.ToInt16(colCount);
        string[] keyRecordArray;
        string[] keyReadArray;

        if (keyRecord == string.Empty)
        {
          keyRecordArray = new string[rows];
          for (int i = 0; i < rows; i++)
          {
            keyRecordArray[i] = (i + 1).ToString();
          }
        }
        else
        {
          keyRecordArray = keyRecord.Split(' ');
        }

        if (keyRead == string.Empty)
        {
          keyReadArray = new string[cols];
          for (int i = 0; i < cols; i++)
          {
            keyReadArray[i] = (i + 1).ToString();
          }
        }
        else
        {
          keyReadArray = keyRead.Split(' ');
        }

        if ((keyRecordArray.GetLength(0) != rows) || (keyReadArray.GetLength(0) != cols))
          return "Error";

        string resStr = string.Empty;
        char[] bufStr = new char[rows * cols];
        int k = 0, l = 0;
        for (int i = 0; i < cols; i++)
        {
          k = Convert.ToInt16(keyReadArray[i]);
          for (int j = 0; j < rows; j++)
          {
            bufStr[k - 1 + j * cols] = message[i * cols + j];
          }
        }

        for (int i = 0; i < rows; i++)
        {
          k = Convert.ToInt16(keyRecordArray[i]);
          for (int j = 0; j < cols; j++)
          {
            resStr += bufStr[(k - 1) * cols + j];
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
