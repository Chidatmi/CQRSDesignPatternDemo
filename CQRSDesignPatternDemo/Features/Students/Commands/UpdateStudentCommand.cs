using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CQRSDesignPatternDemo.Services;

namespace CQRSDesignPatternDemo.Features.Students.Commands
{
    public class UpdateStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int? RollNo { get; set; }

        public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, int>
        {
            private readonly IStudentService _studentService;

            public UpdateStudentCommandHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }

            public async Task<int> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
            {
                var student = await _studentService.GetStudentById(command.Id);
                if (student == null)
                    return default;

                student.RollNo = command.RollNo;
                student.StudentName = command.StudentName;

                return await _studentService.UpdateStudent(student);
            }
        }
    }
}
