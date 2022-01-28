#Generar las tablas de multiplicar de los números pares del 1 al 8. 


print("tabla de multplicar pares del 1 al 8")

for n in range (1, 8):
    if n %2 ==0: 
        for i in range (13):
           if i %2 ==0:  
            result = i*n
        
            print(i,"*", n, "=", result, "\n")