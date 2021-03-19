using System;
using System.Diagnostics;

namespace Library1
{
    public class Individuo
    {
        //ctrl + .  ----->Explorar os recursos
        //atributos
        #region "atributos"
        private string _nome;
        private string _apelido;
        private DateTime _dataNascimento;
        private Empregador _empregador;
        #endregion

        //propriedades
        #region "propriedades"
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public int Idade
        {
            get { return 0; }
        }

        public Empregador Empresa
        {
            get { return _empregador; }

            set { _empregador = value; }
        }
        #endregion

        #region "construtores"
        public Individuo()
        {

        }
        
        public Individuo(string nome, string apelido, DateTime dataNasc)
        {
            _nome = nome;
            _apelido = apelido;
            _dataNascimento = dataNasc;
        }
        //obs: argumentos com valoures por default devem ser vir a direita de todos
        public Individuo(string nome, string apelido = "")
        {
            _nome = nome;
            _apelido = apelido;
        }

        #endregion


        #region "metodos"
        public void MyDebug()
        {
            Debug.Print(_nome);
            Debug.Print(_apelido);
            Debug.Print(_dataNascimento.ToString());
        }

        public string Imprimir()
        {
            return _apelido;
        }
        #endregion
    }
}
//Desafio aula 16/03/20: Fazer as classes do projeto - Loja online genérica
//Criar classes Produtos e Familia(categoria) do produto
//projeto submetido ao git 19/03/2020