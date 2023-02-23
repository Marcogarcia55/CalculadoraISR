using Xunit;
using ISR.Core.Entities;
using ISR.Core.Services;

namespace ISR.Test
{
    public class ISRServiceShould
    {
        [Fact]
        public void ProcessISR()
        {
            // Arrange
            
            var expectedType = 107.51980799999998;
                
            var user = new user { salary = 5600};
        
            var sut = new ISRServices();
        
            // Act	
            
            var result = sut.ProcessIsr(user);
            
            // Assert
            
            Assert.Equal(expectedType, result.isrTotal);
        }
        [Fact]
        public void ProcessISR2()
        {
            var expectedType1 = 517.46936;
            var user1 = new user { salary = 13500};
            var sut = new ISRServices();

            var result1 = sut.ProcessIsr(user1);
            Assert.Equal(expectedType1, result1.isrTotal);


        }
        [Fact]
        public void ProcessISR3()
        {
            var expectedType2 = 6275.822496;
            var user2= new user { salary = 87900};
            var sut = new ISRServices();

            var result2 = sut.ProcessIsr(user2);
            Assert.Equal(expectedType2, result2.isrTotal);

        }
        [Fact]
        public void ProcessISR4()
        {
            var expectedType3 = 10069.0544;
            var user3 = new user { salary = 120400};
            var sut = new ISRServices();

            var result3 = sut.ProcessIsr(user3);
            Assert.Equal(expectedType3, result3.isrTotal);

        }
        [Fact]
        public void ProcessISR5()
        {
            var expectedType4 = 13685.319935999998;
            var user4 = new user { salary = 142050};
            var sut = new ISRServices();

            var result4 = sut.ProcessIsr(user4);
            Assert.Equal(expectedType4, result4.isrTotal);


        }
        [Fact]
        public void ProcessISR6()
        {
            var expectedType5 = 21346.321824;
            var user5 = new user { salary = 180900};
            var sut = new ISRServices();

            var result5 = sut.ProcessIsr(user5);
            Assert.Equal(expectedType5, result5.isrTotal);

            
        }
        [Fact]
        public void ProcessISR7()
        {
            var expectedType6 = 62857.439648;
            var user6 = new user { salary = 370522};
            var sut = new ISRServices();

            var result6 = sut.ProcessIsr(user6);
            Assert.Equal(expectedType6, result6.isrTotal);

            
        }
        [Fact]
        public void ProcessISR8()
        {
            var expectedType7 = 152900.437;
            var sut = new ISRServices();
            var user7 = new user { salary = 700890};
            var result7 = sut.ProcessIsr(user7);
            Assert.Equal(expectedType7, result7.isrTotal);
            
        }
        [Fact]
        public void ProcessISR9()
        {
            var expectedType8 = 31648.73719999999;
            var user8 = new user { salary = 1000000};
            var sut = new ISRServices();
            var result8 = sut.ProcessIsr(user8);
            Assert.Equal(expectedType8, result8.isrTotal);

        }
        [Fact]
        public void ProcessISR10()
        {
            var expectedType9 = 713155.123;
            var user9 = new user { salary = 2400000};
            var sut = new ISRServices();
            var result9 = sut.ProcessIsr(user9);
            Assert.Equal(expectedType9, result9.isrTotal);

        }
        [Fact]
        public void ProcessISR11()
        {
            var expectedType10 = 1608173.7145;
            var user10 = new user { salary = 5000000};
            var sut = new ISRServices();
            var result10 = sut.ProcessIsr(user10);
            Assert.Equal(expectedType10, result10.isrTotal);

        }
    }
}