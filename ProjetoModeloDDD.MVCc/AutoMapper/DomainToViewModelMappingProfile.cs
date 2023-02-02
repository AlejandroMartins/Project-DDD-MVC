using AutoMapper;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDOmainMappings";  }
        }

        protected void Configure()
        {
            this.CreateMap<ClienteViewModel, Cliente>();
            this.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}