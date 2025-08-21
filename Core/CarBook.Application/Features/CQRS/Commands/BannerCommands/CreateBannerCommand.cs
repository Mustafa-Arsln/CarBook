using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class CreateBannerCommand
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoURL { get; set; }

    }
    public class GetBannerByIdQueryResult
        {
           
            public string Title { get; set; }
            public string Description { get; set; }
            public string VideoDescription { get; set; }
            public string VideoURL { get; set; }
        }
    }

