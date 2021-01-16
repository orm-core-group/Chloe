﻿using Chloe.DbExpressions;
using Chloe.RDBMS;
using System.Linq;

namespace Chloe.SQLite.MethodHandlers
{
    class Sum_Handler : IMethodHandler
    {
        public bool CanProcess(DbMethodCallExpression exp)
        {
            if (exp.Method.DeclaringType != PublicConstants.TypeOfSql)
                return false;

            return true;
        }
        public void Process(DbMethodCallExpression exp, SqlGeneratorBase generator)
        {
            SqlGenerator.Aggregate_Sum(generator, exp.Arguments.First(), exp.Method.ReturnType);
        }
    }
}
