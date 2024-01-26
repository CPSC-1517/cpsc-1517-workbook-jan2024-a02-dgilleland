namespace Assorted;

public class ParkingCounter
{
    #region Fields and Properties
    private int _Peak;
    public int OpenSpots { get; private set; }
    public int ParkingSpots { get; private set; }
    public int PeakOccupancy {
        get { return _Peak; }
    }
    #endregion

    #region Constructors
    public ParkingCounter(int parkingSpots)
    {
        if(parkingSpots <= 0)
            throw new Exception("Negative or zero parking spots are not allowed");
        ParkingSpots = parkingSpots;
        OpenSpots = parkingSpots;
        _Peak = 0;
    }
    public ParkingCounter(int parkingSpots, int numberOfCars)
    {
        // TODO: Add validation later, when I get some tests....
        ParkingSpots = parkingSpots;
        OpenSpots = parkingSpots - numberOfCars;
        _Peak = numberOfCars;
    }
    #endregion

    #region Methods
    // TODO: Finish methods later
    public void Enter() {}
    public void Leave() {}
    public void ResetLotAsEmpty() {}
    public void ResetLotAsFull() {}
    #endregion
}