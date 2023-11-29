using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class PlantsTests
    {
        [Test]
        public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            Plant[] plants = new Plant[] { };

            // Act
            string result = Plants.GetFastestGrowing(plants);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
        {
            // Arrange
            Plant[] plants = new Plant[] { new Plant("Rose", 15.5) };

            // Act
            string result = Plants.GetFastestGrowing(plants);

            // Assert
            Assert.That(result, Is.EqualTo("Rose -> 15.50"));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
        {
            // Arrange
            Plant[] plants = new Plant[]
            {
                new Plant("Sunflower", 10.2),
                new Plant("Rose", 15.5),
                new Plant("Tulip", 8.0),
                new Plant("Daisy", 12.8)
            };

            // Act
            string result = Plants.GetFastestGrowing(plants);

            // Assert
            Assert.That(result, Is.EqualTo("Rose -> 15.50\nDaisy -> 12.80\nSunflower -> 10.20"));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
        {
            // Arrange
            Plant[] plants = new Plant[]
            {
                new Plant("sunflower", 10.2),
                new Plant("Rose", 15.5),
                new Plant("TULIP", 8.0),
                new Plant("DAISY", 12.8)
            };

            // Act
            string result = Plants.GetFastestGrowing(plants);

            // Assert
            Assert.That(result, Is.EqualTo("Rose -> 15.50\nDAISY -> 12.80\nsunflower -> 10.20"));
        }
    }

    public class Plant
    {
        public string Name { get; }
        public double GrowthRate { get; }

        public Plant(string name, double growthRate)
        {
            Name = name;
            GrowthRate = growthRate;
        }
    }

    public class Plants
    {
        public static string GetFastestGrowing(Plant[] plants)
        {
            if (plants.Length == 0)
            {
                return string.Empty;
            }

            Array.Sort(plants, (p1, p2) => p2.GrowthRate.CompareTo(p1.GrowthRate));

            List<string> result = new List<string>();
            foreach (var plant in plants)
            {
                result.Add($"{plant.Name} -> {plant.GrowthRate:F2}");
            }

            return string.Join("\n", result);
        }
    }
}
