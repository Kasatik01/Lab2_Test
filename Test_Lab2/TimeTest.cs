using Lab2;

namespace Test_Lab2
{
    public class TimeTest
    {
        [Fact]
        public void setHour_throw_exception_negative()
        {
            // arrange
            Time hour = new Time();
            int h = -1;
            //assert
            Assert.ThrowsAny<Exception>(() => hour.setHour(h));
        }

        [Fact]
        public void setHour_throw_exception_big()
        {
            // arrange
            Time hour = new Time();
            int h = 24;
            //assert
            Assert.ThrowsAny<Exception>(() => hour.setHour(h));
        }

        [Fact]
        public void setHour_zero()
        {
            // arrange
            Time hour = new Time();
            int h = 0;

            //act
            hour.setHour(h);

            //assert
            Assert.Equal(0, hour.Hour);
        }

        [Fact]
        public void setHour_four()
        {
            // arrange
            Time hour = new Time();
            int h = 4;

            //act
            hour.setHour(h);

            //assert
            Assert.Equal(4,hour.Hour);
        }

        [Fact]
        public void setMinute_throw_exception_negative()
        {
            // arrange
            Time minute = new Time();
            int m = -1;
            //assert
            Assert.ThrowsAny<Exception>(() => minute.setHour(m));
        }

        [Fact]
        public void setMinute_throw_exception_big()
        {
            // arrange
            Time minute = new Time();
            int m = 60;
            //assert
            Assert.ThrowsAny<Exception>(() => minute.setHour(m));
        }

        [Fact]
        public void setMinute_zero()
        {
            // arrange
            Time minute = new Time();
            int m = 0;

            //act
            minute.setMinute(m);

            //assert
            Assert.Equal(0, minute.Minute);
        }

        [Fact]
        public void setMinute_ten()
        {
            // arrange
            Time minute = new Time();
            int m = 10;

            //act
            minute.setMinute(m);

            //assert
            Assert.Equal(10, minute.Minute);
        }

        [Fact]
        public void setSecond_throw_exception_negative()
        {
            // arrange
            Time second = new Time();
            int s = -1;
            //assert
            Assert.ThrowsAny<Exception>(() => second.setHour(s));
        }

        [Fact]
        public void setSecond_throw_exception_big()
        {
            // arrange
            Time second = new Time();
            int s = 61;
            //assert
            Assert.ThrowsAny<Exception>(() => second.setHour(s));
        }

        [Fact]
        public void setSecond_zero()
        {
            // arrange
            Time hour = new Time();
            int h = 0;

            //act
            hour.setSecond(h);

            //assert
            Assert.Equal(0, hour.Hour);
        }

        [Fact]
        public void setSecond_ten()
        {
            // arrange
            Time second = new Time();
            int s = 10;

            //act
            second.setSecond(s);

            //assert
            Assert.Equal(10, second.Second);
        }
    }
}