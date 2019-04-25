using System;
using ExpertSystemShell.Tools;

namespace ExpertSystemShell.Model
{
    [Serializable]
    public class Variable : IndexedNamedItem, ICloneable
    {
        private string _question;

        public VariableKind VariableKind { get; set; }
        public Domain Domain { get; set; }
        public string Question
        {
            get => VariableKind == VariableKind.Deductible ? string.Empty : _question;
            set => _question = value;
        }

        public Variable(string name, VariableKind variableKind = VariableKind.Deductible, Domain domain = null, string question = null) : base(name)
        {
            VariableKind = variableKind;
            Domain = domain;
            Question = question;
        }

        public string GenerateQuestion() => $"{Name}?";

        public override object Clone()
        {
            return new Variable((string)Name.Clone(), this.VariableKind, (Domain)this.Domain.Clone(), (string)Question.Clone());
        }
    }
}
