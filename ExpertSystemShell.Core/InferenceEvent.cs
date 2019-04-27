using ExpertSystemShell.Model;

namespace ExpertSystemShell.Core
{
    public class InferenceEvent
    {
        public InferenceEvent InnerEvent { get; set; }

        public bool IsRuleFired { get; set; }

        public Rule Rule { get; set; }

        public Variable Goal { get; set; }

        public bool IsFactRequested { get; set; }

        public Fact Fact { get; set; }

        public string Text { get; set; }
    }
}
