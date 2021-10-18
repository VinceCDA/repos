using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace TypesSql
{
    public static class ExpressionReg
    {
        [SqlFunctionAttribute(IsDeterministic = true)]
        public static SqlBoolean ExepressionRegMatch(SqlString valeur,SqlString motif)
        {
            if (valeur.IsNull || motif.IsNull)
            {
                return SqlBoolean.False;
            }
            return Regex.IsMatch(valeur.Value, motif.Value);
        }
    }
}
