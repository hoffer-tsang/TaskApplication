﻿
using TodoTaskLib.DTOs;
using TodoTaskLib.Enums;

namespace TodoTaskLib.Database
{
    /// <summary>
    /// Interface for TodoItemServices
    /// </summary>
    public interface ITodoItemsService
    {
        List<TodoItem> Get(string? name, int? priority, Status? status);
        TodoItem? GetById(int id);
        TodoItem Add(PostTodoItem postTask);
        TodoItem? Update(int id, TodoItem task);
        bool Remove(int id);


    }
}
