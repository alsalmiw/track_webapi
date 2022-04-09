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
            Description="<h5>Legal Services</h5><p>Many services will provide free consultations. Attorneys can answer questions to help you make an appropriate decisions regarding your legal issues such as:</p><ul><li>Estate Planning- including Advanced Health Care Directives <a href='https://oag.ca.gov/sites' target='_blank'>http://oag.ca.govhttps://oag.ca.gov/sites</a>  (Living Wills), Durable Powers of Attorney, Wills, Trusts, Conservatorships, and Elder Abuse</li><li>Criminal Defense – including citations, arrests or court proceedings</li><li>Driving under the Influence cases</li></ul>" 
            },
            new ServicesModel()
            {
            Id=2,
            ServiceName="Business Services & Support", 
            Icon = "faBriefcase",
            Description="<h5>Chamber of Commerce</h5><p>Through its programs and sponsorships, the Chamber works to benefit its members and strengthen the social and economic framework of the community.</p><ul><li>Advocacy – The Chamber will work hard to represent business interests with government, build a stronger economy and work to improve our local business climate.</li><li>Strength – The Chamber is the County’s largest business membership organization representing companies and individuals who are committed to making a difference in their community</li><li>Vision- The Chamber helps implement plans for a better community and county.</li></ul><h5>Mother Lode Job Training</h5><p>They assist businesses with one or more employees with the following services </p><ul><li>Recruitment</li><li>Workforce training for all employees</li><li>On-the job training for new employees</li><li>Connection to school-to career partnerships supporting the creation of pipelines of skilled workers meeting the needs of the business</li></ul><h5>Economic Development Department</h5><p>The Economic Development Department is responsible for attracting and retaining businesses in the County and or City. The Department’s primary mission is to provide businesses with direct one-on-one assistance and help them navigate the regulatory process. The Department aims to enhance the economic vitality and sustainability of the community, while encouraging and helping a diverse array of businesses to thrive. They also facilitate multi-agency response team meetings on behalf of business aimed at streamlining the permitting process. They are able to connect businesses to the right people by collaborating with business associations and acting as a conduit to private, state and federal resources. No matter what stage of business development you are in. </p>" 
            },
            new ServicesModel()
            {
            Id=3,
            ServiceName="Child Care Services", 
            Icon = "faBabyCarriage",
            Description="<p>he Resource Connection offers Head Start Preschool and Early Head Start infant and toddler programs. These programs offer wonderful opportunities for children and families, recognizing that parents are their children’s first and most important teachers.</p><h5>County Office of Education</h5><p>Child Development Program</p><p>The Child Development program includes both the extended day Programs. Visit your County office of Education for child care.</p>" 
            },
            new ServicesModel()
            {
            Id=4,
            ServiceName="County Services", 
            Icon = "faLandmark",
            Description=" <h5>County Treasurer – Tax Collector</h5><ul><li>Collects Property taxes and unsecured taxes</li><li>Transient Occupancy Taxes (TOT taxes) for Hotel stays etc.</li><li>Business License Fees</li></ul><p><strong>Property taxes</strong> – Your home and land are assessed a value by the County Assessor. This valuation will result in an annual tax bill. This bill can be paid in two installments Dec 10 and April 10. </p><p><strong>Unsecured Taxes </strong> – These taxes are levied on personal property such as Business Equipment, Mobile Homes not attached to a foundation, Aircraft and Vessels TOT – this tax of 6% is levied on rooms in hotels, motels, Bed and Breakfast and all other occupancy for 30 days or less.</p><p><strong>Business License</strong> – If you are operating a business you must have a license</p><h5>County Assessor’s Office </h5><p>The Assessor is the elected official who is responsible for all assessment activities. The office staff locates, describes and values all taxable property. This information is maintained on the assessment roll. In addition, our office processes requests for exemptions, address changes and value changes as well as handling inquires for property identification.</p><h5>County Clerk Recorder</h5><p>County Clerk – Recorder conducts elections and ensures the integrity of official and vital records</p><p> Land Title Documents</p><ul><li>Mining Claims</li><li>Certified Birth Certificates</li><li>Certified Death Certificates</li><li>Election Services</li></ul><h5>County Health and Human Services</h5><p>Calworks helps eligible families become self-supporting through temporary cash aid. It is California’s Temporary Assistance to Needy Families (TANF) Program and provides a number of services, including cash aid, the family also receives Medi-Cal and may be eligible for CalFresh benefits. <a href='https://www.cdss.ca.gov/calworks' target='_blank'>https://www.cdss.ca.gov/calworks</a> </p><h5>Behavioral Health</h5><p>They provide: Adults Individual Recovery Plans, Adult Outreach and Engagement, Representative Payee & Conservatorship, Children/Youth Individual recovery plans, Youth Outreach and engagement, Family Education Programs, Parent support, Group specialty, Youth Adult transition recovery and many more. Check your local county for services.</p><h5>Public Health</h5><p>The mission of the Public Health Department is to improve the health and well-being of everyone in the county.</p><ul><li>Pregnancy testing</li><li>TB Skin Testing</li> <li>HIV Testing</li><li>Pandemic Services</li> </ul><h5>County Transit (Public Transportation)</h5><p>Transit offers public transportation in the county. Check transit routes for info and cost.</p><h5>County Building Department</h5><p>The department provides; Inspection Services, Plan Review, Code Enforcement and Customer Service to every Architect, Engineer, Developer, Contractor, Business and Property Owner That resides or works within the County or City. </p><h5>County District Attorney</h5><ul><li>Criminal Division: receives information from citizens, and law enforcement officers, who suspect that a California law has been violated. If a citizen reports a crime an evaluation is made to determine if a crime was in fact committed and if need be the citizen is referred to the appropriate law enforcement agency who will investigate the crime.</li></ul>" 
            },
            new ServicesModel()
            {
            Id=5,
            ServiceName="Department of Motor Vehicles", 
            Icon = "faCar",
            Description="<ul><li>California Licenses and ID</li><li>California Vehicle Registration</li><li>California Car Title <a href='https://www.dmv.ca.gov/portal/' target='_blank'>https://www.dmv.ca.gov/portal/</a></li><li>Tickets and Violations<ol><li>Speeding tickets</li><li>DUI Violations</li><li>Ticket Attorneys</li><li>DUI Attorneys</li><li>SR-22 Insurance</li></ol></li></ul>"  
            },
            new ServicesModel()
            {
            Id=6,
            ServiceName="Education", 
            Icon = "faSchool",
            Description="<p><strong>Junior Colleges</strong>: Check your area for local Junior Colleges they provide an in expense way for students to explore a variety of pathways.</p><p><strong>Universities</strong>: Check out Universities online to find the one that best suits your pathway</p><p>FASFA: For students who qualify for Grants or Student loans.<a href='https://studentaid.gov/h/apply-for-aid/fafsa' target='_blank'> https://studentaid.gov/h/apply-for-aid/fafsa</a></p>"  
            },
            new ServicesModel()
            {
            Id=7,
            ServiceName="Financial Services & Support", 
            Icon = "faPiggyBank",
            Description="<p><strong>Bank institutions</strong>: Provide bank accounts, saving accounts, loans, money market accounts and many more</p><p><strong>Financial Services</strong>: Provide advanced Estate Planning, Annuities, Banking Services, Brokerage Accounts, Business Continuation Planning, College Planning, Estate Planning Basics, IRA Accounts, Social Security, Succession Planning and many more</p>"  
            },
            new ServicesModel()
            {
            Id=8,
            ServiceName="Food Service", 
            Icon = "faBurger",
            Description="<p>Food Banks are nonprofit organizations providing services and programs in three areas: children and families, nutrition and prevention and intervention. Find the nearest Food bank in your county listings</p>" 
            },
            new ServicesModel()
            {
            Id=9,
            ServiceName="Healthcare", 
            Icon = "faBriefcaseMedical",
            Description=""  
            },
            new ServicesModel()
            {
            Id=10,
            ServiceName="Insurance Services", 
            Icon = "faFileSignature",
            Description=""  
            },
            new ServicesModel()
            {
            Id=11,
            ServiceName="Law Enforcement Services", 
            Icon = "faBuildingShield",
            Description=""  
            },
            new ServicesModel()
            {
            Id=12,
            ServiceName="Military", 
            Icon = "faPersonMilitaryPointing",
            Description=""  
            },
            new ServicesModel()
            {
            Id=13,
            ServiceName="Real Estate Services", 
            Icon = "faSignHanging",
            Description=""  
            },
             new ServicesModel()
            {
            Id=14,
            ServiceName="Social Security Services", 
            Icon = "faPassport",
            Description=""  
            },
             new ServicesModel()
            {
            Id=15,
            ServiceName="Taxes", 
            Icon = "faWallet",
            Description=""  
            },
             new ServicesModel()
            {
            Id=16,
            ServiceName="Utility Services", 
            Icon = "faLightbulb",
            Description=""  
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