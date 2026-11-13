# PPE03_Tipan_Katherine_Calculadora
Calculadora básica con operaciones de suma, resta, multiplicación y división.
# Calculadora

# 1. Nombre del proyecto
Calculadora.
# 2. Descripción general
Calculadora básica con interfaz gráfica que permite realizar operaciones como multiplicación, división, suma y resta. Cuenta con dos cuadros de texto: uno muestra el número que se está escribiendo y el resultado, y otro muestra el historial de la operación completa.

# 3. Objetivos
- Practicar la programación con eventos en C# y Windows Forms.
- Resolver operaciones aritméticas básicas desde una interfaz gráfica sencilla.
- Controlar errores comunes, como la división entre cero, sin que el programa se cierre.

# 4. Características principales
- Suma, resta, multiplicación y división.
- Botones numéricos del 0 al 9.
- Historial de la operación en pantalla.
- Botón **C** para limpiar todo y empezar de nuevo.
- Mensaje **"Error"** al dividir entre cero.
- Validación para no operar con el cuadro de texto vacío.

# 5. Tecnologías utilizadas
- Lenguaje: C#
- Plataforma: .NET
- Interfaz: Windows Forms
- SDK: net10.0

# 6. Requisitos de instalación
- Windows 10 u 11.
- Visual Studio con **Desarrollo de escritorio de .NET**.
- .NET SDK net10.0
- Git

# 7. Instrucciones de ejecución
1. Clonar el repositorio:
   ``bash
   git clone [URL del repositorio]
   ``
2. Abrir la carpeta del proyecto y hacer doble clic en el archivo `Calculadora.sln`.
3. En Visual Studio, esperar a que se restauren los paquetes.
4. Presionar **F5** (o el botón **Iniciar**) para compilar y ejecutar.

# 8. Estructura del proyecto

Calculadora/
Calculadora.sln        # Solución de Visual Studio
Calculadora/
- Form1.cs           # Lógica de la calculadora (eventos y operaciones)
- Form1.Designer.cs  # Diseño de la interfaz (generado por Visual Studio)
- Form1.resx         # Recursos del formulario
- Program.cs         # Punto de entrada de la aplicación


**Componentes principales de `Form1.cs`:**
- OperarInternamente(): resuelve la operación pendiente según el signo guardado.
- Alertas(): detecta la división entre cero y muestra el error.
- Eventos "Click" de cada botón (números, operaciones, igual y C).

# 9. Capturas de pantalla

<img width="375" height="458" alt="image" src="https://github.com/user-attachments/assets/2c0f746f-871d-4c18-b2e4-bd25fa1f1a5c" />
<img width="371" height="454" alt="image" src="https://github.com/user-attachments/assets/65280c62-8bd5-457c-83c1-78da5d30d5fe" />
<img width="374" height="454" alt="image" src="https://github.com/user-attachments/assets/fb238b34-1df3-4d44-826b-9b1deef3e417" />
<img width="374" height="457" alt="image" src="https://github.com/user-attachments/assets/bff3dbc8-b068-4011-a664-2a8bc1807b0e" />
<img width="370" height="458" alt="image" src="https://github.com/user-attachments/assets/60e7db14-dd80-43ac-8350-ef6dbe249925" />
<img width="362" height="461" alt="image" src="https://github.com/user-attachments/assets/54e6a3c2-0bf3-4c60-a3e1-790f3b0a068b" />

# 10. Pruebas realizadas

- Suma simple → 5+3= 8 
- Suma encadenada → 5+3+2= 10
- Resta → 9-4= 5
- Multiplicación → 6*7= 42
- División → 8/2= 4
- División entre cero → 8/0= `Error`
- Botón de operación sin número → No ocurre nada 
- Botón AC → Se limpian ambos cuadros

# 11. Autor

Katherine Eliana Tipán Cadena
