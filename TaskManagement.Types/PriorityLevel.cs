namespace TaskManagement.Types;

public enum PriorityLevel
{
    Normal,
    Urgent
}

public static class PriorityExtension
{
    private static string[] Messages =
    {
        "Normal",
        "Urgente"
    };

    public static string GetMesage(this PriorityLevel priorityLevel)
    {
        return Messages[(int)priorityLevel];
    }
}
