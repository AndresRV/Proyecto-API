using Punto2.Core.Abstractions;
using Punto2.Core.Requests;
using Punto2.Core.Responses;
using System;
using System.Linq;

namespace Punto2.Application
{
    public class AppLogic : IAppLogic
    {
        public Response Resolve(Request request)
        {
            int[] paquetesOrdenados = request.lstPaquetes.OrderByDescending(x => x).ToArray();
            int paquete1 = 0, paquete2 = 0;

            for (int i = 0; i < paquetesOrdenados.Length - 1; i++)
            {
                paquete1 = paquetesOrdenados[i];

                for (int j = i + 1; j < paquetesOrdenados.Length; j++)
                {
                    paquete2 = paquetesOrdenados[j];

                    if (paquete1 + paquete2 == request.tamanioCamion - 30)
                    {
                        j = paquetesOrdenados.Length;
                        i = paquetesOrdenados.Length - 1;
                    }
                }
            }

            return new Response
            {
                Result = new int[] { paquete1, paquete2 }
            };
        }
    }
}
