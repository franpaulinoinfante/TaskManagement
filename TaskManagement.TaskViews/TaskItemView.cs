﻿using TaskManagement.Types;

namespace TaskManagement.TaskViews;

public record TaskItemView
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required TaskStates TaskStates { get; set; }
    public required Category Category { get; set; }
    public required PriorityLevel PriorityLevel { get; set; }
    public required DateTime DueDate { get; set; }
}
