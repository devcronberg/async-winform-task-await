# Demo af sync/async kode i en WinForm

Find en zip med en [kompileret version her](https://github.com/devcronberg/async-winform-task-await/files/3693725/async-winform-task-await.zip), eller hent projektet og kompiler gennem Visual Studio.

![](https://raw.githubusercontent.com/devcronberg/async-winform-task-await/master/async.png)

Denne demo viser forskellen på synkrone og asynkrone kald når der skal hentes data fra nettet. Hvert kald tager omkring 3 sekunder.

Bemærk:

- Klik på "Sync"-knappen låser brugerfladen i 3 sekunder, og der er ingen mulighed for at afbryde
- Klik på "Med await"-knappen henter data asynkront med mulighed for at afbryde. Bemærk, at
  - UI ikke låser
  - at koden ved brug af await er meget simpel

Eksemplet må bruges frit men smid gerne en reference til repository.

/Michell
