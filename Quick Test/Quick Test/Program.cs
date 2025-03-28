using Microsoft.VisualBasic;

namespace Quick_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code Challenge
            //Bambus

        }
    }
    public class MysteryBox
    {
        private string _label;
        private string _contains;
        private bool _isExplosive1;
        public string Label { get => _label; set => _label = value; }
        public string Contains { get => _contains; set => _contains = value; }
        public bool IsExplosive { get => _isExplosive1; set => _isExplosive1 = value; }

        public MysteryBox(string label, string contains, bool isExplosive)
        {
            Label = label;
            Contains = contains;
            IsExplosive = isExplosive;

        }
        public override string ToString()
        {
            return $"Your mystery box has the Label {Label}. It contains {Contains}, and might be explosive: {IsExplosive}";
        }

    }
}
