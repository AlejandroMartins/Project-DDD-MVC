using AutoMapper;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDOmainMappings"; }
        }

        protected void Configure()
        {
            this.CreateMap<Cliente, ClienteViewModel>();
            this.CreateMap<Produto, ProdutoViewModel>();
        }

    }
}