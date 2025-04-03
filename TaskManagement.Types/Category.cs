namespace TaskManagement.Types;

public enum Category
{
    None,
    Personal,
    Trabajo,
    Estudios,
    Hogar,
    SaludBienestar,
    SoftwareDevelopment
}

public static class CategoryExtension
{
    private static string[] Messages =
    {
        "Seleccione Una",
        "Personal",
        "Trabajo",
        "Estudio",
        "Hogar",
        "Salud y Bienestar",
        "Desarrollo de software"
    };

    public static string GetMesage(this Category category)
    {
        return Messages[(int)category];
    }
}
