using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_sample
{
    internal class ReadProcess
    {
        private static Dictionary<string, ITextReader> _reader
            = new Dictionary<string, ITextReader>
            {
                {"file", new FileTextReader("C:\aaa.txt") } ,
                {"network", new NetworkTextReader() },
            };


        public ReadProcess(string type)
        {
            ReadCharacter(_reader.GetValueOrDefault(type));
        }

        private void ReadCharacter(ITextReader reader)
        {
            reader.Open();
            reader.Read();
            reader.Close();
        }
    }
}
