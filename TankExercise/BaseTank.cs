using System;

namespace TankExercise
{
    class BaseTank
    {
        protected string name;

        public BaseTank(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name; 
        }
    }
}