using System.ComponentModel;

namespace TaskManagement.Types;

public enum Category
{
    None,
    Personal,
    [Description("Personal Development")]
    Trabajo,
    Estudios,
    Hogar,
    SaludBienestar,
    SoftwareDevelopment
}

public static class CategoryExtension
{
    private static readonly string[] Messages =
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
