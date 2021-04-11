using System;
using BookLibrary;
using BookLibrary.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP212_LAB5_Q2.Serivces
{
    class BookRespository : IBookRepository
    {
        private CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext _dbContext;
        public BookRespository() 
        {
            _dbContext = new CCENTENNIALCOLLEGE2021WINTERLABSLAB5BOOKSMDFContext();
        }
        public async Task<List<Titles>> LoadBook()
        {
            return await _dbContext.Titles.ToListAsync();
        }

        public async Task<Titles> SaveBook(Titles title)
        {
            _dbContext.Titles.Add(title);
            await _dbContext.SaveChangesAsync();
            return title;
        }

        public async Task<Titles> UpdateBook(Titles title)
        {
            if (!_dbContext.Titles.Local.Any(a => a.Isbn == title.Isbn))
            {

                _dbContext.Titles.Attach(title);
            }
            _dbContext.Entry(title).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return title;
        }
    }
}
