using Microsoft.AspNetCore.Mvc.Razor;

namespace UI_MVC._Framework
{
    public abstract class BaseRazor : RazorPage<object>
    {
        public int PageId { get; set; }
    }

    public abstract class BaseRazor<TModel> : RazorPage<TModel>
    {
        public int PageId { get; set; }
    }

    public interface ICurrentUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string MsterRole { get; set; }
        public string UserIp{ get; set; }
        public string UserLang{ get; set; }
        public void ChangeTheme(string themeName)
        {
        }
    }
}
