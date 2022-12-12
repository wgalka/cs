namespace ExampleLibrary
{
    internal interface IDataLoadible
    {
        public DataArray Load(String filename, Char separator);
        public DataArray Load(String filename, Char separator, bool haveHeaders);
        public bool Save(DataArray data, String filename);
    }
}
