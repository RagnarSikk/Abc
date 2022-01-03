//using Abc.Infra;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Conventions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace Abc.Tests.Infra
//{
//    [TestClass]
//    public class ShopDbContextTests : ClassTests<DbContext>
//    {
//        private class testClass : TrainingDbContext {
//            public testClass(DbContextOptions<TrainingDbContext> o) : base(o) { }
//            public ModelBuilder RunOnModelCreating() {
//                var set = new ConventionSet();
//                var mb = new ModelBuilder(set);
//                OnModelCreating(mb);

//                return mb;
//            }

//        }
//        protected override object createObject() => new InMemoryTrainingDbContext().TrainingDb;
//        [TestMethod] public void BasketsTest() => isProperty<DbSet<BasketData>>();
//        [TestMethod] public void BasketItemsTest() => isProperty<DbSet<BasketItemData>>();
//        [TestMethod] public void BrandsTest() => isProperty<DbSet<BrandData>>();
//        [TestMethod] public void BuyersTest() => isProperty<DbSet<BuyerData>>();
//        [TestMethod] public void CatalogsTest() => isProperty<DbSet<CatalogData>>();
//        [TestMethod] public void OrdersTest() => isProperty<DbSet<OrderData>>();
//        [TestMethod] public void OrderItemsTest() => isProperty<DbSet<OrderItemData>>();
//        [TestMethod] public void ProductsTest() => isProperty<DbSet<ProductData>>();
//        [TestMethod] public void InitializeTablesTest() {
//            var options = new DbContextOptionsBuilder<ShopDbContext>().UseInMemoryDatabase("TestDb").Options;
//            var builder = new testClass(options).RunOnModelCreating();
//            testEntity<ProductData>(builder);
//            testEntity<BasketData>(builder);
//            testEntity<BasketItemData>(builder);
//            testEntity<BrandData>(builder);
//            testEntity<BuyerData>(builder);
//            testEntity<CatalogData>(builder);
//            testEntity<OrderData>(builder);
//            testEntity<OrderItemData>(builder);
//        }
//        private void testEntity<T>(ModelBuilder b) {
//            var name = typeof(T).FullName ?? string.Empty;
//            var entity = b.Model.FindEntityType(name);
//            Assert.IsNotNull(entity, name);
//        }
//    }
//}
