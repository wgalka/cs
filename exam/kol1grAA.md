# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- MiniMunchMachine
    - wymiary szer. 76 cm, gł. 80 cm, wys. 94 cm
    - pojemność 20 produktów
    - płatność gotówką monety (0.5EUR 1EUR 2EUR)
    - przyciski mechaniczne do wyboru produktu (znaki 0-9)
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - pojemność 25 produktów
    - płatność gotówką (0.5EUR 1EUR 2EUR)
    - przyciski mechaniczne do wybotu produktu (znaki A-Z)
- MikroMarket
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - pojemność 30 produktów
    - płatność kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać:
- nazwę produktu
- cenę produktu
- datę ważności

Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa i data puste. Jeśli użytkownik próbuje przypisać ujemną cenę, pustą nazwę lub datę zwróć odpowiedni wyjątek.

Przesłoń metodę `ToString()` aby zwracała wszystkie informacje o produkcie.
Przetestuj działanie metody ToString w metodzie main(). Test podpisz komentarzem "TEST DZIAŁANIA TOSTRING". Utwórz obiekt klasy Product o następujących wartościach:
- nazwa - Czekolada
- cena - twój numer albumu
- data - 02.02.2025


### Zadanie 2

Zaprojektuj abstrakcyjną klasę `AbstractVendingMachine`. Zachowaj hermetyczność klasy.
Każda klasa dziedzicząca po niej powinna mieć:
- metodę `AddProduct()` przyjmującą jako parametr obiekt klasy Product. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` przyjmującą kwotę wrzuconą przez użytkownika. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `BuyProduct()` przyjmującą kod produktu. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `ReturnCoins()` nieprzyjmującą parametrów.


### Zadanie 3

Stwórz klasę konkretną `MiniMunchMachine` dziedziczącą po `AbstractVendingMachine` umożliwiającą wykonanie wszystkich operacji.
- `AddMomeny()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być monetą o odpowiednim nominale. Jeśli spełnia założenia wartość jest zapisywana w **polu klasy**. W przeciwnym wypadku zwróć odpowiedni wyjątek.

- `BuyProduct()` metoda przyjmuje kod produktu np. 12 (możliwy do wpisania na klawiaturze dostępnej w maszynie patrz wyżej). Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt ma zostać wydany(usunięty z maszyny).

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy Product. Nie można też dodać nowych produktów do pełnej maszyny.

- Przeciąż metodę `AddProduct()` tak aby przyjmowała jako parametr obiekt klasy Product oraz kod(miejsce) produktu pod jakim zostanie zapisany. np. 12

- `ShowProducts()` wyświetla kody przekąsek, ich nazwę i cenę w następującej postaci:
```
1: Czekolada 12.00 EUR
5: Pepsi 5.50 EUR 
```

- `ReturnCoins()` zwraca monety wrzucone przez użytkownika. Po wywołaniu funkcji pole przechowujące liczbę monet powinno mieć wartość 0.

- Klasa powinna przechowywać cechy tego automatu(wymiary oraz nazwę) niemożliwe do zmiany po utworzeniu obiektu.

- Przesłoń metodę `ToString()` aby wypisała informację w podanym formacie gdzie nazwa automatu to NazwaAutomatu, XX to wymiary danego automatu:
```
NazwaAutomatu - szer. XX cm, gł. XX cm, wys. XX cm
```


### Zadanie 4

Utwórz obiekt klasy `MiniMunchMachine`. Wypełnij maszynę produktami.

### Zadanie 5 

!Na ocenę 4.0+ powinny być obsłużone wyjątki występujące w programie.

Napisz program pozwalający użytkownikowi zarządzać stanem klasy `MiniMunchMachine` przez standardowe wejście/wyjście.

Utwórz menu składające się z następujących opcji:
- 1 - Pokaż produkty
- 2 - Wrzuć monetę
- 3 - Kup produkt
- 4 - Pokaż ilość wrzuconych pieniędzy
- 5 - Wyciąg monety
- 6 - Wyjście

Zaimplementuj obsługę wszystkich opcji menu w przejrzysty i zrozumiały dla użytkownika sposób. 

Program powinien mieć ukryte menu. Po wpisaniu "1265" mamy możliwość dodania produktów do automatu. 

**Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obsłuż wyjątki mogące wystąpić w aplikacji.**

### Zadanie 6 (Na ocenę 4.0+)
Zmodyfikuj program aby zapisywał i odczytywał  historię akcji wykonywanych przez użytkownika z pliku. Historia jest możliwa do wyświetlenia po wpisaniu kodu "2233445". 

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów występujących w zadaniu.(EK_5)






