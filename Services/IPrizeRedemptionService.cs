using Model;

namespace Services
{
    public interface IPrizeRedemptionService
    {
        Task<int> PostAsync(PrizeRedemptionRequest request);

    }
}