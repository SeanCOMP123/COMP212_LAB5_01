using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LAB5_Q2.Serivces
{
    class AuthorRepository :IAuthorRepository
    {
        private CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext _dbContext;
        public AuthorRepository()
        {
            _dbContext = new CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext();
        }
        public async Task<List<Authors>> LoadAuthor()
        {
            return await _dbContext.Authors.ToListAsync();
        }

        public async Task<Authors> SaveAuthor(Authors author)
        {
            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();
            return author;
        }

        public async Task<Authors> UpdateAuthor(Authors author)
        {
            if (!_dbContext.Authors.Local.Any(a => a.AuthorId == author.AuthorId)) 
            {

                _dbContext.Authors.Attach(author);
            }
            _dbContext.Entry(author).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return author;
        }
    }
}
