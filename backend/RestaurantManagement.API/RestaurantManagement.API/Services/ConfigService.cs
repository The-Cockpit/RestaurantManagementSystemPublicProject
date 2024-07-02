using Microsoft.EntityFrameworkCore;
using RestaurantManagement.API.Data;
using RestaurantManagement.API.Dtos;
using RestaurantManagement.API.Interfaces;
using RestaurantManagement.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Humanizer;

namespace RestaurantManagement.API.Services
{
    public class ConfigService : IConfigService
    {
        private readonly DataContext _context;
        private readonly ILogger<ConfigService> _logger;

        public ConfigService(DataContext dataContext, ILogger<ConfigService> logger)
        {
            _context = dataContext;
            _logger = logger;
        }

        public async Task<List<ShiftSelectionDto>> GetShiftSelectionTemplates()
        {
            List<ShiftSelectionTemplate> templates = await _context.ShiftSelectionTemplates.ToListAsync();

            if (templates == null || templates.Count == 0)
            {
                _logger.LogWarning("\n NO AVAILABLE TEMPLATES\n");
            }

            List<ShiftSelectionDto> shiftsDto = templates.Select(shiftSelectionTemplate => new ShiftSelectionDto
            {
                Id = shiftSelectionTemplate.ID,
                Name = shiftSelectionTemplate.Name,
                StartHour = shiftSelectionTemplate.StartHour,
                StartMin = shiftSelectionTemplate.StartMin,
                EndHour = shiftSelectionTemplate.EndHour,
                EndMin = shiftSelectionTemplate.EndMin
            }).ToList();

            return shiftsDto;
        }

        public async Task AddShiftSelectionTemplate(ShiftSelectionDto template)
        {
            if(template.StartHour >= template.EndHour)
            {
                _logger.LogWarning("\nSTART HOUR IS GREATER THEN END HOUR\n");
                return;
            }
            try
            {
                
                ShiftSelectionTemplate templateToInsert = new ShiftSelectionTemplate
                {
                    ID = 0,
                    Name = template.Name,
                    StartHour = template.StartHour,
                    StartMin = template.StartMin,
                    EndHour = template.EndHour,
                    EndMin = template.EndMin,
                };

                await _context.ShiftSelectionTemplates.AddAsync(templateToInsert);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "\nAn error occurred while adding the ShiftSelectionTemplate.\n");
            }
        }

        public async Task DeleteShiftSelectionTemplate(int templateId)
        {
            try
            {
                var template = await _context.ShiftSelectionTemplates
                    .FirstOrDefaultAsync(t => t.ID == templateId);

                if (template != null)
                {
                    _context.ShiftSelectionTemplates.Remove(template);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "\nAn error occurred while removing the ShiftSelectionTemplate.\n");
            }
        }

        public async Task<Tuple<DateTime, DateTime>> GetWeekSettings()
        {
            Config config = await _context.Configs.FirstOrDefaultAsync();

            if(config == null)
            {
                _logger.LogInformation("\n Fetching Config Failed\n");
                return null;
            }
            Tuple<DateTime, DateTime> settings = Tuple.Create(config.CloseDate, config.FinalizeDate);

            return settings;
        }

      
    }
}
