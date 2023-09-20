using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        #region - Construtor

        private readonly string _jogosCaminhoArquivo;
        public JogoRepository()
        {
            _jogosCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "MegaSena.json");
        }

        #endregion

        #region - Funções do Repositório

        public void Adicionar(Jogo jogo)
        {
            List<Jogo> jogos = new List<Jogo>();
            jogos = LerJogosDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            jogo.AtribuirCodigo(proximoCodigo);
            jogos.Add(jogo);
            EscreverJogosNoArquivo(jogos);
        }

        public void Atualizar(Jogo jogo)
        {
            throw new NotImplementedException();
        }

        public IList<Jogo> ObterTodos()
        {
            return LerJogosDoArquivo();
        }

        public Jogo ObterPorCodigo(int CodigoJogo)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region - Funções do Arquivo

        private List<Jogo> LerJogosDoArquivo()
        {
            if (!System.IO.File.Exists(_jogosCaminhoArquivo))
            {
                return new List<Jogo>();
            }

            string json = System.IO.File.ReadAllText(_jogosCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Jogo>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Jogo> jogos = LerJogosDoArquivo();
            if (jogos.Any())
            {
                return jogos.Max(p => p.CodigoJogo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverJogosNoArquivo(List<Jogo> jogos)
        {
            string json = JsonConvert.SerializeObject(jogos);
            System.IO.File.WriteAllText(_jogosCaminhoArquivo, json);
        }

        #endregion
    }
}
