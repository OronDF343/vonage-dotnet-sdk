﻿using Vonage.Common.Test.Extensions;
using Vonage.Users.CreateUser;
using Xunit;

namespace Vonage.Test.Unit.Users.CreateUser
{
    public class RequestTest
    {
        [Fact]
        public void GetEndpointPath_ShouldReturnApiEndpoint() =>
            CreateUserRequest
                .Build()
                .Create()
                .Map(request => request.GetEndpointPath())
                .Should()
                .BeSuccess("/v1/users");
    }
}