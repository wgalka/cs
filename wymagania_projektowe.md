
|Opis | 3.0 | 4.0 | 5.0|
|-----|-----|-----|----|
| Język w którym została napisana aplikacja | C# | C# | C# |
|Liczba tabel | >= 2 | >= 3 | >= 4|
|Połaczenie z relacyjną bazą danych | Połączenie na stałe w kodzie/pliku | Konfiguracja połączenia w pliku konfiguracyjnym, ale bez możliwości zmiany połączenia w czasie działania aplikacji | Konfiguracja połączenia w pliku (np. appsettings.json) z możliwością zmiany w czasie działania aplikacji|
| Modele | Modele istnieją. (zastosowano podstawowe atrybuty - klucz głowny, relacja 1:N itp.) | Wykorzystano atrybuty walidacji, relacje, klucze głowne i obce są odpowiednio zdefiniowane | Kompleksowe relacje między tabelami: Relacje 1:1, 1:N, [N:M](https://devstyle.pl/2011/02/24/pulapka-relacji-wiele-do-wielu-mn/) z odpowiednimi konfiguracjami przy pomocy Fluent API lub atrybutów. Rozwiązano problem N+1. Zoptymalizowano zapytania.  |
| Instrukcja utworzenia bazy danych niezbędnej do przetestowania aplikacji. | Użytkownik musi wczytać plik SQL tworzący bazę danych. Dodatkowo dostępny jest plik z przykładowymi danymi na których możliwe jest przetestowanie aplikacji. | Utworzone są migracje. Dodatkowo dostępny jest plik sql wypełniajacy bazę danych danymi które są potrzebne do przetestowania projektu | Porjekt zawiera migracje oraz seedery.|
| Operacje odczytu (Read) |     |     | Interfejs umożliwia w prosty sposób znalezienie interesującego nas rekordu np. przez filtrowanie według określonego parametru. |
|     | Aplikacja działa na serwerze postgres 14.0 lub innej relacyjnej |  Aplikacja działa na serwerze postgres 14.0 lub innej relacyjnej  |  Aplikacja działa na serwerze postgres 14.0 lub innej relacyjnej |
| ... | ... | ... |... |
| Walidacja pól formularzy | Podstawowa walidacja (czy pola nie puste/wartości są w zadanym przedziale itp) | Bardziej złożona walidacja danych, wykorzystano regular expression | Zaawansowana walidacja — walidacja zależna od kontekstu (np. różne pola dla różnych krajów), walidacja asynchroniczna (np. sprawdzenie dostępności e-maila w bazie danych) |
| Formularze wykorzystują odpowiednie typy pól dla pobieranych danych od ożytkownika (data, lista rozwijana, checkbox) | ✅ | ✅| ✅|
| ... | ... | ... |... |
| Dokumentacja w postaci pliku markdown opisującego podstawowe informacje na temat aplikacji (opis aplikacji, opis bazy danych, konfiguracja i uruchomienie aplikacji) | ✅ | ✅| ✅|
| Instrukcja obsługi |  | prosta instrukcja obsługi | instrukcja obsługi obejmuje przypadki brzegowe |



Jeśli w aplikacji wykonujemy logowanie aby miało ono sens dla lokalnego systemu należy wykorzystać mechanizmy dostępne w bazie danych np. [Mysql](https://dev.mysql.com/doc/refman/8.4/en/access-control.html) [1](https://stackoverflow.com/questions/10610013/how-does-authorization-work-in-application-that-runs-on-local-network)