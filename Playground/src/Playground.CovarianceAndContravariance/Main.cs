using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.CovarianceAndContravariance
{
    public class Main
    {
        public IVariantCollection<IFeature> Test()
        {
            var list = new VariantCollection<IFeature>();

            list.List = new List<Feature>();

            return list;

        }

        public void TestGeneric()
        {
            var instance = new Generic<Base, Base>();

            Base b;
            b = instance.Test(new Derived());
        }

    }
}
