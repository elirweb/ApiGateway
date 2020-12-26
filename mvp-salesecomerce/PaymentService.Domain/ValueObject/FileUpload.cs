using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace PaymentService.Domain.ValueObject
{
    public  class FileUpload
    {
        public  FileUpload(HttpPostedFile file)
        {
           

            if (file != null && file.ContentLength > 0)
            {
                var Ext = Path.GetExtension(file.FileName);
                if (Ext.ToLower() == ".jpg" || Ext.ToLower() == ".gif" ||
                    Ext.ToLower() == ".jpeg" || Ext.ToLower() == ".png")
                {

                    var diretorio = HttpContext.Current.Server.MapPath("~/") + "Fotos/";
                    if (Directory.Exists(diretorio))
                    {
                        var imagem = System.Drawing.Image.FromStream(file.InputStream);

                       
                        file.SaveAs(diretorio + Path.GetFileName(file.FileName.ToLower()));
                    }
                    else
                    {
                        var imagem = System.Drawing.Image.FromStream(file.InputStream);
                        Directory.CreateDirectory(diretorio);
                        file.SaveAs(diretorio + Path.GetFileName(file.FileName.ToLower()));

                    }


                }

            }

            
        }

       

    }
}
