Zagadnienia C#:

### Tworzenie typów wyliczeniowych i przykłady ich wykorzystania. 

<details>
<summary>
Utwórz typ wyliczeniowy dla różnych stanów transakcji bankowej.
</summary>

Należy potrafić wykorzytsać stworzony typ np. w instrukcjach switch i if wiedząc że pod danymi nazwami kryją się liczby.

</details><br>

### Definiowanie klasy i ich instancji(obiektów) zgodnie z zasadami enkapsulacji(hermetyzacji).

<details>
<summary>
Utwórz klasę reprezentującą Produkt.
</summary>

Każdy produkt ma pewne cechy takie jak nazwa, cena, wielkość itp. które są reprezentowane przez pola klasy. Hermetyzacja polega na ukrywaniu pewnych składowych klasy pól/metod tak aby inne klasy lub użytkownik tworzacy instancję danej klasy mógł użyć jej tylko w poprawny sposób. Np. cena produktu powinna być wartością dodatnią. Zatem pole cena powinno być prywatne i zdefiniowane w ten sposób aby można było do niego przypisać tylko poprawne wartości. 

https://codeeasy.io/lesson/properties

</details><br>

### Definiowanie interfejsów.

<details>
<summary>
Utwórz interfejs dla automatów z przekąskami.
</summary>

Interfejs mówi co dana klasa powinna zrobić, nie w jaki sposób. Interfejs zawiera deklaracje metody bez ich implementacji. W nowszych wersjach Java i C# możliwa jest domyślna implementacja interfejsu wtedy klasa nie musi implementować danej metody.

</details><br>


### Definiowanie klas abstrakcyjnych

<details>
<summary>
Utwórz klasę abstrakcyjną reprezentującą automat.
</summary>

Mając różne automaty: Automat z przekąskami, Automat do gier, Automat z napojami można wyróżnić w nich pewną część wspólną czyli metodę płacenia polegającą na wrzuceniu monety, wybraniu produktu a następnie wydaniu reszty. Zatem definiując wspólny interfejs dla tych automatów implementacja metod za wrzucenie monety, wybranie produktu i wydanie reszty będzie taka sama. Rozwiązaniem tego problemu jest klasa abstrakcyjna która będzie implementować wspólny "moduł" płacenia. 

Nie można tworzyć instancji Klasy(tworzyć obiektów).

</details><br>

### Dziedziczenie i polimorfizm

<details>
<summary>
Utwórz klasę SnackMachine dziedziczącą po klasie Automat. 
</summary>

W Java i C# możliwe jest dziedziczenie po jednej klasie i implementacja wielu interfejsów.

Polimorfizm pozwala na wykorzystanie różnych implementacji metod dla różnych typów obiektów, np. wykorzystanie jednego interfejsu do obsługi różnych typów plików.

</details><br>

### Zapis i odczyt z plików

<details>
<summary>
Zmodyfikuj klasę SnackMachine by zapisywała historię operacji wykonywanych przez użytkonika do pliku.
</summary>

</details><br>

### Struktury danych

Złożoność obliczeniowa struktur danych:
https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections

- List (lista) [metody](https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections)
- Set (zbiór) [metody](https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections)
- Dictionary (słownik) [metody](https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections)
- Queue (kolejka) [metody](https://learn.microsoft.com/pl-pl/dotnet/standard/collections/#algorithmic-complexity-of-collections)