# Snake Game

## Opis

Prosty projekt konsolowej gry węża (Snake) napisany w języku C#. Gra polega na sterowaniu wężem i zbieraniu punktów (owoców), unikając kolizji z granicami ekranu oraz własnym ciałem.

## Zasady współpracy

- Projekt zawiera klasy reprezentujące elementy gry: `SnakeHead` (głowa węża), `Fruit` (owoc) oraz `SnakeSegment` (segment węża).
- Główna logika gry jest zaimplementowana w klasie `SnakeGame`.
- Funkcja `Run()` odpowiada za uruchomienie gry i jej główną pętlę.
- Sterowanie odbywa się za pomocą strzałek klawiatury.
- Punkty są zdobywane poprzez zjedzenie owocu, co skutkuje zwiększeniem wyniku.
- Gra kończy się, gdy wąż uderzy w granice ekranu.

## Instrukcja uruchamiania

1. Pobranie repozytorium:
    ```
    git clone https://github.com/zml18x/snake
    ```

2. Przejście do folderu projektu Snake:
    ```
    cd snake/Snake
    ```

3. Uruchomienie gry:
    ```
    dotnet run
    ```

## Klasy

### `SnakeHead`
- Reprezentuje głowę węża.
- Zawiera informacje o pozycji (X, Y), kolorze i wyglądzie.

### `Fruit`
- Reprezentuje owoc, który wąż może zjeść.
- Zawiera informacje o pozycji (X, Y), kolorze i wyglądzie.

### `SnakeSegment`
- Reprezentuje segment węża.
- Zawiera informacje o pozycji (X, Y).

### `SnakeGame`
- Główna klasa logiki gry.
- Zarządza całym przebiegiem rozgrywki, rysowaniem planszy, sterowaniem wężem oraz sprawdzaniem kolizji.
