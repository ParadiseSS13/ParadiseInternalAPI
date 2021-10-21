using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ParadiseInternalAPI.Core;
using ParadiseInternalAPI.Database;
using ParadiseInternalAPI.Models;
using System;
using System.Linq;
using TwoFactorAuthNet;

namespace ParadiseInternalAPI.Controllers {
    [Route("2fa")]
    [ApiController]
    public class _2FAController : ParaControllerBase {
        public _2FAController(ILogger<_2FAController> logger, paradise_gamedbContext context, IConfiguration config) {
            _logger = logger;
            _context = context;
            _config = config;
        }

        [HttpGet("generate_qr")]
        public IActionResult GenerateQR(string ckey) {
            if (ckey == null) {
                return BadRequest("No ckey provided");
            }

            // See if they have a secret
            if(_context._2faSecrets.Where(x => x.Ckey == ckey).Any()) {
                return BadRequest("You already setup 2FA. Please contact AffectedArc07 if you have lost your authenticator.");
            }

            // They do not have one, so lets make one.
            TwoFactorAuth tfa = new TwoFactorAuth("Paradise Station");
            string secret = tfa.CreateSecret(320);

            // Put their secret into the DB
            _2faSecret db_model = new _2faSecret {
                Ckey = ckey,
                Secret = secret
            };
            _context._2faSecrets.Add(db_model);
            _context.SaveChanges();

            // Return the QR image as Base64
            string qr_code_image = tfa.GetQrCodeImageAsDataUri("Paradise Gameserver", secret);

            _2FA_QR qrc = new _2FA_QR {
                qr_image = qr_code_image
            };

            return Ok(qrc);
        }

        [HttpGet("validate_code")]
        public IActionResult ValidateCode(string ckey, string code) {
            if (ckey == null) {
                return BadRequest("No ckey provided.");
            }
            if (code == null) {
                return BadRequest("No code provided.");
            }

            // We have both pieces. Now we check the DB to see if they have a secret
            if (!_context._2faSecrets.Where(x => x.Ckey == ckey).Any()) {
                return BadRequest("You have not setup 2FA. Please contact AffectedArc07 if you believe this is an error.");
            }

            _2faSecret record = _context._2faSecrets.Where(x => x.Ckey == ckey).First();

            // They do not have one, so lets make one.
            TwoFactorAuth tfa = new TwoFactorAuth("Paradise Station");
            bool auth_sccess = tfa.VerifyCode(record.Secret, code);

            if (auth_sccess) {
                // Update the DB
                record.LastTime = DateTime.UtcNow;
                _context._2faSecrets.Update(record);
                _context.SaveChanges();

                // And return a success
                _2FA_AuthResult ar = new _2FA_AuthResult {
                    authorized = true
                };

                return Ok(ar);
            } else {
                return BadRequest("Incorrect auth code.");
            }
        }
    }
}
