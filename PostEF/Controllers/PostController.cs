using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostEF.Models;
using PostEF.DB;

namespace PostEF.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult Index()
        {
            List<Post> post;
            using (var db = new PostContext())
            {
                post = db.Database.SqlQuery<Post>("SELECT * FROM Posts").ToList();
            }
            return View(post);
        }

        [HttpGet]
        public ActionResult EditAdd(int id = 0)
        {
            Post pst;

            if (id == 0)
            {
                return View(new Post());
            }

            using (var db = new PostContext())
            {
                pst = db.Post.FirstOrDefault(s => s.IdP == id);

            }

            return View(pst);

        }

        [HttpPost]
        public ActionResult EditAdd(Post post)
        {
            if (post.IdP != 0)
            {
                using (var db = new PostContext())
                {
                    db.Entry(post).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }

            }
            else
            {
                using (var db = new PostContext())
                {
                    db.Post.Add(post);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(post);

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Post est;
            using (var db = new PostContext())
            {
                est = db.Post.First(s => s.IdP == id);
            }

            return View(est);

        }
        [HttpPost]
        public ActionResult Delete(Post post)
        {

            using (var db = new PostContext())
            {
                db.Entry(post).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult ShowPost(Post pos)

        {
            using (var db = new PostContext())
            {
                db.Post.FirstOrDefault(s => s.IdP == pos.IdP);

            }
            return View(pos);
        }

    }
}