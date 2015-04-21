using Chapter1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Chapter1.Test
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void CanBuildSessionFactory()
        {
            var cfg = new NHibernate.Cfg.Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Student).Assembly);
            cfg.BuildMappings();
            var sessionFactory = cfg.BuildSessionFactory();
        }

        [TestMethod]
        public void CanReadStudentRecord()
        {
            var cfg = new NHibernate.Cfg.Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Student).Assembly);
            cfg.BuildMappings();
            var sessionFactory = cfg.BuildSessionFactory();
            var student = sessionFactory.OpenSession().Get<Student>(new Guid("75079B2F-C837-40D4-8F75-5C75400E6C1E"));

            Assert.IsNotNull(student);
        }
    }
}