using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {

            CreateMap<NovoRegistroJogoViewModel, Jogo>()
               .ConstructUsing(jogo => new Jogo(0, jogo.Nome, jogo.CPF, jogo.Numero1, jogo.Numero2, jogo.Numero3, jogo.Numero4, jogo.Numero5, jogo.Numero6, DateTime.Now, jogo.Ativo) );

            
        }
    }
}
