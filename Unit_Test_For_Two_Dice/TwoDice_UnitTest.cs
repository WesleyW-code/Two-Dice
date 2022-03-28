using Microsoft.VisualStudio.TestTools.UnitTesting;
using Two_Dice;
using System.IO;
using System;

namespace Unit_Test_For_Two_Dice
{
    [TestClass]
    public class TwoDice_UnitTest
    {
        [TestMethod]
        public void Single_Output()
        {
            //Arranging the data to test
            var Dices = new TwoDice();
            // My test input.
            var Input = "3 3";
            // What is supposed to be outputted.
            var Expected_Output = "4";

            // To redirect output so you can capture it in a unit test, call Console.SetOut() and pass in a StringWriter object, like this:
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Likewise, to pass in fake console input from a unit test, call Console.SetIn() and pass in a StringReader object, like this:
            var stringReader = new StringReader(Input);
            Console.SetIn(stringReader);

            //Acting with the data.
            TwoDice.Main();

            //Assert / Verify if the test runs correctly.
            var output = stringWriter.ToString();
            Assert.AreEqual($"{Expected_Output}\r\n", output);

            /*Notice that stringWriter.ToString() returns a single string. All of the output, including the newlines, are captured in this single string. You can either assert against the single string, with newline delimiters (\r\n on Windows), or split the string and assert each line individually, like this:

            //assert
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Enter Integers: ", outputLines[0]);
            Assert.AreEqual($"{Expected_Output}", outputLines[1]);
            */
        }
        [TestMethod]
        public void Multiple_Outputs()
        {
            //Arranging the data to test
            var Dices = new TwoDice();
            // My test input.
            var Input = "3 4";
            // What is supposed to be outputted.
            var Expected_Output = "4\r\n5";

            // To redirect output so you can capture it in a unit test, call Console.SetOut() and pass in a StringWriter object, like this:
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Likewise, to pass in fake console input from a unit test, call Console.SetIn() and pass in a StringReader object, like this:
            var stringReader = new StringReader(Input);
            Console.SetIn(stringReader);

            //Acting with the data.
            TwoDice.Main();

            //Assert / Verify if the test runs correctly.
            var output = stringWriter.ToString();
            Assert.AreEqual($"{Expected_Output}\r\n", output);

            /*Notice that stringWriter.ToString() returns a single string. All of the output, including the newlines, are captured in this single string. You can either assert against the single string, with newline delimiters (\r\n on Windows), or split the string and assert each line individually, like this:

            //assert
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Enter Integers: ", outputLines[0]);
            Assert.AreEqual($"{Expected_Output}", outputLines[1]);
            */
        }
    }
}