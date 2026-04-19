Algoritmo mes
	Definir a, b, c, ta, co, se, z Como real
	Escribir "Ingrese el lado A"
	leer a
	Escribir "Ingrese el lado B"
	leer B
	Escribir "Ingrese el lado C"
	leer C
	
	Escribir "1-tangente"
	Escribir "2-coseno"
	Escribir "3-seno"
	
	ta = a/b
	co = b/c
	se = a/c
	
	Escribir "Escriba el numero de la operacion que desea realizar"
	leer z
	
	Segun z Hacer
		1: Escribir ta
		2: Escribir co
		3: Escribir se
	FinSegun
FinAlgoritmo
