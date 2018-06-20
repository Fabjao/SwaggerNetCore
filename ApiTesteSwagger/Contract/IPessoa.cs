using ApiTesteSwagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteSwagger.Contract
{
    public interface IPessoa
    {
        List<Pessoa> Lista();
    }
}
