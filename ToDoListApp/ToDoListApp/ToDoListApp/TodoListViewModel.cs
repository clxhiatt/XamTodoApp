using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListApp
{
    public class TodoListViewModel
    { 

        public ObservableCollection<TodoItem> TodoItems { get; set; }
        

        public TodoListViewModel()
        {
            this.TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("Walk The Dog", true));
            TodoItems.Add(new TodoItem("Take Out The Trash", false));
            TodoItems.Add(new TodoItem("Clean The Kitchen", false));
        }

        public string NewTodoInputValue { get; set; }
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
        }

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        void RemoveTodoItem(object o)
        {
            TodoItem TodoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(TodoItemBeingRemoved);
        }


    }

}
