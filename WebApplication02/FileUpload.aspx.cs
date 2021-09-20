using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication02
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Preinit(object sender, EventArgs e)
        {


            HttpCookie cookieTest = Request.Cookies["prefs"];
            if (cookieTest == null)
            {
                Page.Theme = "";
            }
            else
            {
                Page.Theme = cookieTest["theme"];
            }



        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string strFileName;
            string strFilePath;
            string strFolder;
            string[] permittedExtensions = { ".jpg",".jpeg",".png",".gif" }; 
            strFolder = Server.MapPath("ImgUpload/");
            // Retrieve the name of the file that is posted.
            strFileName = fileInput.PostedFile.FileName;
            strFileName = Path.GetFileName(strFileName);
            var ext = Path.GetExtension(strFileName).ToLowerInvariant();
            if (fileInput.Value != "")
            {
                // Create the folder if it does not exist.
                if (!Directory.Exists(strFolder))
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Save the uploaded file to the server.
                strFilePath = strFolder + strFileName;
                if (File.Exists(strFilePath))
                {
                    lblUploadResult.Text = strFileName + " already exists on the server!";
                }
                if (string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
                {
                    lblUploadResult.Text = strFileName + "is invalid format.";
                }
                else
                {
                    fileInput.PostedFile.SaveAs(strFolder + Guid.NewGuid().ToString() + ext);
                    lblUploadResult.Text = strFileName + " has been successfully uploaded.";
                }
            }
            else
            {
                lblUploadResult.Text = "Click 'Browse' to select the file to upload.";
            }
            // Display the result of the upload.

            frmConfirmation.Visible = true;
            

            

            
        }
    }
}