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
            Description="<h5>Legal Services</h5><p>Many services will provide free consultations. Attorneys can answer questions to help you make an appropriate decision regarding your legal issues such as:</p><ul><li>Estate Planning- including Advanced Health Care Directives <a href='https://oag.ca.gov/consumers/general/estate-finance' target='_blank'>https://oag.ca.gov/consumers/general/estate-finance</a>  (Living Wills), Durable Powers of Attorney, Wills, Trusts, Conservatorships, and Elder Abuse</li><li>Criminal Defense – including citations, arrests or court proceedings</li><li>Driving under the Influence cases</li></ul>" 
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
            Description="<p>The Resource Connection offers Head Start Preschool and Early Head Start infant and toddler programs. These programs offer wonderful opportunities for children and families, recognizing that parents are their children’s first and most important teachers.</p><h5>County Office of Education</h5><p>Child Development Program</p><p>The Child Development program includes both the extended day Programs. Visit your County office of Education for child care.</p>" 
            },
            new ServicesModel()
            {
            Id=4,
            ServiceName="County Services", 
            Icon = "faLandmark",
            Description=" <h5>County Treasurer – Tax Collector</h5><ul><li>Collects Property taxes and unsecured taxes</li><li>Transient Occupancy Taxes (TOT taxes) for Hotel stays etc.</li><li>Business License Fees</li></ul><p><strong>Property taxes</strong> – Your home and land are assessed a value by the County Assessor. This valuation will result in an annual tax bill. This bill can be paid in two installments Dec 10 and April 10. </p><p><strong>Unsecured Taxes </strong> – These taxes are levied on personal property such as Business Equipment, Mobile Homes not attached to a foundation, Aircraft and Vessels TOT – this tax of 6% is levied on rooms in hotels, motels, Bed and Breakfast and all other occupancy for 30 days or less.</p><p><strong>Business License</strong> – If you are operating a business you must have a license</p><h5>County Assessor’s Office </h5><p>The Assessor is the elected official who is responsible for all assessment activities. The office staff locates, describes and values all taxable property. This information is maintained on the assessment roll. In addition, our office processes requests for exemptions, address changes and value changes as well as handling inquires for property identification.</p><h5>County Clerk Recorder</h5><p>County Clerk – Recorder conducts elections and ensures the integrity of official and vital records</p> <ul><li>Land Title Documents</li><li>Mining Claims</li><li>Certified Birth Certificates</li><li>Certified Death Certificates</li><li>Election Services</li></ul><h5>County Health and Human Services</h5><p>Calworks helps eligible families become self-supporting through temporary cash aid. It is California’s Temporary Assistance to Needy Families (TANF) Program and provides a number of services, including cash aid, the family also receives Medi-Cal and may be eligible for CalFresh benefits. <a href='https://www.cdss.ca.gov/calworks' target='_blank'>https://www.cdss.ca.gov/calworks</a> </p><h5>Behavioral Health</h5><p>They provide: Adults Individual Recovery Plans, Adult Outreach and Engagement, Representative Payee & Conservatorship, Children/Youth Individual recovery plans, Youth Outreach and engagement, Family Education Programs, Parent support, Group specialty, Youth Adult transition recovery and many more. Check your local county for services.</p><h5>Public Health</h5><p>The mission of the Public Health Department is to improve the health and well-being of everyone in the county.</p><ul><li>Pregnancy testing</li><li>TB Skin Testing</li> <li>HIV Testing</li><li>Pandemic Services</li> </ul><h5>County Transit (Public Transportation)</h5><p>Transit offers public transportation in the county. Check transit routes for info and cost.</p><h5>County Building Department</h5><p>The department provides; Inspection Services, Plan Review, Code Enforcement and Customer Service to every Architect, Engineer, Developer, Contractor, Business and Property Owner That resides or works within the County or City. </p><h5>County District Attorney</h5><ul><li>Criminal Division: receives information from citizens, and law enforcement officers, who suspect that a California law has been violated. If a citizen reports a crime an evaluation is made to determine if a crime was in fact committed and if need be the citizen is referred to the appropriate law enforcement agency who will investigate the crime.</li></ul>" 
            },

             new ServicesModel()
            {
            Id=5,
            ServiceName="Crisis Center", 
            Icon = "faHandHoldingHand",
            Description="<h5>Crisis Adult and Children Center</h5><p>The Resource Connection offers:</p><ol><li><strong>Peer Counseling</strong></li><p>Advocates are available to provide one on one counseling to help victims overcome and heal from past or current domestic violence and/or sexual assault.</p><li><strong><a href='https://trcac.org/ip/ccc/' target='_blank'>Support Groups</a></strong></li><p>Advocates facilitate groups for either men or women who want to learn about domestic violence and/or sexual assault.</p><li><strong>Temporary Restraining Order (TRO) Assistance</strong></li><p>Assistance is available Monday through Thursday to complete paperwork, make copies, and inform individuals of the court process and their legal rights with a Restraining Order.</p><li><strong>Accompaniment</strong></li><p>Victims of Domestic Violence and Sexual Assault have the right to emotional support throughout court proceedings, Law Enforcement interviews, social service and healthcare visits. Advocates are available to provide accompaniment upon request.</p> <li><strong>Hotline</strong></li><p>A Domestic Violence and Sexual Assault hotline is available 24 hours a day, 7 days a week to provide telephone crisis support to men and women.</p></ol>"
            },
            new ServicesModel()
            {
            Id=6,
            ServiceName="Department of Motor Vehicles", 
            Icon = "faCar",
            Description="<ul><li>California Licenses and ID</li><li>California Vehicle Registration</li><li>California Car Title <a href='https://www.dmv.ca.gov/portal/' target='_blank'>https://www.dmv.ca.gov/portal/</a></li><li>Tickets and Violations<ol><li>Speeding tickets</li><li>DUI Violations</li><li>Ticket Attorneys</li><li>DUI Attorneys</li><li>SR-22 Insurance</li></ol></li></ul>"  
            },
            new ServicesModel()
            {
            Id=7,
            ServiceName="Education", 
            Icon = "faSchool",
            Description="<p><strong>Junior Colleges</strong>: Check your area for local Junior Colleges they provide an in expense way for students to explore a variety of pathways.</p><p><strong>Universities</strong>: Check out Universities online to find the one that best suits your pathway</p><p>FASFA: For students who qualify for Grants or Student loans.<a href='https://studentaid.gov/h/apply-for-aid/fafsa' target='_blank'> https://studentaid.gov/h/apply-for-aid/fafsa</a></p>"  
            },
            new ServicesModel()
            {
            Id=8,
            ServiceName="Financial Services & Support", 
            Icon = "faPiggyBank",
            Description="<p><strong>Bank institutions</strong>: Provide bank accounts, saving accounts, loans, money market accounts and many more</p><p><strong>Financial Services</strong>: Provide advanced Estate Planning, Annuities, Banking Services, Brokerage Accounts, Business Continuation Planning, College Planning, Estate Planning Basics, IRA Accounts, Social Security, Succession Planning and many more</p>"  
            },
            new ServicesModel()
            {
            Id=9,
            ServiceName="Food Service", 
            Icon = "faBurger",
            Description="<p>Food Banks are nonprofit organizations providing services and programs in three areas: children and families, nutrition and prevention and intervention. Find the nearest Food bank in your county listings</p>" 
            },
            new ServicesModel()
            {
            Id=10,
            ServiceName="Healthcare", 
            Icon = "faBriefcaseMedical",
            Description="<p>Hospital Services include 24 hour emergency services: Impatient/Outpatient surgery; Intensive Care Unit; Medical and Surgical Units; General X-ray, Ultrasound, Mammography, CT Scan, MRI and Nuclear Medicine; Respiratory Therapy Services; Cancer/Infusion Center; Orthopedic Center, Gastroenterology Center, Physical Therapy Services; Impatient Skilled Rehabilitation; Full Service Clinical Lab; Cardiac and Pulmonary Rehabilitations and Health education.</p><p>Urgent Cares and Medical Doctors also provide many services for your healthcare needs</p>"  
            },
            new ServicesModel()
            {
            Id=11,
            ServiceName="Insurance Services", 
            Icon = "faFileSignature",
            Description="<p>Provide: </p><ul><li>Home</li><li>Auto</li><li>Health</li><li>Commercial</li></ul>"  
            },
            new ServicesModel()
            {
            Id=12,
            ServiceName="Law Enforcement Services", 
            Icon = "faBuildingShield",
            Description="<p>Sheriff Department; Sheriff’s oversee crimes and safety in Counties</p><p>California Highway Patrol (CHP) oversee and assist motorists, investigate traffic collisions and provide security for the Governor, other public officers, employees, constitutional officers and the general public. They provide education awareness programs such as: “Every 15 Minutes”, Impact Teen Drivers, Senior Volunteer Program, and the Start Smart Program.</p><p>Police Department; oversee crime in urban and suburban areas.</p>"  
            },
            new ServicesModel()
            {
            Id=13,
            ServiceName="Media", 
            Icon = "faPhotoFilm",
            Description="<p>Newspapers, TV, Social Media and Radio are all part of the way we get and share information.</p><p>Local Newspapers:</p><ul><li>Share local news </li><li>List Jobs</li><li>Classified Ads</li><li>DBA (Doing business as) a filing for new businesses.</li></ul>"
            },


            new ServicesModel()
            {
            Id=14,
            ServiceName="Military", 
            Icon = "faPersonMilitaryPointing",
            Description="<ul><li>United States Marine Corp <a href='https://www.marines.com/' target='_blank'>https://www.marines.com/</a></li><li>US Navy <a href='https://www.navy.mil/' target='_blank'>https://www.navy.mil/</a> </li><li>US Army <a href='https://www.army.mil/' target='_blank'>https://www.army.mil/</a> </li><li>US Airforce <a href='https://www.airforce.com/' target='_blank'>https://www.airforce.com/</a></li></ul>"  
            },
            new ServicesModel()
            {
            Id=15,
            ServiceName="Real Estate Services", 
            Icon = "faSignHanging",
            Description="<p>Provide assistance in buying or selling residential, commercial buildings or land.</p>"  
            },
             new ServicesModel()
            {
            Id=16,
            ServiceName="Social Security Services", 
            Icon = "faPassport",
            Description="<p>Social Security Number and Cards are used to help keep accurate records of your wages or self-employment earnings. In order to get benefits you must have a card. Do not carry your card with you. Keep it in a safe place with your other important papers.</p>"  
            },
             new ServicesModel()
            {
            Id=17,
            ServiceName="Taxes", 
            Icon = "faWallet",
            Description="<h5>How to File Your Taxes in 4 Simple Steps</h5><ol><li>Step 1: Gather your Tax Documents. Your tax documents consist of a W-2 from all your employers and a proof of health care insurance from your provider. Your employers have until January 31st to get your W-2’s to you.</li><li>Step 2: Choose Between the Standard Deduction or Itemizing. Standard deduction is when you use your W-2 to fill out a simple form. The W-2 has boxes with dollar amounts. The Form will tell you which box to look at to fill out the form. An itemized Deduction is when you have things like; mileage or a new computer that you purchased and only use specifically for work.</li><li>Step 3: Pick a Filing Status. A Filing Status is one of the following: Single, Married or Joint</li><li>Step 4: File Your Taxes. Once your forms are filled out then you submit them to the IRS and to the State</li></ol>"  
            },
            new ServicesModel()
            {
            Id=18,
            ServiceName="Travel", 
            Icon = "faMapLocationDot",
            Description="<p>Travel agents are a wonderful resource for traveling. They can find packages for you to go on a Cruise or fly just about anywhere. They can help you with your passport and let you know what to expect when you get to your destination. They are a great way to prepare for your next vacation.</p>"  
            },
             new ServicesModel()
            {
            Id=19,
            ServiceName="Utility Services", 
            Icon = "faLightbulb",
            Description="<p><strong>Garbage</strong>: Your local Waste Recovery Company will assist you in your garbage pickup. Please check for your local company to start services.</p><p><strong>Phone Company</strong>: Provides residential telephone services, California lifeline telephone program, business telephone service, long distance, calling features, deaf and disabled services, and deaf and disabled telecommunications program.</p><p><strong>Internet Company</strong>: Provide high speed internet with unlimited data and VoIP. Check your local area to find the Internet Company near you.</p><p><strong>Electric and Gas Company</strong>: Some of the big companies are PG&E, SMUD or EDISON. These companies provide electricity and Gas. You must register your residence with them in order to receive services.</p><p><strong>Water</strong>: Your local water company will help you get set up with an account to receive water at your residence.</p>"  
            },
             new ServicesModel()
            {
            Id=20,
            ServiceName="United States Postal Service", 
            Icon = "faEnvelopesBulk",
            Description="<p>Provides<p><ul><li>PO Boxes</li><li>Passport Services</li><li>Stamps</li><li>Mailing services</li><li>Mail Delivery – You must start delivery with the post office when you establish a new residence</li></ul>"
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