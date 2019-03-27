using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemShell.Model
{
    public class Fact
    {
        private string _value;

        public Variable Variable { get; set; }
        public string Value
        {
            get => _value;
            set
            {
                if (!Variable.Domain.Values.Contains(value))
                    throw new ArgumentException();

                _value = value;
            }
        }
    }
}
