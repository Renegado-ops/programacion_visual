#Pedir al usuario que digite la extensión de un archivo y decir el tipo de archivo. 
#Utilizar al menos 7 extensiones diferentes (Contemplar mayúsculas y minúsculas). 
#Mostrar un mensaje de notificación cuando la extensión digitada no está dentro del listado.


extension = []

#print("Las extenciones son: txt, doc, docx, jpg, gif, png, avi, mp4, mp3, exe, bat, dll, sys, zip, rar, pdf")
print("***Que tipo de archivo quiere saber su nombre***")
tipo = input()
extension.append(tipo)


# var = input("Favor digite la extension: ")
# extensiones = var.lower()
#telegram



txt = "txt"
TXT = "TXT"
pdf = "pdf"
PDF = "PDF"
doc = "doc"
DOC = "DOC"
gif = "gif"
GIF = "GIF"
mp3 = "mp3"
MP3 = "MP3"
exe = "exe"
EXE = "EXE"
rar = "rar"
RAR = "RAR"

if (tipo == txt.casefold()):
    print("Es Archivo de texto ASCII")

if (tipo == pdf):
    print("Es Adobe Acrobat")

if (tipo == PDF):
    print("Es Adobe Acrobat")

if (tipo == doc):
    print("Es Microsoft Word")

if (tipo == DOC):
    print("Es Microsoft Word")

if (tipo == gif):
    print("Es XnView / ACDSee")

if (tipo == GIF):
    print("Es XnView / ACDSee")

if (tipo == mp3):
    print("Es Winamp")

if (tipo == MP3):
    print("Es Winamp")

if (tipo == exe):
    print("Es Aplicación")

if (tipo == EXE):
    print("Es Aplicación")

if (tipo == rar):
    print("Es WinRAR")

if (tipo == RAR):
    print("Es WinRAR")

