using System;
using System.Collections.Generic;
using System.Text;

namespace DotaMatchupFinder.Core.Wrappers
{
    public class BasicModelWrapper<T>
    {
        //public string command { get; set; }
        //public int rowCount { get; set; }
        //public string oid { get; set; }
        public List<T> rows { get; set; }
        //public object fields { get; set; }
        //public object _parsers { get; set; }
        //public object _types { get; set; }
        //public object RowCtor { get; set; }
        //public bool rowAsArray { get; set; }
        //public object err { get; set; }
    }
}
