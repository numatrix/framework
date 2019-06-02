namespace Matrix.Framework.Business
{
    public class ServiceContext : IServiceContext
    {
        public string Registry { get; set; }

        public string Directory { get; set; }

        public string Configurator { get; set; }

        public string Journal { get; set; }

        public string Postman { get; set; }
    }
}