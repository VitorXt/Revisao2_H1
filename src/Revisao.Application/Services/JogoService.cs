using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;
        private readonly IMapper _mapper;

        public JogoService(IJogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }

        public void Adicionar(NovoRegistroJogoViewModel jogo)
        {
            if (
                jogo.Numero1 != jogo.Numero2
                && jogo.Numero2 != jogo.Numero3
                && jogo.Numero3 != jogo.Numero4
                && jogo.Numero4 != jogo.Numero5
                && jogo.Numero5 != jogo.Numero6
             )
                //_jogoRepository.Adicionar(
                //  new Jogo(jogo.Nome, jogo.CPF, jogo.Numero1, jogo.Numero2, jogo.Numero3, jogo.Numero4, jogo.Numero5, jogo.Numero6, DateTime.Now, jogo.Ativo)
                //);
                _jogoRepository.Adicionar(_mapper.Map<Jogo>(jogo));

            else
                throw new Exception("Jogo não pode ser realizado, pois existem nros repetidos");
        }

        public void Atualizar(EditaRegistroJogoViewModel jogo)
        {
            throw new NotImplementedException();
        }

        public RegistroJogoViewModel ObterPorCodigo(int CodigoJogo)
        {
            throw new NotImplementedException();
        }

        public IList<RegistroJogoViewModel> ObterTodos()
        {
           return _mapper.Map<List<RegistroJogoViewModel>>(_jogoRepository.ObterTodos());
        }
    }
}
