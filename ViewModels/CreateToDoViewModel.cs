using System;

using Flunt.Notifications;

namespace MiniTodo.ViewModels
{
    public class CreateToDoViewModel : Notifiable<Notification>
    {
        public string Title { get; set; }

        public ToDo MapTo()
        {
            var contract = new Contract()
                .Requires()
                .IsNotNull(Title, "Informe o título da tarefa")
                .IsGreaterThan(Title, 5, "O título deve conter mais de 5 caracteres");

            AddNotifications(contract);

            return new ToDo(Guid.NewGuid(), Title, false);
        }
    }

    public class ToDo
    {
        public ToDo(Guid id, string title, bool completed)
        {
            // Implementação da classe ToDo
        }
    }
}
