﻿using Business_Layer.Concrete;
using Business_Layer.FluentValidation;
using DataAccess_Layer.EntityFramework;
using Entity_Layer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Project_OOP_.Net_7.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager=new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult results= validationRules.Validate(p);
            if (results.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            var value=productManager.GetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateProduct(int id)
        {
            var value = productManager.GetById(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateProduct(Product p)
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
