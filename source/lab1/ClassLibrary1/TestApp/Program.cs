using ExampleLibrary;

internal class Program
{
    private static void Main(string[] args)
    {

        Element el1 = new Element("Asd");
        Element el2 = new Element(el1, "El2");
        el1.SetName("el1");
        Element parent = el2.getParent();

        Console.WriteLine(parent);

        Console.WriteLine("Hello, World!");

        DataArray x = new DataArray(); // inicjalizacja pustej tablicy
        Console.WriteLine(x.columns); // jeśli obiekt jest utworzony domyślnym konstruktorem pole columns jest puste
        Console.WriteLine(x.datatypes); // jeśli obiekt jest utworzony domyślnym konstruktorem pole datatypes jest puste

        // Tworzenie przykłądowej tablicy i wypełnienie jej danymi - Tablice muszą mieć określony wymiar. Struktury takie jak lista i słownik mogą zmieniać rozmiary. object oznacza ze elementem tablicy ejst obiekt np string, int, float
        object[,] exampleArray = new object[10, 4];
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (col == 3)
                {
                    exampleArray[row, col] = "last column";
                }
                else
                {
                    exampleArray[row, col] = col;
                }
            }
        }

        List<Type> types = new List<Type>();
        types.Add(typeof(string));
        types.Add(typeof(string));
        types.Add(typeof(string));
        types.Add(typeof(string));

        List<string> colnames = new List<string>();
        colnames.Add("kolumna 1");
        colnames.Add("kolumna 2");
        colnames.Add("kolumna 3");
        colnames.Add("kolumna 4");

        // utworzenie obiektu z wykorzystaniem konstruktora z parametrem którym jest utworzona tablica.
        DataArray x2 = new DataArray(exampleArray, colnames, types);
        Console.WriteLine(x2); // 
        Console.WriteLine(x2.datatypes.ToString()); //

    }
}