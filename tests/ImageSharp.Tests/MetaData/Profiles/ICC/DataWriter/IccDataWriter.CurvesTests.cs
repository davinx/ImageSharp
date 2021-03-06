﻿// <copyright file="IccDataWriter.CurvesTests.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Tests.Icc
{
    using Xunit;

    public class IccDataWriterCurvesTests
    {
        [Theory]
        [MemberData(nameof(IccTestDataCurves.OneDimensionalCurveTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteOneDimensionalCurve(byte[] expected, IccOneDimensionalCurve data)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteOneDimensionalCurve(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataCurves.ResponseCurveTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteResponseCurve(byte[] expected, IccResponseCurve data, int channelCount)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteResponseCurve(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataCurves.ParametricCurveTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteParametricCurve(byte[] expected, IccParametricCurve data)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteParametricCurve(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataCurves.CurveSegmentTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteCurveSegment(byte[] expected, IccCurveSegment data)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteCurveSegment(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataCurves.FormulaCurveSegmentTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteFormulaCurveElement(byte[] expected, IccFormulaCurveElement data)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteFormulaCurveElement(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataCurves.SampledCurveSegmentTestData), MemberType = typeof(IccTestDataCurves))]
        internal void WriteSampledCurveElement(byte[] expected, IccSampledCurveElement data)
        {
            IccDataWriter writer = CreateWriter();

            writer.WriteSampledCurveElement(data);
            byte[] output = writer.GetData();

            Assert.Equal(expected, output);
        }

        private IccDataWriter CreateWriter()
        {
            return new IccDataWriter();
        }
    }
}
