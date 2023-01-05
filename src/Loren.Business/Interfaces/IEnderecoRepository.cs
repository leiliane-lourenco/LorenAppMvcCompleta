using Loren.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loren.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fonecedorId);
    }
}
