# Tetris-v2
# Ce am facut pana acum Patch_1:

Am facut update la interfata grafica a launcher-ului;

Am modificat putin logica jocului, adaugand o matrice initializata cu zerouri; iar atunci cand punem o piesa pe tabla, in 
matrice punem valoarea 1 in pozitia corescpunzatoare, si coloram patratelele corespunzatoare piesei cu rosu;

Am scos codul inutil, pe care nu il foloseam si nu isi avea rostul;

Am mutat membrii x1,y1,x2,y2,x3,y3,x4,y4(coordonatele pieselor) si metodele pozInit, mutaJos, mutaDreata si mutaStanga din fiecare clasa mostenita
in clasa mare piesa; acum in clasele derivate doar dau valori(in constructor) pentru pozitia initiala;

Momentan functiile mutaDreapta si mutaStanga le folosesc prin niste butoane => in viitor trebuie sa le controlez prin tastatura;

