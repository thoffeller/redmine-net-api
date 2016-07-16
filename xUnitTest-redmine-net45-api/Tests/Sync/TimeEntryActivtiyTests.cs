﻿/*
   Copyright 2011 - 2016 Adrian Popescu.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Redmine.Net.Api.Types;
using Xunit;

namespace xUnitTestredminenet45api
{
	[Trait("Redmine-Net-Api", "TimeEntryActivities")]
	[Collection("RedmineCollection")]
    public class TimeEntryActivityTests
    {
        public TimeEntryActivityTests(RedmineFixture fixture)
        {
            this.fixture = fixture;
        }

        private readonly RedmineFixture fixture;

        [Fact, Order(1)]
        public void Should_Get_All_TimeEntryActivities()
        {
            const int NUMBER_OF_TIME_ENTRY_ACTIVITIES = 3;

            var timeEntryActivities = fixture.RedmineManager.GetObjects<TimeEntryActivity>(null);

            Assert.NotNull(timeEntryActivities);
            Assert.All(timeEntryActivities, t => Assert.IsType<TimeEntryActivity>(t));
            Assert.True(timeEntryActivities.Count == NUMBER_OF_TIME_ENTRY_ACTIVITIES,
                "Time entry activities count ( "+ timeEntryActivities.Count +" ) != " + NUMBER_OF_TIME_ENTRY_ACTIVITIES);
        }
    }
}