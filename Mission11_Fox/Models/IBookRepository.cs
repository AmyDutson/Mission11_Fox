namespace Mission11_Fox.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
