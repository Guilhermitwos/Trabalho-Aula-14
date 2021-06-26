using System;
using System.Collections.Generic;
using System.Linq;
using Aula14;

namespace Aula14
{
public class Compras
{
    private Compra_Atributos _atributos_compra;
    private Carrinho _carrinho_de_compras;
    private Estoque _estoquedaloja;




        public Compras(Carrinho carrinho_, Estoque estoque_, Cliente cliente_ )
        {
            this._atributos_compra = new Compra_Atributos(cliente_);
            this._carrinho_de_compras = carrinho_;
            this._estoquedaloja = estoque_;      
        }



      
        public bool Conferir_estoquedaloja()
        {
                    
        foreach (var item in _carrinho_de_compras.Itens)
            {
                var System_Linq_Query = _estoquedaloja.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);   

                if(item.Value > System_Linq_Query.Value)
                {
                    
                    Console.WriteLine($"O Estoque não tem \"{item.Key.Nome}\" o suficiente - [\"{item.Value}\" Total de unidades no carrinho / \"{System_Linq_Query.Value}\" restantes no estoque] ]");
                    return false;
                }
            
            }
            
            if(_carrinho_de_compras.Itens.Count <= 0)
            {
                Console.WriteLine($"O seu carrinho não tem produtos o suficiente para efetuar a compra - [\"{_carrinho_de_compras.Itens.Count}\" produtos totais no carrinho / \"{_estoquedaloja.Itens.Count}\" restantes no estoque] ]");
                return false;
            }
        

        return true;
        }


         public void Comprar_Produtos()
        {

            if(!Conferir_estoquedaloja()) return;
            
            
            foreach (var item in _carrinho_de_compras.Itens)
            {

            var System_Linq_Query = _estoquedaloja.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);             
                
                for (var i = 0; i < item.Value; i++)
                {                        
                    _estoquedaloja.Remover(item.Key);                              
                }   

            var RestCount = _estoquedaloja.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);
            Console.WriteLine($"O(a) \"{item.Key.Nome}\" foi comprado! - [\"{item.Value}\" Unidades compradas / \"{RestCount.Value}\" restantes no estoque] ");
            }

          
            _atributos_compra.Adicionar(_carrinho_de_compras.Itens);
          
        _carrinho_de_compras.Limpar();
          

        

        }

       public void ImprimirRecibo()
       {
         _atributos_compra.ImprimirAtributos(); 
         _atributos_compra.Limpar(); 
       }
       
    
    }
}