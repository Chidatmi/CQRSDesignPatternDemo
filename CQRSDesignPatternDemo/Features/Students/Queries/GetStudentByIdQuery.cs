using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CQRSDesignPatternDemo.Models;
using CQRSDesignPatternDemo.Services;

namespace CQRSDesignPatternDemo.Features.Students.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }

        public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, Student>
        {
            private readonly IStudentService _studentService;

            public GetStudentByIdQueryHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }

            public async Task<Student> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
            {
                return await _studentService.GetStudentById(query.Id);
            }
        }
    }
}
