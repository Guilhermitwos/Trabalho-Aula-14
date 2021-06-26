using System;

namespace Aula14
{
    public class ProdutoFisico : Produto
    {

        private double _frete;

        public double Frete
        {
            get { return this._frete; }
        }
            public ProdutoFisico(string nomedoproduto,double preco,   double frete, Fornecedor fornecedor)
            {
                this._precodoproduto = preco;

                this._nomedoproduto = nomedoproduto;
            
                this._fornecedor = fornecedor;

                this._frete = frete;     
            }

                   
            public override void Imprimir()
            {
            
                Console.WriteLine
                ("Nome do fornecedor:\t{0}", this._fornecedor.Nome);

                Console.WriteLine
                ("CNPJ do fornecedor:\t{0}", this._fornecedor.Cnpj);
            
                Console.WriteLine
                ("Nome do produto:\t{0}", this.Nome); 

                Console.WriteLine
                ("Preço do produto:\t\tR$ {0:0.00}", this._precodoproduto);

                Console.WriteLine
                ("Frete:\t\tR$ {0:0.00}", this._frete);

                Console.WriteLine
                ("Valor total:\t\tR$ {0:0.00}", this.CalculaValorTotal());
            }
        public override double CalculaValorTotal()
        {
            return this._frete + this._precodoproduto;
        }
    }
}