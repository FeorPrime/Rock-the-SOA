using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalService.Contracts
{
    interface IExternalService
    {
        string getSimpleData();

        ComplexDataType getComplexData();

        string getSimpleData(string simpleParameter);

        ComplexDataType getComplexData(ComplexDataType complexParameter);
    }

    public class ComplexDataType
    {
        public string StingData { get; set; }
        public int IntData { get; set; }
    }
}
