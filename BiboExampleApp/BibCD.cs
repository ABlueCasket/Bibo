namespace BiboExampleApp
{
    internal class BibCD : BibMedium
    {
        public string Interpret { get; set; }

        public BibCD(string name) : base(name)
        {
            Interpret = String.Empty;
        }
    }
}
