﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        // GET: /Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var includes = new List<string> { "Brand", "Model", "Color" };
            var Vehicles = await _unitOfWork.Vehicles.GetAll(includes: includes);
            return Ok(Vehicles);
        }

        // GET: /Vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var includes = new List<string> { "Brand", "Model", "Color", "Bookings" };
            var Vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id, includes);

            if (Vehicle == null)
            {
                return NotFound();
            }

            return Ok(Vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle Vehicle)
        {
            if (id != Vehicle.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Vehicles.Update(Vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle Vehicle)
        {
            await _unitOfWork.Vehicles.Insert(Vehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = Vehicle.Id }, Vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {


            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var Vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            return Vehicle != null;
        }
    }
}
