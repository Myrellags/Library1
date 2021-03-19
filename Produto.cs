using System;
using System.Collections.Generic;
using System.Text;

namespace Library1
{
    class Produto
    {
        //atributos
        #region "atributos"
        public int _idProduto;
        public string _nomeProduto;
        public string _descricaoProduto;
        public string _categoriaProduto;
        public double _pesoProduto;
        public string _fornecedorProduto;
        #endregion

        //propriedades
        #region "propriedades"
        public int IdProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        #endregion

        #region "metodos"
        public void cadastrarProdutos()
        {

        }

        public void removerProdutos()
        {

        }

        public void listarProdutos()
        {

        }

        public void editarProdutos()
        {

        }
        #endregion



    }
}
