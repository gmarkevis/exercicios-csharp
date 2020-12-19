using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao {
    class ContaBancaria {

        public int Id { get; private set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }

        public ContaBancaria(int id, string nome) {
            Id = id;
            Nome = nome;
        }

        public ContaBancaria(int id, string nome, double saldo) : this(id, nome) {
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo = Saldo - valor - 5.0;
            //Saldo -= valor + 5.0;
        }

        public override string ToString() {
            return "Conta " + Id + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
