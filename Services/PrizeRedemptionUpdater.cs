using Data;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Services
{
    public class PrizeRedemptionUpdater : IPrizeRedemptionUpdater
    {
        private readonly DatabaseContext context;
        protected DbSet<PrizeRedemptionEntity> DbSet;

        public PrizeRedemptionUpdater(DatabaseContext context)
        {
            this.context = context;
            DbSet = context.Set<PrizeRedemptionEntity>();
        }

        public async Task<int> PostAsync(PrizeRedemptionEntity entity)
        {
            await DbSet.AddAsync(entity);

            int result = 0;

            try
            {
                result = await context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
              
                throw e;
            }

            return result;
        }
    }
}