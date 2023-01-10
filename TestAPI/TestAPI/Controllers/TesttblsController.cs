using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models.Domain;
using TestAPI.Repositories;


namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesttblsController : ControllerBase
    {
        //private readonly TestdbContext _context;
        public readonly ITesttbleRepository _Repository;
        private readonly IMapper _Mapper;

        public TesttblsController(ITesttbleRepository testtbleRepository, IMapper Mapper)
        {
            _Repository = testtbleRepository;
            _Mapper = Mapper;
        }

        

        // GET: api/Testtbls
        [HttpGet]
        public async Task<IActionResult> GetTesttbls()
        {      
            var tt = await _Repository.GetTesttblsAsync();

            //return Testtbl DTO 

            //var ttDTO = new List<Models.DTO.Testtbl>();
            //tt.ToList().ForEach(Testtbl =>
            //{
            //    var ttdto = new Models.DTO.Testtbl()
            //    {
            //        Id = Testtbl.Id,
            //        FirstName = Testtbl.FirstName,
            //        LastName = Testtbl.LastName,
            //        City = Testtbl.City,
            //        State = Testtbl.State,
            //        Country = Testtbl.Country,
            //        ContactNumber = Testtbl.ContactNumber,
            //    };
            //    ttDTO.Add(ttdto);
            //});

            var ttDTO = _Mapper.Map<List<Models.DTO.Testtbl>>(tt);

            return Ok(ttDTO);
        }

       
    }
}
