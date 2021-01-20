using HiddenVilla_Server.Service.IServices;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Service
{
    public class FileUpload : IFileUpload
    {
        public bool DeleteFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<string> Uploadfile(IBrowserFile file)
        {
            throw new NotImplementedException();
        }
    }
}
