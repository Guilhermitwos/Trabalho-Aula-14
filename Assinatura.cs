using System.Diagnostics.Tracing;
using System;

namespace Aula14
{
public class Assinatura : Licensa
{
    private int _duracaochave;
        
            public double duracaochave
            {
                get { return this._duracaochave; }

            }

                public Assinatura(string nome, double mensalidade, int duracaochave, string chaveAtivacao)
                : base(nome, mensalidade, chaveAtivacao)
                {
                    this._duracaochave = duracaochave;

                }

            public override double CalculaValorTotal()
            {
                return this._precodoproduto * this._duracaochave;

            }
    
                public override void Imprimir()
                {
                    Console.WriteLine("A Mensalidade é:\tR$ {0:0.00}", this._precodoproduto);

                    Console.WriteLine("O Software é:\t{0}", this.Nome); 
                
                    Console.WriteLine("Duração:\t{0}", this._duracaochave);

                    Console.WriteLine("Valor total:\t\tR$ {0:0.00}", this.CalculaValorTotal());
            }
}
}