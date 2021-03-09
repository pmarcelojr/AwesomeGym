using AwesomeGym.Application.InputModels;
using AwesomeGym.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwesomeGym.Application.Service
{
    public interface IUnidadeService
    {
        Task Adicionar(UnidadeInputModel unidadeInputModel);
        Task<List<UnidadeItemViewModel>> ObterTodos();
    }
}