﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School_Management_System.Areas.Master.Models;
using School_Management_System.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using School_Management_System.Data.MasterData;

namespace School_Management_System.Areas.Master.Controllers
{
    [Area("Master")]
    public class MastersController : Controller
    {
        private readonly IMasterService masterService;
        private readonly IStudentService studentService;

        public MastersController(IMasterService _master, IStudentService _student)
        {
            this.masterService = _master;
            this.studentService = _student;
        }

        #region Country
        public async Task<IActionResult> Country()
        {
            MastersViewModel model = new MastersViewModel
            {
                countries = await masterService.GetCountry(),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Country([FromForm] MastersViewModel model)
        {
            var data = new Country
            {
                Id = model.countriesId,
                countryName = model.countryName,
                countryNameBn = model.countryNameBn,
            };

            await masterService.SaveCountry(data);
            return RedirectToAction(nameof(Country));
        }

        #endregion

        #region Division
        [HttpGet]

        public async Task<IActionResult> Division()
        {
            MastersViewModel model = new MastersViewModel
            {
                divisions = await masterService.GetDivision(),
                countries = await masterService.GetCountry(),
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Division([FromForm] MastersViewModel model)
        {
            var data = new Division
            {
                Id = model.divisionId,
                countryId = model.countryId,
                divisionName = model.divisionName,
                divisionNameBn = model.divisionNameBn,
            };

            await masterService.SaveDivision(data);
            return RedirectToAction(nameof(Division));

        }
        #endregion

        #region District
        [HttpGet]
        public async Task<IActionResult> District()
        {
            MastersViewModel model = new MastersViewModel
            {
                divisions = await masterService.GetDivision(),
                districts = await masterService.GetDistrict(),


            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> District([FromForm] MastersViewModel model)
        {
            var data = new District
            {
                Id = model.districtId,
                divisionId = model.divisionId,
                districtName = model.districtName,
                districtNameBn = model.districtNameBn,
            };
            await masterService.SaveDistrict(data);
            return RedirectToAction(nameof(District));


        }
        #endregion

        #region BookName
        [HttpGet]
        public async Task<IActionResult> BookName()
        {
            MastersViewModel model = new MastersViewModel
            {
                classInfos = await studentService.GetAllClasses(),
            };
            return View(model);
        }

        #endregion

    }

}