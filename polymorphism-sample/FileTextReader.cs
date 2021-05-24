using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace polymorphism_sample
{
    internal class FileTextReader : ITextReader
    {
        private int fileNum;

        private string _pathName;

        public FileTextReader(string pathName)
        {
            _pathName = pathName;
        }

        public void Close()
        {
            Console.WriteLine(this.GetType().Name + "クラスの" + MethodBase.GetCurrentMethod().Name + "メソッドがコールされました。");
        }

        public void Open()
        {
            Console.WriteLine(this.GetType().Name + "クラスの" + MethodBase.GetCurrentMethod().Name + "メソッドがコールされました。");
        }

        public char Read()
        {
            Console.WriteLine(this.GetType().Name + "クラスの" + MethodBase.GetCurrentMethod().Name + "メソッドがコールされました。");
            return ' ';
        }
    }
}
