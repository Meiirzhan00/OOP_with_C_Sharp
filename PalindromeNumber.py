class Markov:
    def Tekseru(self) -> bool:
        s=input("Symboldy engiz : ")
        stack=[]
        symbol={"]":"["}
        for i in s:
                if i in symbol.values():
                    stack.append(i)
                elif symbol[i] == stack[-1]:
                    stack.pop()
                else:
                    return False

        return stack == []

p=Markov()
print(p.Tekseru())
