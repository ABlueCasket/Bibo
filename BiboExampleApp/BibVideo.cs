namespace BiboExampleApp
{
    internal class BibVideo : BibMedium
    {
        public int FileSize { get; set; }


        public BibVideo(string name) : base(name)
        {
            FileSize = 0;
        }
    }
}
