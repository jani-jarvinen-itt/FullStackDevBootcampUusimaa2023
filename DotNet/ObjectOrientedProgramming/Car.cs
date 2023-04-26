public class Car
{
    // properties
    public string Model { get; set; }

    public string Make { get; set; }

    public int CurrentSpeed { get; private set; }

    public bool EngineRunning { get; private set; }

    // methods
    public void StartEngine()
    {
        EngineRunning = true;
    }

    public void StopEngine()
    {
        EngineRunning = false;
    }

    public void Accelerate()
    {
        if (!EngineRunning)
        {
            // return;
            throw new InvalidOperationException("Cannot accelerate because the " +
                "engine is not running. Please use StartEngine() first.");
        }

        const int MaxSpeed = 200;
        CurrentSpeed += 10;

        if (CurrentSpeed > MaxSpeed)
        {
            CurrentSpeed = MaxSpeed;
        }
    }

    public void Decelerate()
    {
        CurrentSpeed -= 10;

        if (CurrentSpeed < 0)
        {
            CurrentSpeed = 0;
        }
    }
}
