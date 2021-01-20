using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Service.IServices
{
    public interface IFileUpload
    {
        Task<string> Uploadfile(IBrowserFile file);

        bool DeleteFile(string fileName);
    }
}
