using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordFinder.Core.IRepositories.Words;
using WordFinder.Data.Context;
using WordFinder.Data.Entities.Words;

namespace WordFinder.Core.Repositories.Words
{
    public class WordRepository : IWordRepository
    {
        private readonly WordFinderContext context;

        public WordRepository(WordFinderContext context)
        {
            this.context = context;
        }

        public IQueryable<Word> GetAll()
        {
            return context.Words;
        }
    }
}
