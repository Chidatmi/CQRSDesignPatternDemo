using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CQRSDesignPatternDemo.Models;
using CQRSDesignPatternDemo.Services;

namespace CQRSDesignPatternDemo.Features.Students.Queries
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<Student>>
    {
        public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentsQuery, IEnumerable<Student>>
        {
            private readonly IStudentService _studentService;

            public GetAllStudentQueryHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }

            public async Task<IEnumerable<Student>> Handle(GetAllStudentsQuery query, CancellationToken cancellationToken)
            {
                return await _studentService.GetStudentsList();
            }
        }
    }
}
