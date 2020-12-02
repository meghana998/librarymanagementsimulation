﻿using NUnit.Framework;
using System;
using Moq;
using AuthorizationService.Repository;
using AuthorizationService.Providers;
using AuthorizationService.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using AuthorizationService;

namespace NUnitTestAuthorizationService
{
    class TokenController_GetJsonWebToken_Test
    {

        public string token_not_null;
        public string token_null;
        private User user;

        [SetUp]
        public void Setup()
        {
            token_not_null = "xhagssbmfbdmsdjfbkalalasknasncjafh";
            token_null = null;

        }

        [Test]
        public void controller_getJsonWebToken_correctInput_tokenNotnull()
        {
            var mock = new Mock<IAuthProvider>();
            mock.Setup(p => p.GetJsonWebToken(user)).Returns(token_not_null);
            var res = new TokenController(mock.Object);
            var data = res.GenerateJSONWebToken(user) as OkObjectResult;
            Assert.AreEqual(200, data.StatusCode);
        }
        [Test]
        public void controller_getJsonWebToken_IncorrectToken_tokenNull()
        {
            var mock = new Mock<IAuthProvider>();
            mock.Setup(p => p.GetJsonWebToken(user)).Returns(token_null);
            var res = new TokenController(mock.Object);
            var data = res.GenerateJSONWebToken(user) as BadRequestObjectResult;
            Assert.AreEqual(400, data.StatusCode);
        }

    }
}
