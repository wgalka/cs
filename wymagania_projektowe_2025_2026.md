# Wymagania Projektowe: Programowanie Obiektowe II - C# (2025/2026)

Ten dokument określa kryteria oceniania, zasady punktacji oraz oczekiwane efekty kształcenia dla projektu realizowanego w ramach przedmiotu **Programowanie Obiektowe II - C#**.

**Godziny niekontaktowe – praca własna studenta (przygotowanie do zajęć, przygotowanie projektu zaliczeniowego) 55**

---

## Efekty Kształcenia

Projekt oraz obrona weryfikują następujące efekty kształcenia:

| Symbol | Opis | Odniesienie |
| :--- | :--- | :---: |
| **EK_01** | Zna podstawowe konstrukcje programistyczne i struktury danych występujące w języku C#, w tym również zna dobrze zagadnienia z zakresu programowania obiektowego oraz wie, jak je wykorzystać i zaimplementować w języku C#. | K_W06 |
| **EK_02** | Ma podstawową wiedzę na temat tworzenia graficznych interfejsów użytkownika oraz interfejsów do łączenia się z relacyjnymi bazami danych i użycia ich w języku C#. | K_W06 |
| **EK_03** | Umie zastosować poznane konstrukcje i struktury danych, w tym również kolekcje w języku C#. Potrafi również wykorzystać odpowiednie biblioteki i interfejsy języka C# do tworzenia oprogramowania w paradygmacie obiektowym, w tym również biblioteki do tworzenia graficznych interfejsów użytkownika oraz do łączenia się z relacyjnymi bazami danych. | K_U07 |
| **EK_04** | Potrafi zaprojektować i utworzyć aplikację w języku C#, która umożliwia połączenie się z relacyjną bazą danych i wykorzystującą tę bazę. Utworzona aplikacja posiada odpowiedni do potrzeb interfejs użytkownika. | K_U07 |

---

## Zasady Punktacji (Maksymalnie 100 pkt.)

Ocena z laboratorium jest oceną uzyskaną z zaliczenia projektu według poniższej punktacji.

| Kategoria | Kryteria Oceny | Maks. Pkt. |
| :--- | :--- | :---: |
| **Baza Danych** | **Złożoność i poprawność schematu**: projekt tabel, klucze główne/obce, odpowiednie relacje (1:N, N:M), normalizacja modelu, poprawność zachowania integralności danych oraz zastosowanie mechanizmu migracji. | **10** |
| **Kod i Architektura** | **Struktura aplikacji i jakość kodu**: Ogólna złożoność, podział na odpowiednie warstwy (np. warstwa widoku, logiki, repozytoriów/serwisów), poprawne zastosowanie wzorców (m.in. MVVM, Dependency Injection). Sposób walidacji danych, radzenie sobie ze sprawdzaniem i obsługą wyjątków (try/catch) oraz ogólna czytelność i czystość składni. | **20** |
| **UI i UX** | **Organizacja interfejsu użytkownika**: Przemyślany układ okien i nawigacja aplikacji, złożoność widoków, praca nad warstwą wizualną / stylizacją elementów, a także intuicyjna i spójna obsługa programu przez użytkownika końcowego. | **20** |
| **Technologie** | **Warstwa UI oraz dostępu do danych**: Zastosowanie bardziej wymagających technologii jest nagradzane wyższą liczbą punktów. (Szczegóły i gradacja punktowa poniżej). | **20** |
| **Dokumentacja** | **Jakość dokumentacji projektowej**: Dokument *Markdown* zawierający m.in.: opis celu aplikacji, zebrane wymagania systemu, wygenerowany z bazy model Danych / schemat ERD, precyzyjną instrukcję uruchomienia środowiska projektowego, oraz zrzuty ekranów z kluczowych etapów działania programu (OPISANE w postaci podręcznika użytkownika). | **10** |
| **Obrona Projektu** | **Prezentacja i orientacja w kodzie**: Biegłe i samodzielne omówienie działania uruchomionej aplikacji, wyjaśnienie architektury/podjętych decyzji logicznych. Bezproblemowe odnalezienie się we własnym kodzie, modyfikacja drobnych elementów na prośbę prowadzącego i odpowiedź na dodatkowe pytania kontrolne. | **20** |

---

### Punktacja za Użyte Technologie (Maks. 20 pkt.)

