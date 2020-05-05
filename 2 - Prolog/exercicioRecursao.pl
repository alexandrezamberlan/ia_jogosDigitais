%exercicioRecursao.pl

arco(a,b,10).
arco(b,c,50).
arco(b,e,100).
arco(c,d,5).
arco(d,e,25).
arco(a,e,450).

caminho(O,D,CustoFinal) :- arco(O,D,CustoFinal). %parada da recursão
caminho(O,D,CustoFinal) :- arco(O,I,Custo1),
                           caminho(I,D,Custo2),
                           CustoFinal is Custo1 + Custo2.

%a -> b -> c -> d -> e = 90
%a -> e = 450
%a -> b -> e = 110


pai(giovani,zeno).
pai(zeno,jurandir).
pai(jurandir,alex).
pai(alex,dante).
ascendente(A,D) :- pai(A,D). %parada da recursão
ascendente(A,D) :- pai(A,I),
                   ascendente(I,D).

%giovani -> zeno -> jurandir -> alex -> dante

escreverD(N) :- N == 0, !. %ponto de parada da recursão
escreverD(N) :- writeln(N),
                R is N - 1,
                escreverD(R). %ponto de recursão no empilhamento

escreverC(N) :- N == 0, !.
escreverC(N) :- R is N - 1,
                escreverC(R),%ponto de recursão no desempilhamento
                writeln(N).  


factorial(N,F) :-  N == 0, 
                   F is 1,!.                
factorial(N,F) :-   N1 is N - 1,
                    factorial(N1,F1), %ponto de recursão
                    F is N * F1.          


eh_um(frajola,gato).
eh_um(pipiu,passaro).
eh_um(goldie,peixe).
eh_um(squiggly,minhoca).
gosta(passaro,minhoca).
gosta(gato,peixe).
gosta(gato,passaro).

eh_dona(joana,frajola).

amigo(X,Y) :- gosta(X,Y),
              gosta(Y,X).
amigo(frajola,joana).

come(gato,X) :- gosta(gato,X).

frajolaCome(Comida) :- eh_um(frajola,Bicho),
                       gosta(Bicho,Comida). 
frajolaCome(Comida) :- eh_um(frajola,Bicho),
                       gosta(Bicho,OutroBicho),
                       eh_um(Comida,OutroBicho).                     

homem(joao).
homem(paulo).
homem(antonio).
homem(fernando).
mulher(maria).
mulher(claudia).
gosta(joao,maria).
gosta(paulo,antonio).
gosta(antonio,claudia).
gosta(fernando,claudia).
gosta(claudia,X) :- gosta(X,claudia).
gosta(ninguem,paulo).

namorados(A,B) :- homem(A),
                  mulher(B),
                  gosta(A,B),
                  gosta(B,A).

namorados(A,B) :- homem(B),
                  mulher(A),
                  gosta(A,B),
                  gosta(B,A).
