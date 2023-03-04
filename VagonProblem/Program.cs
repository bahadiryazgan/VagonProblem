namespace VagonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var gelenVagonlar = new string[] { "10808313931813319430761116496", "93876532983858416774152932536" };
            var depoDurum = "0#54134427902231984111412732221";
            VagonProblem.AntrepoYerlestir(depoDurum, gelenVagonlar);
        }
    }
}
