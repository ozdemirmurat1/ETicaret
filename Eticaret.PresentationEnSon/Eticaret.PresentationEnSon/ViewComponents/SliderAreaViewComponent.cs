using Eticaret.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eticaret.PresentationEnSon.ViewComponents
{
    public class SliderAreaViewComponent:ViewComponent
    {
        ISliderService _sliderService;
        public SliderAreaViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.List();
            return View(sliders);
        }
    }
}
