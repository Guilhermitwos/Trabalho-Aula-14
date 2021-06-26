using Aula14;
using System;

namespace Aula14
{
public class Licensa : Produto
{
    
        protected string chavepraativacao;

        public string ChaveAtivacao
        {
            get { return this.chavepraativacao; }

        }

        public Licensa(string nome, double preco, string chaveAtivacao)
        {
            this._nomedoproduto = nome;
            this._precodoproduto = preco;
            this.chavepraativacao = chaveAtivacao;

        }

        public override double CalculaValorTotal()
        {
            return this._precodoproduto;

        }

        public override void Imprimir()
        {
            Console.WriteLine
                ("Software:\t{0}", this.Nome); 
            Console.WriteLine
                ("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());

    }
}
}