using Loren.Business.Interfaces;
using Loren.Business.Models;
using Loren.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Loren.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext db) : base(db)
        { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fonecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(e=>e.FornecedorId== fonecedorId);
        }
    }
}
