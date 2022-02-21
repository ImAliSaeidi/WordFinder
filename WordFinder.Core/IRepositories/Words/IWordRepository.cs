using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordFinder.Data.Entities.Words;

namespace WordFinder.Core.IRepositories.Words
{
    public interface IWordRepository
    {
        IQueryable<Word> GetAll();
    }
}
