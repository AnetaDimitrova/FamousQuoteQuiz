


using System.Collections.Generic;
using FamousQuoteQuiz.Data;

namespace FamousQuoteQuiz.App.ViewModels
{
    public class MainViewModels
    {
        public IEnumerable<AuthorViewModels> Authors { get; set; }

        public IEnumerable<QuoteViewModels> Quotes { get; set; }
    }
}