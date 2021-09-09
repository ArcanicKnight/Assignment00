using System;
using System.IO;
using Xunit;

namespace Assignment00.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_Tests_2000_for_Leap_Year()
        {
            // Arrange
  			//var stringReader = new StringReader("2000");
            
            // Act
            Program.Main();
			Console.WriteLine("2000");
			//Console.SetIn(stringReader);
            var line = Console.ReadLine(); 
            
            // Assert
            Assert.Equal("yay", line);
        }
    }
}
