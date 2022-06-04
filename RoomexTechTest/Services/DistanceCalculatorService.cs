﻿using RoomexTechTestApi.Model;
using RoomexTechTestApi.Services.Calculator;
using RoomexTechTestApi.Services.MeasurementUnit;

namespace RoomexTechTestApi.Services
{
    /// <summary>
    /// Service for performing the calculation between two points.
    /// </summary>
    public class DistanceCalculatorService
    {
        /// <summary>
        /// Calculates the distance and performs any necessary transforms.
        /// </summary>
        /// <param name="body">The body on which the distance shall be calculated between two points.</param>
        /// <returns>The calculated distance.</returns>
        public double Process(Body body)
        {
            CalculatorFactoryBase factory = new DefaultFactory();

            if (string.Equals(body.Form, Cosmos.BodyShape.Sphere))
            {
                factory = new SpheroidCalculatorFactory(Cosmos.Radius.Earth);
            }

            ICalculator calculator = factory.GetCalculator(Cosmos.CalculationMethod.Pythagora);
            double metricResult = calculator.Process(body.Start, body.End);
            IUnitConverter converter = new MetricConverter();

            return converter.Convert(metricResult, body.Unit);
        }
    }
}