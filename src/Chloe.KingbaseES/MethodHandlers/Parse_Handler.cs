﻿using Chloe.DbExpressions;
using Chloe.RDBMS;
using Chloe.RDBMS.MethodHandlers;

namespace Chloe.KingbaseES.MethodHandlers
{
    class Parse_Handler : Parse_HandlerBase
    {
        public override void Process(DbMethodCallExpression exp, SqlGeneratorBase generator)
        {
            DbExpression arg = exp.Arguments[0];
            DbExpression e = DbExpression.Convert(arg, exp.Method.ReturnType);
            e.Accept(generator);
        }
    }
}
