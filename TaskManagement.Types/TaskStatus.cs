﻿namespace TaskManagement.Types;

public enum TaskState
{
    ToDo,
    InProgress,
    Done
}

public static class TaskStateExtension
{
    private static string[] Messages =
    {
        "Por Hacer",
        "En Progreso",
        "Realizada"
    };

    public static string GetMesage(this TaskState taskState)
    {
        return Messages[(int)taskState];
    }
}
