﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SimpleIdServer.OAuth.Api.Jwks
{
    [Route(Constants.EndPoints.Jwks)]
    public class JwksController : Controller
    {
        private readonly IJwksRequestHandler _jwksRequestHandler;

        public JwksController(IJwksRequestHandler jwksRequestHandler)
        {
            _jwksRequestHandler = jwksRequestHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var jwks = await _jwksRequestHandler.Get();
            return new OkObjectResult(jwks);
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            await _jwksRequestHandler.Rotate();
            return new OkResult();
        }
    }
}
