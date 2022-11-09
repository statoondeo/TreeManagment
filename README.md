<img class="main_image" src="https://questionsacm.isograd.com/codecontest/fr/6y3a6uJyWaMY7etA5e3u9.png" alt="Test">
# Optimisation de la distribution hydraulique
<br />
Le réseau d'eau de votre ville nécessite des réparations, mais étant donné les ressources limitées à votre disposition, il est important d'identifier la partie du réseau qui fuit le plus afin de la traiter le plus rapidement.<br />
<br />
Le réseau d'eau est représenté par un arbre binaire de canalisation. (https://fr.wikipedia.org/wiki/Arbre_enraciné)<br />
<br />
La racine de l'arbre est le point de distribution de l'eau (la source), les autres sommets de l'arbre sont tous les points qui nécessitent d'être fournis en eau.<br />
<br />
Si une quantité d'eau doit être acheminée jusqu'à un point du réseau, elle passera obligatoirement par toutes les canalisations de l'unique chemin entre la source et ce point.<br />
<br />
Chaque canalisation reliant 2 sommets dispose d'un coefficient de pertes hydraulique. La perte totale d'une canalisation est égale à la quantité totale d'eau passant par cette canalisation multipliée par le coefficient de perte de cette canalisation.<br />
<br />
## Données<br />
<br />
### Entrée<br />
<br />
**Ligne 1** : un entier N représentant le nombre de points nécessitant d'être fournis en eau. Le point 0 est la source, les autres points sont numérotés de 1 à N (inclus). <br />
<br />
N est compris entre 2 et 200.<br />
<br />
**Ligne 2 à N+2** : Deux possibilités<br />
<br />
- Soit 6 entiers n, q, f1, p1, f2, p2 représentant le numéro du point, la quantité d'eau à acheminer à ce point, la canalisation reliant le point n au point f1 avec une coefficient de perte de p1 et la canalisation reliant n à f2 avec une coefficient de perte de p2.<br />
- Soit deux entiers n et q représentant le numéro du point suivi de la quantité d'eau à acheminer à ce point.<br />
<br />
Note : toutes les lignes avec 6 entiers (qui représentent des sommets internes de l'arbre binaire) sont toujours présentes avant les lignes de 2 entiers (qui représentent des feuilles de l'arbre). Comme il s'agit d'un arbre binaire strict, on peut alors noter que N est toujours paire, et qu'on a toujours N/2 lignes avec 6 entiers et N/2+1 lignes avec 2 entiers.<br />
<br />
Les quantités d'eau et les coefficient de pertes sont compris en 1 et 10.000.<br />
<br />
### Sortie<br />
<br />
Un entier représentant la perte maximale d'une canalisation sur le réseau.<br />
<br />
## Exemple<br />
<br />
Cette entrée représente l'image plus bas.<br />
<br />
Pour l'entrée :<br />
```plaintext<br />
4<br />
0 0 1 1 2 3<br />
1 5 3 2 4 1<br />
2 6 <br />
3 10<br />
4 12<br />
```<br />
<br />
La sortie est :<br />
```plaintext<br />
27<br />
```<br />
<br />
En effet, la canalisation 1 à 3 doit faire passer une quantité d'eau de 10 avec un coefficient de perte de 2. Donc une perte totale de (10)x2 = 20.<br />
<br />
La canalisation 1 à 3 : (10)x2 = 20<br />
La canalisation 1 à 4 : (12)x1 = 12<br />
La canalisation 0 à 2 : (6)x3 = 18<br />
La canalisation 0 à 1 : (5+10+12)x1 = 27<br />
<br />
En effet, la canalisation de 0 à 1 sert à acheminer depuis la source les quantités d'eau pour les sommets 1, 3 et 4.<br />
<br />
<img class="main_image" src="https://questions.s3.eu-west-1.amazonaws.com/codecontest/assets/CTSTSFR0314-example.jpg" alt="Test">

