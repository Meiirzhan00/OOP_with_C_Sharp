from collections import defaultdict 
 
class Graph:
 
    # Конструктор
    def __init__(self):
 
        # графикті сақтауға арналған әдепкі сөздік
        self.graph = defaultdict(list)
 
    # графикке ребра қосу функциясы
    def rebraKosu(self, u, v):
        self.graph[u].append(v)
        print(f"{u} {v}")
 
    # DFS қолданатын Функция
    def DFSKol(self, v, aralau):

        aralau.add(v)
        print(v, end=' ')
        if len(aralau)==2:
            print(end='\n')
 
        for korshi in self.graph[v]:
            if korshi not in aralau:
                self.DFSKol(korshi, aralau)
 
    # DFS айналып өту функциясы. Ол рекурсивті DFSKol() қолданады.
    def DFS(self, v):
 
        # Кірген шыңдарды сақтау жинағы. set() дата типімен бердім.
        aralau = set()
 
        # DFS айналма жолын басып шығару үшін рекурсивті көмекші функцияны шақырамын.
        self.DFSKol(v, aralau)
 
# Driver code
 
 
# Төменде біз граф құрамыз.
print("Men kurgan graph !")
g = Graph()
g.rebraKosu(4, 4)
g.rebraKosu(1, 2)
g.rebraKosu(2, 3)
g.rebraKosu(3, 4)
g.rebraKosu(4, 1)

 
print("Graph 1 shynynan bastaldy.")
g.DFS(1)
