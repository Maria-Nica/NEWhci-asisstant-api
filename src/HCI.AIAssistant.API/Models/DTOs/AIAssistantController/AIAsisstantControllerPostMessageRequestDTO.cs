using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace HCI.AIAssistant.API.Models.DTOs.AIAssistantController;

public class AIAsisstantControllerPostMessageRequestDTO
{
    public string? TextMessage { get; set; }
}
