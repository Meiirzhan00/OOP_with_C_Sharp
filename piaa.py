def reverse():
  while True:
    n=input("Екілік санды енгіз : ")
    s=''
    if '01' not in n :
      for i in n:
        if i=='0':
          s+=i.replace('0','1')
        else:
          s+=i.replace('1','0')
      break
    else:
      print('Қате енгіздіңіз. Қайта енгізіңіз !')

  print(f"Шешімі :\t\t\t {s}")

reverse()

