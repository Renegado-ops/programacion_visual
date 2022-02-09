print ("Digite el id del cliente: ")
cliente = input()

print("Buscando registros que coincidan con...: ",cliente)

print("conexion sakila")

#importar la libreria de mysql para poder conectarnos
import mysql.connector

#establecemos la conexion con  mysql
conexion = mysql.connector.connect(
    host = "localhost",
    user = "root",
    passwd = "",
    db = "sakila"
)

#el cursor representa la terminal de mysql
cursor = conexion.cursor()

#ejecutar un query (sentencia sql)
cursor.execute("SELECT first_name, last_name FROM customer WHERE customer_id ='"+cliente+"'" +"AND store_id = 1")

#guardar en una variable todos los resultados del query
resultado = cursor.fetchall()

for registros in resultado:
    print(registros)