﻿using TaskManagement.Types;

namespace TaskManagement.TaskViews.TaskListViews;

public class TaskItemUpdateView
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required TaskState TaskState { get; set; }
    public required Category Category { get; set; }
    public required PriorityLevel PriorityLevel { get; set; }
    public required DateTime DueDate { get; set; }
}