Przy wyborze stogu technologicznego, użycie nowszych i bardziej wymagających narzędzi (wymagających np. zapoznania się ze wzorcem MVVM, databindingu czy zaawansowanego ORM) owocuje wyższą notą.

**1. Warstwa Interfejsu Użytkownika (Maks. 10 punktów):**
*   **10 pkt.** – WinUI 3
*   **9 pkt.**   – WPF / .NET MAUI / Blazor
*   **6 pkt.**   – Windows Forms

**2. Warstwa Dostępu do Danych (Maks. 10 punktów):**
*   **10 pkt.** – Entity Framework Core (poprawne wykorzystanie DbContext, migracji i LINQ).
*   **6 pkt.**   – ADO.NET (łączenie ze źródłem za pomocą `SqlConnection`, budowanie i wywoływanie `SqlCommand` i obsługa `SqlDataReader`).

---

### Skala Ocen

Po zsumowaniu wynik w punktach (0 – 100) jest przekładany na końcową ocenę według poniższej tabelki:

| Przedział Punktowy | Ostateczna Ocena | Skala |
| :---: | :--- | :---: |
| **0 – 50 pkt.** | niedostateczny | (2.0) |
| **51 – 60 pkt.** | dostateczny | (3.0) |
| **61 – 70 pkt.** | dostateczny plus | (3.5) |
| **71 – 80 pkt.** | dobry | (4.0) |
| **81 – 90 pkt.** | dobry plus | (4.5) |
| **91 – 100 pkt.** | bardzo dobry | (5.0) |

---

## Proponowane Tematy Projektów

Projekt musi rozwiązywać rzeczywisty problem określonej grupy odbiorców. Studenci mogą wymyślić własny temat podlegający akceptacji na zajęciach, bądź skorzystać z gotowych sugestii:

### Problem 1: Rozliczenia kosztów (Kalkulator Paragonów)
Mieszkanie we wspólnym gronie, organizacja imprezy albo zrzutka na majówkową wycieczkę po czasie nierzadko kończy się serią nieporozumień. Arkusz kalkulacyjny szybko staje się niewystarczający w sytuacji wielu paragonów dla różnych proporcji.
*Celem projektu* jest aplikacja dająca elastyczność w dodawaniu paragonu, przydzieleniu kwot poszczególnych "produktów na bloczku" pod konkretną osobę z drużyny i symetrycznego zbilansowania należności dla użytkowników do zwrotu i do opłaty.

### Problem 2: Wsparcie ewidencji działalności nierejestrowanej
Użytkownicy startujący z nierejestrowanym przychodem rzadko wiedzą jak liczyć wymagany limit od najniższej krajowej. Gubią notatki w zeszytach i notatnikach o przychodach. Brak ewidencji rodzi strach przed przekroczeniem progu.
*Celem projektu* jest napisanie szybkiego notatnika ewidencji opartego o bazy danych z inteligentnym pokazywaniem bieżących zarobków i wskaźnikiem zbliżania się do górnej granicy legalnego limitu bez składki ZUS.

---

## Przykładowe Pytania do Obrony Projektu

W czasie prezentacji prowadzący dobiera pytania odpowiednio do wybranych przez studenta technologii i stopnia złożoności kodu. Pytania są pogrupowane według efektów kształcenia oraz poziomu oczekiwanej wiedzy.

---

## EK_01 – Podstawy C# i programowanie obiektowe

> *Zna podstawowe konstrukcje programistyczne i struktury danych w C#, zna dobrze zagadnienia OOP i wie, jak je zaimplementować.*

### Ocena 3.0 – Definicje i rozpoznawanie mechanizmów OOP

*Pytania sprawdzają znajomość definicji czterech filarów OOP, podstawowych typów danych, składni C# i roli elementów klasy.*

