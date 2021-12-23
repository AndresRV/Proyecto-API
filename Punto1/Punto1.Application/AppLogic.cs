using System;
using Punto1.Core.Abstractions;
using Punto1.Core.Requests;
using Punto1.Core.Responses;

namespace Punto1.Application
{
    public class AppLogic : IAppLogic
    {
        public Response Resolve(Request request)
        {
            int[] entrada = (int[])request.lstCasas.Clone();
            int[] salida = (int[])request.lstCasas.Clone();
            int[] aux_dia_siguinte = (int[])request.lstCasas.Clone();

            for (int i = 0; i < request.dias; i++)
            {
                for (int j = 0; j < aux_dia_siguinte.Length; j++)
                {
                    if (j == 0)
                    {
                        aux_dia_siguinte[j] = salida[j + 1] == 0 ? 0 : 1;
                    }
                    else if (j == salida.Length - 1)
                    {
                        aux_dia_siguinte[j] = salida[j - 1] == 0 ? 0 : 1;
                    }
                    else
                    {
                        aux_dia_siguinte[j] = salida[j - 1] == salida[j + 1] ? 0 : 1;
                    }
                }

                salida = (int[])aux_dia_siguinte.Clone();
            }

            return new Response
            {
                dias = request.dias,
                entrada = entrada,
                salida = salida
            };
        }
    }
}
