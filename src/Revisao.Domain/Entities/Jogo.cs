using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Jogo 
    {
        #region - Construtores
       
        public Jogo(int codigoJogo, string nome, string cPF, int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, DateTime dataJogo, bool ativo)
        {
            CodigoJogo = codigoJogo;
            Nome = nome;
            CPF = cPF;
            Numero1 = numero1;
            Numero2 = numero2;
            Numero3 = numero3;
            Numero4 = numero4;
            Numero5 = numero5;
            Numero6 = numero6;
            DataJogo = dataJogo;
            Ativo = ativo;
        }

        //public Jogo(string nome, string cPF, int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, DateTime dataJogo, bool ativo)
        //{
        //    Nome = nome;
        //    CPF = cPF;
        //    Numero1 = numero1;
        //    Numero2 = numero2;
        //    Numero3 = numero3;
        //    Numero4 = numero4;
        //    Numero5 = numero5;
        //    Numero6 = numero6;
        //    DataJogo = dataJogo;
        //    Ativo = ativo;
        //}

        #endregion

        #region - Propriedades

        public int CodigoJogo { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public int Numero1 { get; private set; }
        public int Numero2 { get; private set; }
        public int Numero3 { get; private set; }
        public int Numero4 { get; private set; }
        public int Numero5 { get; private set; }
        public int Numero6 { get; private set; }
        public DateTime DataJogo { get; private set; }
        public bool Ativo { get; private set; }

        #endregion

        #region - Comportamentos

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
        public void AtribuirCodigo(int codigo) => CodigoJogo = codigo;

        #endregion
    }
}
