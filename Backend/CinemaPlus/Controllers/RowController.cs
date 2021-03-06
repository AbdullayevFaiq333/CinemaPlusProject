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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var rows = await _rowService.GetAllRowAsync(id);
            var rowsDto = new List<RowDto>();
            foreach (var row in rows)
            {
                var seatsDto = new List<SeatDto>();
                var seatDto = new SeatDto();
                var rowDto = new RowDto();
                foreach (var seat in row.Seats)
                {
                    if (seat.RowId == row.Id)
                    {
                        seatDto = new SeatDto
                        {
                            Id = seat.Id,
                            SeatNumber = seat.SeatNumber,
                            Buyed=seat.Buyed,
                            RowId = seat.RowId
                        };
                    }
                    seatsDto.Add(seatDto);
                }
                rowDto = new RowDto
                {
                    Id = row.Id,
                    HallId = row.HallId,
                    NumberRow = row.NumberRow,
                    Seats = seatsDto
                };
                rowsDto.Add(rowDto);
            }
            return Ok(rowsDto);
        }
    }
}
