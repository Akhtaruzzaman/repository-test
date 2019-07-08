using Microsoft.EntityFrameworkCore;
using Model;
using Repo.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Repository.IRepo;

namespace WebApp.Repository.Repo
{
    public class StudentRepo : Repository<Student, AppDbContext>, IStudentRepo
    {
    }
}
