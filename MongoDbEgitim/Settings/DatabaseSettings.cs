namespace MongoDbEgitim.Settings
{
    public class DatabaseSettings : IDatabaseSetting
    {
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string CustomerCollectionName { get; set; }
        public string OrderCollectionName { get; set; }
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
