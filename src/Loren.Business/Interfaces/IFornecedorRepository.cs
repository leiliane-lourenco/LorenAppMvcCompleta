﻿using Loren.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loren.Business.Interfaces
{
    public  interface IFornecedorRepository: IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
