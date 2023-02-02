using Ninject;
using ProjetoModeloDDD.Applications;
using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Interfaces.Repositories;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using ProjetoModeloDDD.Domainn.Services;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.Infra.Date.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVCc.AutoMapper
{
        public class NinjectDependencyResolver : IDependencyResolver
        {
            private IKernel _kernel;

            public NinjectDependencyResolver()
            {
                _kernel = new StandardKernel();

                RegisterServices(_kernel);
            }

            public NinjectDependencyResolver(IKernel kernel)
            {
                _kernel = kernel;
            }

            public object GetService(Type serviceType)
            {
                return _kernel.TryGet(serviceType);
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                return _kernel.GetAll(serviceType);
            }

            public static void RegisterServices(IKernel kernel)
            {
                kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
                kernel.Bind<IClienteAppService>().To<ClienteAppService>();
                kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
                kernel.Bind<IVendaAppService>().To<VendaAppService>();
                kernel.Bind<IItemVendaAppService>().To<ItemVendaAppService>();


                kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
                kernel.Bind<IClienteService>().To<ClienteService>();
                kernel.Bind<IProdutoService>().To<ProdutoService>();
                kernel.Bind<IVendaService>().To<VendaService>();
                kernel.Bind<IItemVendaService>().To<ItemVendaService>();

                kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
                kernel.Bind<IClienteRepository>().To<ClienteRepository>();
                kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
                kernel.Bind<IVendaRepository>().To<VendaRepository>();
                kernel.Bind<IItemVendaRepository>().To<ItemVendaRepository>();
            }
        }
    
}