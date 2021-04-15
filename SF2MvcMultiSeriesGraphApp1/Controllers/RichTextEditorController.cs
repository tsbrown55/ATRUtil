using System.Web.Mvc;
namespace SyncfusionMvcApplicationRichTextEditor3.Controllers
{
    public class RichTextEditorController : Controller
    {

        public ActionResult Index()
        {
            string val =
                @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor'>HTML markup</a> or <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#html-editor'>markdown</a> of the content</p>
                <p><b> Toolbar </b></p>
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
            string val1 =
                @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor'>HTML markup</a> or <a href='https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/formation/?no-cache=1#html-editor'>markdown</a> of the content</p>
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
            val1 = "<p><br></p><table class='e-rte-table' style='width: 100%; min-width: 0px;'><tbody><tr><td style='width: 50%;' class=''><p style=' margin: 0px 0px 10px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><b style=' font-weight: 700;'>Toolbar</b></p><ol style=' margin-top: 0px; margin-bottom: 1rem; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc</p></li><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Toolbar is fully customizable</p></li></ol><p style=' margin: 0px 0px 10px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><b style=' font-weight: 700;'>Links</b></p><ol style=' margin-top: 0px; margin-bottom: 1rem; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>You can insert a hyperlink with its corresponding dialog</p></li><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Attach a hyperlink to the displayed text.</p></li><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Customize the quick toolbar based on the hyperlink</p></li></ol><p style=' margin: 0px 0px 10px; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><b style=' font-weight: 700; background-color: unset; text-align: inherit;'>Image.</b><br></p><ol style=' margin-top: 0px; margin-bottom: 1rem; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255);'><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Allows you to insert images from an online source as well as the local computer</p></li><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>You can upload an image</p></li><li style=' margin-bottom: 10px;'><p style=' margin: 0px;'>Provides an option to customize quick toolbar for an image</p></li></ol></td><td style='width: 50%; text-align: center;' class=''>&nbsp; " +
                   "<img alt='Logo' src='https://ej2.syncfusion.com/aspnetmvc/Content/images/RichTextEditor/RTEImage-Feather.png' class='e-rte-image e-imgcenter e-resize e-imginline' style=' vertical-align: bottom; border: 0px; cursor: pointer; display: inline-block; float: none; margin: auto 5px; max-width: calc(100% - 10px); position: relative; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif, -apple-system, BlinkMacSystemFont; font-size: 14px; font-style: normal; font-weight: 400; text-align: left; text-indent: 0px; white-space: normal; background-color: rgb(255, 255, 255); width: 300px;'>";
            
            ViewBag.value = val1;
            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                            "FontName", "FontSize", "FontColor", "BackgroundColor",
                            "LowerCase", "UpperCase", "|",
                            "Formats", "Alignments", "OrderedList", "UnorderedList",
                            "Outdent", "Indent", "|",
                            "CreateTable", "CreateLink", "Image", "|", "ClearFormat", "Print",
                            "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.hello = "world";
            return View();
        }
    }
}

