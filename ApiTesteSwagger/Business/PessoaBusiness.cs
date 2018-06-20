using ApiTesteSwagger.Contract;
using ApiTesteSwagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteSwagger.Business
{
    public class PessoaBusiness : IPessoa
    {
        public List<Pessoa> Lista()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa()
            {
                Nome = "Joãozinho",
                Idade = 22,
                DataNascimento = new DateTime(2018, 5, 24)
            });
            pessoas.Add(new Pessoa()
            {
                Nome = "Mariazinha",
                Idade = 32,
                DataNascimento = new DateTime(2010, 6, 4)
            });
            return pessoas;
        }
    }
}
