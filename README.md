# longSlice
## Descrizione esercizio
#### Esercizio C# in console che, data una stringa composta solo da cifre, calcoli il prodotto maggiore ottenibile per una sua sottostringa contina di cifre di lunghezza N; in caso la lunghezza della sottostringa sia 0 ritornare 1.

## lista dei passagi svolti per svolgere il compito

#### dichiaro le variabili che userò
```
int maggiore,maggioreTot = 1;
int lenght = digits.Length;
int temp;
```

#### sistemo i casi speciali
```
for (int i = 0; i < lenght; i++){
            if (!(char.IsNumber(digits[i]))){
                throw new System.ArgumentException();
            }
        }

        if (span < 0){
            throw new System.ArgumentException();
        }


        if (span > lenght){
            throw new System.ArgumentException();
        }
        
        if( span==0 ){
            return 1;
        }
```
#### trasformo la stringa in entrata in un array di char

```
char[] numeri = digits.ToCharArray();
```

#### ciclo per soddisfare la richiesta del programma

```
for (int i = 0; i <= lenght-span; i++)
        {
            maggiore = 1;
            temp = i;
        
            for (int j = 0; j < span; j++){
                maggiore = maggiore * (digits[temp]-48);
                temp = temp + 1;
            }


            if (maggiore > maggioreTot){
                maggioreTot = maggiore;
            }
            if (maggioreTot == 1){
                maggioreTot = 0;
            }
            
        }
```

#### return per terminare il programma
```
return maggioreTot;
```


