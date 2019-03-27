using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    public class Variable : IndexedNamedItem
    {
        private string _question;

        public VariableKind VariableKind { get; set; }
        public Domain Domain { get; set; }
        public string Question
        {
            get => string.IsNullOrWhiteSpace(_question) ? $"{Name}?" : _question;
            set => _question = value;
        }

        public Variable(string name, VariableKind variableKind, Domain domain, string question = null) : base(name)
        {
            VariableKind = variableKind;
            Domain = domain;
            Question = question;
        }
    }
}
