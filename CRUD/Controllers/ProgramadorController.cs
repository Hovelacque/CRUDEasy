using CRUD.EntityFramework;
using CRUD.Models;
using CRUD.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{

    public class ProgramadorController : Controller
    {
        private IProgramadorManager _programadorManager;

        public ProgramadorController()
        {
            _programadorManager = new ProgramadorManager(new CRUDContext());
        }

        // GET: Programador
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Insert(Programador input)
        {
            try
            {
                await _programadorManager.Create(input);
                return Json(new { Mensagem = "Salvo com Sucesso!" });
            }
            catch (DataException ex)
            {
                return Json(new { Mensagem = ex });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Update(Programador input)
        {
            try
            {
                await _programadorManager.Update(input);
                return Json(new { Mensagem = "Atualizado com Sucesso!" });
            }
            catch (DataException ex)
            {
                return Json(new { Mensagem = ex });
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(Programador input)
        {
            try
            {
                await _programadorManager.Delete(input.Id);
                return Json(new { Mensagem = "Salvo com Sucesso!" });
            }
            catch (DataException ex)
            {
                return Json(new { Mensagem = ex });
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetAll()
        {
            var ret = await _programadorManager.GetAll();
            return Json(ret);
        }

        [HttpPost]
        public async Task<ActionResult> Get(int id)
        {
            var ret = await _programadorManager.Get(id);
            return Json(ret);
        }
    }
}