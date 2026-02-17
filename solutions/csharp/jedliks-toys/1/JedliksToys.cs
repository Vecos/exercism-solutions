class RemoteControlCar
{
    private int _driven = 0; 
    private int _battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_driven} meters";

    public string BatteryDisplay() => _battery <= 0 ? "Battery empty" :$"Battery at {_battery}%";
    

    public void Drive()
    {
        if (_battery <= 0) return;
        _driven += 20;
        _battery -= 1;
    
    }
}

