using TankExercise;

class Tank : BaseTank, ITank
{
    private int capacity;
    private int amount = 0;

    public Tank(string name, int capacity) : base(name)
    {
        this.capacity = capacity;
    }

    public string AddToTank(int amount)
    {
        if (amount < 0)
        {
            return $"säiliön {name} tilaa ei muutettu";
        }
        if (amount > capacity - this.amount)
        {
            throw new Exception($"lisättävä määärä ({amount}) ylittää säiliön {name} kapasiteetin");
        }

        this.amount += amount;

        if (this.amount == capacity)
        {
            return $"säiliöön {name} lisättiin {amount} yksikköä,n säiliö on täynnä";
        }

        return $"säiliöön {name} lisättiin {amount} yksikköä"; 
    }

    public int GetAmount()
    {
        return amount;
    }

    public string RemoveFromTank(int amount)
    {
        if (amount < 0)
        {
            return $"säiliön {name} tilaa ei muuuttu";
        }

        if (amount > this.amount)
        {
            throw new Exception($"poistettava määrä ({amount}) on suurempi kuin säiliön {name} nykyinen määrä");
        }

        this.amount -= amount;

        if (this.amount == 0)
        {
            return $"säiliöstä {name} poistettiin {amount} yksillöä, säiliö on tyhjä";
        }

        return $"säiliöstä {name} poistettiin {amount} yksikköä";
    }

    public void ClearTank()
    {
        amount = 0;
    }

    public override string ToString()
    {
        return $"säiliö {name}: kapasiteetti: {capacity}, nestettä: {amount}";
    }
}
