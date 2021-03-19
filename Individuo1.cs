using System;
using System.Collections.Generic;
using System.Text;

namespace Library1
{
    public class Individuo1
    {
        private string _cc;
        private string _nif;
        private string _nome;
        private string _apelido;
        private DateTime _datanascimento;

        public string CC
        {
            get { return _cc; }
            set { _cc = value; }
        }
        public string nif
        {
            get { return _nif; }
            set { _nif = value; }
        }
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
        }

        public DateTime datanascimento
        {
            get { return _datanascimento; }
            set { _datanascimento = value; }
        }

        public string NomeCompleto()
        {
            return _nome + " " + _apelido;
        }

    }

    public class Militar : Individuo1
    {
        private string _cm;
        private string _patente;

        public string CM
        {
            get { return _cm; }
            set { _cm = value; }
        }

        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        public string NomeCompleto()
        {
            return _patente + " " + nome + " " + apelido;
        }
    }
}
