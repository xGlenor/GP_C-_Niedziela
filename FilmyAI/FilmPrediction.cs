using Microsoft.ML.Data;

public class FilmPrediction
{
    [ColumnName("PredictionLabel")]
    public bool Prediction { get; set; }

    public float Score { get; set; }
}