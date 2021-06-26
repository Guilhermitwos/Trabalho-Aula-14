using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Aula14;

namespace Aula14
{
public class Estoque
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
                double soma = 0;
            
                foreach (KeyValuePair<Produto, int> ordenado in this._itens)
                    soma += ordenado.Key.CalculaValorTotal() * ordenado.Value;

                return soma;


            }
        }

        public Estoque()
        {
            this._itens = new Dictionary<Produto, int>();


        }
    
        public void Adicionar(Produto itemunico, int numero_de_itens)
        {
        
            if (this._itens.ContainsKey(itemunico))
                this._itens[itemunico] = this._itens[itemunico] + numero_de_itens; 
            else              
                this._itens[itemunico] = numero_de_itens;
        }

        public void Adicionar(Produto itemunico)
        {
            
            this.Adicionar(itemunico, 1);


        }
    
        public void Adicionar(List<Produto> itens)
        {   
            foreach (var itemunico in itens)
            {    
                this.Adicionar(itemunico);


            }
        }
   
        public void Adicionar(Dictionary<Produto, int> itens)
        {    
            foreach (KeyValuePair<Produto, int> ordenado in itens)
            {
                this.Adicionar(ordenado.Key, ordenado.Value);


            }
        
        }

    
        public void Limpar()  { _itens.Clear(); }

        public void Remover(Produto itemunico)
        {
        
            var System_Linq_Query = _itens.FirstOrDefault(x => x.Key.Nome == itemunico.Nome);

    
            if( System_Linq_Query.Value == 1)
            {        
               _itens.Remove(System_Linq_Query.Key);
               return;

            }
            else if(System_Linq_Query.Value >= 2)         
               _itens[itemunico] -= 1;

     
        }
  
   



        public void ImprimirEstoque()
        {
            foreach (KeyValuePair<Produto, int> ordenado in this._itens)
            {
                ordenado.Key.Imprimir();
                Console.WriteLine
                    ("Número de itens:\t{0}", ordenado.Value);
                Console.WriteLine
                    ("Total: \tR$ " + ordenado.Value  * ordenado.Key.CalculaValorTotal());
            }
            Console.WriteLine
                ("Valor Total:\tR$ {0:0.00}", this.Total);

        }


}
}