using AutoMapper;
using Buisness.Abstract;
using Entity.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffController : ControllerBase
    {
        private readonly ITariffService _tariffService;
        private readonly IMapper _mapper;

        public TariffController(IMapper mapper, ITariffService tariffService)
        {

            _mapper = mapper;
            _tariffService = tariffService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var tariffs = await _tariffService.GetAllTariffAsync(id);
            var tariffDto = _mapper.Map<TariffDto>(tariffs);

            return Ok(tariffDto);
        }
    }
}
