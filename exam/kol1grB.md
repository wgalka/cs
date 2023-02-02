# Automat z przekąskami
Pewna firma sprzedaje 3 rodzaje automatów:
- MicroMarket
    - wymiary szer. 77 cm, gł. 81 cm, wys. 97 cm
    - pojemność 20 produktów
    - płatność gotówką monety (20gr 50gr 1zł 2zł 5 zł)
    - przyciski mechaniczne do wyboru produktu (znaki A-Z)
- CompactCafe
    - wymiary szer. 80 cm, gł. 83 cm, wys. 183 cm
    - pojemność 25 produktów
    - płatność gotówką (50gr 1zł 2zł 5zł)
    - przyciski mechaniczne do wybotu produktu (znaki A-Z)
- MiniMunchMachine
    - wymiary szer. 89 cm, gł. 85 cm, wys. 183 cm
    - pojemność 30 produktów
    - płatność kartą
    - monitor dotykowy

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać:
- nazwę produktu
- cenę produktu
- opis produktu

Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa i opis puste. Jeśli użytkownik próbuje przypisać ujemną cenę, pustą nazwę lub opis zwróć odpowiedni wyjątek.

Przesłoń metodę `ToString()` aby zwracała wszystkie informacje o produkcie.
Przetestuj działanie metody ToString w metodzie main(). Test podpisz komentarzem "TEST DZIAŁANIA TOSTRING". Utwórz obiekt klasy Product o następujących wartościach:
- nazwa - Czekolada
- cena - 112337
- opis - twój numer albumu


### Zadanie 2

Zaprojektuj interfejs `IVendingMachine`.
Każda klasa implementująca interfejs powinna mieć:
- metodę `AddProduct()` przyjmującą jako parametr obiekt klasy Product. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `AddMoney()` przyjmującą kwotę wrzuconą przez użytkownika. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `BuyProduct()` przyjmującą kod produktu. Poszczególne implementacje metody będą się różnić w klasach dziedziczących.
- metodę `ReturnCoins()` nieprzyjmującą parametrów.


### Zadanie 3

Stwórz klasę konkretną `MicroMarket` implementującą interfejs `IVendingMachine` umożliwiającą wykonanie wszystkich operacji.
- `AddMoney()` dodaje kwotę przekazaną jako parametr funkcji do kasetki maszyny. Kwota powinna być monetą o odpowiednim nominale. Jeśli spełnia założenia wartość jest zapisywana w **polu klasy**. W przeciwnym wypadku zwróć odpowiedni wyjątek.

- `BuyProduct()` metoda przyjmuje kod produktu np. F (możliwy do wpisania na klawiaturze dostępnej w maszynie patrz wyżej). Jeśli produkt jest w maszynie i kwota wrzucona do kasetki jest wystarczająca produkt ma zostać wydany(usunięty z maszyny).

- `AddProduct()` dodaje produkt do maszyny. Metoda przyjmuje obiekty klasy Product. Nie można też dodać nowych produktów do pełnej maszyny.

- Przeciąż metodę `AddProduct()` tak aby przyjmowała jako parametr obiekt klasy Product oraz kod(miejsce) produktu pod jakim zostanie zapisany. np. F

- `ShowProducts()` wyświetla kody przekąsek, ich nazwę i cenę w następującej postaci:
```
A: Czekolada 12 PLN
F: Pepsi 5 PLN 
```

- `ReturnCoins()` zwraca monety wrzucone przez użytkownika. Po wywołaniu funkcji pole przechowujące liczbę monet powinno mieć wartość 0.

- Klasa powinna przechowywać cechy tego automatu(wymiary oraz nazwę) niemożliwe do zmiany po utworzeniu obiektu.

- Przesłoń metodę `ToString()` aby wypisała informację w podanym formacie gdzie nazwa automatu to NazwaAutomatu, XX to wymiary danego automatu:
```
NazwaAutomatu - szer. XX cm, gł. XX cm, wys. XX cm
```


### Zadanie 4

Utwórz obiekt klasy `MicroMarket`. Wypełnij maszynę produktami.

### Zadanie 5 

!Na ocenę 4.0+ powinny być obsłużone wyjątki występujące w programie.

Napisz program pozwalający użytkownikowi zarządzać stanem klasy `MicroMarket` przez standardowe wejście/wyjście.

Utwórz menu skłądające się z następujących opcji:
- A - Pokaż produkty
- B - Wrzuć monetę
- C - Kup produkt
- D - Pokaż ilość wrzuconych pieniędzy
- E - Wyciąg monety
- F - Wyjście

Zaimplementuj obsługę wszystkich opcji menu w przejrzysty i zrozumiały dla użytkownika sposób. 

Program powinien mieć ukryte menu. Po wpisaniu "ACAB" mamy możliwość dodania produktów do automatu. 

**Program powinien działać do momentu wybrania opcji wyjście z aplikacji przez użytkownika. Obsłuż wyjątki mogące wystąpić w aplikacji.**

### Zadanie 6 (Na ocenę 4.0+)
Zmodyfikuj program aby zapisywał i odczytywał  historię akcji wykonywanych przez użytkownika z pliku. Historia jest możliwa do wyświetlenia po wpisaniu kodu HISTORY. 

## Kryteria oceny:
- Aby otrzymać ocenę 5, program powinien być poprawnie działający, dobrze zorganizowany i czytelny, oraz spełniać wszystkie wymagania zadania. Powinien przewidywać i obsługiwać sytuacje wyjątkowe.(EK_4, EK_5, EK_6)
- Należy dobrać odpowiednie struktury do problemów występujących w zadaniu.(EK_5)






