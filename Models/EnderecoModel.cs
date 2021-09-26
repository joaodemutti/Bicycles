using System;

namespace Bicycles.Models
{
    public class EnderecoModel
    {
        public int cod_end {get;set;}
        public int cep_end { get;set;}
        public string endereco {get; set;}
        public int numero_end {get; set;}
        public string bairro_end {get; set;}
        public string estado_end {get; set;}
        public string cidade_end {get; set;}

        public EnderecoModel(int cod_end, int cep_end,string endereco,int numero_end, string bairro_end,string estado_end,string cidade_end)
            {
                this.cod_end = cod_end;
                this.cep_end = cep_end;
                this.endereco = endereco;
                this.numero_end = numero_end;
                this.bairro_end = bairro_end;
                this.cidade_end = cidade_end;
            }

       public EnderecoModel(int cep_end,string endereco,int numero_end, string bairro_end,string estado_end,string cidade_end)
            {
                this.cod_end = -1;
                this.cep_end = cep_end;
                this.endereco = endereco;
                this.numero_end = numero_end;
                this.bairro_end = bairro_end;
                this.cidade_end = cidade_end;
            }

    }
}