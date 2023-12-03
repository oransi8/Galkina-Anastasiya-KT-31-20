﻿using GalkinaAnastasiyaKT_31_20.Database;
//using GalkinaAnastasiyaKT_31_20.Filters.StudentFiltres;
using GalkinaAnastasiyaKT_31_20.Models;
using GalkinaAnastasiyaKT_31_20.Filters.StudentFilters;
//using GalkinaAnastasiyaKT_31_20.interfaces.StudentInterfaces;
using Microsoft.EntityFrameworkCore;

namespace GalkinaAnastasiyaKT_31_20.Interfaces.StudentsInterfaces
{
    public interface IStudentService
    {
        public Task<Student[]> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken);
    }

    public class StudentService : IStudentService
    {
        private readonly StudentDbContext? _dbContext;
        public StudentService(StudentDbContext? dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Student[]>? GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = _dbContext?.Set<Student>().Where(w=> w.Group.GroupName == filter.GroupName).ToArrayAsync(cancellationToken);
            return students;
        }
    }
}
