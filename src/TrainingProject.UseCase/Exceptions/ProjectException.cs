using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.UseCase.Exceptions
{
    public class ProjectException : Exception
    {
        public int StatusCode;
        public ProjectException(int code, string message) : base(message) 
        {
            this.StatusCode = code;    
        }
    }
}
