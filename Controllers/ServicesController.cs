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
     public List<ServicesModel>AllServices = new List<ServicesModel>()
        {
            new ServicesModel()
            {
            Id=1,
            ServiceName="Attorney / Legal Services", 
            Icon = "faGavel",
            Description="Many services will provide free consultations. Attorneys can answer questions to help you make an appropriate decisions regarding your legal issues such as: Estate Planning- including Advanced Health Care Directives https://oag.ca.gov/sites (Living Wills), Durable Powers of Attorney, Wills, Trusts, Conservatorships, and Elder Abuse Criminal Defense - including citations, arrests or court proceedings Driving under the Influence cases" 
            },
            new ServicesModel()
            {
            Id=2,
            ServiceName="Business Services & Support", 
            Icon = "faBriefcase",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=3,
            ServiceName="Child Care Services", 
            Icon = "faBabyCarriage",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=4,
            ServiceName="County Services", 
            Icon = "faLandmark",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=5,
            ServiceName="Department of Motor Vehicles", 
            Icon = "faCar",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=6,
            ServiceName="Education", 
            Icon = "faSchool",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=7,
            ServiceName="Financial Services & Support", 
            Icon = "faPiggyBank",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=8,
            ServiceName="Food Service", 
            Icon = "faBurger",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque" 
            },
            new ServicesModel()
            {
            Id=9,
            ServiceName="Healthcare", 
            Icon = "faBriefcaseMedical",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=10,
            ServiceName="Insurance Services", 
            Icon = "faFileSignature",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=11,
            ServiceName="Law Enforcement Services", 
            Icon = "faBuildingShield",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=12,
            ServiceName="Military", 
            Icon = "faPersonMilitaryPointing",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
            new ServicesModel()
            {
            Id=13,
            ServiceName="Real Estate Services", 
            Icon = "faSignHanging",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=14,
            ServiceName="Social Security Services", 
            Icon = "faPassport",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=15,
            ServiceName="Taxes", 
            Icon = "faWallet",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=16,
            ServiceName="Utility Services", 
            Icon = "faLightbulb",
            Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed ligula mauris. Vestibulum efficitur nibh condimentum porttitor rutrum. Nullam semper nunc sed congue facilisis. Vestibulum dignissim pellentesque velit, eget facilisis nulla blandit non. Phasellus ac ultrices libero, ut semper ipsum. Quisque placerat augue sed sem tempus varius. Morbi malesuada tortor metus, at ultrices ante pellentesque vel. Maecenas in ex tincidunt, tincidunt eros et, aliquam tellus. Vivamus sit amet egestas justo, eu luctus nisi. Nunc consequat velit id enim gravida molestie. Vivamus ut bibendum leo. Morbi vel mauris a urna luctus tempor vel pulvinar dolor. Maecenas in consectetur neque"  
            },
             new ServicesModel()
            {
            Id=17,
            ServiceName="United States Postal Service", 
            Icon = "faEnvelopesBulk",
            Description="<p>Provides<p>'<ul><li>PO Boxes</li><li>Passport Services</li><li>Stamps</li><li>Mailing services</li><li>Mail Delivery – You must start delivery with the post office when you establish a new residence</li></ul>}"
            },
        };
    
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
                    SearchedServices.Add(AllServices[i]); //
                }
            }
            return SearchedServices;
        }

         [HttpGet("GetSearchResult/{term}")]
        public List<ServicesModel> GetSearchResult (string? term)
        {
            List<ServicesModel>SearchedServices = new List<ServicesModel>();
            for (int i=0; i<AllServices.Count; i++)
            {
                string descriptions = AllServices[i].Description.ToLower();
                string titles = AllServices[i].ServiceName.ToLower();

                if(descriptions.Contains(term.ToLower()) || titles.Contains(term.ToLower()))
                {
                    SearchedServices.Add(AllServices[i]); 
                }
                
            }
            return SearchedServices;
        }


       
    }
}