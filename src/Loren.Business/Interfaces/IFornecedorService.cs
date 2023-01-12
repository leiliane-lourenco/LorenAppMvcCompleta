using Loren.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loren.Business.Interfaces
{
    public  interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);
    }
}
