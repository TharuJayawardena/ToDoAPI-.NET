namespace TodoAPI.Controllers
{
    public class TodoItemDTO
    {
        public bool IsComplete { get; internal set; }
        public string Name { get; internal set; }
        public long Id { get; internal set; }
    }
}