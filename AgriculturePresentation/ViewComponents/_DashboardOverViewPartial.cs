﻿using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverViewPartial:ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x=> x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = c.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = c.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sutUreticisi = c.Teams.Where(x => x.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = c.Teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();


            return View();
        }
    }
}