1. Wymień cztery filary programowania obiektowego i krótko opisz każdy z nich.
2. Czym jest klasa, a czym obiekt? Jaka jest między nimi różnica?
3. Czym jest dziedziczenie i jakie słowo kluczowe służy do niego w C#?
4. Czym jest polimorfizm? Podaj prosty przykład — jak ta sama nazwa metody może zachowywać się różnie w klasach pochodnych?
5. Czym jest hermetyzacja (enkapsulacja)? Po co ukrywa się pola klasy za modyfikatorami dostępu?
6. Czym jest klasa abstrakcyjna i czym różni się od zwykłej klasy oraz od interfejsu?
7. Co to jest metoda w klasie i jak wywołujemy ją na obiekcie?
8. Jaką rolę pełni konstruktor w klasie?
9. Wymień dwa modyfikatory dostępu (`public`, `private`) i wyjaśnij ich działanie.
10. Czym jest interfejs (`interface`) w języku C# i po co go stosujemy?
11. Wymień trzy podstawowe typy proste w C# i powiedz, co każdy z nich przechowuje.
12. Czym różni się typ `int` od `string`? Jakiego jest każdy z nich rodzaju (wartościowy / referencyjny)?
13. Jakie są różnice między `float` a `double` (precyzja, rozmiar)?
14. Do czego służy blok `try...catch` i kiedy go używamy?

### Ocena 4.0 – Rozumienie relacji i wyjaśnienie działania

*Pytania wymagają wyjaśnienia, jak i dlaczego dany mechanizm działa — nie tylko co oznacza.*

1. Wyjaśnij różnicę między typem wartościowym a referencyjnym i podaj przykłady każdego.
2. Czym różni się metoda wirtualna (`virtual`) od metody abstrakcyjnej (`abstract`)? Kiedy używamy każdej z nich?
3. Opisz zasadę działania hermetyzacji (enkapsulacji) i wskaż ją na przykładzie własnego kodu — jakie pola i właściwości chronisz?
4. Jak działa mechanizm `base(...)` w konstruktorach klas pochodnych i kiedy jest wymagany?
5. Opisz relację „jest" (is-a) w kontekście dziedziczenia oraz relację „ma" (has-a) w kontekście kompozycji — podaj przykład obu.
6. Czym jest przeciążanie metod (overloading)? Czym różni się od przesłaniania (overriding)?
7. Wyjaśnij działanie operatora `as` oraz `is` w kontekście rzutowania i polimorfizmu dynamicznego.
8. Jak działają delegaty i zdarzenia (`event`) w C#? Do czego je stosujemy?
9. Jak działa słowo kluczowe `this` i kiedy jest niezbędne?
10. Opisz różnicę między właściwościami (`get`/`set`) a polami (fields) — dlaczego właściwości są preferowane?
11. Jak wymusić, aby klasa nie mogła być dziedziczona (słowo kluczowe `sealed`)?
12. Czym jest rekord (`record`) i kiedy warto go stosować zamiast klasy?
13. Co to są Primary Constructors (konstruktory pierwotne) i jak skracają definicję klasy/rekordu?
14. Do czego służą Collection Expressions (np. `int[] x = [1, 2, 3];`) wprowadzone w C# 12?

### Ocena 5.0 – Dogłębna wiedza o działaniu środowiska .NET

*Pytania sprawdzają rozumienie wewnętrznych mechanizmów .NET, zaawansowanych wzorców językowych i optymalizacji.*

1. Wyjaśnij mechanizm działania Garbage Collector (GC) w C# — jak identyfikuje obiekty do usunięcia i co to są generacje?
2. Czym różni się modyfikator `override` od `new` przy przesłanianiu metod — co każdy z nich robi z wywołaniem przez referencję klasy bazowej?
3. Wyjaśnij pojęcie „unmanaged code" i sposób użycia bloków `unsafe` — kiedy sięgamy po wskaźniki w C#?
4. Wyjaśnij działanie słowa kluczowego `in` oraz `ref readonly` — kiedy warto ich używać dla wydajności?
5. Jakie są konsekwencje niemutowalności typu `string` (interning, alokacje) i kiedy użyć `StringBuilder`?
6. Opisz różnice w implementacji interfejsów przed i po C# 8.0 (metody domyślne w interfejsach) — jakie to otwiera możliwości?
7. Jak zaprojektować własny indeksator w klasie i do czego jest przydatny?
8. Wyjaśnij, jak działa przeciążanie operatorów na przykładzie klasy `Punkt` (suma wektorów).
9. Czym jest polimorfizm statyczny (compile-time) i jak go zrealizować poprzez przeciążanie metod oraz generyki?
10. Co to jest „pattern matching" w nowoczesnym C# — jakie formy przybiera (`switch` expression, `is` z wzorcem, `when`)?
11. Czym są ograniczenia typów generycznych (`where T : class`, `where T : new()`) i po co je stosujemy?
12. Jaka jest różnica między `Task` a `ValueTask` i kiedy optymalizujemy kod za pomocą tego drugiego?

