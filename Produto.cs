namespace Aula14
{
    public abstract class Produto : IImprimivel
    {
        
            protected string _nomedoproduto;
            protected double _precodoproduto;
            protected Fornecedor _fornecedor;


            public Fornecedor Fornecedor
            {
                get {return this._fornecedor;}

            }


           

            public string Nome
            {
                get { return this._nomedoproduto; }

            }
            
            public double Preco
            {
                get { return this._precodoproduto; }

            }

        public abstract double CalculaValorTotal();
            public abstract void Imprimir();
        
    }
}