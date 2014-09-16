﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teaCRM.Entity;

namespace teaCRM.Web.Controllers.Apps.Settings
{
    public class AppMakerController : Controller
    {
        #region 应用定制首页 2014-09-07 14:58:50 By 唐有炜

        //
        // GET:/Apps/Settings/AppMaker/

        public ActionResult Index()
        {
            return View("AppMakerIndex");
        }

        #endregion

        #region 详细应用设置首页 2014-09-16 14:58:50 By 唐有炜

        //
        // GET:/Apps/Settings/AppMaker/Detail/1

        public ActionResult Detail(int id)
        {
            return View("AppMakerDetail");
        }

        #endregion

        #region 添加应用定制 2014-09-07 14:58:50 By 唐有炜

        //
        // GET: /Apps/Settings/AppMaker/Add/
        public ActionResult Add(FormCollection fc)
        {
            if (fc.Count == 0) //默认返回页面
            {
                return View("AppMakerEdit");
            }
            else //数据添加
            {
                ResponseMessage rmsg = new ResponseMessage();
                return Json(rmsg);
            }
        }

        #endregion

        #region 修改应用定制 2014-09-07 14:58:50 By 唐有炜

        //
        // GET: /Apps/Settings/AppMaker/Edit/
        public ActionResult Edit(FormCollection fc)
        {
            if (fc.Count == 0) //默认返回页面
            {
                return View("AppMakerEdit");
            }
            else //数据修改
            {
                ResponseMessage rmsg = new ResponseMessage();
                return Json(rmsg);
            }
        }

        #endregion

        #region 删除应用定制 2014-09-07 14:58:50 By 唐有炜

        //
        // GET: /Apps/Settings/AppMaker/Delete/1/
        public ActionResult Delete(int id)
        {
            ResponseMessage rmsg = new ResponseMessage();
            return Json(rmsg);
        }

        #endregion
    }
}