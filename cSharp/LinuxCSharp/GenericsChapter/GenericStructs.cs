using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace GenericsChapter
{
    struct PieceOfData<T> 
    {
        public PieceOfData(T value) { _data = value; }
        private T _data;
        public T Data
        {
            get =>_data; 
            set => _data = value; 
        }
    }
    public static class GenericStructs
    {
        public static void Main() 
        {
            var intData     = new PieceOfData<int>(10);
            var stringData  = new PieceOfData<string>("Hi there");
            var d = new PieceOfData<int>();
            d.Data = 77;

            WriteLine($"intData     = {intData.Data}");
            WriteLine($"stringData  = { stringData.Data}");
            WriteLine($"d           = {d.Data}");
        }
    }
}