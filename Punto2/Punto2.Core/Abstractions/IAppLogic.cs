using Punto2.Core.Requests;
using Punto2.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2.Core.Abstractions
{
    public interface IAppLogic
    {
        Response Resolve(Request request);
    }
}
