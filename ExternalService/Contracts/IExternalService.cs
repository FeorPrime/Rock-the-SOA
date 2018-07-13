using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalService.Contracts
{
    interface IExternalService
    {
        string GetSimpleData();

        ComplexDataType GetComplexData();

        string GetSimpleDataWithParameter(string simpleParameter);

        ComplexDataType GetComplexDataWithParameter(ComplexDataType complexParameter);
    }

    public class ComplexDataType
    {
        public string StingData { get; set; }
        public int IntData { get; set; }
    }
}
