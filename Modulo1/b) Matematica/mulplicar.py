#Hacer el proceso de la multiplicación sin utilizar el signo de multiplicar.

mult = int(input("ingrese numero: "))
mult2 = int(input("ingrese otro numero: "))

# cont = mult
# for i in range (1):
#     cont += mult
#print(cont)

cont = 0   
for i in range (mult2):
    cont = cont + mult
print(cont)