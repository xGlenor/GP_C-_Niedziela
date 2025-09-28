using System;
using System.Security.Cryptography;

namespace Singleton;

public sealed class Counter
{
    // Przechowuje jedyną instancję klasy Counter
    private static Counter _instance;

    // Obiekt do blokowania w sytuacji wielowątkowej (thread-safe)
    private static readonly object _lock = new object();

    // Pole licznika
    private int _count;

    // Prywatny konstruktor, aby uniemożliwić tworzenie obiektów klasy poza nią
    private Counter()
    {
        _count = 0;
    }

    // Właściwość Instance, zapewnia dostęp do jedynej instancje
    public static Counter Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new Counter();
                }
            }
            return _instance;
        }
    }

    public int Increment()
    {
        return ++_count;
    }

    public int CurrentValue => _count;

}
