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
    public partial class FilmKategori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Film Kategorileri";
            if (!IsPostBack)
            {
                using (Repo< Model.FilmKategori> db = new Repo<Model.FilmKategori>())
                {

                    var FilmKategorileri = db.GetAllEntities().OrderBy(i=> i.FilmKategoriId).ToList();
                    KategoriListView.DataSource = FilmKategorileri;
                    KategoriListView.DataBind();
                }
            }
        }

        public void Delete(int FilmKategoriId)
        {
            using (Repo<Model.FilmKategori> db = new Repo<Model.FilmKategori>())
            {

                db.DeleteEntity(FilmKategoriId);
                Response.Redirect("~/FilmKategori");
            }
        }
    }
}