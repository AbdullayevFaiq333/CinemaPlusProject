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
    public class RowController : ControllerBase
    {
        private readonly IRowService _rowService;
        private readonly IMapper _mapper;

        public RowController(IMapper mapper, IRowService rowService)
        {

            _mapper = mapper;
            _rowService = rowService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rows = await _rowService.GetAllRowAsync();
            var rowDto = _mapper.Map<List<RowDto>>(rows);

            return Ok(rowDto);
        }
    }
}
