﻿using System.Linq;

namespace VaderSentimentAnalysis
{
    public static class Utility
    {
        public static int Search(string[] words, string word)
        {
            // see: https://stackoverflow.com/questions/4075340/finding-first-index-of-element-that-matches-a-condition-using-linq

            var index = words.Select((value, idx) => new { value, idx = idx + 1 })
                .Where(pair => pair.value.Equals(word))
                .Select(pair => pair.idx)
                .FirstOrDefault() - 1;

            return index;
        }
    }
}
