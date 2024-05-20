# Das Haus DNN modul

DNN modul a webshop termékeinek összehasonlítására.

## Specifikáció

[Funkcionális terv](https://rf.uni-corvinus.hu/mantis/view.php?id=4309)

[Dizájn terv](https://rf.uni-corvinus.hu/mantis/view.php?id=4257)

## Branching

A `master` branch védett, csak jóváhagyott pull requesttel lehet behúzni rá kódot.

Minden nagyobb feature fejlesztésekor (pl. adatbázis bekötése, UI létrehozása) az alábbi követendő:

1. Feature branch létrehozása értelemszerű néven
2. Feature lefejlesztése, közben rendszeres commitolás
3. Pull request a `master` branchbe
4. Jóváhagyás esetén feature branch törlése
