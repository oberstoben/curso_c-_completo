using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEComposicoes.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours;

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours )
        {

        }

        public double TotalValue()
        {
            return this.Hours * this.ValuePerHour;
        }
    }
}
