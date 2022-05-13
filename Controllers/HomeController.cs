using Hotel.Data;
using Hotel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using System.Diagnostics;


namespace Hotel.Controllers
{

    public class HomeController : Controller
    {


        #region [Ctor]
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        #endregion

        #region [Index]
        public IActionResult Index()
        {
            var hotelList = _db.Hotels.ToList();
            return View(hotelList);
        }
        #endregion

        #region [CreateHotel]
        [HttpGet]
        public IActionResult CreateHotel()
        {
            return View();
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateHotel(Hotel.Models.Hotel model)
        {
            _db.Hotels.Add(model);

            _db.SaveChanges();
            return RedirectToAction("Index");
            return View(model);

        }
        #endregion

        #region [UpdateHotel]

        [HttpGet]

        public IActionResult UpdateHotel(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = _db.Hotels.FirstOrDefault(x => x.HotelId == id);

            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateHotel(Hotel.Models.Hotel model)
        {
            try
            {
                var oldmodel = _db.Hotels.FirstOrDefault(x => x.HotelId == model.HotelId);

                if (oldmodel != null)
                oldmodel.HotelId = model.HotelId;
                oldmodel.HotelAddress = model.HotelAddress;
                oldmodel.HotelName = model.HotelName;
                oldmodel.HotelBads = model.HotelBads;
                oldmodel.HotelStar = model.HotelStar;

                var response = _db.SaveChanges();
                if (response > 0)
                    return RedirectToAction("Index");

            }
            catch (Exception ex)
            {

                ViewBag.meessage = "Error";
            }
            return View(model);


        }
        #endregion

        #region [DeleteUpdate]
        [HttpGet]
        public IActionResult DeleteHotel(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = _db.Hotels.FirstOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteHotel(Models.Hotel model)
        {

            try
            {
                var oldmodel = _db.Hotels.FirstOrDefault(x => x.HotelId == model.HotelId);

                _db.Hotels.Remove(oldmodel);
                var response = _db.SaveChanges();
                if (response > 0)

                    return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }

            return View(model);

        }
        #endregion


    }
}