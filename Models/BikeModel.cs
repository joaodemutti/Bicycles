using System;

namespace Bicycles.Models
{
    public class BikeModel
    {
        public int cod_bike {get;set;}
        public string modelo_bike {get;set;}
        public string cor_bike {get;set;}
        public string tipo_bike {get;set;}

        public BikeModel(int cod_bike,string modelo_bike,string cor_bike, string tipo_bike)
        {
            this.cod_bike = cod_bike;
            this.modelo_bike = modelo_bike; 
            this.cor_bike = cor_bike;
            this.tipo_bike = tipo_bike; 
        }
        public BikeModel(string modelo_bike,string cor_bike, string tipo_bike)
        {
            this.cod_bike = -1;
            this.modelo_bike = modelo_bike;
            this.cor_bike = cor_bike;
            this.tipo_bike = tipo_bike; 
        }
        
    }
}