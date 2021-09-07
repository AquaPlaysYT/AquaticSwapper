using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Skin_Swapper__Sorry_.Program_Configs
{
    public static class Researcher
    {

        public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
        {
            List<long> list = new List<long>();
            stream.Position = startIndex;
            while (stream.Position != 5000000000L)
            {
                int num = stream.ReadByte();
                if (num == -1)
                {
                    return list;
                }
                if (num == (int)searchPattern[searchPosition])
                {
                    searchPosition++;
                    if (searchPosition == searchPattern.Length)
                    {
                        list.Add(stream.Position - (long)searchPattern.Length);
                        return list;
                    }
                }
                else
                {
                    searchPosition = 0;
                }
            }
            return list;
        }
    }
}

