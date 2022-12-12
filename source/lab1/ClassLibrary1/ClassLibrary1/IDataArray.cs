namespace ExampleLibrary
{
    internal interface IDataArray
    {
        Dictionary<string, Type> getDataTypes();
        List<string> getColumns();

    }
}
