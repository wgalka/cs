# Automat z przekąskami
http://www.avt4you.pl/napoje_przekaski.html
## EK_04

### Zadanie 1
Utwórz klasę **Product**. Obiekty tej klasy będą przechowywać informacje o nazwie, cenie, dacie ważności produktu. Klasa powinna być hermetyczna. Cena nie może być ujemna a nazwa pusta. Jeśli użytkownik próbuje przypisać ujemną cenę do pola klasy przypisz wartość 0. Natomiast jeśli próbuje przypisać pustą nazwę przypisz wartość “Default name”.

Przesłoń metodę ToString() aby zwracała informację o nazwie produktu oraz jego cenie.

### Zadanie 2

Zaprojektuj abstrakcyjną klasę AbstractVendingMachine w oparciu o następujący opis.

Pewna firma sprzedaje 3 rodzaje automatów: MiniMunchMachine
- wymiary
CompactCafe
- 
MicroMarket

Automaty pozwalają na:
- dodanie przekąski
- wrzucenie monety
- wybranie produktu
-   

- Automat przechowuje przekąski(obiekty klasy snack).
- W automacie jest kasetka z różnymi monetami o pewnej pojemności.
- Automat ma pewną pojemność określającą ile przekąsek jest w stanie pomieścić.
- Chcemy mieć możliwość dodania przekąski do automatu
- Chcemy mieć możliwosć dodania pieniędzy do automatu
- Chcemy mieć możliwosć sprawdzenia stanu pieniędzy po wpisaniu tajnego kodu przypisanego do konkretnego automatu który jest definiowany w momencie jego tworzenia.
- Chcemy mieć możliwośc wyboru produktu. Automaty mogą robić to w różny sposób np. po wpisaniu odpowiedniego kodu na klawiaturze.
- Chcemy mieć możliwość wyświetlenia cen przekąsek.

### Zadanie 3

Stwórz klasę konkretną MiniMunchMachine dziedziczącą po AbstractVendingMachine umożliwiającą spełnienie jej założeń.

## EK_05

Utwórz obiekt klasy MiniMunchMachine a nastpęnie wypełnij maszynę przekąskami. 

## EK_06
Utwórz menu pozwalające użytkownikowi zarządzać stanem klasy VendingMachine. Użytkownik ma mieć możliwość dodawania przekąski tylko po wpisaniu w konsoli hasła 1234.
Użytkownik ma możliwość kupowania przekąsek podając wcześniej wartość wrzuconych monet. Jeśli funkcja BuySncak zwróci false, aplikacja wyświetla stosowny komunikat i pozwala użytkownikowi wybrać czy wyczyścić saldo czy dodać kolejne monety.
Użytkownik ma mieć możliwość sprawdzenia jakie przekąski są dostępne.
Użytkownik decyduje kiedy zakończyć działanie aplikacji.
Obsłuż odpowiednie wyjątki występujące np. podczas parsowania danych i wyświetl stosowne komunikaty. 






