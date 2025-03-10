﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Core_Project_API.DAL.ApiContext;
using Portfolio_Core_Project_API.DAL.Entity;
using System.Linq;

namespace Portfolio_Core_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());
        }
        [HttpGet("{id")]
        public IActionResult CatagoryGet(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult CatagoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category p)
        {
            using var c = new Context();
            var value = c.Find<Category>(p.CategoryID);
            if (value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
