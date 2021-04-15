using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using SyncfusionMvcApplicationRichTextEditor3.Models;

namespace SyncfusionMvcApplicationRichTextEditor3.Controllers
{
   public class IncidentReviewsController : Controller
   {
          private IncidentReviewsContext db = new IncidentReviewsContext();

        //
        // GET: /IncidentReviews/

        public ActionResult Index()
        {
            return View(db.IncidentReviews.ToList());
        }

        //
        // GET: /IncidentReviews/Details/5

        public ActionResult Details(int id = 0)
        {
            IncidentReview incidentreview = db.IncidentReviews.Find(id);
            if (incidentreview == null)
            {
                return HttpNotFound();
            }
            return View(incidentreview);
        }

        //
        // GET: /IncidentReviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /IncidentReviews/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IncidentReview incidentreview)
        {
            if (ModelState.IsValid)
            {
                db.IncidentReviews.Add(incidentreview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incidentreview);
        }

        //
        // GET: /IncidentReviews/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IncidentReview incidentreview = db.IncidentReviews.Find(id);
            if (incidentreview == null)
            {
                return HttpNotFound();
            }
            return View(incidentreview);
        }

        //
        // POST: /IncidentReviews/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IncidentReview incidentreview)
        {
            if (!string.IsNullOrEmpty(ViewBag.ReviewNotesHtml))
                incidentreview.ReviewNotes = ViewBag.ReviewNotesHtml;
            if (ModelState.IsValid)
            {
                db.Entry(incidentreview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incidentreview);
        }

        //
        // GET: /IncidentReviews/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IncidentReview incidentreview = db.IncidentReviews.Find(id);
            if (incidentreview == null)
            {
                return HttpNotFound();
            }
            return View(incidentreview);
        }

        //
        // POST: /IncidentReviews/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncidentReview incidentreview = db.IncidentReviews.Find(id);
            db.IncidentReviews.Remove(incidentreview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    
        public ActionResult Index1()
        {
            string val = @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor'>HTML markup</a> or <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#html-editor'>markdown</a> of the content</p>
                <table class='e-rte-table' style='width: 100%;'>
                    <tbody>
                        <tr>
                            <td style='width: 33.3333%;'><p style='text-align: center;'>DIV</p></td>
                            <td style='width: 33.3333%;'><p style='text-align: center;'>IFrame</p></td>
                            <td style='width: 33.3333%;'><p style='text-align: center;'>MarkDown</p></td>
                        </tr>
                    </tbody>
                </table>
                <p><b><br></b></p><p><b> Toolbar </b></p>
                <ol>
                    <li><p>Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc </p></li>
                    <li><p>Toolbar is fully customizable </p></li>
                </ol>
                <p><b> Links </b></p>
                <ol>
                    <li><p>You can insert a hyperlink with its corresponding dialog</p></li>
                    <li><p>Attach a hyperlink to the displayed text. </p></li>
                    <li><p>Customize the quick toolbar based on the hyperlink </p></li>
                </ol>
                <p><b> Image.</b></p>
                <ol>
                    <li><p>Allows you to insert images from an online source as well as the local computer</p></li>
                    <li><p>You can upload an image</p></li><li><p>Provides an option to customize quick toolbar for an image </p></li>
                </ol>
                <img alt='Logo' src='https://ej2.syncfusion.com/aspnetmvc/Content/images/RichTextEditor/RTEImage-Feather.png' style='width: 300px;'>";

            string val1 = @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor'>HTML markup</a> or <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#html-editor'>markdown</a> of the content</p>
                <p><b><br></b></p><p><b> Toolbar </b></p>
                <ol>
                    <li><p>Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc </p></li>
                    <li><p>Toolbar is fully customizable </p></li>
                </ol>
                <p><b> Links </b></p>
                <ol>
                    <li><p>You can insert a hyperlink with its corresponding dialog</p></li>
                    <li><p>Attach a hyperlink to the displayed text. </p></li>
                    <li><p>Customize the quick toolbar based on the hyperlink </p></li>
                </ol>
                <p><b> Image.</b></p>
                <ol>
                    <li><p>Allows you to insert images from an online source as well as the local computer</p></li>
                    <li><p>You can upload an image</p></li><li><p>Provides an option to customize quick toolbar for an image </p></li>
                </ol>
                <img alt='Logo' src='https://ej2.syncfusion.com/aspnetmvc/Content/images/RichTextEditor/RTEImage-Feather.png' style='width: 300px;'>";

            ViewBag.value = val1;
                ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                            "FontName", "FontSize", "FontColor", "BackgroundColor",
                            "LowerCase", "UpperCase", "|",
                            "Formats", "Alignments", "OrderedList", "UnorderedList",
                            "Outdent", "Indent", "|",
                            "CreateTable", "CreateLink", "Image", "|", "ClearFormat", "Print",
                            "SourceCode", "FullScreen", "|", "Undo", "Redo" };
              return View();
         }
     }
}

       