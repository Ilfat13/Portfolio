﻿using PortfolioMisc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioMisc.Services.EmailService
{
    public interface IEmailService
    {
        public void SendGmail(EmailModel emailModel);
    }
}
