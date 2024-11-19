using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly FinalContext _context;

        public TeamMembersController(FinalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMember()
        {
            return Ok(_context.TeamMember.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetTeamMember(int id)
        {
            TeamMember member = _context.TeamMember.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(member);
            }
        }

        [HttpPost]
        public IActionResult PostTeamMember(TeamMember member)
        {
            _context.TeamMember.Add(member);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            TeamMember member = _context.TeamMember.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    _context.TeamMember.Remove(member);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return NotFound();
                }
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult PutTeamMember(TeamMember member)
        {
            try
            {
                _context.Entry(member).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
