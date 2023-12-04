using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CQRSDesignPatternDemo.Models;
using CQRSDesignPatternDemo.Services;

namespace CQRSDesignPatternDemo.Features.Students.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string StudentName { get; set; }
        public int? RollNo { get; set; }

        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
        {
            private readonly IStudentService _studentService;

            public CreateStudentCommandHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }

            public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
            {
                var student = new Student()
                {
                    StudentName = command.StudentName,
                    RollNo = command.RollNo,
                };

                return await _studentService.CreateStudent(student);
            }
        }
    }
}