---

## EK_02 – Graficzny interfejs użytkownika i dostęp do baz danych (wiedza)

> *Ma podstawową wiedzę na temat tworzenia GUI oraz interfejsów do łączenia się z relacyjnymi bazami danych w C#.*

### Ocena 3.0 – Podstawowe pojęcia UI i relacyjnych baz danych

*Pytania sprawdzają znajomość fundamentalnych pojęć dotyczących baz danych i elementów interfejsu w wybranej technologii UI.*

1. Co to jest relacyjna baza danych i czym różni się od przechowywania danych w pliku tekstowym?
2. Co to jest tabela w bazie danych i jaką rolę pełni klucz główny (Primary Key)?
3. Do czego służy polecenie `SELECT` w SQL i jak wygląda jego prosta składnia?
4. Co to jest connection string i gdzie zazwyczaj jest przechowywany w projekcie?
5. Co oznacza skrót ORM i czym jest Entity Framework Core?
6. Czym jest `DbSet<T>` w kontekście Entity Framework i do czego go używamy?
7. Jak otworzyć nowe okno (formularz) w technologii Windows Forms?
8. Na czym polega różnica między `Show()` a `ShowDialog()` w Windows Forms?
9. Czym jest `MenuStrip` i do czego służy w aplikacji desktopowej?
10. Jak dodać przycisk (`Button`) do formularza WinForms w kodzie?
11. Co to jest projekt WPF i czym różni się od Windows Forms (XAML vs. designer)?
12. Jakie pliki wchodzą w skład okna WPF (`.xaml` i `.xaml.cs`) i za co każdy odpowiada?

### Ocena 4.0 – Zrozumienie mechanizmów UI i warstwy danych

*Pytania wymagają wyjaśnienia działania technologii data bindingu, konfiguracji EF Core i roli kluczowych klas.*

1. Co zawiera interfejs `INotifyPropertyChanged` i dlaczego jego implementacja jest konieczna przy data bindingu w WPF/MAUI?
2. Jak wygląda składnia wiązania danych w XAML (`{Binding PropertyName}`) i jaką rolę pełni `DataContext`?
3. Jakie znaczenie ma metoda `OnModelCreating` w `DbContext` — do czego jej używamy?
4. Jak skonfigurować connection string i klasę `DbContext` przy użyciu pliku `appsettings.json`?
5. Jakie znaczenie mają adnotacje danych (np. `[Key]`, `[Required]`, `[MaxLength]`) w modelach EF Core?
6. Co to jest migracja w Entity Framework i jakie polecenia CLI służą do jej tworzenia i aplikowania?
7. Opisz działanie `BindingList<T>` i jej przewagę nad zwykłą `List<T>` w kontekście automatycznego odświeżania GUI.
8. Czym jest `DataGridView` i jak podpiąć do niego źródło danych w WinForms?
9. Jaką rolę pełni klasa `DbContext` — czym jest wzorzec Unit of Work i jak `SaveChanges()` synchronizuje zmiany z bazą?

### Ocena 5.0 – Zaawansowane wzorce i architektura warstwy UI/danych

*Pytania sprawdzają dogłębne rozumienie wzorców architektonicznych, mechanizmów bindingu i świadomych wyborów technologicznych.*

1. Omów, dlaczego aplikacje WPF i WinUI powinny opierać się o architekturę **MVVM** — gdzie spoczywa logika biznesowa, a gdzie obsługa zdarzeń UI?
2. Dlaczego unika się logiki w klasach „Code-behind" (np. `MainWindow.xaml.cs`) i jak ją przenieść do ViewModelu?
3. Do czego służy `IDesignTimeDbContextFactory` i dlaczego jest ważna przy pracy z migracjami w projektach bez hosta generycznego (np. WinForms)?
4. Opisz mechanizm dwukierunkowego data bindingu w WPF/WinUI i wyjaśnij rolę `ObservableCollection<T>` wobec zwykłej `List<T>`.
5. Opisz różnice między ADO.NET a Entity Framework Core z perspektywy wydajności, kontroli nad SQL i złożoności kodu — kiedy sięgnąć po czyste ADO.NET?
6. Wyjaśnij rolę Dependency Injection w rejestrowaniu `DbContext` przez kontenery IoC (`AddDbContext`, cykl życia `Scoped`).
7. Jak zrealizować paginację danych na poziomie bazy danych przy użyciu `Skip` i `Take` i dlaczego jest to lepsze od pobierania wszystkich rekordów do pamięci?

