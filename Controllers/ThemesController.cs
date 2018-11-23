using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmTeacherApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AcmTeacherApi.Controllers
{
    [Route("api/themes")]
    [ApiController]
    public class ThemesController : ApiControllerBase
    {

        private static IEnumerable<Theme> _themes;

        #region [Ctor]

        public ThemesController():base()
        {
            if (_themes == null)
            {
                var themes = new[]
            {
                new Theme { Id=Guid.NewGuid(), Name="Jiu-Jitsu", Description="Jiu Jitsu Classes", Enabled=true },
                new Theme { Id=Guid.NewGuid(), Name="Boxing", Description="Boxing Classes", Enabled=true },
                new Theme { Id=Guid.NewGuid(), Name="Muay Thai", Description="Muay Thai Classes", Enabled=true }
            };

                _themes = themes;
            }

            
        }

        #endregion

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Theme>), 200)]
        public async Task<IActionResult> Get()
        {
           
            return await AsyncHandler(async() => {

                return await Task.Run(()=> Ok(_themes));                

            });

        }


        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(Theme), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get(Guid id)
        {

            return await AsyncHandler(async () => {

                var theme = _themes.FirstOrDefault(x => x.Id == id);
                if (theme != null)
                    return await Task.Run(() => Ok(theme));
                return NotFound();
                
            });

            
        }


        [HttpPost]
        [ProducesResponseType(typeof(Theme), 201)]
        public IActionResult Post([FromBody] Theme model)
        {
            return CreatedAtAction("Get", new { id = model.Id }, model);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        public IActionResult Put(int id, [FromBody] Theme model)
        {
            return Ok(model);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
