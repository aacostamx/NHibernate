using NHibernate.Cfg;
using NHibernate.Dialect;
using System;

namespace ConfigByCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nhConfig = new Configuration().DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2012Dialect>();
                db.ConnectionStringName = "db";
                db.BatchSize = 100;
            });
            var sessionFactory = nhConfig.BuildSessionFactory();
            Console.WriteLine("NHibernate Configured!");
            Console.ReadKey();
        }
    }
}