---

## EK_03 – Implementacja: kolekcje, biblioteki i OOP w praktyce

> *Umie zastosować konstrukcje i struktury danych, kolekcje oraz biblioteki C# do tworzenia oprogramowania w paradygmacie obiektowym.*

### Ocena 3.0 – Zastosowanie podstawowej składni, kolekcji i klas

*Pytania sprawdzają, czy student potrafi użyć podstawowych konstrukcji C# — tworzyć obiekty, operować na kolekcjach i pisać metody.*

1. Jak stworzyć obiekt klasy i wywołać na nim metodę? Napisz przykładowy kod.
2. Jak zadeklarować listę przechowującą napisy (`List<string>`) i dodać do niej elementy?
3. Co robi metoda `Add()` w kolekcji `List<T>` i jak usunąć element metodą `Remove()`?
4. Jak zadeklarować tablicę liczb całkowitych (`int[]`) i wypełnić ją wartościami?
5. Jak dodać parę klucz-wartość do słownika `Dictionary<string, int>` i jak pobrać wartość po kluczu?
6. Do czego służy właściwość `Length` w tablicach, a do czego `Count` w listach?
7. Co to jest LINQ w najprostszym ujęciu i do czego służy?
8. Do czego służy pętla `for` i czym różni się od `foreach`?
9. Jak stworzyć prostą metodę, która nic nie zwraca (typ `void`) i metodę zwracającą wartość?
10. Do czego służy słowo kluczowe `return`?
11. Do czego służy klasa `Path` z przestrzeni `System.IO` — podaj przykład użycia.
12. Do czego służy instrukcja `if...else` — jak wygląda w C# i kiedy używamy `switch`?

### Ocena 4.0 – Stosowanie bibliotek i wyjaśnienie działania mechanizmów

*Pytania wymagają zrozumienia działania bibliotek standardowych, LINQ oraz mechanizmów zarządzania zasobami.*

1. Czym różni się składnia zapytaniowa LINQ (query syntax) od składni metod (method syntax) — pokaż ten sam filtr w obu formach?
2. Co to jest „leniwe wykonywanie" (deferred execution) w LINQ i jakie ma konsekwencje praktyczne (np. wielokrotne odpytanie bazy)?
3. Jak obsłużyć wiele różnych typów wyjątków w jednym bloku `try` — jak działa kolejność klauzul `catch`?
4. Do czego służy blok `finally` w obsłudze wyjątków i kiedy jest uruchamiany (nawet gdy wyjątek nie wystąpił)?
5. Co to są metody rozszerzające (extension methods) i jak je zdefiniować — podaj przykład dla `string` lub `IEnumerable`?
6. Jak działa mechanizm `using` przy pracy ze strumieniami i dlaczego gwarantuje zwolnienie zasobów (interfejs `IDisposable`)?
7. Opisz różnicę między `IEnumerable<T>` a `IQueryable<T>` — kiedy używamy każdego z nich i co dzieje się z filtrem po stronie serwera vs. klienta?
8. Jak przefiltrować i posortować listę obiektów za pomocą LINQ (operatory `Where`, `OrderBy`, `Select`)?
9. Jak stworzyć własny wyjątek w C# dziedzicząc po `Exception` — co powinien zawierać?
10. Opisz klasę `FileStream` – kiedy jej używamy i jak bezpiecznie otworzyć plik do zapisu przy użyciu `using`?
11. Dlaczego używamy `List<T>` zamiast `ArrayList`? Wyjaśnij pojęcie boxing i unboxing w kontekście wydajności.

### Ocena 5.0 – Zaawansowane stosowanie bibliotek i optymalizacja

*Pytania sprawdzają rozumienie pułapek wydajnościowych, zaawansowanych operacji LINQ i mechanizmów niskopoziomowych.*

