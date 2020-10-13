using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPIProject.DTOs;
using FirstAPIProject.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreesController : ControllerBase
    {

        private readonly ITreesRepository _treeRepo;

        public TreesController(ITreesRepository treeRepo)
        {
            _treeRepo = treeRepo;
        }


        // GET: api/<TreesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var newTree = new TreeDto() { Age = 4, Seasons =["Fall", "Spring"], TreeName = "White Oak" };

            return _treeRepo.GetSeasons(newTree);

        }

        // GET api/<TreesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TreesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TreesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TreesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
