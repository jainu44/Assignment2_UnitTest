using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;


namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Analyze_Input15and1and2_ReturnsNotValid()
        {
            //Arrange
            int edge1 = 15;
            int edge2 = 1;
            int edge3 = 2;      

            //Act
            string expectedResult = "This Triangle is not a Valid one.";
            string actualResult = TriangleSolver.Analyze(edge1, edge2, edge3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input3and100and2_ReturnsNotValid()
        {
            //Arrange
            int edge1 = 3;
            int edge2 = 100;
            int edge3 = 2;

            //Act
            string expectedResult = "This Triangle is not a Valid one.";
            string actualResult = TriangleSolver.Analyze(edge1, edge2, edge3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input4and4and6_ReturnsIsosceles()
        {
            //Arrange
            int side1 = 4;
            int side2 = 4;
            int side3 = 6;     

            //Act
            string expectedResult = "This is a Isosceles Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input20and20and25_ReturnsIsosceles()
        {
            //Arrange
            int side1 = 20;
            int side2 = 20;
            int side3 = 25;

            //Act
            string expectedResult = "This is a Isosceles Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input3and4and5_ReturnsScalene()
        {
            //Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;      

            //Act
            string expectedResult = "This is a Scalene Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input11and12and13_ReturnsScalene()
        {
            //Arrange
            int side1 = 11;
            int side2 = 12;
            int side3 = 13;

            //Act
            string expectedResult = "This is a Scalene Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input7and7and7_ReturnsEquilateral()
        {
            //Arrange
            int side1 = 7;
            int side2 = 7;
            int side3 = 7;      

            //Act
            string expectedResult = "This is a Equilateral Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input20and20and20_ReturnsEquilateral()
        {
            //Arrange
            int side1 = 20;
            int side2 = 20;
            int side3 = 20;

            //Act
            string expectedResult = "This is a Equilateral Triangle.";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
