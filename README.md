# Mi Presentacion

Estudiante: Dilan Tapia Mercado

## Descripcion

Esta aplicacion fue desarrollada con C# y Avalonia UI. Permite ingresar el nombre, apellido y edad de una persona para mostrar una presentacion en pantalla.

## Controles utilizados

- TextBox: permite ingresar el nombre, apellido y edad.
- TextBlock: muestra los textos y resultados.
- Button: permite ejecutar las acciones de la aplicacion.
- StackPanel: organiza los elementos de la interfaz.

## Funcionamiento

La aplicacion cuenta con tres botones:

- Presentarme: muestra una presentacion con los datos ingresados y valida que la informacion sea correcta.
- Limpiar: borra los campos y restablece el mensaje inicial.
- Cambiar saludo: muestra un mensaje alternativo.

## Casos de prueba

1. Ingresar datos correctos.
2. Dejar el nombre vacío.
3. Dejar el apellido vacío.
4. Ingresar letras en el campo edad.
5. Ingresar una edad igual a cero o negativa.
6. Utilizar el boton Limpiar.

## Ejecucion

Para ejecutar el proyecto, abre una terminal en la carpeta principal y escribe:

```bash
dotnet restore
dotnet run
```

## Preguntas

**¿Para que sirve MainWindow.axaml?**

Es el archivo donde se diseña la interfaz grafica de la aplicacion, como los campos de texto, botones y mensajes.

**¿Para que sirve MainWindow.axaml.cs?**

Es el archivo donde se escribe el codigo C# que controla las acciones de los botones y las validaciones.

**¿Como se relacionan los dos archivos?**

Se relacionan mediante los nombres asignados con x:Name y los eventos Click de los botones, que permiten ejecutar el codigo correspondiente.