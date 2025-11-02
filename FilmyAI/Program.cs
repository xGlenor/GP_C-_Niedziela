using System.Runtime.Intrinsics.Arm;
using Microsoft.ML;

// Tworzymy kontekt MachineLearning'u
MLContext mLContext = new MLContext();

// Wczytanie danych z pliku
string dataPath = "filmy.csv";
IDataView dataView = mLContext.Data.LoadFromTextFile<Film>(
    path: dataPath,
    hasHeader: true,
    separatorChar: ','
);

// Dzieli nasz zbiór danych na zbiór treningowy i zbiór testowy, gdzie testowy to 20%
var split = mLContext.Data.TrainTestSplit(dataView, testFraction: 0.2);
// Odpowiada za zbiór danych do nauki (trenowania)
var trainData = split.TrainSet;
// Odpowiada za zbiór do sprawdzenia jakości danych/ modelu (testowanie)
var testData = split.TestSet;

// Stworzenie pipeline:
// Czyli stworzenie łańcucha kroków
var pipeline = mLContext.Transforms.Categorical
            .OneHotEncoding(
                inputColumnName: "Gatunek",
                outputColumnName: "GatunekEncoded"
            )
            .Append(mLContext.Transforms.Categorical.OneHotEncoding(
                inputColumnName: "Rezyser",
                outputColumnName: "RezyserEncoded"
            ))
            .Append(mLContext.Transforms.Concatenate(
                "Features", // Kolumna, która będzie przechowywać poniższe cechy (kolumny)
                "GatunekEncoded",
                "RezyserEncoded",
                nameof(Film.Rok),
                nameof(Film.Ocena)
            ))
            .Append(mLContext.BinaryClassification.Trainers.SdcaLogisticRegression(
                labelColumnName: nameof(Film.Lubiany),
                featureColumnName: "Features"
            ));

// Trenujemy nasz model po krokach z pipleline'u na podstawie danych do trenowania
var model = pipeline.Fit(trainData);

// Obliczamy skuteczność działania modelu na danych testowych
var predictions = model.Transform(testData);
var metrics = mLContext.BinaryClassification.Evaluate(
    data: predictions,
    labelColumnName: nameof(Film.Lubiany),
    scoreColumnName: "Score"
);

// Ile procent przypadków model przewidział poprawnie (czy Film był lubiany czy nie)
Console.WriteLine($"Accuracy {metrics.Accuracy:F2}");
// Spośród filmów, które model uznał "lubiane", ile rzeczywiście było lubiane
Console.WriteLine($"Precision: {metrics.PositivePrecision:F2}");
// Sposród wszystkich faktycznie lubianych filmów, ile model oznaczył jako "lubiane"
Console.WriteLine($"Recall: {metrics.PositiveRecall:F2}");

// Zapisujemy model np. do pliku
mLContext.Model.Save(model, dataView.Schema, "ModelFilmy.zip");

Console.WriteLine("Model wytrenowany");

// Tworzymy silnik predykcji (PredictionEngine)
var predEngine = mLContext.Model.CreatePredictionEngine<Film, FilmPrediction>(model);

var nowyFilm = new Film()
{
    Tytul = "Harry Potter",
    Gatunek = "Horror",
    Rok = 2012,
    Ocena = 9.1f,
    Rezyser = "Nolan"
};

var wynik = predEngine.Predict(nowyFilm);

Console.WriteLine($"Czy film '{nowyFilm.Tytul}' będzie lubiany? {wynik.Prediction} (Score {wynik.Score})");


// Stworzyć program, który bedzie pobierać dane do filmu i przewidywał jego wyniki i wyświetlał inforamcje o nich na konsoli. Program ma pytać użytkownika o danych film, do momentu aż nie wpisze 'exit'

Console.WriteLine("\nWpisz 'exit' w tytule filmu, aby zakończyć \n");
while (true)
{
    Console.Write("Tytuł: ");
    string tytul = Console.ReadLine() ?? "";
    if (tytul.ToLower() == "exit") break;

    Console.Write("Gatunek: ");
    string gatunek = Console.ReadLine() ?? "";

    Console.Write("Rok: ");
    int rok;
    while (!int.TryParse(Console.ReadLine(), out rok))
    {
        Console.Write("Błędna wartość. Podaj liczbę całkowitą: ");
    }

    Console.Write("Ocena: ");
    float ocena;
    while (!float.TryParse(Console.ReadLine(), out ocena))
    {
        Console.Write("Błędna wartość. Podaj liczbę zmiennoprzecinkową: ");
    }

    Console.Write("Reżyser: ");
    string rezyser = Console.ReadLine() ?? "";

    var userFilm = new Film()
    {
        Tytul = tytul,
        Gatunek = gatunek,
        Rok = rok,
        Ocena = ocena,
        Rezyser = rezyser
    };

    var result = predEngine.Predict(userFilm);
    Console.WriteLine($"Przewidywany wynik: {result.Prediction} (Score: {result.Score})");
}