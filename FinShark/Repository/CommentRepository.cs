using FinShark.Data;
using FinShark.Interfaces;
using FinShark.Models;
using Microsoft.EntityFrameworkCore;

namespace FinShark.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var existingModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

            if (existingModel == null)
            {
                return null;
            }

            _context.Comments.Remove(existingModel);

            await _context.SaveChangesAsync();

            return existingModel;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.Include(a => a.AppUser).ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.Include(a => a.AppUser).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Comment> UpdateAsync(int id, Comment commentModel)
        {
            var existingModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

            if (existingModel == null)
            {
                return null;
            }

            existingModel.Title = commentModel.Title;
            existingModel.Content = commentModel.Content;

            await _context.SaveChangesAsync();

            return existingModel;
        }
    }
}
