using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IJogoService
    {
        public void Adicionar(NovoRegistroJogoViewModel jogo);
        public void Atualizar(EditaRegistroJogoViewModel jogo);
        public IList<RegistroJogoViewModel> ObterTodos();
        public RegistroJogoViewModel ObterPorCodigo(int CodigoJogo);
    }
}
