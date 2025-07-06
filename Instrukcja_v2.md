# Space Invaders część 2 - Lista zadań do wykonania

## Cel
Kontynuacja pracy nad grą Space Invaders - dodanie obcych statków kosmicznych, ich ruchu, kolizji z graczem i pociskami, punktacji oraz warunków zwycięstwa/przegranej.

---

## Zadanie 1: Stworzenie klasy Enemy

**Czynności do wykonania:**
1. Utwórz nowy plik `Enemy.cs` w katalogu `GameObjects`
2. Stwórz klasę `Enemy` dziedziczącą po `GameObject`
3. Dodaj prywatne pole `direction` (typu float) do kontroli kierunku ruchu
4. Zaimplementuj konstruktor przyjmujący pozycję statku
5. Nadpisz metodę `Update()` - ruch poziomy na podstawie kierunku
6. Dodaj metodę `SwitchDirection()` - zmiana kierunku i ruch w dół

**Efekt:** Klasa reprezentująca obcy statek z możliwością ruchu poziomego i zmiany kierunku

---

## Zadanie 2: Rozszerzenie GameManager

**Czynności do wykonania:**

### 2.1 Dodanie nowych pól
1. Dodaj pole `List<Enemy> enemies` dla listy obcych statków
2. Dodaj pole `int score` dla punktacji gracza
3. Dodaj pole `float elapsedTime` dla mierzenia czasu gry

### 2.2 Modyfikacja metody Initialize
1. Zainicjalizuj pustą listę `enemies`
2. Ustaw `score` na 0
3. Ustaw `elapsedTime` na 0
4. Stwórz zagnieżdżone pętle do generowania siatki obcych statków
5. Dla każdego wiersza i kolumny utwórz nowy obiekt `Enemy`
6. Dodaj każdy obiekt do listy `enemies`

### 2.3 Aktualizacja metody Update
1. Dodaj aktualizację wszystkich obcych statków (pętla foreach)
2. Sprawdź kolizje z krawędziami ekranu dla każdego statku
3. Ustaw flagę `changeDirection` gdy statek dotknie krawędzi
4. Sprawdź czy któryś statek dotarł do dolnej krawędzi (gameState = Lost)
5. Jeśli trzeba zmienić kierunek - wykonaj dla wszystkich statków
6. Dodaj zliczanie czasu gry (`elapsedTime += Raylib.GetFrameTime()`)
7. Sprawdź warunek wygranej (lista enemies pusta)
8. Dodaj wywołanie `CollisionManager.HandleCollisions`

### 2.4 Aktualizacja metody Draw
1. Dodaj rysowanie wszystkich obcych statków (pętla foreach)
2. Dodaj warunek else z wywołaniem `DrawScore()` dla stanów końcowych

**Efekt:** GameManager zarządza flotą obcych statków i ich ruchem

---

## Zadanie 3: Implementacja CollisionManager

**Czynności do wykonania:**
1. Utwórz nowy plik `CollisionManager.cs` w katalogu `Managers`
2. Stwórz statyczną klasę `CollisionManager`
3. Dodaj statyczną metodę `HandleCollisions` z parametrami: Player, List<Enemy>, List<Bullet>
4. Zaimplementuj sprawdzanie kolizji pocisk-obcy statek (zagnieżdżone pętle)
5. Gdy kolizja - ustaw `IsActive = false` dla pocisku i obcego statku
6. Gdy kolizja - wywołaj `GameManager.AddScore()`
7. Usuń nieaktywne obiekty z list (`RemoveAll`)
8. Sprawdź kolizje obcy statek-gracz
9. Gdy kolizja z graczem - ustaw stan gry na przegrana
10. Sprawdź czy obce statki dotarły do dolnej krawędzi

**Efekt:** System obsługi wszystkich kolizji w grze

---

## Zadanie 4: Dodanie metod pomocniczych do GameManager

