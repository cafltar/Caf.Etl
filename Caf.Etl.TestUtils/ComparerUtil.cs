using Caf.Etl.Models.CosmosDBSqlApi.Core;
using Caf.Etl.Models.CosmosDBSqlApi.Measurement;
using Caf.Etl.Models.CosmosDBSqlApi.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caf.Etl.TestUtils
{
    public static class ComparerUtil
    {
        public static bool AreVegetationSamplesRoughlyEqual(
            List<VegetationSample> firsts,
            List<VegetationSample> seconds)
        {
            foreach(var first in firsts)
            {
                try
                {
                    var second = seconds.SingleOrDefault(s => s.Id == first.Id);

                    if (second == null)
                        return false;

                    if (!IsVegetationSampleRoughlyEqual(first, second))
                        return false;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }

            return true;
        }

        public static bool IsVegetationSampleRoughlyEqual(
            VegetationSample first,
            VegetationSample second)
        {
            return first.HarvestYear == second.HarvestYear &&
                first.PlantName == second.PlantName &&
                IsSampleRoughlyEqual((SampleV2)first, (SampleV2)second);
        }

        public static bool AreSamplesRoughlyEqual(
            List<SampleV2> firsts,
            List<SampleV2> seconds)
        {
            foreach(var first in firsts)
            {
                try
                {
                    var second = seconds.SingleOrDefault(s => s.Id == first.Id);

                    if (second == null)
                        return false;

                    if (!IsSampleRoughlyEqual(first, second))
                        return false;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }

            return true;
        }

        public static bool IsSampleRoughlyEqual(
            SampleV2 first,
            SampleV2 second)
        {
            return first._rid == second._rid &&
                   first._self == second._self &&
                   first._etag == second._etag &&
                   first._attachments == second._attachments &&
                   EqualityComparer<int?>.Default.Equals(first._ts, second._ts) &&
                   first.PartitionKey == second.PartitionKey &&
                   first.Id == second.Id &&
                   first.Type == second.Type &&
                   first.Name == second.Name &&
                   first.Schema == second.Schema &&
                   first.Project == second.Project &&
                   first.AreaOfInterest == second.AreaOfInterest &&
                   EqualityComparer<LocationV2>.Default.Equals(first.Location, second.Location) &&
                   EqualityComparer<DateTime?>.Default.Equals(first.DateTime, second.DateTime) &&
                   AreMeasurementsRoughlyEqual(first.Measurements, second.Measurements);
        }
        public static bool AreMeasurementsRoughlyEqual(
            List<MeasurementV2> firsts, 
            List<MeasurementV2> seconds)
        {
            foreach(var first in firsts)
            {
                if (first.Id != null)
                {
                    try
                    {
                        var second = seconds.SingleOrDefault(m => m.Id == first.Id);

                        if (second == null)
                            return false;

                        if (!IsMeasurementRoughlyEqual(first, second))
                            return false;
                    }
                    catch (InvalidOperationException e)
                    {
                        throw e;
                    }
                }
                else if (first.Name != null)
                {
                    try
                    {
                        var second = seconds.SingleOrDefault(m => m.Name == first.Name);

                        if (second == null)
                            return false;

                        if (!IsMeasurementRoughlyEqual(first, second))
                            return false;
                    }
                    catch (InvalidOperationException e)
                    {
                        throw e;
                    }
                }
                else { return false; }
            }

            return true;
        }

        public static bool IsMeasurementRoughlyEqual(
            MeasurementV2 first, 
            MeasurementV2 second)
        {
            return first.AreaOfInterest == second.AreaOfInterest
                && first.Location == second.Location
                && first.PartitionKey == second.PartitionKey
                && first.PhysicalQuantities.Count == second.PhysicalQuantities.Count
                && ArePhysicalQuantityV2RoughlyEqual(first.PhysicalQuantities[0],second.PhysicalQuantities[0])
                && first.Project == second.Project
                && first.Schema == second.Schema
                && first.TimestepSec == second.TimestepSec
                && first.Type == second.Type
                && first._attachments == second._attachments
                && first._etag == second._etag
                && first._rid == second._rid
                && first._self == second._self
                && first._ts == second._ts;
        }

        public static bool ArePhysicalQuantityV2RoughlyEqual(
            PhysicalQuantityV2 first,
            PhysicalQuantityV2 second)
        {
            return first.QCValues == second.QCValues
                && first.QualityControlId == second.QualityControlId
                && first.SourceID == second.SourceID
                && first.Unit == second.Unit
                && first.Value == second.Value;
        }
    }
}
