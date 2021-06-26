using System;
using System.Collections.Generic;

namespace Aula14
{
    public class Relatorio
    {
        private string _titulo;
        private string _descricao;
        private List<IImprimivel> _itens;

        public string Titulo
        {
            get
            {
                return this._titulo;
            }
        }
 
        public string Descricao
        {
            get
            {
                return this._descricao;
            }
        }

        public Relatorio(string titulo, string descricao)
        {
            this._descricao = descricao;
            this._titulo = titulo;
            this._itens = new List<IImprimivel>();
        }

        public void AdicionarItem(IImprimivel item)
        {
            this._itens.Add(item);
        }

        public void ImprimirRelatorio()
        {
            
            Console.WriteLine("\n======== RELATÓRIO ========");
            Console.WriteLine(this._titulo);
            Console.WriteLine("===========================");
            Console.WriteLine(this._descricao);
            Console.WriteLine("========== ITENS ==========");
            foreach (var item in _itens)
            {
                item.Imprimir(); 
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("===========================");
        }
    }
}