1. Opisz problem N+1 przy zapytaniach w Entity Framework — jak go rozwiązać za pomocą `Include` (Eager Loading) i jak wykryć w logach SQL?
2. Jak wykonać „Join" dwóch kolekcji w składni LINQ i kiedy użyć `GroupJoin` zamiast `Join`?
3. Wyjaśnij różnicę między `First()`, `FirstOrDefault()`, `Single()` i `SingleOrDefault()` — kiedy każde z nich rzuca wyjątek?
4. Opisz mechanizm „podwójnej enumeracji" w LINQ, dlaczego należy go unikać i jak mu zapobiec (użycie `ToList()`)?
5. Jakie są różnice między `MemoryStream` a `FileStream` pod kątem zastosowania i wydajności — kiedy używamy każdego?
6. Jak użyć klasy `Environment` do pobierania ścieżek systemowych w sposób działający na różnych systemach operacyjnych?
7. Wyjaśnij różnicę między `ref` a `out` przy przekazywaniu parametrów — kiedy kompilator wymaga inicjalizacji przed przekazaniem?
8. Do czego służy `checked` i `unchecked` w operacjach arytmetycznych i co się dzieje przy przepełnieniu (`int.MaxValue + 1`)?
9. Jak zdefiniować i wywołać zdarzenie z niestandardowymi argumentami (własna klasa dziedzicząca po `EventArgs`)?
10. Wyjaśnij, czym są wyrażenia lambda i jak są powiązane z delegatami (`Func<T>`, `Action<T>`, `Predicate<T>`) — pokaż przykład użycia w LINQ.

---

## EK_04 – Projektowanie i tworzenie aplikacji z bazą danych i interfejsem

> *Potrafi zaprojektować i utworzyć aplikację C# z bazą danych i odpowiednim interfejsem użytkownika.*

### Ocena 3.0 – Podstawowe umiejętności tworzenia aplikacji z bazą danych

*Pytania sprawdzają, czy student rozumie środowisko pracy, strukturę projektu i potrafi wykonać podstawowe operacje na bazie danych przez UI.*

1. Jakie polecenie w terminalu służy do kompilacji i uruchomienia projektu (`dotnet build`, `dotnet run`)?
2. Co to jest NuGet i jak dodać nową bibliotekę (np. `Microsoft.EntityFrameworkCore`) do projektu?
3. Co to jest przestrzeń nazw (`namespace`) i czemu służy porządkowanie kodu w przestrzenie?
4. Jakie rozszerzenie mają pliki projektów C# (`.csproj`) i co konfigurujemy w tym pliku?
5. Co to jest klucz główny (Primary Key) i klucz obcy (Foreign Key) — jaką rolę pełnią w relacji między tabelami?
6. Co to jest schemat ERD i jakie informacje powinien zawierać (tabele, kolumny, relacje, klucze)?
7. Jak dodać nowe okno (formularz) do projektu Windows Forms i jak je otworzyć z innego okna?
8. Jak wstawić nowy rekord do bazy danych przy użyciu metody `Add()` i `SaveChanges()` w EF Core?
9. Jak odczytać listę rekordów z tabeli przy użyciu EF Core (metoda `ToList()` na `DbSet`)?
10. Czym jest `null` i dla jakich typów można go użyć — co to są typy nullowalne (`int?`)?

### Ocena 4.0 – Projektowanie warstw i integracja komponentów

*Pytania wymagają wyjaśnienia, jak łączyć warstwy aplikacji, stosować wzorce projektowe i zarządzać danymi w pełnoprawnej aplikacji.*

1. Czym jest Dependency Injection (DI)? Wyjaśnij cykle życia rejestrowania usług: `Singleton`, `Scoped`, `Transient` — który jest właściwy dla `DbContext`?
2. Co to znaczy „Podejście Code-First" w EF Core? Omów kroki od napisania modelu (klasy C#) do pojawienia się tabeli w bazie danych.
3. Jak wygląda typowy workflow przy dodaniu nowej kolumny do istniejącej tabeli bazy danych za pomocą migracji EF Core?
4. Do czego służą zasady **SOLID**? Opisz zasadę Single Responsibility Principle na przykładzie własnej klasy z projektu.
5. Jak wyglądają relacje 1:N i N:M z perspektywy modelu w EF Core (właściwości nawigacyjne `ICollection<T>`, tabela pośrednia)?
6. Jak stosować `async`/`await` przy operacjach bazodanowych (`SaveChangesAsync`, `ToListAsync`)? Czym grozi używanie `.Result` lub `.Wait()` w metodach asynchronicznych (problem Deadlocka)? Dlaczego należy stosować „async all the way"?
7. Jak obsługiwać błędy połączenia z bazą danych i nieudane transakcje w warstwie serwisowej (`try/catch` przy operacjach EF Core)?
8. Jak zwalidować dane wejściowe od użytkownika — zarówno na poziomie UI (komunikaty) jak i modelu domenowego (adnotacje)?
9. Jak zaprojektować strukturę folderów projektu, aby oddzielić modele, serwisy, repozytoria i widoki?
10. W jaki sposób Dependency Injection ułatwia pisanie testów jednostkowych (Unit Testing)? Czym jest Mockowanie obiektów i jakie biblioteki się do tego wykorzystuje (np. Moq, NSubstitute)?

