using Contents;
using Loading.Packing;

namespace Loading.HardcodedLoaders
{
    partial class HardcodedLoader : LoaderBase
    {
        public HardcodedLoader(Bundle bundle, GameConfiguration gameConfiguration) : base(bundle, gameConfiguration)
        {
        }

        private void AddEntity(Entity entity)
        {
            GameConfiguration.Entities.Add(entity);
        }

        public override void Load()
        {
            LoadStatuses();
            LoadOpening();
            LoadTalks();
            LoadScheduleDialogs();
            LoadSchedules();
            LoadEndings();
        }
    }
}
