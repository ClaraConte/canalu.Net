using canalu.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace canalu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ControllerBase
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;
        public UsersController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                //Todos los usuarios con las direcciones 
                //var result = contexto.Users.Include(e => e.address).ToList();

                // un solo usuario
                // return Ok(contexto.Users.Single(e => e.IdUsers == id));

                // var result = contexto.Users.Include(e => e.address).Where(e => e.IdUsers == id);

                // Leftjoin de user con 
                // return Ok(contexto.Inmuebles.Include(e => e.Duenio).Where(e => e.Duenio.Email == usuario).Single(e => e.Id == id));

                //return Ok(contexto.Users.Include(e => e.Address).Include(f => f.Employees).Single(e => e.IdUsers == id));

                return Ok(contexto.Users.Include(e => e.address).Where(e => e.IdUsers == id));
                //return Ok(contexto.Commerces);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<controller>/5
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                // Leftjoin de user sin empleados
                var query = from users in contexto.Users.Include(e => e.address)

                            join employees in contexto.Employees on users.IdUsers equals employees.IdEmployees into myJoinedTable

                            from leftJoin in myJoinedTable.DefaultIfEmpty()
                            where leftJoin.IdEmployees == null
                            select users;

                return Ok(query);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>/login
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Post(LoginView loginView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: loginView.Clave,
                        salt: System.Text.Encoding.ASCII.GetBytes(config["Salt"]),
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 1000,
                        numBytesRequested: 256 / 8));
                    var employees = contexto.Employees.Single(x => x.EmployeesUserName == loginView.Usuario);
                    if (employees == null || employees.EmployeesKey != hashed)
                    {
                        return BadRequest("Nombre de usuario o clave incorrecta");
                    }
                    else
                    {
                        var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"]));
                        var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                        var token = new JwtSecurityToken(
                            issuer: config["TokenAuthentication:Issuer"],
                            audience: config["TokenAuthentication:Audience"],

                            expires: DateTime.Now.AddMinutes(60),
                            signingCredentials: credenciales
                        );
                        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                    }
                }
                else { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /*// GET api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // 
        [AllowAnonymous]
        [Route("/")]
        [HttpGet]
        public IActionResult Get2()
        {
            var content = "Hello WorldThis is the main page";
            return new ContentResult()
            {
                Content = content,
                ContentType = "text / html",
            };
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
