using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.CovarianceAndContravariance
{
    public interface IGeneric<out TReturn, in TParam>
    {
        TReturn Test(TParam param1);
    }

    public class Generic<TReturn, TParam> : IGeneric<TReturn, TParam> where TParam : TReturn
    {
        public TReturn Test(TParam param1)
        {
            return param1;
        }
    }
}
