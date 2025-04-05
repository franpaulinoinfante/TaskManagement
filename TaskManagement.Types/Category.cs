namespace TaskManagement.Types;

public enum Category
{
    Root,
    Personal,
    PersonalDevelopment,
    GoalsAndPlanning,
    SelfLearning,
    JournalingAndReflections,
    HabitsAndRoutines,
    Work,
    Meetings,
    Reports,
    SoftwareDevelopment,
    DataAnalysis,
    Presentations,
    Studies,
    TasksAndProjects,
    Exams,
    PendingReadings,
    ClassesAndCourses,
    Home,
    Cleaning,
    HouseholdShopping,
    Maintenance,
    UtilityPayments,
    HealthAndWellness,
    MedicalAppointments,
    Exercise,
    Nutrition,
    Rest
}

public static class CategoryExtension
{
    private static readonly string[] Messages =
    {
        "Raíz",
        "Personal",
        "Desarrollo Personal",
        "Planes y Metas",
        "Autoaprendizaje",
        "Diario y Reflexiones",
        "Hábitos y Rutinas",
        "Trabajo",
        "Reuniones",
        "Reportes",
        "Desarrollo de Software",
        "Análisis de Datos",
        "Presentaciones",
        "Estudio",
        "Tareas y Proyectos",
        "Examenes",
        "Lecturas Pendientes",
        "Clases y Cursos",
        "Hogar",
        "Limpieza",
        "Compras Para el Hogar",
        "Mantenimiento",
        "Pagos de Servicios Públicos",
        "Salud y Bienestar",
        "Citas Médicas",
        "Ejercicio",
        "Nutricón",
        "Descanso"
    };

    public static string GetMesage(this Category category)
    {
        return Messages[(int)category];
    }
}