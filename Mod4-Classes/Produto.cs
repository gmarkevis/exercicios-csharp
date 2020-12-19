using System;
using System.Globalization;

namespace Mod4_Classes {
    class Produto {
        public String nome;
        public double preco;
        public int quantidade;

        public double valorTotalEstoque() {
            return this.preco * this.quantidade;
        }

        public void adicionarProdutos(int quantidade) {
            this.quantidade += quantidade;
        }

        public void removerProdutos(int quantidade) {
            this.quantidade -= quantidade;
        }

        public override string ToString() {
            return this.nome 
                + ", $ " 
                + this.preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this.quantidade
                + " unidades, Total: $ " + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
