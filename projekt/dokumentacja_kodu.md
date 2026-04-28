# Generowanie dokumentacji kodu w C#

W języku C# standardowym sposobem dokumentowania kodu są tzw. **Komentarze XML** (XML Documentation Comments), które rozpoczyna się od trzech ukośników (`///`). Kompilator potrafi wyciągnąć te komentarze i zapisać je w postaci pliku XML, który z kolei może posłużyć do wygenerowania czytelnej dokumentacji w formie strony HTML (np. przy użyciu narzędzia **DocFX**).

## Jak włączyć generowanie pliku XML z dokumentacją?

Włączenie tej opcji w interfejsie graficznym dowolnego nowoczesnego IDE (Visual Studio, JetBrains Rider) zawsze sprowadza się pod spodem do modyfikacji pliku `.csproj`. Kompilator opiera się ostatecznie wyłącznie na zawartości tego pliku.

Możesz to zrobić na kilka sposobów:

**1. Ręczna edycja pliku `.csproj` (Rekomendowane i uniwersalne):**
Otwórzyć plik projektu (dwuklik na projekt w drzewie plików w VS lub Riderze) i dodać wpis `<GenerateDocumentationFile>` w sekcji `<PropertyGroup>`:

```xml
<PropertyGroup>
  <GenerateDocumentationFile>true</GenerateDocumentationFile>
</PropertyGroup>
```

**2. Przez interfejs w Visual Studio:**
1. Kliknąć prawym przyciskiem myszy na swój projekt w *Solution Explorer* i wybrać **Properties** (Właściwości).
2. Przejść do zakładki **Build** -> **Output**.
3. Zaznaczyć opcję **Documentation file** (Plik dokumentacji). Edytor sam zaktualizuje plik `.csproj`.

**3. Przez interfejs w JetBrains Rider:**
1. Kliknąć prawym przyciskiem myszy na swój projekt w drzewie plików i wybrać **Properties**.
2. Przejść do sekcji **Configurations** (lub *Build* w zależności od wersji).
3. Znaleźć i zaznaczyć opcję **Generate XML documentation**. Rider również automatycznie zaktualizuje plik `.csproj`.

## Najpopularniejsze znaczniki komentarzy XML

Komentarze XML używają specjalnych znaczników do strukturyzacji tekstu. Poniższa tabela przedstawia najważniejsze i najczęściej używane z nich:

