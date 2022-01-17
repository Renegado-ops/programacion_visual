print("programa que me haga una factura")

#Que introduzca una cantidad, articulo, precio. y que me diga el total y me de la devuelta

cantidad = int (input("Ingrese la cantidad "))
articulo = input("Ingrese el articulo a pagar ")
precio =  float (input ("Ingrese el precio del articulo "))

total = (cantidad * precio)
print (total)

pago = int(input("Digite el pago "))

itbis = (total * 18/100)

devuelta = pago - total


print(itbis)
print (devuelta)

