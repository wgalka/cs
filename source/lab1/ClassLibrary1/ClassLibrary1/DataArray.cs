using System.Collections;

namespace ExampleLibrary
{
    public class Column : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class DataArray
    {
        public object[,]? data;

        public List<string> columns;

        public List<Type> datatypes;

        public DataArray()
        {
        }

        public DataArray(object[,] data, List<string> colnames, List<Type> datatypes)
        {
            this.columns = colnames;
            this.data = data;
            this.datatypes = datatypes;
        }




        public override string ToString()
        {
            string result = "";

            if (data != null)
            {
                foreach (String item in columns)
                {
                    result += item;
                    result += "\t ";
                }
            }
            result += "\n";


            for (int row = 0; row < data.GetLength(0); row++)
            {
                for (int col = 0; col < data.GetLength(1); col++)
                {
                    result += data[row, col].ToString();
                    result += "\t";
                }
                result += "\n";
            }

            foreach (Type item in datatypes)
            {
                result += item;
                result += "\t ";
            }

            return result;
        }

        public void GetRow()
        {
            String.
        }
    }

    public enum DataTypes
    {
        Integer,
        String,
        Float,
        Bool
    }
}
