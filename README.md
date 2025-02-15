Markdown: Es un formato de texto ligero utilizado para documentación.
Se usa en archivos README.md dentro de proyectos para explicar su contenido.
Permite agregar títulos, listas, código y enlaces con una sintaxis sencilla.

Markdown es un formato de texto ligero utilizado para documentación.
Se usa en archivos README.md dentro de proyectos para explicar su contenido.
Permite agregar títulos, listas, código y enlaces con una sintaxis sencilla.



# Laboratorio2 - Programación en C#

## Preguntas del Laboratorio

### 1. ¿Para qué crees que se usan los operadores lógicos en programación?
Los operadores lógicos (`&&`, `||`, `!`) permiten combinar condiciones en estructuras como `if-else` y `while`, facilitando la toma de decisiones en un programa.

### 2. ¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Declarar correctamente los tipos de datos ayuda a evitar errores, mejora el rendimiento y permite que el compilador optimice el uso de memoria.

---

## Explicación de la implementación
Enunciado 1: Clasificación de edad
Un programa debe determinar la categoría de una persona según su edad:
* Menos de 12 años: Niño
* Entre 12 y 17 años: Adolescente
* Entre 18 y 59 años: Adulto
* 60 años o más: Adulto mayor

¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
### 🔹 Clasificación de edad
- Usarías `if-else` porque permite evaluar rangos de valores con condiciones lógicas claras y flexibles.

Enunciado 2: Día de la semana
Se quiere crear un programa que reciba un número del 1 al 7 y devuelva el nombre del día correspondiente.
* 1 = Lunes
* 2 = Martes
* 3 = Miércoles
* 4 = Jueves
* 5 = Viernes
* 6 = Sábado
* 7 = Domingo

¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
### 🔹 Día de la semana
- usaría`switch` porque permite comparar un solo valor con múltiples opciones de forma más ordenada y eficiente.

Enunciado 3: Verificación de acceso
Un usuario intenta iniciar sesión en una aplicación. Debes verificar:
* Si el usuario ingresó el nombre y contraseña correctos, mostrar "Acceso concedido".
* Si solo ingresó el nombre correcto pero la contraseña es incorrecta, mostrar "Contraseña incorrecta".
Si el nombre de usuario no existe, mostrar "Usuario no registrado".
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
### 🔹 Verificación de acceso
- Usarías `if-else` porque involucra múltiples condiciones dependientes y requiere validaciones más detalladas.
---

## 📌 Instrucciones para ejecutar los programas

1. Asegúrate de tener **Visual Studio Code** y el SDK de .NET instalado.
2. Abre la carpeta del proyecto en VS Code.
3. Ejecuta el código en la terminal usando:
   ```sh
   dotnet run
