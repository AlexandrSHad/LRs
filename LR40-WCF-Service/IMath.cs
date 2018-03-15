using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LR40_WCF_Service
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int Factorial(int num);
    }
}
