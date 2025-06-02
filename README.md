# Mini gra - kółko i krzyżyk
> Aplikacja przedstawia grę "Kółko i krzyżyk". W programie użytkownik może zmierzyć się z przeciwnikiem sterowanym przez komputer, który losowo wybiera ruchy.

## Spis treści
* [Informacje ogólne](#informacje-ogólne)
* [Technologie użyte w projekcie](#technologie-użyte-w-projekcie)
* [Funkcje](#funkcje)
* [Ustawienia](#ustawienia)
* [Użytkowanie](#użytkowanie)
* [Status projektu](#status-projektu)
* [Obszar do poprawy](#obszar-do-poprawy)
* [Kontakt](#kontakt)


## Informacje ogólne
- Projekt został wykonany w celach edukacyjnych w ramach zaliczenia przedmiotu: Wstęp do programowania.
- Program przedstawia popularną grę - kółko i krzyżyk.


## Technologie użyte w projekcie
- Microsoft Visual Studio
- .NET Framework 4.7.2
- Język C#
- System.Windows.Forms.Timer
- Windows Forms
- GDI+


## Funkcje
- Gra 1 vs 1 – gracz wybiera swój ruch (kamień, papier lub nożyce), a komputer losowo wybiera swój.
- Zegar odliczający czas – gracz ma ograniczony czas na dokonanie wyboru.
- System punktacji – na bieżąco aktualizowany wynik gracza i przeciwnika.
- Grafiki - wyświetlanie odpowiednich grafik w zależności od wyboru gracza.
- Restart gry – możliwość zresetowania wyników i rozpoczęcia nowej rozgrywki.
- Historia rozgrywki – wbudowana lista (ListView), w której zapisywane są wszystkie rozegrane rundy wraz z wynikiem (wygrana, przegrana, remis).


## Ustawienia
Wymagania systemowe:
- System operacyjny: Windows
- .NetFramework: minimum 4.7.2
- Microsoft Visual Studio

Pliki wymagane do działania:
- kamień.jpg, nożyce.jpg, papier.jpg, puste.jpg - grafiki wybranych przedmiotów w quizie

Do folderu Resources należy dodać opisane wyżej grafiki.

## Użytkowanie
Obsługa gry:
1. Wciśnij dowolny przycisk z wybranym przedmotem "Papier", "Kamień" lub "Nożyce".
2. Odczekaj czas upływający na ekranie.
3. Po upłynięciu czasu na ekranie pojawi się komunikat z wynikiem rundy lub z prośbą o wybranie przedmiotu.
4. Powtórz czynność do momentu pojawienia się końcowego wyniku rozgrywek.
5. Po zakończeniu gry możesz wcisnąć przycisk "Restart", aby ponownie rozpocząć grę.

*Nad punktacją możesz odczytać poprzednie ruchy gracza oraz przeciwnika, a także wynik rundy.


## Status projektu
Projekt ukończony i działający.


## Obszar do poprawy
