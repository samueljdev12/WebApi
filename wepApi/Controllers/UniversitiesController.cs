using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace wepApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UniversitiesController : Controller
{
    [HttpGet(Name = "GetTopUniversities")]
    public IEnumerable<University> GetTopUniversities()
    {
        List<University> topUniversities = GetTop100Universities();

        return topUniversities;
    }

// Placeholder class for University
    public class University
    {
        public string Name { get; set; }
        // Add other relevant properties
    }

// Placeholder method to retrieve the top 100 universities (hardcoded for demonstration)
    private List<University> GetTop100Universities()
    {
        List<University> universities = new List<University>
        {
            new University {Name = "Massachusetts Institute of Technology (MIT)"},
            new University {Name = "University of Cambridge "},
            new University {Name = "University of Oxford "},
            new University { Name = "Harvard University" },
            new University { Name = "Stanford University" },
            new University{Name = "Imperial College London "},
            new University{Name = "ETH Zurich (Swiss Federal Institute of Technology) "},
            new University{Name = "National University of Singapore (NUS)  "},
            new University{Name = "UCL (University College London) "},
            new University{Name = "University of California, Berkeley (UCB)  "},
            new University{Name = "University of Chicago "},
            new University{Name = "University of Pennsylvania  "},
            new University{Name = "Cornell University  "},
            new University{Name = "University of Melbourne   "},
            new University{Name = "California Institute of Technology (Caltech)   "},
            new University{Name = "Yale University  "},
            new University{Name = "Peking University  "},
            new University{Name = " Princeton University "},
            new University{Name = "University of New South Wales (UNSW Sydney)  "},
            new University{Name = "University of Sydney  "},
            new University{Name = "University of Toronto  "},
            new University{Name = "University of Edinburgh "},
            new University{Name = "Columbia University  "},
            new University{Name = "Universite PSL  "},
            new University{Name = "Tsinghua University "},
            new University{Name = "Nanyang Technological University, Singapore (NTU)  "},
            new University{Name = "University of Hong Kong (UKU)  "},
            new University{Name = "Johns Hopkins University  "},
            new University{Name = "University of Tokyo  "},
            new University{Name = "University of California, Los Angeles (UCLA)  "},
            new University{Name = "McGill University  "},
            new University{Name = "University of Manchester "},
            new University{Name = "University of Michigan-Ann Arbor  "},
            new University{Name = "Australian National University  "},
            new University{Name = "University of British Columbia  "},
            new University{Name = "Ecole Polytechnique Fédérale de Lausanne (EPFL)   "},
            new University{Name = "Technical University of Munich  "},
            new University{Name = "Institut Polytechnique de Paris  "},
            new University{Name = "New York University (NYU)  "},
            new University{Name = "King's College London  "},
            new University{Name = "Seoul National University "},
            new University{Name = "Monash University "},
            new University{Name = "University of Queensland "},
            new University{Name = "Zhejiang University "},
            new University{Name = "London School of Economics and Political Science (LSE)  "},
            new University{Name = "Kyoto University"},
            new University{Name = "Delft University of Technology  "},
            new University{Name = "Northwestern University  "},
            new University{Name = "Chinese University of Hong Kong (CUHK) "},
            new University{Name = "Fudan University "},
            new University{Name = "Shanghai Jiao Tong University  "},
            new University{Name = "Shanghai Jiao Tong University  "},
            new University{Name = "Carnegie Mellon University  "},
            new University{Name = "University of Amsterdam  "},
            new University{Name = "Ludwig-Maximilians-Universität München  "},
            new University{Name = "University of Bristol  "},
            new University{Name = "KAIST - Korea Advanced Institute of Science & Technology "},
            new University{Name = "Duke University  "},
            new University{Name = "University of Texas at Austin "},
            new University{Name = "Sorbonne University  "},
            new University{Name = "Hong Kong University of Science and Technology (HKUST) "},
            new University{Name = "KU Leuven  "},
            new University{Name = "University of California, San Diego (UCSD)  "},
            new University{Name = "University of Washington "},
            new University{Name = "University of Illinois at Urbana-Champaign  "},
            new University{Name = "ong Kong Polytechnic University "},
            new University{Name = "Universiti Malaya (UM)   "},
            new University{Name = "University of Warwick  "},
            new University{Name = "University of Auckland  "},
            new University{Name = "National Taiwan University (NTU)  "},
            new University{Name = "City University of Hong Kong  "},
            new University{Name = "Universite Paris-Saclay "},
            new University{Name = "University of Western Australia "},
            new University{Name = "Brown University  "},
            new University{Name = "KTH Royal Institute of Technology   "},
            new University{Name = "University of Leeds   "},
            new University{Name = "University of Glasgow "},
            new University{Name = "Yonsei University  "},
            new University{Name = "Durham University  "},
            new University{Name = "Korea University "},
            new University{Name = "Osaka University  "},
            new University{Name = "Trinity College Dublin, The University of Dublin "},
            new University{Name = "University of Southampton  "},
            new University{Name = "Pennsylvania State University "},
            new University{Name = "University of Birmingham "},
            new University{Name = "Lund University  "},
            new University{Name = "Universidade de São Paulo "},
            new University{Name = "Lomonosov Moscow State University "},
            new University{Name = "Universität Heidelberg "},
            new University{Name = "The University of Adelaide "},
            new University{Name = "University of Technology Sydney "},
            new University{Name = " Tokyo Institute of Technology  "},
            new University{Name = "University of Zurich  "},
            new University{Name = "Boston University "},
            new University{Name = "Universidad Nacional Autónoma de México (UNAM) "},
            new University{Name = "Universidad de Buenos Aires (UBA)   "},
            new University{Name = "University of St Andrews  "},
            new University{Name = "Georgia Institute of Technology  "},
            new University{Name = "Freie Universitaet Berlin "},
            new University{Name = "Purdue University "},
            new University{Name = "Pohang University of Science and Technology (POSTECH)"},
            new University{Name = "tUniversity of Nottingham"},
            
       
            

        };

        return universities;
    }

}