﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Services.Abstract
{
    public interface IMailMessageService : IGenericService<MailMessage>
    {
        string GetMailByAdmin { get; }
    }
}