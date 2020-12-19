using System.Globalization;

namespace Mod5_Construtores {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }//Auto Properties - prop + tab + tab
        public int Quantidade { get; private set; }

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade){
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public string Nome {//Properties
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {//value é o parâmetro do set
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        //public Produto(string nome, double preco, int quantidade)  : this(nome, preco){
        //    _quantidade = quantidade;
        //}

        //public string getNome() {
        //    return _nome;
        //}

        //public void setNome(string nome) {
        //    if(nome != null && nome.Length > 1) {
        //        _nome = nome;
        //    }

        //}

        //public double Preco {//Properties
        //    get { return _preco; }  
        //}

        //public int Quantidade {//Properties
        //    get { return _quantidade; }
        //}


    }
}
