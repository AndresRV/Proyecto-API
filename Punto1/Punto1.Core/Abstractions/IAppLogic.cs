using Punto1.Core.Requests;
using Punto1.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1.Core.Abstractions
{
    public interface IAppLogic
    {
        Response Resolve(Request request);
    }
}
