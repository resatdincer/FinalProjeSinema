using Sinema.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sinema.Model;

namespace Sinema
{
    public partial class FilmKategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void addFilmKategoriForm_InsertItem()
        {
            var item = new Model.FilmKategori();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (Repo<Model.FilmKategori> db = new Repo<Model.FilmKategori>())
                {

                    bool sonuc = db.InsertEntity(item);
                }
            }
        }
        protected void addFilmKategoriForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/FilmKategori");
        }
        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FilmKategori");
        }
    }
}