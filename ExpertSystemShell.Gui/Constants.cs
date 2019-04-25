using System.Collections.Generic;
using ExpertSystemShell.Model;

namespace ExpertSystemShell.Gui
{
    public static class Constants
    {
        public static Dictionary<VariableKind, string> VariableKinds = new Dictionary<VariableKind, string>
        {
            { VariableKind.Deductible, "Выводимая"},
            { VariableKind.Requested, "Запрашиваемая" },
            { VariableKind.DeductibleRequested, "Выводимо-запрашиваемая" }
        };
    }
}
