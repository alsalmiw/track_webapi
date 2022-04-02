using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using track_webapi.Models;

namespace track_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : ControllerBase
    {
        [HttpGet("GetAllServices")]
        public List<ServicesModel> GetAllServices ()
        {
            return AllServices;
        }

          [HttpGet("GetServiceByName/{name}")]
        public List<ServicesModel> GetAllServices (string? name)
        {
            List<ServicesModel>SearchedServices = new List<ServicesModel>();
            for (int i=0; i<AllServices.Count; i++)
            {
                if(AllServices[i].ServiceName.Contains(name))
                {
                    SearchedServices.Add(AllServices[i]);
                }
            }
            return SearchedServices;
        }


        public List<ServicesModel>AllServices = new List<ServicesModel>()
        {
            new ServicesModel()
            {
            Id=1,
            ServiceName="Attorney / Legal Services", 
            Icon = "",
            Description="Many services will provide free consultations. Attorneys can answer questions to help you make an appropriate decisions regarding your legal issues such as: Estate Planning- including Advanced Health Care Directives https://oag.ca.gov/sites (Living Wills), Durable Powers of Attorney, Wills, Trusts, Conservatorships, and Elder Abuse Criminal Defense - including citations, arrests or court proceedings Driving under the Influence cases" 
            },
            new ServicesModel()
            {
            Id=2,
            ServiceName="Business Services & Support", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=3,
            ServiceName="Child Care Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=4,
            ServiceName="County Services", 
            Icon = "",
            Description="" 
            },
            new ServicesModel()
            {
            Id=5,
            ServiceName="Department of Motor Vehicles", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=6,
            ServiceName="Education", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=7,
            ServiceName="Financial Services & Support", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=8,
            ServiceName="Food Service", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=9,
            ServiceName="Healthcare", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=10,
            ServiceName="Insurance Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=11,
            ServiceName="Law Enforcement Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=12,
            ServiceName="Military", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=13,
            ServiceName="Real Estate Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=14,
            ServiceName="Social Security Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=15,
            ServiceName="Taxes", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=16,
            ServiceName="Utility Services", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=17,
            ServiceName="United States Postal Service", 
            Icon = "",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
        };
    }
}