using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Playground.ExpressionTree
{
    public class GenericTypeInference<T>
    {
        public string GetPropertyName<TProperty>(Expression<Func<T, TProperty>> func)
        {
            return ExpressionTree.Parser.GetPropertyName(func);
        }
    }
}
