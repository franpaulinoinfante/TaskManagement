# Task Management
Práctica Final: Estructuras de Datos en el Lenguaje de Programación de Tu Preferencia

## Objetivo:
Desarrollar una aplicación que implemente y utilice diferentes estructuras de datos (listas, pilas, colas y árboles) para resolver un problema específico. Los estudiantes podrán elegir el lenguaje de programación con el que se sientan más cómodos.

## Descripción del Problema:
Desarrolla una aplicación de gestión de tareas para una empresa. La aplicación debe permitir a los usuarios realizar las siguientes acciones:
1. Listas: Mantener una lista de tareas pendientes, donde cada tarea tiene un título, descripción, prioridad y fecha de vencimiento.
2. Pilas: Implementar un historial de acciones realizadas (deshacer/rehacer) en las tareas.
3. Colas: Gestionar una cola de tareas que requieren atención urgente. Estas tareas deben ser procesadas en el orden en que llegan.
4. Árboles: Organizar las tareas en un árbol según su categoría (por ejemplo, trabajo, personal, estudios) y subcategorías.

## Requerimientos:
1. Lista de Tareas:
- Permitir agregar, eliminar y modificar tareas.
- Mostrar la lista de tareas ordenada por prioridad y fecha de vencimiento.
2. Historial de Acciones:
- Implementar una pila para registrar las acciones de agregar, eliminar y modificar tareas.
- Permitir deshacer y rehacer acciones utilizando la pila de historial.
3. Cola de Tareas Urgentes:
- Permitir agregar tareas a una cola de tareas urgentes.
- Procesar las tareas en el orden en que fueron agregadas (FIFO).
4. Organización en Árboles:
- Permitir organizar las tareas en categorías y subcategorías utilizando una estructura de árbol.
- Mostrar las tareas organizadas jerárquicamente.

## Documentación:

### Descripción del Problema y Cómo Fue Resuelto
El problema consiste en desarrollar una aplicación de gestión de tareas que permita a los usuarios organizar, priorizar y realizar un seguimiento de sus tareas. Para resolver este problema, se implementaron diferentes estructuras de datos que permiten manejar las tareas de manera eficiente:

- **Listas**: Se utilizaron para almacenar y gestionar las tareas pendientes. Cada tarea incluye atributos como título, descripción, prioridad y fecha de vencimiento. Las listas permiten ordenar las tareas según criterios específicos, como prioridad y fecha.
- **Pilas**: Se implementó un historial de acciones utilizando una pila. Esto permite registrar las operaciones realizadas sobre las tareas (agregar, eliminar, modificar) y habilitar las funcionalidades de deshacer y rehacer.
- **Colas**: Se utilizó una cola para gestionar las tareas urgentes. Las tareas se procesan en el orden en que fueron agregadas, siguiendo el principio FIFO (First In, First Out).
- **Árboles**: Las tareas se organizaron jerárquicamente en un árbol, con categorías y subcategorías. Esto facilita la visualización y organización de las tareas según su contexto.

### Explicación de Cada Estructura de Datos Utilizada y Por Qué Se Eligió
1. **Listas**:
   - **Uso**: Almacenar y gestionar las tareas pendientes.
   - **Implementación:** Se utilizó una lista para almacenar las tareas pendientes. Cada tarea se representó como un objeto.
   - **Razón**: Las listas son una estructura de datos flexible y eficiente para manejar colecciones de elementos. Permiten realizar operaciones básicas como agregar, eliminar y buscar elementos con facilidad. Además, su capacidad para ordenar elementos según criterios específicos las hace ideales para gestionar tareas pendientes.

2. **Pilas**:
   - **Uso**: Implementar el historial de acciones (deshacer/rehacer).
   - **Implementación:** Se utilizó una pila para implementar el historial de acciones realizadas sobre las tareas. Cada acción (como agregar, eliminar o modificar una tarea) se almacena como un objeto en la pila.
   - **Razón**: Las pilas son adecuadas para manejar operaciones en orden LIFO (Last In, First Out). Esto es perfecto para un historial de acciones, ya que la última acción realizada es la primera que se deshace. Además, el uso de una segunda pila para rehacer acciones asegura que el historial se mantenga consistente.

3. **Colas**:
   - **Uso**: Gestionar las tareas urgentes.
   - **Implementación:** Se implementó una cola para gestionar las tareas urgentes. Cada tarea urgente se agrega al final de la cola y se procesa desde el frente. 
   - **Razón**: Las colas son perfectas para manejar elementos en orden FIFO (First In, First Out). Esto asegura que las tareas urgentes se procesen en el mismo orden en que fueron agregadas, lo cual es crucial para garantizar que ninguna tarea urgente sea ignorada o procesada fuera de turno.

4. **Árboles**:
   - **Uso**: Organizar las tareas en categorías y subcategorías.
   - **Implementación:** Se utilizó un árbol para organizar las tareas en categorías y subcategorías. Cada nodo del árbol representa una categoría o subcategoría, y las tareas se almacenan como hojas o listas asociadas a los nodos. Las operaciones realizadas incluyen:
   - **Razón**: Los árboles son ideales para representar relaciones jerárquicas. Permiten organizar las tareas en niveles (categorías y subcategorías) y facilitan la navegación y visualización de las mismas. Además, su estructura flexible permite agregar nuevas categorías o subcategorías sin afectar el resto del árbol.

5. **Conclusión**
Cada estructura de datos fue seleccionada e implementada en función de las necesidades específicas del problema:

**Listas** para manejar colecciones de tareas con operaciones básicas y ordenamiento.  
**Pilas** para gestionar el historial de acciones con deshacer/rehacer.  
**Colas** para procesar tareas urgentes en orden FIFO.  
**Árboles** para organizar tareas jerárquicamente en categorías y subcategorías.

Estas implementaciones son correctas porque aprovechan las fortalezas de cada estructura de datos, garantizando eficiencia y claridad en la gestión de las tareas.

## Domain Model
![image](https://github.com/user-attachments/assets/2e306aa5-0bc0-44fe-b04d-451757e457f5)

## Use Cases Diagram
![image](https://github.com/user-attachments/assets/01c7d3eb-6e78-415c-93c3-712f4d15906c)

### Use Cases Specifications

## Add Task
![image](https://github.com/user-attachments/assets/10bd080b-e806-4d89-8635-a86110f0e3db)

### Update Task
![image](https://github.com/user-attachments/assets/d472238d-148c-43f1-a054-786c60bb85c0)

### Delete Task
![image](https://github.com/user-attachments/assets/d9a3decd-2d71-4d2f-a06e-bfebb9bcc2d5)

### Push Task Action History
![image](https://github.com/user-attachments/assets/de08daae-74c9-4023-be0c-4ad6be35f74b)

### Undo 
![image](https://github.com/user-attachments/assets/6bf70971-4f65-45e4-96b2-23adb754a8fa)

### Mark Task Urgent
![image](https://github.com/user-attachments/assets/b532ce4f-ffe4-402d-93c6-04c82e6c2c2f)

### Proccess Task
![image](https://github.com/user-attachments/assets/6d0c6736-d059-405a-b345-e84983ecb2b4)
