print ("Digite la categoria: ")
categoria = input()

print("Buscando registros que coincidan con...: ",categoria)

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
cursor.execute("SELECT * FROM category where category_id ='"+categoria+"'")

#guardar en una variable todos los resultados del query
resultado = cursor.fetchall()

for registros in resultado:
    print(registros)