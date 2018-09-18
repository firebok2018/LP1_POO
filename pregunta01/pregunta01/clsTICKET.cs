using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta01
{
    class clsTiCKET
    {
        public int numeroTicket { get; set; }
        public DateTime fechaTicket { get; set; }
        public string tipoVehiculo { get; set; }

        public double peaje { get; set; }
        public double igv { get; set; }
        public double neto { get; set; }

        public clsTiCKET()
        {
            igv = 0.17;
            tipoVehiculo = "Auto o Moto";
        }
        
        public double calc_IGV()
        {
            if (tipoVehiculo == "Camion")
            {
                return igv*10;
            }
            else if (tipoVehiculo=="Camioneta")
            {
                return igv * 25;
            }
            else
                return igv * 10;
        }
        public double calc_neto()
        {
            if (tipoVehiculo == "Camion")
            {
                return calc_IGV() + 10;
            }
            else if (tipoVehiculo == "Camioneta")
            {
                return calc_IGV() * 25;
            }
            else
                return calc_IGV() * 10;
            
        }

        
    }
}
