using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolves.Ninject
{
    public  class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel= new StandardKernel(new BusinessModul());
            return kernel.Get<T>();
        }
    }
}
