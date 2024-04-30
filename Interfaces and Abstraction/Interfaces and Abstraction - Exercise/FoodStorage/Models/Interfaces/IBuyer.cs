namespace FoodStorage.Models.Interfaces
{
    public interface IBuyer
    {
        int Food { get; }
        string Name { get; }
        public void BuyFood();
    }
}
