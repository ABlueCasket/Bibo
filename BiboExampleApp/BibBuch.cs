namespace BiboExampleApp
{
    internal class BibBuch : BibMedium
    {
        public string Autor { get; set; }
        public string ISBN { get; set; }

        public BibBuch(string name) : base(name)
        {
            Autor = String.Empty;
            ISBN = String.Empty;
        }
    }



}
