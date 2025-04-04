namespace TaskManagement.Types;

public enum TaskStates
{
    ToDo,
    InProgress,
    Done
}

public static class TaskStateExtension
{
    private static readonly string[] Messages =
    {
        "Pendiente",
        "En Progreso",
        "Realizada"
    };

    public static string GetMesage(this TaskStates taskState)
    {
        return Messages[(int)taskState];
    }
}
