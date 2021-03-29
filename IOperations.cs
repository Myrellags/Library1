using System;
using System.Collections.Generic;
using System.Text;

namespace Library1
{
    interface IOperations
    {
        string ToJson();
        void FromJson(string json);
        string ToXML();
        void FromXML(string xml);

    }
}