**Czynności do wykonania:**
1. Dodaj publiczny getter dla właściwości `GameState`
2. Stwórz metodę `SetGameState(GameState state)` - ustawienie stanu gry
3. Stwórz metodę `AddScore()` - obliczanie i dodawanie punktów na podstawie czasu
4. Stwórz metodę `RestartGame()` - wywołanie Initialize i ustawienie stanu Playing

**Efekt:** Dodatkowe metody do zarządzania stanem gry i punktacją

---

## Zadanie 5: Rozszerzenie InputManager o restart

**Czynności do wykonania:**
1. Otwórz klasę `InputManager`
2. W metodzie `HandleInput` dodaj sprawdzanie klawisza Enter
3. Dodaj warunek: klawisz Enter + (stan Lost OR stan Won)
4. Jeśli warunek spełniony - wywołaj `GameManager.RestartGame()`

**Efekt:** Możliwość restartu gry po zakończeniu rozgrywki

---

## Zadanie 6: Implementacja wyświetlania wyników

**Czynności do wykonania:**
1. W klasie `GameManager` dodaj prywatną metodę `DrawScore()`
2. Określ tekst wiadomości na podstawie stanu gry (Won/Lost)
3. Ustaw odpowiedni kolor wiadomości (zielony/czerwony)
4. Przygotuj teksty: komunikat główny, instrukcja restartu, wynik końcowy
5. Oblicz szerokość każdego tekstu (`Raylib.MeasureText`)
6. Oblicz pozycje X dla wyśrodkowania tekstów
7. Narysuj wszystkie teksty w odpowiednich pozycjach i kolorach

**Efekt:** Ekran końcowy z wynikiem i możliwością restartu

---

## Zadanie 7: Definicja stałych

**Czynności do wykonania:**
1. Otwórz klasę `Constants`
2. Dodaj stałą `ENEMY_SIZE` (rozmiar obcego statku)
3. Dodaj stałą `ENEMY_SPEED` (prędkość ruchu poziomego)
4. Dodaj stałą `ENEMY_DROP_DISTANCE` (odległość ruchu w dół)
5. Dodaj stałą `ENEMY_ROWS` (liczba wierszy obcych statków)
6. Dodaj stałą `ENEMY_COLUMNS` (liczba kolumn obcych statków)

**Efekt:** Wszystkie potrzebne stałe do konfiguracji gry

---

## Lista kontrolna - testowanie

Po ukończeniu wszystkich zadań sprawdź czy:

✅ **Flota obcych statków** - widać siatkę statków poruszającą się poziomo  
✅ **Zmiana kierunku** - statki zmieniają kierunek przy krawędziach ekranu  
✅ **Strzelanie** - pociski niszczą obce statki  
✅ **Warunki przegranej** - gra kończy się gdy:
   - Obcy statek dotknie gracza
   - Obce statki dotrą do dołu ekranu  
✅ **Warunek wygranej** - gra kończy się po zniszczeniu wszystkich statków  
✅ **Restart** - klawisz Enter restartuje grę po zakończeniu  
✅ **Ekran wyników** - wyświetla się komunikat końcowy z punktacją  

---

## Opcjonalne zadania rozszerzające

Po ukończeniu podstawowej implementacji możesz dodać:

🔊 **Dźwięki** - efekty audio dla akcji w grze  
📊 **System logów** - wyświetlanie informacji o stanie gry  
🏆 **Najwyższy wynik** - zapisywanie i wyświetlanie rekordów  
💪 **Poziomy życia obcych** - statki z różnymi kolorami po trafieniach  
🚀 **Kolejne poziomy** - nowe rundy po wygranej  

---

## Uwagi końcowe

- Testuj grę po każdym ukończonym zadaniu
- Sprawdzaj czy projekt się kompiluje po każdej zmianie  
- W razie problemów skonsultuj się z dokumentacją Raylib
- Używaj najnowszych wersji bibliotek