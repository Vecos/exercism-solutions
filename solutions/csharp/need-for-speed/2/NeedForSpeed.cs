class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int _speed;
    private int _batteryDrain ;
    private int _battery = 100;
    private int _distance = 0;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }
    public bool BatteryDrained() => _battery < _batteryDrain;   
    

    public int DistanceDriven() =>_distance;
  

    public void Drive()
    {
    if (!BatteryDrained())
    {
        _distance += _speed;
        _battery -= _batteryDrain;
    }    
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    
    private int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
      while (!car.BatteryDrained())
    {
        car.Drive();
    }

    return car.DistanceDriven() >= _distance;
    }
}
