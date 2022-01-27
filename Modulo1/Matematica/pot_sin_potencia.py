#Hacer un programa que simule el cálculo de la potencia de un número.

mult = int(input("ingrese numero: "))
mult2 = int(input("ingrese otro numero: "))

# cont = mult
# for i in range (1):
#     cont += mult
#print(cont)

acumulador = 1   
for i in range (mult2):
    #acumulador = acumulador * mult
    acumulador *= mult
print("El numero es: ", acumulador)