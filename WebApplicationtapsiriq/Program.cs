namespace WebApplicationtapsiriq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.MapControllerRoute(
                name:"default",
                pattern:"{Controller}/{action}/{id?}" 
                );

            app.Run();
        }
    }
}
