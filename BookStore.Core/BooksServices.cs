namespace BookStore.Core
{
    public class BooksServices : IBookServices
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>() { new Book() {
                Id="1",
                Name="Positive",
                Author="Neha Ghedia",
                Price = "200$"
            } };
        }
    }
}