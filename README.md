# Tetris-v2
# Ce am facut pana acum Patch_0:
Forma Launcher care are butoanele Start(ce porneste jocul in sine-adica clasa Game), Instructions(care va porni o fereastra cu niste 
instructiuni-inca nu l-am implementat) si Exit ce iese din aplicatie.

Am reusit sa creez cele 5 clase ce reprezinta piesele(Patrat,Linie,L,T si Patru) derivate din clasa Piesa.
Clasele au functia pozInit care pune piesa in pozitia initiala si functia mutaJos ce muta piesele cu cate o
pozitie in jos.

In forma Game, tabla de sah am facut-o printr-un tableLayoutPanel, iar peste fiecare patratica din tabel am pus cate un label.
Logica pe care ma bazez, este ca atunci cand initializez o pieza, colorez patratelele corespunzatoare cu rosu, iar cand o mut,
o colorez cu culoarea tabelului(albastru)-ca si cum as sterge-o din pozitia initiala, si o recolorez in pozitia urmatoare
In forma Game mai am niste componente care semnifica scorul si piesa urmatoare(neimplementate inca) si butonul de Play care 
atunci cand se apasa, se genereaza piesa random, si porneste timerul setat la o secunda.


# Updates Patch_1:
Am facut update la interfata grafica a launcher-ului;

Am modificat putin logica jocului, adaugand o matrice initializata cu zerouri; iar atunci cand punem o piesa pe tabla, in 
matrice punem valoarea 1 in pozitia corescpunzatoare, si coloram patratelele corespunzatoare piesei cu rosu;

Am scos codul inutil, pe care nu il foloseam si nu isi avea rostul;

Am mutat membrii x1,y1,x2,y2,x3,y3,x4,y4(coordonatele pieselor) si metodele pozInit, mutaJos, mutaDreata si mutaStanga din fiecare clasa mostenita
in clasa mare piesa; acum in clasele derivate doar dau valori(in constructor) pentru pozitia initiala;

Momentan functiile mutaDreapta si mutaStanga le folosesc prin niste butoane => in viitor trebuie sa le controlez prin tastatura;

