using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Metrics;
using API.Models;
using API.Models.ViewModels;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextProcessorController : ControllerBase
    {
        private readonly ITextProcessingService _textProcessingService;
        private readonly IMapper _mapper;

        public TextProcessorController(IMapper mapper, ITextProcessingService textProcessingService)
        {
            _mapper = mapper;
            _textProcessingService = textProcessingService;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessText([FromBody] TextToProcessViewModel date)
        {
            if(String.IsNullOrEmpty(date.DateString))
            {
                return BadRequest();
            }
            var metrics = await Task.Run(() => _textProcessingService.HandleMetrics(date.DateString));

            return Ok(_mapper.Map<IEnumerable<MetricsModel>>(metrics));
        }
    }
    
}