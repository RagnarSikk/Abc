﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra {
    [TestClass]
    public class DbInitializerTests : ClassTests<object> {
        //static internal protected void addSet<T>(IEnumerable<T> set, DbContext db) where T : PeriodData
        //{
        //    try
        //    {
        //        db?.AddRange(set);
        //        db?.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        Log.Exception(e);
        //        rollBack(db);
        //        addItems(set, db);
        //    }
        //}
        //static internal protected void addItems<T>(IEnumerable<T> set, DbContext db) where T : PeriodData
        //{
        //    foreach (var e in set)
        //        addItem(e, db);
        //}
        //static internal protected void addItem<T>(T item, DbContext db) where T : PeriodData
        //{
        //    try
        //    {
        //        db?.Add(item);
        //        db?.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        Log.Exception(e);
        //        rollBack(db);
        //        try
        //        {
        //            db?.Update(item);
        //            db?.SaveChanges();
        //        }
        //        catch (Exception e1)
        //        {
        //            Log.Exception(e1);
        //            rollBack(db);
        //        }
        //    }
        //}
        //static internal protected void rollBack(DbContext db)
        //{
        //    var changedEntries = db.ChangeTracker.Entries()
        //        .Where(x => x.State != EntityState.Unchanged).ToList();
        //    foreach (var entry in changedEntries)
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Modified:
        //                entry.CurrentValues.SetValues(entry.OriginalValues);
        //                entry.State = EntityState.Unchanged;
        //                break;
        //            case EntityState.Added:
        //                entry.State = EntityState.Detached;
        //                break;
        //            case EntityState.Deleted:
        //                entry.State = EntityState.Unchanged;
        //                break;
        //        }
        //    }
        //}
    }
}
