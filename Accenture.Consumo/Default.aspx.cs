using Entities;
using Facade;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Accenture.Consumo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserFacade userFacade = new UserFacade();
            PostFacade postFacade = new PostFacade();
            AlbumFacade albumFacade = new AlbumFacade();
            CommentFacade commentFacade = new CommentFacade();

            User user = userFacade.GetUsers();
            Posts post = postFacade.GetPosts();
            Albums album = albumFacade.GetAlbums();
            Comment comment = commentFacade.GetComments();

            lblUserName.Text = user.Name;
            lblTitlePost.Text = post.Title;
            lblBodyPost.Text = post.Body;
            lblTitleAlbum.Text = album.Title;
            lblNameComment.Text = comment.Name;
            lblEmailComment.Text = comment.Email;
            lblBodyComment.Text = comment.Body;
        }
    }
}