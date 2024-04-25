using System;
using System.Web;
using MyMVC.Models;
using System.Data.Entity;

public class Global : HttpApplication
{
    protected void Application_Start(object sender, EventArgs e)
    {
       Database.SetInitializer(new BookDbInitializer());
    }
}