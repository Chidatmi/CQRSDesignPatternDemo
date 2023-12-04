using Microsoft.EntityFrameworkCore;
using CQRSDesignPatternDemo.Data;
using CQRSDesignPatternDemo.Models;
using System.Numerics;

namespace CQRSDesignPatternDemo.Services
{
    public class StudentsService:IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentsService(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetStudentsList()
        {
            return await _context.Students
                .ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Student> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<int> UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            return await _context.SaveChangesAsync();
        }
    }
}
