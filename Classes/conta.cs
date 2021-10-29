using System;

namespace DIO.Bank
{
    public class Conta
    {
        private string Nome {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private TipoConta TipoConta {get; set;}

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Saque(double valorsaque)
        {
            //validação
            if (this.Saldo - valorsaque < (this.Credito *-1))
            {
                Console.WriteLine("saldo insuficiente");
                return false;
            }

            this.Saldo -= valorsaque;

            Console.WriteLine("saldo atual da conta de{0} é {1}", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double valordeposito)
        {
            this.Saldo += valordeposito;

            Console.WriteLine("saldo atual da conta de{0} é {1}", this.Nome, this.Saldo);
        }

        public void transferir(double valortransferencia, Conta contadestino)
        {
            if(this.Saque(valortransferencia))
            {
                contadestino.Depositar(valortransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
        }
    }
}











