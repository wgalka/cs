namespace ExampleLibrary
{
    internal class LoadCsv : IDataLoadible
    {
        public object Load(String filename)
        {
            throw new NotImplementedException();
        }

        public DataArray Load(string filename, char separator)
        {
            throw new NotImplementedException();
        }

        public DataArray Load(string filename, char separator, bool haveHeaders)
        {
            throw new NotImplementedException();
        }

        public bool Save(String filename)
        {
            throw new NotImplementedException();
        }
    }
}
