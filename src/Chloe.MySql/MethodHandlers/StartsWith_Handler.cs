﻿using Chloe.DbExpressions;
using Chloe.RDBMS;
using System.Linq;

namespace Chloe.MySql.MethodHandlers
{
    class StartsWith_Handler : IMethodHandler
    {
        public bool CanProcess(DbMethodCallExpression exp)
        {
            if (exp.Method != PublicConstants.MethodInfo_String_StartsWith)
                return false;

            return true;
        }
        public void Process(DbMethodCallExpression exp, SqlGeneratorBase generator)
        {
            exp.Object.Accept(generator);
            generator.SqlBuilder.Append(" LIKE ");
            generator.SqlBuilder.Append("CONCAT(");
            exp.Arguments.First().Accept(generator);
            generator.SqlBuilder.Append(",'%'");
            generator.SqlBuilder.Append(")");
        }
    }
}
