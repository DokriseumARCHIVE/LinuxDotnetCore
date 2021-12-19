namespace ConsoleApplication.Vehicles
{
    public class Car
    {
        
        private int ps;
        private string brand;
        private string model;
        private int damage;
        private int passengers;

        public void setPS(int ps)
        {
            this.ps = ps;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setDamageInPercent(int damage)
        {
            this.damage = damage;
            if (damage > 100)
            {
                throw new System.ArgumentException("wrong input: not higher as 100%");
            }
            if (damage < 0)
            {
                throw new System.ArgumentException("wrong input: not lower as 0%");
            }
        }

        public void setPassengers(int passengers)
        {
            this.passengers = passengers;
        }

        public int getPS()
        {
            return this.ps;
        }

        public string getBrand()
        {
            return this.brand;
        }

        public string getModel()
        {
            return this.model;
        }

        public int getDamageInPercent()
        {
            return this.damage;
        }

        public int getPassengers()
        {
            return this.passengers;
        }
    }
}