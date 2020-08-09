using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HandsOnWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly HandsOnWebApi.Repositories.StudentRepo _Controller;
        private readonly IConfiguration config;
        public StudentController(HandsOnWebApi.Repositories.StudentRepo _Controller, IConfiguration config)
        {
            this._Controller = _Controller;
            this.config = config;
        }
        [HttpPost]
        [Route("Add")]

        public IActionResult Add()
        {
            try
            {
                _Controller.AddStudentRecords();
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.InnerException.Message);
            }

        }
        [HttpPost]
        [Route("AddStudent")]

        public IActionResult Add(Student student)
        {
            try
            {
                _Controller.AddStudent(student);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }


        }
        [HttpGet]
        [Route("GetAll")]

        public IActionResult GetAll()
        {
            try
            {
                return Ok(_Controller.GetAllRecords());
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }


        }
        [HttpGet]
        [Route("Get/{id}")]

        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_Controller.GetOneRecords(id));
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }

        }
        [HttpPut]
        [Route("Update/{id}")]

        public IActionResult Update(int id)
        {
            try
            {
                _Controller.UpdateRecord(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }


        }
        [HttpDelete]
        [Route("Delete/{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _Controller.DeleteRecord(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }


        }
    }
    }
