﻿using TaskManagement.Types;

namespace TaskManagement.TaskViews.TaskListViews;

public class TaskItemListView
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public PriorityLevel PriorityLevel { get; set; }
    public TaskStates TaskStates { get; set; }
    public Category Category { get; set; }
    public DateTime DueDate { get; set; }
}