### Ocena 5.0 – Zaawansowane projektowanie i świadomość architektoniczna

*Pytania sprawdzają umiejętność świadomego podejmowania decyzji architektonicznych, znajomość pułapek ORM i mechanizmów runtime .NET.*

1. Omów architekturę warstwową aplikacji (View → ViewModel → Service → Repository → DbContext). Gdzie spoczywa logika biznesowa i dlaczego jej wyniesienie z warstwy widoku jest ważne?
2. Podczas zapisu do 3 powiązanych tabel wystąpił błąd przed zapisem ostatniej. Jak użyć `Transaction` w EF Core, by zagwarantować spójność danych (all-or-nothing)?
3. Wyjaśnij pojęcie Leaky Abstraction — dlaczego mimo używania ORM nadal trzeba rozumieć działanie SQL-a i kiedy ORM generuje nieefektywne zapytania?
4. Jaka jest główna korzyść z `IQueryable<T>` nad `IEnumerable<T>` — co się dzieje po stronie bazy danych w każdym przypadku i jak to wpływa na zużycie RAM-u?
5. Jak zaimplementować wzorzec Singleton w C# i dlaczego jest przydatny np. dla konfiguracji lub sesji użytkownika — jakie są jego wady w aplikacjach wielowątkowych?
6. Wyjaśnij dylemat asynchroniczności i niebezpieczeństwo blokowania wątku przez użycie `.Result` lub `.Wait()` (tzw. Deadlocks) — dlaczego należy stosować „async all the way"?
7. Wyjaśnij rolę kodu bajtowego (IL) i środowiska CLR w kontekście kompilacji JIT — co to oznacza dla przenośności aplikacji .NET?
8. Jak zrealizować filtrowanie wyjątków przy użyciu słowa kluczowego `when` i kiedy jest to lepsze od sprawdzania warunku wewnątrz bloku `catch`?
9. Jakie są różnice w dostępie `protected internal` a `private protected` i w jakich scenariuszach (biblioteki wielomodułowe) je stosujemy?
10. Czym różni się wzorzec Repository od Unit of Work? Czy Entity Framework Core już sam w sobie realizuje te wzorce (DbContext, DbSet) i kiedy dodatkowa warstwa abstrakcji jest uzasadniona?



# Ważne uwagi

## Migracje i zasiewanie

Migracje oraz seedery są ważnymi elementami w procesie testowania i prezentacji aplikacji. Aby móc przetestować takie aspekty jak paginacja czy wydajność strony, konieczne jest posiadanie dużej ilości danych w bazie. Dane te można dodawać ręcznie lub przygotować w postaci zapytań SQL, jednak takie podejście bywa czasochłonne i mało elastyczne.

W przypadku pojawienia się błędów w interfejsie lub potrzeby zmiany struktury czy zawartości danych, tradycyjne metody wiążą się często z koniecznością wykonywania wielu powtarzalnych operacji. Może to prowadzić do ogromnego nakładu pracy oraz zwiększonego ryzyka pomyłek.

Zastosowanie seederów pozwala znacząco uprościć ten proces – zamiast ręcznie modyfikować dane, wystarczy zmienić odpowiedni fragment kodu, często nawet jedną linię, aby wygenerować nowy zestaw danych testowych. Dzięki temu praca staje się szybsza, bardziej przewidywalna i łatwiejsza do utrzymania.

Migracje natomiast umożliwiają zarządzanie strukturą bazy danych w sposób uporządkowany i wersjonowany. Pozwalają one na łatwe wprowadzanie zmian w schemacie bazy, takich jak dodawanie tabel czy kolumn, a także ich cofanie w razie potrzeby.



