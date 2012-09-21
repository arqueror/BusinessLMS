using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BusinessLMS.Models.Mapping;

namespace BusinessLMS.Models
{
    public class BusinessLMSContext : DbContext
    {
        static BusinessLMSContext()
        {
            Database.SetInitializer<BusinessLMSContext>(null);
        }

		public BusinessLMSContext()
			: base("Name=BusinessLMSContext")
		{
		}

        public DbSet<Area> Areas { get; set; }
        public DbSet<CompletedStep> CompletedSteps { get; set; }
        public DbSet<ContactFollowup> ContactFollowups { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Dream> Dreams { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<IBO> IBOs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Timeframe> Timeframes { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ZIPCode> ZIPCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new CompletedStepMap());
            modelBuilder.Configurations.Add(new ContactFollowupMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new ContactTypeMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DreamMap());
            modelBuilder.Configurations.Add(new GoalMap());
            modelBuilder.Configurations.Add(new IBOMap());
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new StepMap());
            modelBuilder.Configurations.Add(new TimeframeMap());
            modelBuilder.Configurations.Add(new ToolMap());
            modelBuilder.Configurations.Add(new ZIPCodeMap());
        }
    }
}
