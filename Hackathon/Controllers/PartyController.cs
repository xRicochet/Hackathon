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
            List<PartyDTO> partiesDTO = new List<PartyDTO>(parties.Count);
            List<Tuple<int,string>> Pictures = partyService.GetAllPictures();
            for (int i = 0; i < parties.Count; i++)
            {
                partiesDTO[i].InjectFrom(parties[i]);
                partiesDTO[i].Pics = Pictures.Where(picture => picture.Item1==partiesDTO[i].Id).Select(picture => picture.Item2).ToList();
            }
            return View(parties);
        }

        public ActionResult Details(int Id)
        {
            var party = partyService.GetPartyByID(Id);
            PartyDTO partyDTO = new PartyDTO();
            partyDTO.InjectFrom(party);
            partyDTO.Pics = partyService.GetPicsFromParty(partyDTO.Id);
            return View(partyDTO);
        }
    }
}