Algoritmo CalculadoraModular
    Definir num1, num2 Como Real
    Definir opcion Como Entero
    
    Repetir
        Escribir "Calculadora Modular"
        
        Escribir "Ingrese el primer numero:"
        num1 <- LeerNumero()
        
        Escribir "Ingrese el segundo numero:"
        num2 <- LeerNumero()
        
        MostrarMenu()
        Leer opcion
        
        Segun opcion Hacer
            1:
                Escribir "El resultado de la suma es: ", Sumar(num1, num2)
            2:
                Escribir "El resultado de la resta es: ", Restar(num1, num2)
            3:
                Escribir "El resultado de la multiplicacion es: ", Multiplicar(num1, num2)
            4:
                Si num2 <> 0 Entonces
                    Escribir "El resultado de la division es: ", Dividir(num1, num2)
                SiNo
                    Escribir ""
                    Escribir "Error: No se puede dividir entre cero. Intente con otro valor."
                    Escribir ""
                FinSi
            5:
                Escribir "Saliendo del programa..."
            De Otro Modo:
                Escribir "Opcion invalida. Intente nuevamente."
        FinSegun
        Escribir ""
    Hasta Que opcion = 5
FinAlgoritmo

SubProceso MostrarMenu()
    Escribir "Seleccione la operacion a realizar:"
    Escribir "1. Sumar"
    Escribir "2. Restar"
    Escribir "3. Multiplicar"
    Escribir "4. Dividir"
    Escribir "5. Salir"
FinSubProceso

Funcion res <- LeerNumero()
    Definir res Como Real
    Leer res
FinFuncion

Funcion res <- Sumar(x, y)
    Definir res Como Real
    res <- x + y
FinFuncion

Funcion res <- Restar(x, y)
    Definir res Como Real
    res <- x - y 
FinFuncion

Funcion res <- Multiplicar(x, y)
    Definir res Como Real
    res <- x * y
FinFuncion

Funcion res <- Dividir(x, y)
    Definir res Como Real
    res <- x / y
FinFuncion