# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- MiniMunchMachine
    - wymiary szer. 77 cm, gł. 81 cm, wys. 97 cm
    - waga 150kg
    - 15 rodzajów produktów
    - pojemność 500 sztuk produktów
    - Rodzaje produktów: batony, napoje zimne
    - płatnosć gotówką
    - przyciski mechaniczne do wyboru produktu
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - waga 250kg
    - 7 rodzajów produktów
    - pojemność 1120 sztuk produktów
    - Rodzaje produktów: kawa, cherbata
    - płatnośći kartą
    - monitor dotykowy
- MicroMarket
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - waga 240kg
    - 65 rodzajów produktów
    - pojemność 1330 sztuk produktów
    - Rodzaje produktów: długopisy, zeszyty, witaminy, suplementy diety, chusteczki, batony, chipsy, woda, soki, napoje
    - płatnośći kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać informacje o nazwie, cenie, dacie ważności produktu, typie produktu. Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa pusta. Jeśli użytkownik próbuje przypisać ujemną cenę do pola klasy przypisz wartość 0. Natomiast jeśli próbuje przypisać pustą nazwę przypisz wartość “Default name”.

Przesłoń metodę `ToString()` aby zwracała informację o nazwie produktu oraz jego cenie.

### Zadanie 2

Zaprojektuj abstrakcyjną klasę AbstractVendingMachine. Zachowaj hermetyczność klasy.
Każda klasa dziedzicząca po niej powinna mieć:
- metodę `AddProduct()` zwracającą true false i przyjmującą jako parametr obiekt klasy Snack. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` zwracającą true lub false. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `SelectProduct()` zwracającą true lub false. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- pola przechowujące cechy wspólne wszystkich automatów.

Utwórz typ wyliczeniowy z następującymi stanami:
- AddMoney
- SelectProduct

### Zadanie 3

Stwórz klasę konkretną MiniMunchMachine dziedziczącą po AbstractVendingMachine umożliwiającą wykonanie wszystkich operacji.
- `AddMomeny()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być wielkokrotnością liczby 0.5(Automat przyjmuje minimalnie monety 50gr) jeśli spełnia założenia wartość jest zapisywana w polu klasy i zwracana jest odpowiednia wartość.
- `SelectProduct()` metoda przyjmuje numer produktu. Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt jest wydawany z maszyny,  zwracana jest reszta(do sejfu automatu pobierana jest tylko wartość wybranego produktu) oraz zwracana jest wartość true. W przeciwnym przypadku kwota wrzucona przez użytkownika wypada z automatu i zwracana jest wartość false.

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy produkt. Nie można dodać produktu o tej samej nazwie ale różnych cenach. W takim przypadku maszyna zwróci wartość false. Podobnie w przypadku zapełnienia maszyny.

- `ShowProducts()` wyświetla id przekąsek, ich nazwę, cenę, oraz ilość.


### Zadanie 4

Utwórz obiekt klasy `MiniMunchMachine` a nastpęnie wypełnij maszynę różnymi generowanymi losowo produktami. 

### Zadanie 5
Utwórz program pozwalający użytkownikowi zarządzać stanem klasy VendingMachine przez standardowe wejście/wyjście.

Utwórz menu umożliwiające:
- Dodanie przekąski do automatu
- Wrzucenie monet
- Zakupienie produktu
- Wyświetlenie produktów
- Wyświetlenie informacji o automacie
- Wyjście z aplikacji

Historia działań użytkownika powinna zapisywać się do pliku log.txt

Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obdłuż wyjątki mogące wystąpić w aplikacji.






