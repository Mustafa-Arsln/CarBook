using Carbook.Domain.Entities;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carBookcontext;

        public BlogRepository(CarBookContext carBookcontext)
        {
            _carBookcontext = carBookcontext;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values= _carBookcontext.Blogs.Include(x=>x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
            return values;
        }
    }
}
