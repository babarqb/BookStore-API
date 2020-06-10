// ***********************************************************************
// Assembly         : BookStore-API
// Author           : babarqb
// Created          : 06-09-2020
//
// Last Modified By : babarqb
// Last Modified On : 06-09-2020
// ***********************************************************************
// <copyright file="HomeController.cs" company="BookStore-API">
//     Copyright (c) memobiles.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BookStore_API.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_API.Controllers
{
    /// <summary>
    /// Class HomeController. Implements the <see cref="Microsoft.AspNetCore.Mvc.ControllerBase"/>
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase"/>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly ILoggerService _loggerService;
        public HomeController(ILoggerService loggerService) { this._loggerService = loggerService; }
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        [HttpGet]
        public IEnumerable<string> Get() { return new string[] { "value1", "value2" }; }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>System.String.</returns>
        [HttpGet("{id}")]
        public string Get(int id) { return "value"; }

        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        [HttpPost]
        public void Post([FromBody] string value) { }


        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }


        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
