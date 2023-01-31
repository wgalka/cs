# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- **MiniMunchMachine**
    - **wymiary szer. 77 cm, gł. 81 cm, wys. 97 cm**
    - pojemność 40 produktów
    - płatnosć gotówką monety (20gr 50gr 1zł 2zł 5 zł)
    - przyciski mechaniczne do wyboru produktu (znaki 0-9)
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - pojemność 55 produktów
    - płatnosć gotówką (50gr 1zł 2zł 5zł)
    - przyciski mechaniczne do wybotu produktu (znaki 0-9)
- MicroMarket
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - pojemność 60 produktów
    - płatnośći kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać informacje o nazwie i cenie produktu. Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa pusta. Jeśli użytkownik próbuje przypisać ujemną cenę lub pustą nazwę zwróć odpowiedni wyjątek.

Przesłoń metodę `ToString()` aby zwracała informację o produkcie.

<details>
<summary>
Wskazówki
</summary>

Hermetyzacja nie polega na samym dodaniu do pól klasy modyfikatora dostępu private oraz utworzeniu Atrybutów lub getterów i setterów. Tworząc klasę należy zadbać o to aby nie mogło dojść do sytuacji w której wartość pola jest niepoprawne. **Jeśli nie ma takiej potrzeby nie udostępniamy metody set lub get**. Tyczy się to całego kolokwium nie tylko tego zadania.

Częstym błędem jest utworzenie Atrybutu w którym wartość pola cena jest poprawnie zwalidowana natomiast w konstruktorze metody przypisują Państwo wartość bezpośrednio.

```cs
private _price

public Product(Decimal price)
{
    _price = price; // Używając konstruktora możliwe jest wpisanie ujemnej ceny TAK NIE ROBIĆ
}

public Decimal Price // używając konstruktora wpisujemy tylko poprawną cenę
{
    get { return _price; }
    set { if (value < 0)
        {
            _price = 0;
        }
        else
        {
            _price = value;
        }
        }
}
```

</details>

### Zadanie 2

Zaprojektuj abstrakcyjną klasę `AbstractVendingMachine`. Zachowaj hermetyczność klasy.
Każda klasa dziedzicząca po niej powinna mieć:
- metodę `AddProduct()` przyjmującą jako parametr obiekt klasy Product. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` przyjmującą kwotę wrzuconą przez użytkownika. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `BuyProduct()` przyjmującą kod produktu. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `ReturnCoins()`
- pola przechowujące cechy wspólne wszystkich automatów.

<details>
<summary>
Wskazówki
</summary>

Hermetyzacja nie polega na samym dodaniu do pól klasy modyfikatora dostępu private oraz utworzeniu Atrybutów lub getterów i setterów. Tworząc klasę należy zadbać o to aby nie mogło dojść do sytuacji w której wartość pola jest niepoprawne. **Jeśli nie ma takiej potrzeby nie udostępniamy metody set lub get**. Tyczy się to całego kolokwium nie tylko tego zadania.

Częstym błędem jest utworzenie Atrybutu w którym wartość pola cena jest poprawnie zwalidowana natomiast w konstruktorze metody przypisują Państwo wartość bezpośrednio.

```cs
private _price

public Product(Decimal price)
{
    _price = price; // Używając konstruktora możliwe jest wpisanie ujemnej ceny TAK NIE ROBIĆ
}

public Decimal Price // używając konstruktora wpisujemy tylko poprawną cenę
{
    get { return _price; }
    set { if (value < 0)
        {
            _price = 0;
        }
        else
        {
            _price = value;
        }
        }
}
```
</details>


### Zadanie 3

Stwórz klasę konkretną `CompactCafe` dziedziczącą po AbstractVendingMachine umożliwiającą wykonanie wszystkich operacji.
- `AddMomeny()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być monetą o odpowiednim nominale. jeśli spełnia założenia wartość jest zapisywana w **polu klasy**. W przeciwnym wypadku zwróć odpowiedni wyjątek.
- `BuyProduct()` metoda przyjmuje kod produktu(możliwy do wpisania na klawiaturze dostępnej w maszynie patrz wyżej). Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt ma zostać wydany(usunięty z maszyny).

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy produkt. Nie można dodać produktu o tej samej nazwie ale różnych cenach. Nie można też dodać nowych produktów do pełnej maszyny lub jeśli osiągnięty został limit rodzajów produktów.
Metoda generuje losowy kod produktu.

- Przeciąż metodę `AddProduct()` tak aby przyjmowała jako parametr obiekt klasy Product oraz miejsce produktu pod jakim zostanie zapisany.

- `ShowProducts()` wyświetla kody przekąsek, ich nazwę, cenę, oraz ilość.

- `ReturnCoins()` zwraca monety wrzucone przez użytkownika. Po wywołaniu funkcji pole przechowujące liczbę monet powinno mieć wartość 0.


### Zadanie 4

Utwórz obiekt klasy `CompactCafe`. Wypełnij maszynę produktami.

### Zadanie 5
Napisz program pozwalający użytkownikowi zarządzać stanem klasy `CompactCafe` przez standardowe wejście/wyjście.

Na początku działania programu wyświetl informację o obiekcie za pomocą metody `ToString()`.

Utwórz menu umożliwiające:
- Dodanie przekąski do automatu
- Wrzucenie monet
- Zakupienie produktu
- Wyświetlenie produktów
- Wyświetlenie informacji o automacie
- Wyjście z aplikacji

Historia działań użytkownika powinna zapisywać się do pliku log.txt

Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obdłuż wyjątki mogące wystąpić w aplikacji.

### Zadanie 6
Zdomyfikuj program aby zapisywał i odczytywał  historię akcji wykonywanych przez użytkownika z pliku.

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów wystepujących w zadaniu.(EK_5)






