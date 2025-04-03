namespace TaskManagement.Types;
public enum ActionOnTask
{
    Create,
    Update,
    Remove
}

public static class ActionOnTaskExtension
{
    private static string[] Messages =
    {
        "Agregar",
        "Actualizar",
        "Eliminar"
    };

    public static string GetMesage(this ActionOnTask actionOnTask)
    {
        return Messages[(int)actionOnTask];
    }
}
