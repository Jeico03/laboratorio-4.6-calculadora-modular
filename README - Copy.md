# Laboratorio 4.6 — Calculadora Modular en C#

## 📝 Descripción del Proyecto

Este proyecto consiste en una aplicación de consola desarrollada en **C# (.NET 10.0)** que implementa una **Calculadora Modular Interactiva**. La solución permite realizar operaciones matemáticas básicas (suma, resta, multiplicación y división) aplicando principios de modularización, reusabilidad de código mediante métodos independientes con parámetros y valores de retorno, control de ciclos repetitivos y validaciones robustas para la captura de datos.

## 📋 Requisitos del Sistema

Para compilar y ejecutar este proyecto de forma local, asegúrate de contar con los siguientes elementos:

* **SDK de .NET:** Versión 8.0 / 9.0 / 10.0 o superior.
* **IDE / Editor:** Visual Studio 2022, Visual Studio Code o JetBrains Rider.
* **Sistema Operativo:** Windows 10/11, macOS o Linux.

## 🚀 Instrucciones de Ejecución

### Opción 1: Desde Visual Studio

1. Clona el repositorio en tu máquina local:
   ```bash
   git clone https://github.com/tu-usuario/laboratorio-4.6-calculadora-modular.git
   ```
2. Abre el archivo de solución `Laboratorio4_6_CalculadoraModular.sln` en **Visual Studio**.
3. Presiona la tecla **F5** o haz clic en el botón **Iniciar** (Play) para compilar y ejecutar la aplicación.

### Opción 2: Desde la Terminal (.NET CLI)

1. Abre tu consola o terminal e ingresa a la carpeta del proyecto:
   ```bash
   cd laboratorio-4.6-calculadora-modular/Laboratorio4_6_CalculadoraModular
   ```
2. Compila el proyecto:
   ```bash
   dotnet build
   ```
3. Ejecuta la aplicación:
   ```bash
   dotnet run
   ```

## 🔍 Matriz de Trazabilidad entre Requerimientos y Casos de Prueba

La siguiente matriz documenta la relación de trazabilidad directa entre los **Requerimientos Funcionales (RF)**, las **Reglas de Negocio (RN)** y los **Casos de Prueba (CP)** implementados y verificados en esta solución.

| Requerimientos Funcionales | Reglas de Negocio Asociadas | Casos de Prueba (CP) | Descripción del Escenario de Prueba | 
| ----- | ----- | ----- | ----- | 
| **RF-01, RF-02, RF-12, RF-13** | RN-01, RN-06, RN-07 | **CP-07, CP-10, CP-11** | Manejo del menú interactivo, validación de opciones fuera de rango (ej. opción 9), ejecución consecutiva de menú y salida limpia del programa mediante la opción 5. | 
| **RF-03, RF-08** | RN-02, RN-07 | **CP-06, CP-09** | Captura e ingreso de datos decimales. Validación de entrada no numérica mediante `decimal.TryParse()` (evita excepciones al ingresar texto tipo "ABC"). | 
| **RF-04, RF-05, RF-06** | RN-04, RN-05 | **CP-01, CP-02, CP-03, CP-08, CP-09** | Verificación de los métodos de cálculo `Sumar`, `Restar` y `Multiplicar` utilizando operandos positivos, negativos y números decimales. | 
| **RF-07, RF-09** | RN-03, RN-04, RN-05 | **CP-04, CP-05** | Ejecución de la división estándar (`10 / 5 = 2`) y prevención de la división por cero mediante mensaje de alerta (`10 / 0`). | 
| **RF-10, RF-11, RF-14** | RN-04, RN-05, RN-06 | **CP-01 a CP-04, CP-10** | Presentación adecuada de los resultados, estructura modular en métodos estáticos independientes y ciclo continuo `while` que permite realizar múltiples operaciones. | 

## 👤 Información del Proyecto

* **Estudiante:** Jeico Arias Brito
* **Profesores:**
  * Francis Ricardo Ramirez De Leon
  * Manuel Titín
* **Curso:** Fundamentos de Programación con C#