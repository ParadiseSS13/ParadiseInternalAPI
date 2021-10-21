using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ParadiseInternalAPI.Core;
using ParadiseInternalAPI.Database;
using ParadiseInternalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using TwoFactorAuthNet;

namespace ParadiseInternalAPI.Controllers {
    [Route("notify")]
    [ApiController]
    public class NotifyController : ParaControllerBase {
        // Yes I know this should be a list of longs. But guess what. It isnt.
        private static List<string> discord_ids = new List<string>();
        public NotifyController(ILogger<NotifyController> logger, paradise_gamedbContext context, IConfiguration config) {
            _logger = logger;
            _context = context;
            _config = config;
        }

        [HttpGet("get_users")]
        public IActionResult GetUsers() {
            // This needs to be cloned, or it wipes first
            List<string> local_list = new List<string>(discord_ids);
            discord_ids.Clear();
            return Ok(local_list);
        }

        [HttpGet("toggle_notify")]
        public IActionResult ToggleNotify(string id) {
            if (id == null) {
                return BadRequest("No discord ID provided.");
            }
            
            if(discord_ids.Contains(id)) {
                discord_ids.Remove(id);
                return Ok("You will no longer be notified when the server restarts");
            } else {
                discord_ids.Add(id);
                return Ok("You will now be notified when the server restarts");
            }
        }
    }
}
