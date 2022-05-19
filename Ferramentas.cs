using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios
{
    public static class Ferramentas
    {

        public static string SomenteNumeros(string tmpStr)
        {
            string Dig = "";
            int X;

            for (X = 1; X <= Strings.Len(tmpStr); X++)
            {
                if (Information.IsNumeric(Strings.Mid(tmpStr, X, 1)))
                    Dig = Dig + Strings.Mid(tmpStr, X, 1);
            }

            return Dig;
        }

    }

}
