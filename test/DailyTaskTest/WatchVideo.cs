using DailyTaskTest.Share;
using Ray.BiliBiliTool.Console;
using Xunit;

namespace WatchVideoTest
{
    public class WatchVideo
    {
        [Fact]
        public void Test1()
        {
            Program.PreWorks(new string[] { });

            var dailyTask = DailyTaskBuilder.Build();

            string aid = dailyTask.GetRandomVideo();
            dailyTask.WatchVideo(aid);

            Assert.True(true);
        }
    }
}
