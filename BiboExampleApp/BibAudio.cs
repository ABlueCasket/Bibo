namespace BiboExampleApp
{
    internal class BibAudio : BibMedium
    {
        public int FileSize { get; set; }

        public BibAudio(string name) : base(name)
        {
            FileSize = 0;

        }

    }
}
