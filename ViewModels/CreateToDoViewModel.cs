using System.Diagnostics.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using Microsoft.AspNetCore.Components.Web;

namespace MiniTodo.ViewModels
{
    public class CreateToDoViewModel : Notifiable<Notification>
    {
        public string Title { get; set; }
        
   
      public ToDo MapTo()
        {
            AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Title, "Informe o título da tarefa")
            .IsGreaterThan(Title, 5,"O título deve conter mais de cinco caracteres"));
            
            return new ToDo(Guid.NewGuid(), Title, false);
        }
    }
}