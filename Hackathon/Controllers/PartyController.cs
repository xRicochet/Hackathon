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
        private IUserService userService;
        private IPartyService partyService;
        private ICommentariesService commentaryService;
        public PartyController()
        {
            this.partyRepository = unitOfWork.Service<Party>();
            this.partyService = new PartyService();
            this.commentaryService = new CommentariesService();
            this.userService = new UserService();
        }
        public ActionResult Index()
        {
            var parties = partyService.GetAllParties();
            List<PartyDTO> partiesDTO = new List<PartyDTO>();
            for (int i = 0; i < parties.Count; i++)
            {
                PartyDTO partyDTO = new PartyDTO();
                partyDTO.InjectFrom(parties[i]);
                partyDTO.Pics = partyService.GetPicsFromParty(partyDTO.Id);
                partiesDTO.Add(partyDTO);
            }
            return View(partiesDTO);
        }

        public ActionResult Details(int Id)
        {
            var party = partyService.GetPartyByID(Id);
            PartyDTO partyDTO = new PartyDTO();
            partyDTO.InjectFrom(party);
            partyDTO.Pics = partyService.GetPicsFromParty(partyDTO.Id);
            var comms = commentaryService.GetAllCommentariesAtAParty(partyDTO.Id);
            List<CommentariesDTO> commsDTO= new List<CommentariesDTO>();
            foreach (var c in comms)
            {
                var comment = new CommentariesDTO();
                var user = userService.GetUserById(c.UserId);
                comment.InjectFrom(c);
                comment.LastName = user.LastName;
                comment.FirstName = user.FirstName;
            }
            return View(partyDTO);
        }
    }
}