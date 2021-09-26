using System;

namespace Bicycles.Models
{
    public class PagamentoModel
    {
        public int cod_pag {get;set;}
        public string tipo {get;set;}
        public int valor {get;set;}
        public int cod_locacao {get;set;}
        
        public PagamentoModel(int cod_pag,string tipo,int valor,int cod_locacao)
        {
            this.cod_pag = cod_pag; 
            this.tipo = tipo; 
            this.valor = valor; 
            this.cod_locacao = cod_locacao;           
        }

        public PagamentoModel(string tipo,int valor,int cod_locacao)
        {
            this.cod_pag = -1; 
            this.tipo = tipo; 
            this.valor = valor; 
            this.cod_locacao = cod_locacao;           
        }
    }
}