using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using SCORE.Data;
using SCORE.Models;

namespace SCORE.Controllers
{
    public class ExerciciosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment _he;

        public ExerciciosController(ApplicationDbContext context, IHostEnvironment e)
        {
            _context = context;
            _he = e;
        }

        //[Authorize(Roles = "Docente")]
        public async Task<IActionResult> Index()
        {

            var applicationDbContext = _context.Exercicios;
            return View(await applicationDbContext.ToListAsync());
        }



        public List<FileViewModel> GetFiles(string he, string utilizador)
        {
            List<FileViewModel> arquivos = new List<FileViewModel>();

            string caminho = Path.Combine("C:\\Users\\pedro\\Desktop\\UTAD\\3º Ano\\2ºSemestre\\Lab Projeto\\SCORE\\SCORE\\wwwroot\\Documents\\", he);

            // Verifica se o diretório existe antes de tentar ler os arquivos
            if (Directory.Exists(caminho))
            {
                // Obtém os nomes dos arquivos no diretório
                string[] nomesArquivos = Directory.GetFiles(caminho);

                // Cria um objeto FileViewModel para cada arquivo e adiciona à lista
                foreach (string nomeArquivo in nomesArquivos)
                {
                    var arquivo = new FileViewModel { Name = Path.GetFileName(nomeArquivo), Nota = 0, Utilizador = utilizador };
                    _context.Add(arquivo);
                    arquivos.Add(arquivo);
                }
                _context.SaveChanges();
            }

            return arquivos;
        }

        //[Authorize(Roles = "Docente")]
        public async Task<IActionResult> AtualizarNota(string nomeArquivo, int nota)
        {
            var arquivo = await _context.Exercicios.FirstOrDefaultAsync(a => a.Titulo == nomeArquivo);

            if (arquivo != null)
            {
                arquivo.Nota = nota;
                _context.Update(arquivo);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Submissoes));
        }



        // GET
        //[Authorize(Roles = "Docente")]

        [Route("Exercicios/Submissoes")]
        public async Task<IActionResult> Submissoes(int id, int nota)
        {
            DocFiles files = new DocFiles();

            string utilizador = User.Identity.Name;

            ViewBag.xpto = files.GetFiles(_he, User.Identity.Name).Count();



            return View(files.GetFiles(_he, User.Identity.Name));

        }


        // GET: Exercicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Exercicios == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios
                .FirstOrDefaultAsync(m => m.IdExercicio == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            return View(exercicio);
        }


        public IActionResult Upload()
        {
            return View();
        }

        // GET: Exercicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exercicios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdExercicio,Titulo,Descricao,Nota,DataEntrega")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exercicio);
        }

        // GET: Exercicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Exercicios == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios.FindAsync(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            return View(exercicio);
        }

        // POST: Exercicios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdExercicio,Titulo,Descricao,Nota,DataEntrega")] Exercicio exercicio)
        {
            if (id != exercicio.IdExercicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExercicioExists(exercicio.IdExercicio))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(exercicio);
        }



        // GET: Exercicios/Delete/5
        //[Authorize(Roles = "Docente")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Exercicios == null)
            {
                return NotFound();
            }

            var exercicio = await _context.Exercicios
                .FirstOrDefaultAsync(m => m.IdExercicio == id);
            if (exercicio == null)
            {
                return NotFound();
            }

            return View(exercicio);
        }




        // POST: Exercicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Exercicios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Exercicios'  is null.");
            }
            var exercicio = await _context.Exercicios.FindAsync(id);
            if (exercicio != null)
            {
                _context.Exercicios.Remove(exercicio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Upload(IFormFile Name)
        {
            if (ModelState.IsValid)
            {
                string destination = Path.Combine(
                    _he.ContentRootPath, "wwwroot/Documents", Path.GetFileName(Name.FileName)
                    );

                FileStream fs = new FileStream(destination, FileMode.Create);

                Name.CopyTo(fs);
                fs.Close();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Download(string id)
        {
            string pathFile = Path.Combine(_he.ContentRootPath, "wwwroot/Documents/", id);

            byte[] fileBytes = System.IO.File.ReadAllBytes(pathFile);

            string mimeType;

            new FileExtensionContentTypeProvider().TryGetContentType(id, out mimeType);

            return File(fileBytes, mimeType);

        }

        private bool ExercicioExists(int id)
        {
            return (_context.Exercicios?.Any(e => e.IdExercicio == id)).GetValueOrDefault();
        }
    }
}
