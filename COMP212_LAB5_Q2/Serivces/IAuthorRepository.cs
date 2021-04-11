using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LAB5_Q2.Serivces
{
    interface IAuthorRepository
    {
        Task<List<Authors>> LoadAuthor();

        Task<Authors> SaveAuthor(Authors author);
        Task<Authors> UpdateAuthor(Authors author);

    }
}
