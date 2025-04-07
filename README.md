# Task Management
Práctica Final: Estructuras de Datos en el Lenguaje de Programación de Tu Preferencia

## Indice

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

**Conclusión**  
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


### Interfaz de Usuario
![image](https://github.com/user-attachments/assets/1d850b46-d772-4fee-9573-1c6bc38d1921)

![image](https://github.com/user-attachments/assets/005e236c-767e-4074-b29b-75ffbe3cebf1)

![image](https://github.com/user-attachments/assets/4f77f364-f23e-4ba7-b05a-0dc553ae6d63)

![image](https://github.com/user-attachments/assets/8e7c469c-eebb-4ad5-aa64-eb74025ea31b)

### Arquitectura

![image](https://github.com/user-attachments/assets/10caeb27-919f-40f7-aeac-caf2b78f4cd5)

### Guía de instalación para los usuarios:
1. Requisitos previos:
   - Sistema operativo Windows.
   - .NET 9 Runtime instalado (si no está incluido en el instalador).
2. Pasos de instalación:
   -	Descargar el instalador: TaskManagementApp.msi o TaskManagementApp.exe
2.	Ejecutar el instalador:
   - Haz doble clic en el archivo setup.msi para iniciar el asistente de instalación.
3.	Seguir las instrucciones del asistente:
   - Haz clic en "Siguiente" en la pantalla de bienvenida.
   - Selecciona la carpeta de destino donde deseas instalar la aplicación y haz clic en "Siguiente".
   - Haz clic en "Instalar" para comenzar la instalación.
4.	Finalizar la instalación:
   - Una vez completada la instalación, haz clic en "Finalizar" para cerrar el asistente.
5.	Ejecutar la aplicación:
   - Ve al menú de inicio o al escritorio y haz clic en el acceso directo de la aplicación para ejecutarla.
Siguiendo estos pasos, podrás crear un instalador para tu sistema y proporcionar una guía clara para que los usuarios puedan instalar y usar tu aplicación fácilmente.

###  Resumen de los Principios Respetados en el Proyecto
1. Modularidad: El proyecto se estructuró en módulos independientes, cada uno encargado de una funcionalidad específica (gestión de tareas, historial de acciones, tareas urgentes, organización jerárquica). Esto facilita el mantenimiento y la escalabilidad del sistema.
2. Uso Adecuado de Estructuras de Datos
   - Se seleccionaron estructuras de datos óptimas para cada caso de uso:
      - Listas para tareas pendientes.
      - Pilas para el historial de acciones.
      - Colas para tareas urgentes.
      - Arboles para la organización jerárquica.
   - Esto asegura eficiencia y claridad en las operaciones realizadas.
3. Principio de Responsabilidad Única (SRP)
   - Cada componente del sistema tiene una única responsabilidad:
      - La lista gestiona las tareas pendientes.
      - La pila maneja el historial de acciones.
      - La cola organiza las tareas urgentes.
      - El árbol estructura las categorías y subcategorías.
4. Reusabilidad: Las estructuras de datos y funciones implementadas son reutilizables en diferentes partes del proyecto, evitando duplicación de código.
5. Eficiencia: Se priorizó el uso de algoritmos y estructuras de datos que optimizan el tiempo y el espacio, como el uso de pilas para deshacer/rehacer y colas para tareas urgentes.
6. Claridad y Legibilidad del Código: El código fue escrito siguiendo buenas prácticas, con nombres descriptivos para variables y funciones, y comentarios que explican cada sección.
7. Gestión de Errores: Se implementaron mecanismos para manejar errores y excepciones, asegurando que el sistema sea robusto y no falle ante entradas inesperadas.
8. Escalabilidad: La estructura del proyecto permite agregar nuevas funcionalidades (como nuevas categorías o tipos de tareas) sin afectar el diseño existente.
9. Principio de Abierto/Cerrado (OCP): El sistema está diseñado para ser extensible sin modificar el código base, por ejemplo, añadiendo nuevas categorías o funcionalidades.
10. Facilidad de Uso: La interfaz gráfica fue diseñada para ser intuitiva, permitiendo a los usuarios interactuar fácilmente con las tareas y sus categorías.

### Explicación de la Clase CategoryNode
La clase CategoryNodo es una implementación que representa un nodo en un árbol jerárquico de categorías. Este diseño permite organizar tareas en categorías y subcategorías, facilitando la gestión y navegación de las mismas.
- Propiedades
   1. Category
      - Tipo: Category
      - Representa la categoría asociada al nodo actual. Es el identificador principal del nodo.
   2. Subcategories
      - Tipo: List<CategoryNodo>
      - Contiene una lista de subcategorías (hijos) del nodo actual. Esto permite construir una estructura jerárquica de categorías.
   3. Tasks
      - Tipo: List<TaskItemListView>
      - Almacena las tareas asociadas a la categoría representada por el nodo actual.
- Constructor
public CategoryNodo(Category category)
{
    Category = category;
    Subcategories = new List<CategoryNodo>();
    Tasks = new List<TaskItemListView>();
}
- Propósito: Inicializa un nodo con una categoría específica.
- Acciones: Asigna la categoría al nodo e inicializa las listas de subcategorías (Subcategories) y tareas (Tasks) como vacías.
- Métodos
1. AddSubCategory
public void AddSubcategory(CategoryNodo subcategory)
{
    Subcategories.Add(subcategory);
}
- Propósito: Agrega una subcategoría al nodo actual.
- Uso: Permite construir la jerarquía del árbol añadiendo nodos hijos al nodo actual
- Funcionamiento:
   - Recibe un nodo (subcategory) como parámetro.
   - Lo agrega a la lista de subcategorías (Subcategories).
2. AddTaskToCategory
public bool AddTaskToCategory(Category targetCategory, TaskItemListView task)
{
    if (Category == targetCategory)
    {
        Tasks.Add(task);
        return true; 
    }

    foreach (var sub in Subcategories)
    {
        if (sub.AddTaskToCategory(targetCategory, task))
        {
            return true;
        }
    }

    return false;
}
- Propósito: Agrega una tarea a una categoría específica dentro del árbol.
- Parámetros:
   - targetCategory: La categoría objetivo donde se desea agregar la tarea.
   - task: La tarea que se desea agregar.
- Funcionamiento: 
   1. Comprueba si la categoría del nodo actual (Category) coincide con la categoría objetivo (targetCategory).
      - Si coincide, agrega la tarea a la lista de tareas (Tasks) del nodo actual y retorna true.
   2. Si no coincide, recorre recursivamente las subcategorías (Subcategories) llamando al mismo método en cada nodo hijo.
      - Si alguna subcategoría agrega la tarea, retorna true.
      - Si no se encuentra la categoría objetivo en el nodo actual ni en sus subcategorías, retorna false.
**Ventaja**: Este método utiliza una búsqueda recursiva para localizar la categoría objetivo en cualquier nivel del árbol, lo que lo hace eficiente para estructuras jerárquicas.
**Resumen**
La clase CategoryNodo es una implementación clave para organizar tareas en un árbol jerárquico de categorías. Sus principales características son:
- Jerarquía: Permite construir una estructura de árbol mediante la lista de subcategorías.
- Flexibilidad: Soporta la asignación de tareas a cualquier categoría dentro del árbol.
- Recursividad: Utiliza un enfoque recursivo para buscar categorías y asignar tareas, lo que simplifica la navegación en estructuras complejas.  
Esta implementación es adecuada para sistemas de gestión de tareas donde las categorías y subcategorías son esenciales para organizar la información de manera clara y eficiente.

### Instalador
https://1drv.ms/f/s!Ao2-T3T2v5nLhOpgAuki5JqkpmIpHQ?e=WXsIZM
