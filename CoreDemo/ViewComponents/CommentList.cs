using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    id= 1,
                    userName = "Mustafa"
                },
                new UserComment
                {
                    id= 2,
                    userName = "Murat"
                },
                new UserComment
                {
                    id= 3,
                    userName = "Onur"
                }
            };
            return View(commentValues);
        }
    }
}
