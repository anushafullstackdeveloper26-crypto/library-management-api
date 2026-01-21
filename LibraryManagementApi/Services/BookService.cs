using LibraryManagementApi.Models;
using LibraryManagementApi.Repositories;

namespace LibraryManagementApi.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Book> CreateAsync(Book book)
        {
            return await _repository.AddAsync(book);
        }

        public async Task<bool> UpdateAsync(int id, Book book)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return false;

            existing.Title = book.Title;
            existing.Author = book.Author;
            existing.Isbn = book.Isbn;
            existing.PublishedYear = book.PublishedYear;
            existing.AvailableCopies = book.AvailableCopies;

            await _repository.UpdateAsync(existing);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var book = await _repository.GetByIdAsync(id);
            if (book == null)
                return false;

            await _repository.DeleteAsync(book);
            return true;
        }
    }
}
