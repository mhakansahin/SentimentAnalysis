using System;
using System.Collections.Generic;
using Microsoft.ML.Runtime.Api;
using System.Text;

namespace SentimentAnalysis
{
    public class SentimentData
    {
        [Column(ordinal: "0", name: "Label")]
        public float Sentiment;
        [Column(ordinal: "1")]
        public string SentimentText;
    }

    public class SentimentPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool Sentiment;
    }
}
