using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario {
    class ContaBancaria {
        public string Nome { get; set; }
        private int _numeroConta;
        private double _quantia;

        public ContaBancaria(string nome, int numeroConta) {
            Nome = nome;
            _numeroConta = numeroConta;
            _quantia = 0;
        }

        public ContaBancaria(string nome, int numeroConta, double valor): this(nome, numeroConta) {
            _quantia = valor;
        }

        public double Deposito(double valor) {
            return _quantia += valor;
        }

        public double Saque(double valor) {
            return _quantia -= valor + 5.00;
        }

        public override string ToString() {
            return "Conta" + _numeroConta + ", Titular: " + Nome + ", Saldo: R$" + _quantia.ToString("F2");
        }




    }
}
