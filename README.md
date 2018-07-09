# Teste de Lógica Benner

Para criação do algoritmo foi baseada na Teoria de Conjuntos, onde um unvierso pode possuir "N" conjuntos e os conjuntos podem possuir "N" elementos. A interação entre os conjuntos é feita de modo que os elementos que os memos possuem em comum sejam o ponto de conexão.

A implementação seguiu a principio os pré requisitos do enunciado: É solicitado ao usuário que informe o número de elementos e o mesmo será utilizado como construtor no Objeto Universo(Total de conjuntos) e no objeto Conjunto.
Assim tambem foi implementado dois metodos publicos conectar (connect) e consultar (query).
Para indentificação de cada conjunto dentro de um universo foi escolhida uma collection (IDictionary) que indexa pela chave definida na criação de cada conjunto tornando muito facil e rapido para localizar os itens. Outro fato que me levou a usar esta collection é visando que se futuramente o algoritmo tivesse que buscar apenas ligações diretas seria muito simples implementar a partir do algoritmo já construido.
