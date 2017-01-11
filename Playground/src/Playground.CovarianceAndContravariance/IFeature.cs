using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.CovarianceAndContravariance
{
    public interface IVariantCollection<T> // where TC: T
    {
        IEnumerable<T> List { get; set; }
    }

    public class VariantCollection<T>: IVariantCollection<T>
    {
        public IEnumerable<T> List { get; set; }
    }

    public interface IFeature
    {
        string Data { get; set; }
    }

    public class Feature : IFeature
    {
        public string Data { get; set; }
    }


   
}
