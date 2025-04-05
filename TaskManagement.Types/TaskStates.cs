namespace TaskManagement.Types;

public enum TaskStates
{
    ToDo,
    InProgress,
    Done,
    Deleted
}

public static class TaskStateExtension
{
    private static readonly string[] Messages =
    {
        "Pendiente",
        "En Progreso",
        "Realizada",
        "Deleted"
    };

    public static string GetMesage(this TaskStates taskState)
    {
        return Messages[(int)taskState];
    }
}
