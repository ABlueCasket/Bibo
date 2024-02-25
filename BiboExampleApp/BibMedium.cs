namespace BiboExampleApp
{
    internal class BibMedium
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public BibMedium(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }

    }


}
