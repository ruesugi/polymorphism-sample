using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_sample
{
    internal class ReadProcess
    {
        public ReadProcess(Setting setting)
        {
            if (setting == Setting.FILE) ReadCharacter(new FileTextReader("C:\aaa.txt"));
            else if (setting == Setting.NETWORK) ReadCharacter(new NetworkTextReader());
        }

        public enum Setting{
            FILE,
            NETWORK,
        };

        private void ReadCharacter(ITextReader reader)
        {
            reader.Open();
            reader.Read();
            reader.Close();
        }
    }
}
