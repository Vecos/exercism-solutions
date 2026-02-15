class RemoteControlCar
{
    private int _driven = 0; 
    private int _battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_driven} meters";

    public string BatteryDisplay() => this._battery <= 0 ? "Battery empty" :$"Battery at {_battery}%";
    

    public void Drive()
    {
        if (_battery <= 0) return;
        this._driven += 20;
        this._battery -= 1;
    
    }
}

