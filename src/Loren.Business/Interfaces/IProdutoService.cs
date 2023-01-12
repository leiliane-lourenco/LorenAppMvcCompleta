using Loren.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loren.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
