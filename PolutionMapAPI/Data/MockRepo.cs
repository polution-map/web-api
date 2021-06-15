using System.Runtime.Serialization;
using PolutionMapAPI.Models;
using System;
using System.Collections.Generic;

namespace PolutionMapAPI.Data
{
    public class MockRepo : IMeasurmentsRepo
    {
        private readonly List<Measurement> measurments = new List<Measurement>
        {
            new Measurement
            {
                Id = 0,
                Latitude = 53.222923278808594,
                Longitude = 56.87229206431822,
                Properties = new (15, 145),
                TimeStamp = DateTime.Now.AddDays(-1)
            },
            new Measurement
            {
                Id = 1,
                Latitude = 53.222923278808594,
                Longitude = 56.87229206431822,
                Properties = new (15, 145),
                TimeStamp = DateTime.Now.AddDays(-1)
            }
        };
        public void CreateNewMeasurments(Measurement newMeasure)
        {
            measurments.Add(newMeasure);
        }

        public IEnumerable<Measurement> GetAllMeasurments()
        {
            return measurments;
        }
    }
}