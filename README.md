# Demo af sync/async kode i en WinForm

![](https://raw.githubusercontent.com/devcronberg/async-winform-task-await/master/async-winform-task-awai.png)

Denne demo viser forskellen på synkrone og asynkrone kald når der skal hentes data fra nettet. Hvert kald tager omkring 3 sekunder.

Bemærk:

- Klik på "Sync"-knappen låser brugerfladen i 3 sekunder, og der er ingen mulighed for at afbryde
- Klik på "Med Task"-knappen henter data asynkront med mulighed for at afbryde. Bemærk, at UI ikke låser
- Klik på "Med await"-knappen henter data asynkront med mulighed for at afbryde. Bemærk, at UI ikke låser
- At koden ved brug af await er meget simplere end ved brug af Task alene
- Prøv også de forskellige knapper ved kryds i "Dan fejl". Så vil der blot smides en Exception

Eksemplet må bruges frit men smid gerne en reference til repository.

/Michell

