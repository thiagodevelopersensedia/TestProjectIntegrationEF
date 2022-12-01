using Model;

namespace Services
{
    public interface IPrizeRedemptionUpdater
    {
        Task<int> PostAsync(PrizeRedemptionEntity request);
    }
}