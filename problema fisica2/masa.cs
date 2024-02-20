using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_fisica2
{
    internal class masa
    {
        public masa() 
        {
            Console.WriteLine("la masa del objeto es");
        }
        public double metros3;
        public double dencidad;

        public double Metros3 { get => metros3; set => metros3 = value; }
        public double Dencidad { get => dencidad; set => dencidad = value; }

        public void resultado(double metros3,double dencidad)
        {
            this.metros3 = metros3;
            this.dencidad = dencidad;
        }
    }
}
