using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Concrete;
using DAL.Abstract;

namespace BLL.Infrastructure
{
    class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<EFUserRepository>();
            Bind<IPouchRepository>().To<EFPouchRepository>();
            Bind<IPurchaseRepository>().To<EFPurchaseRepository>();
        }
    }
}
