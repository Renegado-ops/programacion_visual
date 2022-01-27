#El usuario debe digitar su nombre, edad, y dos números. Luego podrá seleccionar una opción de un listado con las 4 
#operaciones básicas (Suma, Resta, División y Multiplicación) marcando su número correspondiente (1 - 4).

#debo comentar todo el codigo
print("Mi nombre es eriksson")


nombre = input("Dijite su nombre: ")
edad = int(input("Dijite su edad: "))

num = int(input("Ingrese 1 numero: "))
num2 = int(input("Ingrese otro numero: "))

result = 0

print ("1) suma, 2) resta, 3) división, 4) multiplicación")
var = int(input())

if var == 1:
    result = num+num2
    print("La suma es: ",result)

if var == 2:
    result = num-num2
    print("La resta es: ",result)

if var == 3:
    result = num/num2
    print("La división es: ",result)

if var == 4:
    result = num*num2
    print("La multiplicación es: ",result)
