# Tetris-v2
# Ce am facut pana acum Patch_00:
Forma Launcher care are butoanele Start(ce porneste jocul in sine-adica clasa Game), Instructions(care va porni o fereastra cu niste 
instructiuni-inca nu l-am implementat) si Exit ce iese din aplicatie.

Am reusit sa creez cele 5 clase ce reprezinta piesele(Patrat,Linie,L,T si Patru) derivate din clasa Piesa.
Clasele au functia pozInit care pune piesa in pozitia initiala si functia mutaJos ce muta piesele cu cate o
pozitie in jos.

In forma Game, tabla de sah am facut-o printr-un tableLayoutPanel, iar peste fiecare patratica din tabel am pus cate un label.
Logica pe care ma bazez, este ca atunci cand initializez o pieza, colorez patratelele corespunzatoare cu rosu, iar cand o mut,
o colorez cu culoarea tabelului(albastru)-ca si cum as sterge-o din pozitia initiala, si o recolorez in pozitia urmatoare
In forma Game mai am niste componente care semnifica scorul si piesa urmatoare(neimplementate inca) si butonul de Play care 
atunci cand se apasa, se alege o piesa curenta cu functia generare piesa random, si porneste timerul setat la o secunda.
