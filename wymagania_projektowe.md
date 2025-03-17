

|Opis | 3.0 | 4.0 | 5.0|
|-----|-----|-----|----|
|Liczba tabel | >= 2 | >= 3 | >= 4|
|Połaczenie z relacyjną bazą danych | Połączenie na stałe w kodzie/pliku | Konfiguracja połączenia w pliku konfiguracyjnym, ale bez możliwości zmiany połączenia w czasie działania aplikacji | Konfiguracja połączenia w pliku (np. appsettings.json) z możliwością zmiany w czasie działania aplikacji|
| Modele | Modele istnieją. (zastosowano podstawowe atrybuty - klucz głowny, relacja 1:N itp.) | Wykorzystano atrybuty walidacji, relacje, klucze głowne i obce są odpowiednio zdefiniowane | Kompleksowe relacje między tabelami: Relacje 1:1, 1:N, N:M z odpowiednimi konfiguracjami przy pomocy Fluent API lub atrybutów. Rozwiązano problem N+1. Zoptymalizowano zapytania.  |
