using System;

public class Cheetah : Animal
{
    public override int Speed
    {
        get
        {
            return 100;
        }
    }

    public override string GetName()
    {
        return "cheetah";
    }
    //public int CompareTo(Animal other)
    //{
    //    return this.Speed.CompareTo(other.Speed);
    //}
}
