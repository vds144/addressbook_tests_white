﻿using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace addressbook_tests_white
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {

            List<GroupData> oldGroups = app.Groups.GetGroupsList();

            GroupData newGroup = new GroupData()
            {
                Name = "white"
            };

             app.Groups.Add(newGroup);

             List<GroupData> newGroups = app.Groups.GetGroupsList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
           newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
