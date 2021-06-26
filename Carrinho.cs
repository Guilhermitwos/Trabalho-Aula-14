using System;
using System.Collections.Generic;
using System.Linq;
using Aula14;

namespace Aula14
{
public class Carrinho
{
        private Dictionary<Produto, int> _itens;

        public Dictionary<Produto, int> Itens
        {
            get { return this._itens; }
        }

            public double Total
            {
                get
                {
                    double somatorio = 0; 
            
                    foreach (KeyValuePair<Produto, int> Ordenado in this._itens)
                        somatorio += Ordenado.Key.CalculaValorTotal() * Ordenado.Value;

                    return somatorio;
                }
        }

        public Carrinho()
        {
            this._itens = new Dictionary<Produto, int>();
        }
    
            public void Adicionar(Produto item, int quantidadeitens)
            {
                if (this._itens.ContainsKey(item))

                    this._itens[item] = this._itens[item] + quantidadeitens;
                else

                    this._itens[item] = quantidadeitens;
            }

            public void Adicionar(Produto item)
            {
                this.Adicionar(item, 1);

        }
    
        public void Adicionar(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);

            }
        }
    
            public void Adicionar(Dictionary<Produto, int> itens)
            {
                foreach (KeyValuePair<Produto, int> Ordenado in itens)
                {

                    this.Adicionar(Ordenado.Key, Ordenado.Value);

                }


            }


    public void Limpar()  { _itens.Clear(); }


  



    public void ImprimirCarrinho()
        {
          
        foreach (KeyValuePair<Produto, int> Ordenado in this._itens)
        {
            Ordenado.Key.Imprimir();
            Console.WriteLine("quantidadeitens:\t{0}", Ordenado.Value);

            Console.WriteLine("Total:\tR$ {0:0.00}", Ordenado.Value * Ordenado.Key.CalculaValorTotal());
           
        }
        Console.WriteLine("Valor total no carrinho:\tR$ {0:0.00}", this.Total);
       
    }
}
}