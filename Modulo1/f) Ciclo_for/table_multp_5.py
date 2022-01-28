#Generar las tablas de multiplicar del 1 al 5.


print("tabla de multplicar del 5")

for n in range (1, 6):
    for i in range (13):
        result = i*n
        
        print(i,"*", n, "=", result, "\n")
       