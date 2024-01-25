﻿using System;
using AutoFixture;
using FluentAssertions;
using Vonage.Meetings.UpdateApplication;
using Vonage.Test.Common.Extensions;
using Xunit;

namespace Vonage.Test.Meetings.UpdateApplication;

public class RequestTest
{
    private readonly Guid themeId;

    public RequestTest()
    {
        var fixture = new Fixture();
        this.themeId = fixture.Create<Guid>();
    }

    [Fact]
    public void GetEndpointPath_ShouldReturnApiEndpoint() =>
        UpdateApplicationRequest.Parse(this.themeId)
            .Map(request => request.GetEndpointPath())
            .Should()
            .BeSuccess("/v1/meetings/applications");

    [Fact]
    public void Parse_ShouldReturnFailure_GivenThemeIdIsEmpty() =>
        UpdateApplicationRequest.Parse(Guid.Empty)
            .Should()
            .BeParsingFailure("DefaultThemeId cannot be empty.");

    [Fact]
    public void Parse_ShouldReturnSuccess_GivenValuesAreProvided() =>
        UpdateApplicationRequest.Parse(this.themeId)
            .Should()
            .BeSuccess(request => request.DefaultThemeId.Should().Be(this.themeId));
}