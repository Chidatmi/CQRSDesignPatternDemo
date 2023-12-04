using System;
using System.Collections.Generic;

namespace CQRSDesignPatternDemo.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? RollNo { get; set; }
}
