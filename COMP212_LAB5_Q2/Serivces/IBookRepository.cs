using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LAB5_Q2.Serivces
{
    interface IBookRepository
    {
        Task<List<Titles>> LoadBook();

        Task<Titles> SaveBook(Titles title);
        Task<Titles> UpdateBook(Titles tile);


    }
}
