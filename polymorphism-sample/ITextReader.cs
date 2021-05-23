using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_sample
{
    internal interface ITextReader
    {
        void Open();
        void Close();
        char Read();
    }
}
