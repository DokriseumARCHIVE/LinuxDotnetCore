namespace ConsoleApplication.Vehicles
{
    public interface Vehicle
    {
        void setPS(int ps);
        void setBrand(string brand);
        void setModel(string model);
        void setDamageInPercent(int damage);
        int getPS();
        string getBrand();
        string getModel();
        int getDamageInPercent();
    }
}