Algoritmo mes
	Definir p, i, a1, b, c2, d, e Como real
	Definir c1, a2 como entero
	
	p = 650
	i = 0.12
	
	Escribir "Ingrese la cantidad de impresoras que desea comprar"
	leer c
	
	a1 = p+(p*i)
	
	Escribir "1 - efectivo = 10%"
	Escribir "2 - tarjeta = 5%"
	Escribir "3 - Vale de regalo = 15%"
	Escribir "Elija el numero segun su forma de pago"
	leer a2
	
	Segun a Hacer
		1:  c2 = 0.10
		2:  c2 = 0.05
		3:  c2 = 0.15
	FinSegun
	
	b = a1 * c
	d = b * c2
	e = b - d
	
	Escribir "Su cantidad es: ",c
	Escribir "Su precio con iva es: Q",a1
	Escribir "Su total sin descuento es: ",b
	Escribir "Su descuento es: Q",d
	Escribir "Su total a pagar es: ",e
FinAlgoritmo
