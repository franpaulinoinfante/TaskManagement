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
   - **Razón**: Las listas son ideales para manejar colecciones de elementos ordenados. Permiten agregar, eliminar y buscar tareas de manera eficiente, además de ordenar las tareas según criterios específicos.

2. **Pilas**:
   - **Uso**: Implementar el historial de acciones (deshacer/rehacer).
   - **Razón**: Las pilas son adecuadas para manejar operaciones en orden LIFO (Last In, First Out). Esto permite deshacer la última acción realizada y rehacerla si es necesario.

3. **Colas**:
   - **Uso**: Gestionar las tareas urgentes.
   - **Razón**: Las colas son perfectas para procesar elementos en el orden en que llegan (FIFO). Esto asegura que las tareas urgentes se atiendan en el orden correcto.

4. **Árboles**:
   - **Uso**: Organizar las tareas en categorías y subcategorías.
   - **Razón**: Los árboles permiten representar relaciones jerárquicas entre elementos. Esto facilita la organización de las tareas en niveles, como categorías principales y subcategorías.

## Domain Model
![image](https://github.com/user-attachments/assets/2e306aa5-0bc0-44fe-b04d-451757e457f5)

## Use Cases Diagram
![image](https://github.com/user-attachments/assets/c67713bf-55ec-482d-9213-37da81e98a0d)

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
