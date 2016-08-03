using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qvisitorCorp.Data;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace qvisitorCorp.Controllers
{
    public class mockupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public mockupController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("admin/coutries")]
        // GET: qvCountries
        public async Task<IActionResult> Countries()
        {
            return View(await _context.Countries.ToListAsync());
        }
        [Route("admin/coutries/show/{id}")]
        // GET: qvCountries/Details/5
        public async Task<IActionResult> CountriesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }

            return View(qvCountry);*/
            return View();
        }
        [Route("admin/coutries/create")]
        // GET: qvCountries/Create
        public IActionResult CountriesCreate()
        {
            return View();
        }

        // POST: qvCountries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/create")]
        public async Task<IActionResult> CountriesCreate([Bind("Id,Name")] qvCountry qvCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvCountry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(qvCountry);
        }

        [Route("admin/coutries/edit/{id}")]
        // GET: qvCountries/Edit/5
        public async Task<IActionResult> CountriesEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }
            return View(qvCountry);*/
            return View();
        }

        // POST: qvCountries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/edit/{id}")]
        public async Task<IActionResult> CountriesEdit(int id, [Bind("Id,Name")] qvCountry qvCountry)
        {
            /*if (id != qvCountry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvCountry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvCountryExists(qvCountry.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(qvCountry);*/
            return View();
        }

        [Route("admin/coutries/delete/{id}")]
        // GET: qvCountries/Delete/5
        public async Task<IActionResult> CountriesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }

            return View(qvCountry);*/
            return View();
        }

        // POST: qvCountries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/delete/{id}")]
        public async Task<IActionResult> CountriesDeleteConfirmed(int id)
        {
            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            _context.Countries.Remove(qvCountry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvCountryExists(int id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }


        [Route("admin/coutries/cities")]
        // GET: qvCities
        public async Task<IActionResult> Cities()
        {
            var applicationDbContext = _context.Cities.Include(q => q.Country);
            return View(await applicationDbContext.ToListAsync());
        }

        [Route("admin/coutries/cities/show/{id}")]
        // GET: qvCities/Details/5
        public async Task<IActionResult> CitiesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCity = await _context.Cities.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCity == null)
            {
                return NotFound();
            }

            return View(qvCity);*/
            return View();
        }

        [Route("admin/coutries/cities/create")]
        // GET: qvCities/Create
        public IActionResult CitiesCreate()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "Country");
            return View();
        }

        // POST: qvCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/cities/create")]
        public async Task<IActionResult> CitiesCreate([Bind("Id,CountryID,Name")] qvCity qvCity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvCity);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "Country", qvCity.CountryID);
            return View(qvCity);
        }

        [Route("admin/coutries/cities/edit/{id}")]
        // GET: qvCities/Edit/5
        public async Task<IActionResult> CitiesEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCity = await _context.Cities.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCity == null)
            {
                return NotFound();
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "Country", qvCity.CountryID);
            return View(qvCity);*/
            return View();
        }

        // POST: qvCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/cities/edit/{id}")]
        public async Task<IActionResult> CitiesEdit(int id, [Bind("Id,CountryID,Name")] qvCity qvCity)
        {
            /*if (id != qvCity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvCity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvCityExists(qvCity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "Country", qvCity.CountryID);
            return View(qvCity);*/
            return View();
        }

        [Route("admin/coutries/cities/delete/{id}")]
        // GET: qvCities/Delete/5
        public async Task<IActionResult> CitiesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCity = await _context.Cities.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCity == null)
            {
                return NotFound();
            }

            return View(qvCity);*/
            return View();
        }

        // POST: qvCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("admin/coutries/cities/delete/{id}")]
        public async Task<IActionResult> CitiesDeleteConfirmed(int id)
        {
            var qvCity = await _context.Cities.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cities.Remove(qvCity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvCityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }


        [Route("admin/companies")]
        // GET: qvCompanies
        public async Task<IActionResult> Companies()
        {
            var applicationDbContext = _context.Companies.Include(q => q.Country);
            return View(await applicationDbContext.ToListAsync());
        }

        [Route("admin/companies/show/{id}")]
        // GET: qvCompanies/Details/5
        public async Task<IActionResult> CompaniesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCompany = await _context.Companies.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCompany == null)
            {
                return NotFound();
            }

            return View(qvCompany);*/
            return View();
        }

        [Route("admin/companies/create")]
        // GET: qvCompanies/Create
        public IActionResult CompaniesCreate()
        {
            ViewData["CounryId"] = new SelectList(_context.Countries, "Id", "Country");
            return View();
        }

        // POST: qvCompanies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/create")]
        public async Task<IActionResult> CompaniesCreate([Bind("Id,CounryId,Name")] qvCompany qvCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CounryId"] = new SelectList(_context.Countries, "Id", "Country", qvCompany.CounryId);
            return View(qvCompany);
        }

        // GET: qvCompanies/Edit/5
        [Route("admin/companies/edit/{id}")]
        public async Task<IActionResult> CompaniesEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCompany = await _context.Companies.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCompany == null)
            {
                return NotFound();
            }
            ViewData["CounryId"] = new SelectList(_context.Countries, "Id", "Country", qvCompany.CounryId);
            return View(qvCompany);*/
            return View();
        }

        // POST: qvCompanies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/edit/{id}")]
        public async Task<IActionResult> CompaniesEdit(int id, [Bind("Id,CounryId,Name")] qvCompany qvCompany)
        {
            if (id != qvCompany.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvCompanyExists(qvCompany.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CounryId"] = new SelectList(_context.Countries, "Id", "Country", qvCompany.CounryId);
            return View(qvCompany);
        }
        [Route("admin/companies/delete/{id}")]
        // GET: qvCompanies/Delete/5
        public async Task<IActionResult> CompaniesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvCompany = await _context.Companies.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCompany == null)
            {
                return NotFound();
            }

            return View(qvCompany);*/
            return View();
        }

        // POST: qvCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/delete/{id}")]
        public async Task<IActionResult> CompaniesDeleteConfirmed(int id)
        {
            var qvCompany = await _context.Companies.SingleOrDefaultAsync(m => m.Id == id);
            _context.Companies.Remove(qvCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvCompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }


        [Route("admin/companies/objects")]
        // GET: qvObjects
        public async Task<IActionResult> Objects()
        {
            var applicationDbContext = _context.Objects.Include(q => q.City);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("admin/companies/objects/show/{id}")]
        // GET: qvObjects/Details/5
        public async Task<IActionResult> ObjectsDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvObject = await _context.Objects.SingleOrDefaultAsync(m => m.Id == id);
            if (qvObject == null)
            {
                return NotFound();
            }

            return View(qvObject);*/
            return View();
        }

        [Route("admin/companies/objects/create")]
        // GET: qvObjects/Create
        public IActionResult ObjectsCreate()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City");
            return View();
        }

        // POST: qvObjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/objects/create")]
        public async Task<IActionResult> ObjectsCreate([Bind("Id,CityId,Name")] qvObject qvObject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvObject);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvObject.CityId);
            return View(qvObject);
        }

        // GET: qvObjects/Edit/5
        [Route("admin/companies/objects/edit/{id}")]
        public async Task<IActionResult> ObjectsEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvObject = await _context.Objects.SingleOrDefaultAsync(m => m.Id == id);
            if (qvObject == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvObject.CityId);
            return View(qvObject);*/
            return View();
        }

        // POST: qvObjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/objects/edit/{id}")]
        public async Task<IActionResult> ObjectsEdit(int id, [Bind("Id,CityId,Name")] qvObject qvObject)
        {
            /*if (id != qvObject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvObject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvObjectExists(qvObject.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvObject.CityId);
            return View(qvObject);*/
            return View();
        }

        // GET: qvObjects/Delete/5
        [Route("admin/companies/objects/delete/{id}")]
        public async Task<IActionResult> ObjectsDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvObject = await _context.Objects.SingleOrDefaultAsync(m => m.Id == id);
            if (qvObject == null)
            {
                return NotFound();
            }

            return View(qvObject);*/
            return View();
        }

        // POST: qvObjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("admin/companies/objects/delete/{id}")]
        public async Task<IActionResult> ObjectsDeleteConfirmed(int id)
        {
            var qvObject = await _context.Objects.SingleOrDefaultAsync(m => m.Id == id);
            _context.Objects.Remove(qvObject);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvObjectExists(int id)
        {
            return _context.Objects.Any(e => e.Id == id);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult add_city()
        {
      
            return View();
        }

        public IActionResult add_country()
        {
           
            return View();
        }

        public IActionResult add_filiation()
        {
            return View();
        }
        public IActionResult add_user()
        {
            return View();
        }

        public IActionResult citiesOfKazakhstan()
        {
      
            return View();
        }

        public IActionResult citiesOfRussia()
        {
           
            return View();
        }

        public IActionResult citiesOfUSA()
        {
            return View();
        }
 public IActionResult countries()
        {
            return View();
        }

        public IActionResult filiations()
        {
      
            return View();
        }

        public IActionResult statistics()
        {
           
            return View();
        }

        public IActionResult update_city()
        {
            return View();
        }
        public IActionResult update_country()
        {
            return View();
        }
        public IActionResult update_filiation()
        {
           
            return View();
        }

        public IActionResult update_user()
        {
            return View();
        }
        public IActionResult users()
        {
            return View();
        }
    }
}
