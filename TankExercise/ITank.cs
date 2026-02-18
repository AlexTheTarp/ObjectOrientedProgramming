using TankExercise;

interface ITank
{
    string AddToTank(int amount);
    int GetAmount();
    string RemoveFromTank(int amount);
    void ClearTank();
}
