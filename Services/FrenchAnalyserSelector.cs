using Lucene.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lucene.FrenchAnalyser.Services {
    public class FrenchAnalyserSelector : ILuceneAnalyzerSelector {
        public string Name => "French";

        public LuceneAnalyzerSelectorResult GetLuceneAnalyzer(string indexName) {
            return new LuceneAnalyzerSelectorResult {
                Priority = 0,
                Analyzer = new FrenchAnalyser(LuceneIndexProvider.LuceneVersion)
            };
        }
    }
}