| Znacznik | Opis | Przykład użycia |
|----------|------|-----------------|
| `<summary>` | Krótkie podsumowanie tego, co robi dana klasa, metoda lub właściwość. Powinien być to pierwszy znacznik. | `/// <summary>Zapisuje użytkownika do bazy.</summary>` |
| `<param name="nazwa">` | Opisuje konkretny parametr przyjmowany przez metodę. | `/// <param name="id">Identyfikator użytkownika.</param>` |
| `<returns>` | Opisuje wartość zwracaną przez metodę (jeśli nie jest `void`). | `/// <returns>Prawdę, jeśli operacja się powiodła.</returns>` |
| `<remarks>` | Dodatkowe, bardziej szczegółowe informacje o działaniu elementu (np. edge case'y). | `/// <remarks>Metoda może wyrzucić wyjątek bazy danych.</remarks>` |
| `<exception cref="Typ">` | Informuje o wyjątkach, które mogą zostać celowo wyrzucone przez metodę. | `/// <exception cref="ArgumentNullException">Gdy podano null.</exception>` |
| `<example>` | Używany do zamieszczania przykładu użycia kodu. Często używany w parze z tagiem `<code>`. | `/// <example><code>var x = Calculate(2);</code></example>` |
| `<see cref="InnyElement">` | Tworzy wewnątrz tekstu link (odnośnik) do innej klasy, metody lub właściwości. | `/// Oblicza na podstawie <see cref="BaseService.Setup"/>` |
| `<seealso cref="Inny">` | Dodaje link w sekcji "Zobacz również" na dole dokumentacji. | `/// <seealso cref="IDatabaseContext"/>` |
| `<value>` | Opisuje wartość, którą reprezentuje właściwość (Property). | `/// <value>Imię i nazwisko jako jeden string.</value>` |

### Przykład użycia w praktyce:

```csharp
/// <summary>
/// Pobiera informacje o użytkowniku na podstawie jego identyfikatora.
/// </summary>
/// <remarks>
/// Metoda wykonuje zapytanie do bazy danych. Jeśli użytkownik o podanym 
/// ID nie istnieje, metoda zwraca null, zamiast rzucać wyjątkiem.
/// </remarks>
/// <param name="userId">Unikalny identyfikator użytkownika (musi być większy od zera).</param>
/// <returns>Obiekt reprezentujący użytkownika lub null, gdy nie znaleziono rekordu w bazie.</returns>
/// <exception cref="ArgumentException">Wyrzucany, gdy argument <paramref name="userId"/> jest mniejszy lub równy 0.</exception>
/// <seealso cref="UserService.GetAllUsers"/>
public User GetUserById(int userId)
{
    if (userId <= 0)
    {
        throw new ArgumentException("ID użytkownika musi być większe od 0.", nameof(userId));
    }

    // logika pobierania z bazy...
    return new User();
}
```

## Narzędzia do generowania dokumentacji (np. HTML)

**Sam plik XML wygenerowany przez kompilator jest przydatny dla środowiska IDE (np. Visual Studio wyświetla te informacje w tzw. *IntelliSense* w podpowiedziach), ale dla celów oddania projektu na uczelni czy prezentacji zazwyczaj generuje się z niego czytelną stronę WWW w formie portalu z dokumentacją.**

Najpopularniejsze narzędzia do tego celu zestawiono w poniższej tabeli:

| Narzędzie | Rok powstania |
|-----------|---------------|
| **DocFX** | 2015 |
| **Doxygen** | 1997 |
| **Sandcastle (SHFB)** | 2006 |


## Dokumentacja projektu - co zawrzeć?

Podczas tworzenia dokumentacji projektowej łatwo wpaść w pułapkę opisywania każdego trywialnego elementu (np. dokumentowanie właściwości public int Id { get; set; } jako "Pobiera lub ustawia identyfikator"). Zamiast tego, skup się na dostarczeniu wartościowej wiedzy.

**Dokumentuj "Dlaczego", a nie tylko "Co"**

Kompilator i nazwy metod mówią nam, co kod robi. Komentarze XML powinny wyjaśniać intencję lub specyficzne warunki brzegowe.
- Źle: `/// <summary>Metoda Save</summary>`
- Dobrze: `/// <summary>Trwale zapisuje stan zamówienia. Wywołuje proces walidacji stanów magazynowych przed transakcją.</summary>`


W dokumentacji nie opisywać wszsytkiego - wybrać kilka najbardziej reprezentatywnych klas (6 - 10) i opisać je porządnie wykorzystując jak najwięcej znaczników (pokazać że umie się korzystać z narzędzi zamiast pisać ogólniki dla małych funkcji)

### Strona internetowa z dokumentacją kodu

DocFX instaluje się jako narzędzie globalne .NET za pomocą terminala (PowerShell lub CMD):

````Bash
dotnet tool install -g docfx
````

Przejdź w terminalu do folderu głównego swojego projektu (tam, gdzie jest plik .sln lub .csproj) i wpisz:


````Bash
docfx init
````

Narzędzie zada kilka pytań (możesz zatwierdzać domyślne opcje klawiszem Enter).

Zostanie utworzony nowy folder (domyślnie docfx_project) z konfiguracją dokumentacji.

Aby zbudować dokumentację i podejrzeć ją w przeglądarce, wpisz:

````Bash
docfx docfx_project/docfx.json --serve
````

Otwórz przeglądarkę i wpisz adres: http://localhost:8080.