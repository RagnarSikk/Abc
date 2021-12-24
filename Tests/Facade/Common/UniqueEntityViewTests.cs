﻿using Abc.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Facade.Common {

    [TestClass]
    public class UniqueEntityViewTests : AbstractTests<PeriodView> {

        private class testClass : UniqueEntityView { }
        [TestMethod] public void IdTest() => isRequiredProperty<string>("Id");
        [TestMethod]
        public void GetIdTest() {
            var o = obj as UniqueEntityView;
            areEqual(o.Id, o.GetId());
        }
        [TestMethod]
        public void HasDefaultIdTest() {
            var o = obj as UniqueEntityView;
            var s = Guid.TryParse(o.Id, out _);
            isTrue(s);
        }
        protected override object createObject() => new testClass();
    }
}