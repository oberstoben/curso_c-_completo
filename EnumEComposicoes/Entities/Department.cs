using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEComposicoes.Entities
{
    class Department
    {
        private string deptName;

        public Department(string deptName)
        {
            this.deptName = deptName;
        }

        public string Design { get; set; }
    }
}
