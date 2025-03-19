using System;
using System.Collections.Generic;

// Observer Interface
public interface IObserver
{
    void Update(float temperature);
}

// Observable Interface
public interface IObservable
{
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers();
}

// Concrete Observable (WeatherStation)
public class WeatherStation : IObservable
{
    private float _temperature;
    private List<IObserver> _observers;

    public WeatherStation()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }

    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        Console.WriteLine($"Weather Station: Temperature changed to {_temperature} ºC");
        NotifyObservers();
    }
}

// Concrete Observer (Display)
public class Display : IObserver
{
    private string _name;

    public Display(string name)
    {
        _name = name;
    }

    public void Update(float temperature)
    {
        Console.WriteLine($"{_name} Display: Updated temperature is {temperature} ºC");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        var weatherStation = new WeatherStation();
        var display1 = new Display("Sala");
        var display2 = new Display("Cozinha");
        var display3 = new Display("WC");
        var display4 = new Display("Corredor");

        // Register Observers
        weatherStation.RegisterObserver(display1);
        weatherStation.RegisterObserver(display2);
        weatherStation.RegisterObserver(display3);
        weatherStation.RegisterObserver(display4);

        // Simulate Temperature Change
        weatherStation.SetTemperature(25);
        weatherStation.SetTemperature(30);

        // Unregister one observer and change temperature again
        weatherStation.UnregisterObserver(display2);
        weatherStation.SetTemperature(28);
    }
}
