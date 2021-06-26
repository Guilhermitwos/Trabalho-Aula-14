using System;
using System.Collections.Generic;
using System.Linq;
using Aula14;

namespace Aula14
{
public class Compra_Atributos
{
    private Dictionary<Produto, int> _itens;
    
    private Cliente _cliente;

    public Dictionary<Produto, int> Itens
    {
        get { return this._itens; }
    }

    public double Total
    {
        get
        {
            double somatorio = 0;
            // somatorio de valor total de cada item multiplicado pela quantidade de itens no carrinho
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
                somatorio += parOrdenado.Key.CalculaValorTotal() * parOrdenado.Value;

            return somatorio;
        }
    }

    

    public Compra_Atributos(Cliente cliente_)
    {
        this._itens = new Dictionary<Produto, int>();
        this._cliente = cliente_;
    }
    
    public void Adicionar(Produto item, int quantidade)
    {
        if (this._itens.ContainsKey(item))
            this._itens[item] = this._itens[item] + quantidade;
        else
            this._itens[item] = quantidade;
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
        foreach (KeyValuePair<Produto, int> parOrdenado in itens)
        {
            this.Adicionar(parOrdenado.Key, parOrdenado.Value);
        }
    }


    public void Limpar()  { _itens.Clear(); }




    public void ImprimirAtributos()
    { 
        DateTime dateTime = DateTime.UtcNow.Date;
        Console.WriteLine("======== CARRINHO ========");
        Console.WriteLine("==========================");
        Console.WriteLine("Nome Cliente: \t{0}", _cliente.Nome);     
        Console.WriteLine("CPF Cliente: \t{0}", _cliente.Cpf);        
        Console.WriteLine("==========================");
        foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
        {
            parOrdenado.Key.Imprimir();
            Console.WriteLine("Data de compra:\t{0:0.00}", dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("Quantidade: \tx{0} Unidades", parOrdenado.Value);         
            Console.WriteLine("==========================");
            Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
            Console.WriteLine("==========================");
        }
        Console.WriteLine("Valor Final :\tR$ {0:0.00}", this.Total);
        Console.WriteLine("==========================");
    }
}
}