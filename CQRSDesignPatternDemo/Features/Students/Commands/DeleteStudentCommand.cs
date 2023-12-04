using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CQRSDesignPatternDemo.Services;

namespace CQRSDesignPatternDemo.Features.Students.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int? RollNo { get; set; }

        public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, int>
        {
            private readonly IStudentService _studentService;

            public DeleteStudentCommandHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }

            public async Task<int> Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
            {
                var student = await _studentService.GetStudentById(command.Id);
                if (student == null)
                    return default;

                return await _studentService.DeleteStudent(student);
            }
        }
    }
}
