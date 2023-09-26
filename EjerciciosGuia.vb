Module MainModule
    Sub Main()
        Console.WriteLine("Creado por Ramon Santos")
        Console.WriteLine()
        
        Console.WriteLine("Ejercicio 1:")
        Ejercicio1()
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.WriteLine("Ejercicio 2:")
        Ejercicio2()
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.WriteLine("Ejercicio 3:")
        Ejercicio3()
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.WriteLine("Ejercicio 4:")
        Ejercicio4()
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.ReadLine()
    End Sub

    Sub Ejercicio1()
        Console.WriteLine("Ejercicio 1:")
        Console.WriteLine("Creado por Ramon Santos")
        Console.WriteLine(" se reunen los datos de entrada del usuario, que son las horas y los minutos.
Luego, se llama a la función CalcularYMostrarVelocidadMedia para calcular y mostrar la velocidad media en diferentes unidades (Km/h, Km/min, Km/s, m/min, m/s).")

        ' Primero preguntamos las horas mediante InputBox y al mismo tiempo los minutos como un integer 
        Dim horas As Integer = Integer.Parse(InputBox("Ingrese el tiempo en Horas : "))
        Dim minutos As Integer = Integer.Parse(InputBox("Ingrese el tiempo en minutos: "))

        ' Resultado de la media de los rangos buscados
        CalcularYMostrarVelocidadMedia(horas, minutos)
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.ReadLine()
    End Sub

    Sub CalcularYMostrarVelocidadMedia(ByVal horas As Integer, ByVal minutos As Integer)
        ' Tiempo total reflejado en horas y la distancia en Kilómetros 
        Dim tiempoTotalEnHoras As Double = horas + minutos / 60.0
        Dim distanciaEnKm As Double = 42.195

        ' Calculo de Km/h, Km/min, Km/s, m/min, m/s
        Dim velocidadKmPorHora As Double = distanciaEnKm / tiempoTotalEnHoras
        Dim velocidadKmPorMinuto As Double = distanciaEnKm / (tiempoTotalEnHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaEnKm / (tiempoTotalEnHoras * 3600)
        Dim velocidadMetroPorMinuto As Double = (distanciaEnKm * 1000) / (tiempoTotalEnHoras * 60)
        Dim velocidadMetroPorSegundo As Double = (distanciaEnKm * 1000) / (tiempoTotalEnHoras * 3600)

        ' Resultado Reflejado del cálculo de cada elemento
        Console.WriteLine("Velocidad en Km/h: " & velocidadKmPorHora.ToString("0.00") & " Km/h")
        Console.WriteLine("Velocidad en Km/min: " & velocidadKmPorMinuto.ToString("0.00") & " Km/min")
        Console.WriteLine("Velocidad en Km/s: " & velocidadKmPorSegundo.ToString("0.00") & " Km/s")
        Console.WriteLine("Velocidad en m/min: " & velocidadMetroPorMinuto.ToString("0.00") & " m/min")
        Console.WriteLine("Velocidad en m/s: " & velocidadMetroPorSegundo.ToString("0.00") & " m/s")
    End Sub

    Sub Ejercicio2()
        Console.WriteLine("Ejercicio 2:")
        Console.WriteLine("Creado por Ramon Santos")
        Console.WriteLine(" se le pregunta el promedio mensual de infracciones de tráfico.
Se calcula el promedio diario de infracciones en la mañana, tarde y noche, y se muestran estos valores.")

        ' Se pega al usuario el promedio mensual de infracciones (N)
        Dim promedioMensual As Integer = Integer.Parse(InputBox("Escriba el promedio mensual de infracciones : "))

        ' Cálculos del promedio mensual mañana tarde y noche 
        Dim infraccionesManana As Double = promedioMensual * 0.2
        Dim infraccionesTarde As Double = promedioMensual * 0.35
        Dim infraccionesNoche As Double = promedioMensual * 0.45

        ' Promedios diarios
        Dim promedioDiarioManana As Double = infraccionesManana / 30
        Dim promedioDiarioTarde As Double = infraccionesTarde / 30
        Dim promedioDiarioNoche As Double = infraccionesNoche / 30

        ' Mostrar resultados en consola
        Console.WriteLine("Promedio diario de infracciones en la mañana: " & promedioDiarioManana.ToString("0.00"))
        Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioDiarioTarde.ToString("0.00"))
        Console.WriteLine("Promedio diario de infracciones en la noche: " & promedioDiarioNoche.ToString("0.00"))
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.ReadLine()
    End Sub

    Sub Ejercicio3()
        Console.WriteLine("Ejercicio 3:")
        Console.WriteLine("Creado por Ramon Santos")
        Console.WriteLine("Se ingresan dos números enteros (NI y N2).")
        Console.WriteLine("El programa verifica si NI es divisor de N2 y muestra el resultado.")

        ' Pedir ingresar el primer número entero  
        Dim NI As Integer = Integer.Parse(InputBox("Inserte el primer número entero : "))

        ' Pedir ingresar el segundo número entero  
        Dim N2 As Integer = Integer.Parse(InputBox("Inserte el segundo número entero : "))

        ' Saber si NI es divisor de N2
        If N2 Mod NI = 0 Then
            Console.WriteLine(NI & " es divisor de " & N2)
        Else
            Console.WriteLine(NI & " no es divisor de " & N2)
        End If
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.ReadLine()
    End Sub

    Sub Ejercicio4()
        Console.WriteLine("Ejercicio 4:")
        Console.WriteLine("Creado por Ramon Santos")
        Console.WriteLine("se solicitan tres números enteros  (valor1, valor2 y valor3).
El programa determina cuál es el mayor, el medio y el menor de los tres números, sin importar el orden en que se ingresen.")

        ' Insertar los valores enteros
        Dim valor1 As Integer = Integer.Parse(InputBox("Inserte el primer valor entero: "))
        Dim valor2 As Integer = Integer.Parse(InputBox("Inserte el segundo valor entero: "))
        Dim valor3 As Integer = Integer.Parse(InputBox("Inserte el tercer valor entero: "))

        ' Los mayores, menores y medios
        Dim mayor As Integer
        Dim medio As Integer
         Dim menor As Integer

        ' Hallar el mayor
        If valor1 >= valor2 AndAlso valor1 >= valor3 Then
            mayor = valor1
            medio = Math.Max(valor2, valor3)
            menor = Math.Min(valor2, valor3)
        ElseIf valor2 >= valor1 AndAlso valor2 >= valor3 Then
            mayor = valor2
            medio = Math.Max(valor1, valor3)
            menor = Math.Min(valor1, valor3)
        Else
            mayor = valor3
            medio = Math.Max(valor1, valor2)
            menor = Math.Min(valor1, valor2)
        End If

        ' Entregar los resultados
        Console.WriteLine("Mayor: " & mayor)
        Console.WriteLine("Medio: " & medio)
        Console.WriteLine("Menor: " & menor)
        MostrarDatosDelDesarrollador("Ramon Santos")

        Console.ReadLine()
    End Sub

    Sub MostrarDatosDelDesarrollador(ByVal nombre As String)
        Console.WriteLine(" programa consta de cuatro ejercicios diferentes que realizan tareas específicas, como calcular la velocidad media de un corredor de maratón, calcular promedios de infracciones, verificar si un número es divisor de otro y encontrar el mayor, medio y menor de tres números")
        Console.WriteLine("Datos del Desarrollador:")
        Console.WriteLine("Desarrollado por: " & nombre)
        Console.WriteLine("Fecha de creación: " & DateTime.Now.ToString("dd/MM/yyyy"))
        Console.WriteLine()
    End Sub
End Module