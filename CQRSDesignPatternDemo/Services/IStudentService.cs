using CQRSDesignPatternDemo.Models;
using System.Numerics;

namespace CQRSDesignPatternDemo.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudentsList();
        Task<Student> GetStudentById(int Id);
        Task<Student> CreateStudent(Student student);
        Task<int> UpdateStudent(Student student);
        Task<int> DeleteStudent(Student student);
    }
}
