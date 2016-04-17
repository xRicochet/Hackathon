using Hackathon.Data;
using Hackathon.DbData;
using Hackathon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Omu.ValueInjecter;
using Hackathon.DTO;

namespace Hackathon.Controllers
{
    public class PartyController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Service<Party> partyRepository;
        private IPartyService partyService;
        public PartyController()
        {
            this.partyRepository = unitOfWork.Service<Party>();
            this.partyService = new PartyService();
        }
        public ActionResult Index()
        {
            var parties = partyService.GetAllParties();
            foreach (var party in parties)
            {

            }
            return View(new List<PartyDTO>());
        }

        public ActionResult Details(int Id)
        {
            var party = partyService.GetPartyByID(Id);
            return View(party);
        }
    }
}