using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Playground.ExpressionTree
{
    public partial class Parser
    {
        public static string GetPropertyName<TObject, T>(Expression<Func<TObject, T>> func)
        {
            return GetPropertyNameFromLambda(func);
        }

        public static string GetPropertyName<T>(Expression<Func<T>> func)
        {
            return GetPropertyNameFromLambda(func);
        }

        private static string GetPropertyNameFromLambda(LambdaExpression lambdaExpression)
        {

            return ((MemberExpression)lambdaExpression.Body).Member.Name;
        }
    }
}
