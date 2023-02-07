using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AttributeRouting.Controller
{
    [Route("api/{controller}")]
    //http://localhost:5154/api/employee
    // [Route("api/{controller}/{action}")]
    public class EmployeeController : ControllerBase
    {
        static List<string> _name = new List<string>();
        static EmployeeController()
        {
            _name.Add("Amey");
            _name.Add("Kartik");
            _name.Add("Suraj");
        }

        [HttpGet]
        //public IEnumerable<string> Get()
        public IEnumerable<string> All()
        {
            return _name;
        }

        [HttpGet]
        public string One()
        {
            return _name.First();
        }

        [HttpGet]
        public void Create(string newName)
        {
            _name.Add(newName);
        }

        [HttpDelete]
        public void Remove()
        {
            _name.RemoveAt(1);
        }
    }
}
